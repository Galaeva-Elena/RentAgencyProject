using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAgencyProject
{
    public class Manager: User
    {        
        private static int mngr_cnt = 0;
        private int id;

        //Новый менеджер
        public Manager()
        {
            mngr_cnt ++;
            this.id = mngr_cnt;
            base.Surname = "Тестов";
            base.Name = "Тест";
            base.Midname = "Тестович";
            base.Birth_date = "01.01.1900";
            base.Phone = "00000";
            base.Password = "admin";
        }

        //ID
        public int Id
        {
            get
            {
                return id;
            }

            set 
            {
                id = value;
            }
        }        
    }
}
