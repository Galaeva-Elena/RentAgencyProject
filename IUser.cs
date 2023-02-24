using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAgencyProject
{
    interface IUser
    {
        //Обновление списка объектов
        List<Object> refreshList(string objDataFile, ListBox listBox, Object objItem, List<Object> objList);               

        //Добавление экземпляра класса
        void addClassItem(string dataFile, string objDataFile, Object objItem);

        //Перезапись всего класса
        void rewriteClassItems(string dataFile, string objDataFile, Object objItem);

        //Работа с заявкой
        void workOnApplication();

        //Оценка
        void rateAssignment(Object objItem, ListBox listBox, string propName);
        
    }
}
