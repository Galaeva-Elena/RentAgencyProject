using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAgencyProject
{
    [Serializable]
    public class Client: User
    {
        private static int clt_cnt = 0;
        private int max_id = 0;
        private int id;

        //Новый клиент
        public Client(int max_id, string surname, string name, string midname, DateTime birth_date, string phone) : base(surname, name, midname, birth_date, phone)
        {
            this.max_id = max_id;
            clt_cnt += max_id + 1;
            this.id = clt_cnt;
        }

        //ID
        public int Id
        {
            get
            {
                return id;
            }
        }

        //Инфо о клиенте
        //пароль добавлен в целях демонстрации
        public override string ToString()
        {
            return $"ID: {this.id} Тел: {base.Phone} Пароль: {base.Password} ФИО: {base.Surname} {base.Name} {base.Midname} Дата рождения: {base.Birth_date}";
        }
    }
}
