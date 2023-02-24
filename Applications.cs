using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAgencyProject
{
    [Serializable]
    public class Applications
    {
        private static int app_cnt = 0;
        private int max_id = 0;
        private int id;
        private Client client;
        private Apartment apartment;
        private string description;
        
        private bool is_approved;

        //Заявка на аренду
        public Applications(int max_id, Client client, Apartment apartment, string description) 
        {
            this.max_id = max_id;
            app_cnt += max_id + 1;
            this.id = app_cnt;
            this.client = client;
            this.apartment = apartment;
            this.is_approved = false;
            this.description = description;            
        }

        //ID
        public int Id
        {
            get
            {
                return id;
            }
        }

        //Статус заявки
        public bool Is_approved
        {
            get
            {
                return is_approved;
            }

            set 
            {
                is_approved = value;
            }
        }

        //Клиент - инициатор заявки
        public Client AppClient
        {
            get 
            { 
                return client;
            }

            set
            {
                client = value;
            }
        }

        //Квартира
        public Apartment AppApartment
        {
            get
            {
                return apartment;
            }

            set
            {
                apartment = value;
            }
        }

        private string toYesNo(bool b)
        {
            return b ? "Да" : "Нет";
        }

        //Статус заявки
        public string AppStatus
        {
            get 
            {
                return this.toYesNo(this.is_approved);
            }
        }

        //Описание
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        //Заявка на аренду
        public override string ToString()
        {
            return $"ID: {this.id} Клиент: {this.client.Surname} {this.client.Name.Substring(0,1)}. {this.client.Midname.Substring(0, 1)}. Квартира: {this.apartment.Address} Комментарий клиента: {this.description} Одобрена: {this.AppStatus}";
        }
    }
}
