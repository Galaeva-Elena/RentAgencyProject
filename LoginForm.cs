using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAgencyProject
{
    public partial class LoginForm : Form
    {
        //IUser userM = new Manager();
        private List<Client> clients = new List<Client>();
        private List<Manager> managers = new List<Manager>();
        public int clt_max_id = 0;
        Manager manager;
        Client client;
        public LoginForm()
        {
            InitializeComponent();
        }

        //Текущий пользователь
        public class Globals
        {
            public static readonly Globals Instance = new Globals();
            private Globals() { }
            public string Сurrent_user { get; set; }
            public Client reg_client;
        }

        //Загрузка формы входа и регистрации
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Создание единственного менеджера
            manager = new Manager();
            managers.Add(manager);

            //Обновление списка клиентов в List<Client>
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStreamObj = new FileStream("ClientListObj.txt", FileMode.Open))
            {
                while (fileStreamObj.Position != fileStreamObj.Length)
                {
                    Object objItem = (Object)binaryFormatter.Deserialize(fileStreamObj);
                    clients.Add((Client)objItem);
                }
            }
            clt_max_id = clients.Max(x => x.Id);
        }

        //Добавление (регистрация) клиента
        private void btn_Reg_Click(object sender, EventArgs e)
        {
            client = new Client(clt_max_id, txtBx_F.Text, txtBx_I.Text, txtBx_O.Text, DTPkr_DR.Value.Date, txtBx_Tel.Text);
            clients.Add(client);

           lbl_regPwd.Text = "Запомните пароль: " + client.Password;
            
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("ClientList.txt", FileMode.Append))
            {
                StreamWriter strmW = new StreamWriter(fileStream, Encoding.GetEncoding("windows-1251"));
                strmW.AutoFlush = true;
                strmW.Write(((Object)client).ToString() + '\n');
            }

            using (FileStream fileStream = new FileStream("ClientListObj.txt", FileMode.Append))
            {
                binaryFormatter.Serialize(fileStream, (Object)client);
            }

            clt_max_id = 0;

            txtBx_F.Text = "";
            txtBx_I.Text = "";
            txtBx_O.Text = "";
            DTPkr_DR.Value = DateTime.Now;
            txtBx_Tel.Text = "";

            System.Threading.Tasks.Task.Delay(3000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => { lbl_regPwd.Text = ""; }));
            });
        }

        //Вход (для зарегистрированных пользователей)
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (this.txtBx_Login.Text == "" || this.txtBx_Pwd.Text == "")
            {
                MessageBox.Show("Введите данные для входа или зарегистрируйтесь!");
            }
            else if (this.txtBx_Login.Text != "" && this.txtBx_Pwd.Text != "") 
            {
                if (managers[0].Phone == txtBx_Login.Text && managers[0].Password == txtBx_Pwd.Text)
                {
                    LoginForm.Globals.Instance.Сurrent_user = "Менеджер";

                    Form DealForm = new DealForm();
                    DealForm.Show();
                    this.Hide();
                }
                else if (clients.Where(clt => clt.Phone.Equals(txtBx_Login.Text) && clt.Password.Equals(txtBx_Pwd.Text)).Any())
                {                                      
                    LoginForm.Globals.Instance.Сurrent_user = "Клиент";
                    LoginForm.Globals.Instance.reg_client = clients.Find(c => c.Phone == txtBx_Login.Text); ;

                    if (LoginForm.Globals.Instance.reg_client.Surname.StartsWith("*"))
                    {
                        this.tabCtrl_Login.Enabled = false;
                        MessageBox.Show("Вы заблокированы за нарушения правил сайта!");
                        Application.Exit();
                    }
                    else
                    {
                        Form DealForm = new DealForm();
                        DealForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин и/или пароль!");
                }
            }             
        }        
    }
}
