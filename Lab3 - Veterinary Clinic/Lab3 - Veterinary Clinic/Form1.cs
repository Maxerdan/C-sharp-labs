using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3___Veterinary_Clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // при загрузке формы будет выполняться этот код
            object[] array = new object[8];

            // создаем экземпляр класса
            Doctors_Appointment da = new Doctors_Appointment("Зоодоктор", "Прием врача", "Хирург");
            // заполняем массив
            array[0] = da;

            Ultrasound us = new Ultrasound("Зоо", "УЗИ", "Почки");
            array[1] = us;

            Haircut.haircut = 500; // стоимость любой стрижки
            Haircut hc = new Haircut("Зоодоктор+", "Стрижка");
            array[2] = hc;

            Express_Test et = new Express_Test("Доктор Животных", "Экспресс-Биохимия");
            array[3] = et;

            Test t = new Test("Доктор Животных", "Биохимия");
            array[4] = t;

            Maintenance_In_The_Hospital mt = new Maintenance_In_The_Hospital("Клиника Питомцев", "Стационар", 24);
            array[5] = mt;

            Wound_Treatment wt = new Wound_Treatment("Зоодоктор", false, "Обработка царапины");
            array[6] = wt;

            Operation op = new Operation("Зоодоктор", true, "Операция на печень");
            array[7] = op;

            // вывод каждого элемента массива в элемент listbox
            for (int i = 0; i < array.Length; i++)
                listBox1.Items.Add(array[i].ToString());
        }
    }
}
