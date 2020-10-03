using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO5
{
    public partial class Form1 : Form
    {
        public object[] array = new object[50];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Doctors_Appointment da1 = new Doctors_Appointment("Зоодоктор", "Прием врача", "Хирург");
            array[0] = da1;

            Ultrasound us1 = new Ultrasound("Зоо", "УЗИ", "Почки");
            array[1] = us1;

            Haircut.haircut = 500;
            Haircut hc1 = new Haircut("Зоодоктор+", "Стрижка");
            array[2] = hc1;

            Express_Test et1 = new Express_Test("Доктор Животных", "Экспресс-Биохимия");
            array[3] = et1;

            Test t1 = new Test("Доктор Животных", "Биохимия");
            array[4] = t1;

            Maintenance_In_The_Hospital mt1 = new Maintenance_In_The_Hospital("Клиника Питомцев", "Стационар", 24);
            array[5] = mt1;

            Wound_Treatment wt1 = new Wound_Treatment("Зоодоктор", false, "Обработка царапины");
            array[6] = wt1;

            Operation op1 = new Operation("Зоодоктор", true, "Операция на печень");
            array[7] = op1;

            Doctors_Appointment da2 = new Doctors_Appointment("Зоо", "Прием врача", "Терапевт");
            array[8] = da2;

            Ultrasound us2 = new Ultrasound("Друг животных", "УЗИ", "Печень");
            array[9] = us2;

            Haircut hc2 = new Haircut("Друг животных", "Стрижка");
            array[10] = hc2;

            Express_Test et2 = new Express_Test("Зоо", "Экспресс-Биохимия");
            array[11] = et2;

            Test t2 = new Test("Зоодоктор", "Биохимия");
            array[12] = t2;

            Maintenance_In_The_Hospital mt2 = new Maintenance_In_The_Hospital("Зоо", "Стационар", 12);
            array[13] = mt2;

            Wound_Treatment wt2 = new Wound_Treatment("Друг животных", false, "Обработка раны");
            array[14] = wt2;

            Operation op2 = new Operation("Друг животных", true, "Операция на лапу");
            array[15] = op2;

            Doctors_Appointment da3 = new Doctors_Appointment("Зоодоктор+", "Прием врача", "Хирург");
            array[16] = da3;

            Ultrasound us3 = new Ultrasound("Друг животных", "УЗИ", "Почки");
            array[17] = us3;

            Haircut hc3 = new Haircut("Зоо", "Стрижка");
            array[18] = hc3;

            Express_Test et3 = new Express_Test("Друг животных", "Экспресс-Биохимия");
            array[19] = et3;

            Test t3 = new Test("Доктор Животных", "Биохимия");
            array[20] = t3;

            Maintenance_In_The_Hospital mt3 = new Maintenance_In_The_Hospital("Зоо", "Стационар", 35);
            array[21] = mt3;

            Wound_Treatment wt3 = new Wound_Treatment("Клиника Питомцев", false, "Удаление гноя");
            array[22] = wt3;

            Operation op3 = new Operation("Клиника Питомцев", true, "Операция на почки");
            array[23] = op3;

            Doctors_Appointment da4 = new Doctors_Appointment("Клиника Питомцев", "Прием врача", "Терапевт");
            array[24] = da4;

            Ultrasound us4 = new Ultrasound("Клиника Питомцев", "УЗИ", "Сердца");
            array[25] = us4;

            Haircut hc4 = new Haircut("Клиника Питомцев", "Стрижка");
            array[26] = hc4;

            Express_Test et4 = new Express_Test("Клиника Питомцев", "Экспресс-Биохимия");
            array[27] = et4;

            Test t4 = new Test("Доктор Животных", "Биохимия");
            array[28] = t4;

            Maintenance_In_The_Hospital mt4 = new Maintenance_In_The_Hospital("Клиника Питомцев", "Стационар", 24);
            array[29] = mt4;

            Wound_Treatment wt4 = new Wound_Treatment("Зоодоктор", false, "Обработка царапины");
            array[30] = wt4;

            Operation op4 = new Operation("Клиника Питомцев", false, "Операция на почки");
            array[31] = op4;

            Operation op5 = new Operation("Зоодоктор", true, "Операция на сердце");
            array[32] = op5;

            Operation op6 = new Operation("Доктор Животных", true, "Операция на печень");
            array[33] = op6;

            Operation op7 = new Operation("Зоо", true, "Операция на почки");
            array[34] = op7;

            Operation op8 = new Operation("Клиника Питомцев", true, "Операция на печень");
            array[35] = op8;

            Haircut hc5 = new Haircut("Зоодоктор+", "Стрижка");
            array[36] = hc5;

            Haircut hc6 = new Haircut("Доктор Животных", "Стрижка");
            array[37] = hc6;

            Haircut hc7 = new Haircut("Доктор Животных", "Стрижка");
            array[38] = hc7;

            Haircut hc8 = new Haircut("Зоо", "Стрижка");
            array[39] = hc8;

            Maintenance_In_The_Hospital mt5 = new Maintenance_In_The_Hospital("Клиника Питомцев", "Стационар", 2);
            array[40] = mt5;

            Maintenance_In_The_Hospital mt6 = new Maintenance_In_The_Hospital("Клиника Питомцев", "Стационар", 36);
            array[41] = mt6;

            Maintenance_In_The_Hospital mt7 = new Maintenance_In_The_Hospital("Клиника Питомцев", "Стационар", 33);
            array[42] = mt7;

            Maintenance_In_The_Hospital mt8 = new Maintenance_In_The_Hospital("Клиника Питомцев", "Стационар", 99);
            array[43] = mt8;

            Maintenance_In_The_Hospital mt9 = new Maintenance_In_The_Hospital("Клиника Питомцев", "Стационар", 80);
            array[44] = mt9;

            Maintenance_In_The_Hospital mt10 = new Maintenance_In_The_Hospital("Зоодоктор", "Стационар", 44);
            array[45] = mt10;

            Maintenance_In_The_Hospital mt11 = new Maintenance_In_The_Hospital("Зоодоктор", "Стационар", 70);
            array[46] = mt11;

            Maintenance_In_The_Hospital mt12 = new Maintenance_In_The_Hospital("Зоодоктор", "Стационар", 33);
            array[47] = mt12;

            Maintenance_In_The_Hospital mt13 = new Maintenance_In_The_Hospital("Зоодоктор", "Стационар", 22);
            array[48] = mt13;

            Maintenance_In_The_Hospital mt14 = new Maintenance_In_The_Hospital("Зоодоктор", "Стационар", 66);
            array[49] = mt14;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //<==============================================   1   ===========================================================>
            listBox1.Items.Clear(); // чистим поле для вывода
            string requestText = InBox1.Text; // параметр запроса, который вводит пользователь

            var list = from req in array
                       where req.GetType() == typeof(Maintenance_In_The_Hospital) // выбираем только класс стационар
                       where req.ToString().Contains($"Клиника: {requestText},") // и в качестве вводимого параметра будем искать по названию клиники из переопределенного метода ToString для класса "стрижка"
                       select req;

            foreach (var el in list) // Выводим все найденные данные
            {
                listBox1.Items.Add(el + "\t"); // вывод будет браться из переопределенного метода
            }
            //<==============================================   Конец 1   =====================================================>
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //<==============================================   2   ===========================================================>
            listBox2.Items.Clear();
            string requestText = inBox2.Text;

            var list = from req in (
                       from r in array
                       where r.GetType() == typeof(Operation) // выбираем только класс операции
                       select (Operation)r // так как храним массив объектов приведем найденные объекты к классу нужному
                       ) // так как мы стремимся сделать все одним запросом, то сначала мы выберем все объекты нужного класса (все что выше), а потом будем искать в уже отобранных (ниже по коду) своеобразная двойная проверка
                       where req.Name == requestText // ищем нужное имя клиники
                       where req.anesthesia == checkBox2.Checked // ищем те в которых нужна анестезия или не нужна
                       select req;

            foreach (var el in list) // Выводим все найденные данные
            {
                string booleanOutput; // конструкция для красивого вывода
                if (el.anesthesia)
                    booleanOutput = "С анестезией";
                else
                    booleanOutput = "Без анестезии";

                listBox2.Items.Add(el.chosenTypeName + "\t" + booleanOutput); // тип + использовать анестезию/нет
            }
            //<==============================================   Конец 2   =====================================================>
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //<==============================================   3   ===========================================================>
            listBox3.Items.Clear();
            var namesList = listBox3_choose.SelectedItems; // получаем список выделенных клиник

            var list = from req in (
                       from r in array
                       where r.GetType() == typeof(Maintenance_In_The_Hospital) // выбираем только класс стационар
                       select (Maintenance_In_The_Hospital)r // так как храним массив объектов приведем найденные объекты к классу нужному
                       )
                       where namesList.Contains(req.Name) // берем только те клиники которые входят в список
                       orderby req.Name, req.time // сортируем сначала по названию а потом по времени провождения
                       select req;

            foreach (var el in list)
            {
                listBox3.Items.Add(el.Name + "\t" + el.time + " ч"); // название клиники + время
            }
            //<==============================================   Конец 3   =====================================================>
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //<==============================================   4   ===========================================================>
            listBox4.Items.Clear();
            var namesList = listBox4_choose.SelectedItems;

            var list = from req in (
                       from r in array
                       where r.GetType() == typeof(Maintenance_In_The_Hospital) // выбираем только класс стационар
                       select (Maintenance_In_The_Hospital)r // так как храним массив объектов приведем найденные объекты к классу нужному
                       )
                       where namesList.Contains(req.Name) // берем только те клиники которые входят в список
                       select new { Name = req.Name, Time = req.time, Cost = req.cost }; // для каждого найденного элемента создадим анонимный тип с полями: Название клиники, Время, Цена и выберем его

            foreach (var el in list)
            {
                listBox4.Items.Add(el.Name + "\t" + el.Time + " ч" + "\t" + el.Cost + " р");
            }
            //<==============================================   Конец 4   =====================================================>
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //<==============================================   5   ===========================================================>
            listBox5.Items.Clear();
            var namesList = listBox5_choose.SelectedItems;

            var list = from req in (
                       from r in array
                       where r.GetType() == typeof(Haircut) // выбираем только класс стрижка
                       select (Haircut)r // так как храним массив объектов приведем найденные объекты к классу нужному
                       )
                       where namesList.Contains(req.Name) // берем только те клиники которые входят в список
                       group req by req.Name into rr // группируем по названию клиники
                       select new { Name = rr.Key, Count = rr.Count() }; // создаем анонимный тип содежражий название клиники и количество записей

            foreach (var el in list)
            {
                listBox5.Items.Add(el.Name + "\t" + el.Count + " шт");
            }
            //<==============================================   Конец 5   =====================================================>
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //<==============================================   6   ===========================================================>
            listBox6.Items.Clear();
            var namesList = listBox6_choose.SelectedItems;
            int N = int.Parse(inBox6.Text);

            var list = array
               .Where(req => req.GetType() == typeof(Maintenance_In_The_Hospital)) // выбираем только класс стационар
               .Select(req => (Maintenance_In_The_Hospital)req) // так как храним массив объектов приведем найденные объекты к классу нужному
               .Where(req => namesList.Contains(req.Name)) // берем только те клиники которые входят в список
               .GroupBy(req => req.Name) // группируем записи по названиям клиник
               .Where(req => req.Select(r => r.time).Average() >= N) // берем только те клиники у которых среднее арифметическое времени больше введенного числа
               .OrderBy(req => req.Key) // сортируем имена 
               .Select(req => new { Name = req.Key, Time = req.OrderBy(re => re.time).Select(r => r.time).ToList() }) // создаем анонимный тип в котором первое значение - название клиники, второе - лист, в котором хранится время всех записей, отсортированное
               .ToList();

            foreach (var el in list) // для каждой группы
            {
                foreach (var el2 in el.Time) // для каждой записи
                    listBox6.Items.Add(el.Name + "\t" + el2.ToString() + " ч");
            }
            //<==============================================   Конец 6   =====================================================>
        }
    }
}
