using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace RentAgencyProject
{
    public partial class DealForm : Form
    {
        Manager userM = new Manager();
        Client userC = LoginForm.Globals.Instance.reg_client;
        List<Client> clients = new List<Client>();
        List<Apartment> apartments = new List<Apartment>();
        List<Applications> applications = new List<Applications>();
        List<Agreement> agreements = new List<Agreement>();
        Apartment apart;
        Client clts;
        Applications app;
        Agreement agrmt;
        public int apt_max_id = 0;
        public int app_max_id = 0;
        public int agr_max_id = 0;
        public DealForm()
        {
            InitializeComponent();
        }

        //Загрузка основной формы
        private void DealForm_Load(object sender, EventArgs e)
        {
            //Загрузка интерфейса в зависимости от типа пользователя ('Менеджер', 'Клиент')
            if (LoginForm.Globals.Instance.Сurrent_user == "Менеджер")
            {
                lbl_User.Text = LoginForm.Globals.Instance.Сurrent_user;
                clntPnl.Visible = false;
                mngrPnl.BringToFront();

                //Обновление списка квартир в List<Apartment> и ListBox 
                var apts = userM.refreshList("AptsListObj.txt", lstBx_mAptView, (Apartment)apart, apartments.Cast<Object>().ToList());
                foreach (Apartment a in apts)
                {
                    this.apartments.Add(a);
                }
                apt_max_id = apartments.Max(x => x.Id);

                //Обновление списка клиентов в List<Client> и ListBox
                var clt = userM.refreshList("ClientListObj.txt", lstBx_mClntList, (Client)clts, clients.Cast<Object>().ToList());
                foreach (Client c in clt)
                {
                    this.clients.Add(c);
                }

                //Обновление списка заявок в List<Applications> и ListBox
                var appl = userM.refreshList("AppsListObj.txt", lstBx_mAppl, (Applications)app, applications.Cast<Object>().ToList());
                foreach (Applications a in appl)
                {
                    this.applications.Add(a);
                }
            }
            else if (LoginForm.Globals.Instance.Сurrent_user == "Клиент")
            {
                lbl_User.Text = LoginForm.Globals.Instance.reg_client.Surname + " " + LoginForm.Globals.Instance.reg_client.Name + " " + LoginForm.Globals.Instance.reg_client.Midname;
                mngrPnl.Visible = false;
                clntPnl.BringToFront();

                //Обновление списка квартир в List<Apartment> и ListBox
                var apts = userC.refreshList("AptsListObj.txt", lstBx_cAptView, (Apartment)apart, apartments.Cast<Object>().ToList());
                foreach (Apartment a in apts)
                {
                    this.apartments.Add(a);
                }

                //Обновление списка заявок конкретного клиента
                lstBx_cAppl.Items.Clear();

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStreamObj = new FileStream("AppsListObj.txt", FileMode.Open))
                {
                    while (fileStreamObj.Position != fileStreamObj.Length)
                    {
                        Applications apln = (Applications)binaryFormatter.Deserialize(fileStreamObj);
                        applications.Add((Applications)apln);

                        if (apln.AppClient.Id == userC.Id)
                        {
                            lstBx_cAppl.Items.Add(apln);
                        }
                    }
                    app_max_id = applications.Max(x => x.Id);
                }
            }

            //Обновление списка договоров в List<Agreement>
            BinaryFormatter binaryFormatter1 = new BinaryFormatter();
            using (FileStream fileStreamObj = new FileStream("AgrsListObj.txt", FileMode.Open))
            {
                while (fileStreamObj.Position != fileStreamObj.Length)
                {
                    Agreement agrt = (Agreement)binaryFormatter1.Deserialize(fileStreamObj);
                    agreements.Add((Agreement)agrt);
                }
                agr_max_id = agreements.Max(x => x.Id);
            }
        }

        //Добавление квартиры (интерфейс менеджера)
        private void btn_addApt_Click(object sender, EventArgs e)
        {
            if (txtBx_Address.Text == "" || txtBx_Size.Text == "" || txtBx_numOfRooms.Text == "" || txtBx_Price.Text == "" || txtBx_Desc.Text == "")
            {
                MessageBox.Show("Введите все данные о квартире!");
            }
            else if (txtBx_Address.Text != "" && txtBx_Size.Text != "" && txtBx_numOfRooms.Text != "" && txtBx_Price.Text != "" && txtBx_Desc.Text != "") 
            {
                apart = new Apartment(apt_max_id, txtBx_Address.Text, Convert.ToInt32(txtBx_Size.Text), Convert.ToInt32(txtBx_numOfRooms.Text), Convert.ToInt32(txtBx_Price.Text), txtBx_Desc.Text);
                apartments.Add(apart);

                userM.addClassItem("AptsList.txt", "AptsListObj.txt", apart);
            }
            txtBx_Address.Text = "";
            txtBx_Size.Text = "";
            txtBx_numOfRooms.Text = "";
            txtBx_Price.Text = "";
            txtBx_Desc.Text = "";            
        }

        //Обновление списка квартир (интерфейс менеджера)
        private void btn_mAptList_Click(object sender, EventArgs e)
        {            
            userM.refreshList("AptsListObj.txt", lstBx_mAptView, (Apartment)apart, apartments.Cast<Object>().ToList());
        }

        //Обновление списка квартир (интерфейс клиента)
        private void btn_cAptList_Click(object sender, EventArgs e)
        {
            userC.refreshList("AptsListObj.txt", lstBx_cAptView, (Apartment)apart, apartments.Cast<Object>().ToList());
        }

        //Блокирование клиента (интерфейс менеджера)
        private void btn_blockClt_Click(object sender, EventArgs e)
        {
            if (lstBx_mClntList.SelectedIndex >= 0)
            {
                clts = lstBx_mClntList.SelectedItem as Client;
                if (clts.Surname.StartsWith("*"))
                {
                    MessageBox.Show("Клиент уже заблокирован!");
                }
                else 
                { 
                    var clt_in_lst = clients.Find(c => c.Phone == clts.Phone);
                    clt_in_lst.Surname = "*" + clts.Surname;
                }                
            }
            else
            {
                MessageBox.Show("Выберите клиента для блокировки!");
            }
            lstBx_mClntList.SelectedIndex = -1;
        }

        //Обновление списка клиентов (интерфейс менеджера)
        private void btn_mClntList_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ClientList.txt", string.Empty);
            File.WriteAllText("ClientListObj.txt", string.Empty);

            foreach (Client item in clients)
            {
                userM.rewriteClassItems("ClientList.txt", "ClientListObj.txt", item);
            }
            userM.refreshList("ClientListObj.txt", lstBx_mClntList, (Client)clts, clients.Cast<Object>().ToList());
        }

        //Одобрение заявки -> создание договора (интерфейс менеджера)
        private void btn_appApprove_Click(object sender, EventArgs e)
        {
            if (lstBx_mAppl.SelectedIndex >= 0)
            {
                app = lstBx_mAppl.SelectedItem as Applications;
                if ((app.Is_approved == true) || (app.AppApartment.Address.StartsWith("*")))
                {
                    MessageBox.Show("Заявка по этому адресу уже отработана!");
                }
                else
                {
                    var app_in_lst = applications.Find(a => a.Id == app.Id);
                    app_in_lst.Is_approved = true;

                    agrmt = new Agreement(agr_max_id, app_in_lst);
                    agreements.Add(agrmt);

                    userM.addClassItem("AgrsList.txt", "AgrsListObj.txt", agrmt);

                    //"Блокировка" остальных заявок на одобренную квартиру
                    List<Applications> rest_apps = applications.Where(a => (a.Id != app.Id) && (a.AppApartment.Id == app.AppApartment.Id) && (!a.AppApartment.Address.StartsWith("*"))).ToList();
                    foreach (Applications item in rest_apps)
                    {
                        item.AppApartment.Address = "*" + item.AppApartment.Address;
                    }

                    //Изменение статуса квартиры
                    var apt_in_lst = apartments.Find(a => a.Id == app_in_lst.AppApartment.Id);
                    apt_in_lst.Is_vacant = false;

                    File.WriteAllText("AptsList.txt", string.Empty);
                    File.WriteAllText("AptsListObj.txt", string.Empty);

                    foreach (Apartment item in apartments)
                    {
                        userM.rewriteClassItems("AptsList.txt", "AptsListObj.txt", item);
                    }
                    userM.refreshList("AptsListObj.txt", lstBx_mAptView, (Apartment)apt_in_lst, apartments.Cast<Object>().ToList());
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку для одобрения!");
            }
            lstBx_mAppl.SelectedIndex = -1;
        }

        //Обновление списка заявок (интерфейс менеджера)
        private void btn_mAppList_Click(object sender, EventArgs e)
        {
            File.WriteAllText("AppsList.txt", string.Empty);
            File.WriteAllText("AppsListObj.txt", string.Empty);

            foreach (Applications item in applications)
            {
                userM.rewriteClassItems("AppsList.txt", "AppsListObj.txt", item);
            }
            userM.refreshList("AppsListObj.txt", lstBx_mAppl, (Applications)app, applications.Cast<Object>().ToList());
        }

        //Контроль ввода оценки
        private void txtBx_Rate_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBx_Rate.Text, "[^1-5]"))
            {
                MessageBox.Show("Введите число от 1 до 5");
                txtBx_Rate.Text = "";
            }
        }

        //Оценивание квартиры (интерфейс клиента)
        private void btn_RateAsmt_Click(object sender, EventArgs e)
        {
            if (lstBx_cAptView.SelectedIndex >= 0)
            {
                if (txtBx_Rate.Text != "")
                {
                    apart = lstBx_cAptView.SelectedItem as Apartment;
                    var apt_in_lst = apartments.Find(a => a.Id == apart.Id);

                    apt_in_lst.Set(LoginForm.Globals.Instance.reg_client.Id.ToString(), Convert.ToInt32(txtBx_Rate.Text));
                    lstBx_cAptView.SelectedIndex = -1;
                    //MessageBox.Show(apt_in_lst.ToString());
                }
                else 
                {
                    MessageBox.Show("Введите оценку (от 1 до 5 баллов)!");
                }
            }
            else 
            {
                MessageBox.Show("Выберите квартиру для оценки!");
            }
        }

        //Обновление списка квартир (интерфейс клиента)
        private void btn_cAptList_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText("AptsList.txt", string.Empty);
            File.WriteAllText("AptsListObj.txt", string.Empty);

            foreach (Apartment item in apartments)
            {
                userC.rewriteClassItems("AptsList.txt", "AptsListObj.txt", item);
            }
            userC.refreshList("AptsListObj.txt", lstBx_cAptView, (Apartment)apart, apartments.Cast<Object>().ToList());
        }

        //Заявка на аренду (интерфейс клиента)
        private void btn_Rent_Click(object sender, EventArgs e)
        {
            if (lstBx_cAptView.SelectedIndex >= 0)
            {
                apart = lstBx_cAptView.SelectedItem as Apartment;
                var apt_in_lst = apartments.Find(a => a.Id == apart.Id);

                if (apt_in_lst.Is_vacant == false)
                {
                    MessageBox.Show("Квартира уже сдана!");
                }
                else 
                { 
                app = new Applications(app_max_id, LoginForm.Globals.Instance.reg_client, apt_in_lst, txtBx_appComm.Text);
                applications.Add(app);

                userC.addClassItem("AppsList.txt", "AppsListObj.txt", app);
                lstBx_cAptView.SelectedIndex = -1;
                } 
            }
            else
            {
                MessageBox.Show("Выберите квартиру для заявки!");
            }
        }

        //Обновление списка заявок (интерфейс клиента)
        private void btn_cApp_Click(object sender, EventArgs e)
        {
            lstBx_cAppl.Items.Clear();

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStreamObj = new FileStream("AppsListObj.txt", FileMode.Open))
            {
                while (fileStreamObj.Position != fileStreamObj.Length)
                {
                    Applications apln = (Applications)binaryFormatter.Deserialize(fileStreamObj);
                    applications.Add((Applications)apln);

                    if (apln.AppClient.Id == userC.Id)
                    {
                        lstBx_cAppl.Items.Add(apln);
                    }
                }
            }
        }

        //Просмотр договора по одобренной заявке (интерфейс клиента)
        private void btn_viewAgrmt_Click(object sender, EventArgs e)
        {
            if (lstBx_cAppl.SelectedIndex >= 0)
            {
                app = lstBx_cAppl.SelectedItem as Applications;
                if (app.Is_approved == true)
                {
                    var agr_in_lst = agreements.Find(a => a.AgrApplications.Id == app.Id);
                    Agrmnt.Text = agr_in_lst.ToString();
                }
                apart = lstBx_cAptView.SelectedItem as Apartment;                
            }
            else
            {
                MessageBox.Show("Выберите заявку для просмотра договора!");
            }
        }

        //Выход (интерфейс менеджера)
        private void btn_mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Выход (интерфейс клиента)
        private void btn_cExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
