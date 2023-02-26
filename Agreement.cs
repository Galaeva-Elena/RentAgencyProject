using System;

namespace RentAgencyProject
{
    [Serializable]
    public class Agreement
    {
        private static int agr_cnt = 0;
        private int max_id = 0;
        private int id;
        Applications application;
        DateTime start_day;

        //Договор аренды
        public Agreement(int max_id, Applications application)
        {
            this.max_id = max_id;
            agr_cnt += max_id + 1;
            this.id = agr_cnt;
            this.application = application;

            start_day = DateTime.Now.AddDays(1);
            
        }

        //ID
        public int Id
        {
            get
            {
                return id;
            }
        }

        //Заявка
        public Applications AgrApplications
        {
            get
            {
                return application;
            }

            set
            {
                application = value;
            }
        }

        //Расчет арендной платы за ближайший месяц
        public int Payment() 
        {
            DateTime end_day = start_day.AddMonths(1);
            int days = Convert.ToInt32((end_day - start_day).TotalDays);
            int sum_per_month = days * application.AppApartment.Price_per_day;

            return sum_per_month;
        }

        public override string ToString()
        {
            return $@"ДОГОВОР АРЕНДЫ
Арендатор: {this.application.AppClient.Surname} {this.application.AppClient.Name} {this.application.AppClient.Midname} {this.application.AppClient.Birth_date} тел.: {this.application.AppClient.Phone}
Квартира: {this.AgrApplications.AppApartment.Address} {this.AgrApplications.AppApartment.Size}м2 {this.AgrApplications.AppApartment.Num_of_rooms}-комн. {this.AgrApplications.AppApartment.Price_per_day} руб/сут {this.AgrApplications.AppApartment.Description}
Срок договора: c {this.start_day.ToShortDateString()} по {this.start_day.AddYears(1).ToShortDateString()}
Сумма к оплате: {this.Payment()*3}, в т.ч. аренда: {this.Payment()}, депозит: {this.Payment()}, комиссия агентству: {this.Payment()}
";
        }
    }
}
