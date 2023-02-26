using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace RentAgencyProject
{
    [Serializable]
    public class User
    {
        private string surname;
        private string name;
        private string midname;
        private string birth_date;
        private string phone;
        private string password;

        public User(string surname, string name, string midname, DateTime birth_date, string phone)
        {
            this.surname = surname;
            this.name = name;
            this.midname = midname;
            this.birth_date = birth_date.ToShortDateString();
            this.phone = phone;
            this.password = String.Format("{0:X}", (surname + name + birth_date.ToShortDateString()).GetHashCode());
        }

        public User() 
        { 
        
        }
        
        //Фамилия
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                if (value.Length > 3)
                {
                    surname = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        //Имя
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length > 3)
                {
                    name = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        //Отчество
        public string Midname
        {
            get
            {
                return midname;
            }

            set
            {
                if (value.Length > 3)
                {
                    midname = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        //Дата рождения
        public string Birth_date
        {
            get
            {
                return birth_date;
            }

            set
            {
                birth_date = value;
            }
        }

        //Телефон (логин)
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                if (value.Length >= 5 && value.Length <= 10)
                {
                    phone = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        //Пароль
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        //Обновление объектов класса и списка в ListBox
        public List<Object> refreshList(string objDataFile, ListBox listBox, Object objItem, List<Object> objList)
        {
            listBox.Items.Clear();

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStreamObj = new FileStream(objDataFile, FileMode.Open))
            {
                while (fileStreamObj.Position != fileStreamObj.Length)
                {
                    objItem = (Object)binaryFormatter.Deserialize(fileStreamObj);
                    objList.Add(objItem);
                    listBox.Items.Add(objItem);
                }
            }
            return objList;
        }

        //Добавление экземпляра класса в файл строковых представлений и файл объектов
        public void addClassItem(string dataFile, string objDataFile, Object objItem)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(dataFile, FileMode.Append))
            {
                StreamWriter strmW = new StreamWriter(fileStream, Encoding.GetEncoding("windows-1251"));
                strmW.AutoFlush = true;
                strmW.Write(objItem.ToString() + '\n');
            }

            using (FileStream fileStream = new FileStream(objDataFile, FileMode.Append))
            {
                binaryFormatter.Serialize(fileStream, objItem);
            }
        }

        //Перезапись файла строковых представлений и файла объектов при изменении существующего объекта
        public void rewriteClassItems(string dataFile, string objDataFile, Object objItem)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(dataFile, FileMode.Append))
            {
                StreamWriter strmW = new StreamWriter(fileStream, Encoding.GetEncoding("windows-1251"));
                strmW.AutoFlush = true;
                strmW.Write(objItem.ToString() + '\n');
            }

            using (FileStream fileStream = new FileStream(objDataFile, FileMode.Append))
            {
                binaryFormatter.Serialize(fileStream, objItem);
            }
        }
    }
}
