using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAgencyProject
{
    [Serializable]
    public class Apartment
    {
        private static int apt_cnt = 0;
        private int max_id = 0;
        private int id;
        private string address;
        private int size;
        private int num_of_rooms;
        private int price_per_day;
        private string description;
        private bool is_vacant;
        private Dictionary<string, int> rating = new Dictionary<string, int>();


        //Квартира
        public Apartment(int max_id, string address, int size, int num_of_rooms, int price_per_day, string description) 
        {
            this.max_id = max_id;
            apt_cnt += max_id + 1;
            this.id = apt_cnt;
            this.address = address;
            this.size = size;
            this.num_of_rooms = num_of_rooms;
            this.price_per_day = price_per_day;
            this.description = description;
            this.is_vacant = true;         
        }

        //ID
        public int Id
        {
            get
            {
                return id;
            }
        }

        //Адрес
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        //Площадь
        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        //Количество комнат
        public int Num_of_rooms
        {
            get
            {
                return num_of_rooms;
            }

            set
            {
                num_of_rooms = value;
            }
        }

        //Стоимость аренды
        public int Price_per_day
        {
            get
            {
                return price_per_day;
            }

            set
            {
                price_per_day = value;
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

        //Статус
        public bool Is_vacant
        {
            get
            {
                return is_vacant;
            }

            set
            {
                is_vacant = value;
            }
        }

        
        //Оценка
        public void Set(string key, int value)
        {
            if (rating == null) 
            { 
                rating = new Dictionary<string, int>();
            }
                
            if (rating.ContainsKey(key))
            {
                rating[key] = value;
            }
            else
            {
                rating.Add(key, value);
            }
        }

        public double calcRating() 
        {
            double score = 0.0;
            if (rating?.Count > 0) 
            {
                score = Math.Round(rating.Average(x => x.Value), 1);
            }

            return score;

        }

        //Инфо о квартире
        public override string ToString()
        {
            return $"ID: {this.id} Адрес: {this.address} Площадь: {this.size} Количество комнат: {this.num_of_rooms} Стоимость аренды за сутки: {this.price_per_day} Описание: {this.description} Статус: {this.is_vacant} Оценка: {this.calcRating():0.0}";
        }
    }
}
