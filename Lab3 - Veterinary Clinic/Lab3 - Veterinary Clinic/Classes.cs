using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3___Veterinary_Clinic
{
    // родительский класс (Услуги)
    class Services
    {
        // название клиники
        private string clinic_Name;

        // будем использовать для доступа к private полю clinic_Name
        public string Name
        {
            get { return clinic_Name; }
            set { clinic_Name = value; }
        }

        public Services(string name)
        {
            clinic_Name = name;
        }

        // метод который будем перегружать в производном классе
        public virtual string Info()
        {
            return "Вы пользуетесь услугами клиники: " + clinic_Name;
        }
    }

    // <----------------------------------------------------------------------------------------------------------->
    // использование абстрактных классов:
    // их использование объясняется тем, что от этих классов мы не будем создавать объекты, они используются для обощения своих производных классов
    // <----------------------------------------------------------------------------------------------------------->

    // производный класс (Лечебные манипуляции)
    abstract class Therapeutic_Manipulations : Services
    {
        // переменная для записи названия выбранной услуги
        public string chosenTypeName;

        // base используется для передачи переменных классу родителю - т е классу Services
        public Therapeutic_Manipulations(string name, string ChosenTypeName) : base(name)
        {
            chosenTypeName = ChosenTypeName;
        }
    }

    // производный класс (Лабораторные исследования)
    abstract class Laboratory_Analysis : Services
    {
        // экспресс тест или обычный
        public string typeOfTest;

        public Laboratory_Analysis(string name, string TypeOfTest) : base(name)
        {
            typeOfTest = TypeOfTest;
        }
    }

    // производный класс (Стационарное лечение)
    abstract class Hospital_Treatment : Services
    {
        public string chosenTypeName;

        public Hospital_Treatment(string name, string ChosenTypeName) : base(name)
        {
            chosenTypeName = ChosenTypeName;
        }
    }

    // производный класс (Хирургические манипуляции)
    abstract class Surgical_Manipulation : Services
    {
        public bool anesthesia;

        public string chosenTypeName;

        public Surgical_Manipulation(string name, bool Anesthesia, string ChosenTypeName) : base(name)
        {
            anesthesia = Anesthesia;
            chosenTypeName = ChosenTypeName;
        }
    }

    // производный класс от производного (Прием врача)
    class Doctors_Appointment : Therapeutic_Manipulations
    {
        // специальность врача
        public string doctors_Specialty;

        // конструктор передающий переменные в конструктор родителя
        public Doctors_Appointment(string name, string ChosenTypeName, string Doctors_Speciality) : base(name, ChosenTypeName)
        {
            doctors_Specialty = Doctors_Speciality;
        }

        // перегрузка метода
        public override string Info()
        {
            return doctors_Specialty + " вылечит вашего питомца в клинике: " + Name;
        }

        // перегрузка метода для вывода на форму
        public override string ToString()
        {
            return base.ToString() + $"\t\t Клиника: {Name}, {chosenTypeName}, Специальность: {doctors_Specialty}";
        }
    }

    // производный класс от производного (УЗИ)
    class Ultrasound : Therapeutic_Manipulations
    {
        // узи какого органа
        public string organUnderStudy;

        public Ultrasound(string name, string ChosenTypeName, string OrganUnderStudy) : base(name, ChosenTypeName)
        {
            organUnderStudy = OrganUnderStudy;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t\t\t Клиника: {Name}, {chosenTypeName}, Исследуемый орган: {organUnderStudy}";
        }
    }

    // производный класс от производного (Стрижки)
    class Haircut : Therapeutic_Manipulations
    {
        // поле static потому что считаем, что стрижки любого рода стоят одну цену (для всех экземпляров класса будет одинаковой)
        // цена стрижки
        public static int haircut;

        public Haircut(string name, string ChosenTypeName) : base(name, ChosenTypeName)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"\t\t\t Клиника: {Name}, {chosenTypeName}, Стоимость: {haircut}";
        }
    }

    // производный класс от производного (Экспресс-тесты)
    class Express_Test : Laboratory_Analysis
    {
        public Express_Test(string name, string TypeOfTest) : base(name, TypeOfTest)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"\t\t\t Клиника: {Name}, Экспресс - тест: {typeOfTest}";
        }
    }

    // производный класс от производного (Тесты)
    class Test : Laboratory_Analysis
    {
        public Test(string name, string TypeOfTest) : base(name, TypeOfTest)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"\t\t\t Клиника: {Name}, Тест: {typeOfTest}";
        }
    }

    // производный класс от производного (Содержание в стационаре)
    class Maintenance_In_The_Hospital : Hospital_Treatment
    {
        // время пребывания в стационаре (в часах)
        public int time;

        // цена
        public int cost;

        public Maintenance_In_The_Hospital(string name, string ChosenTypeName, int Time) : base(name, ChosenTypeName)
        {
            time = Time;
            Count();
        }

        // рассчет стоимости содержания (за 12 часов)
        public void Count()
        {
            if (time < 12)
                cost = 600;
            else
                cost = 400 * time / 12;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t Клиника: {Name}, {chosenTypeName}, Время пребывания: {time}, Стоимость: {cost}";
        }
    }

    // производный класс от производного (Обработка ран)
    class Wound_Treatment : Surgical_Manipulation
    {
        public Wound_Treatment(string name, bool Anesthesia, string ChosenTypeName) : base(name, Anesthesia, ChosenTypeName)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"\t\t Клиника: {Name}, {chosenTypeName}, Использование анастезии - {anesthesia}";
        }
    }

    // производный класс от производного (Операции)
    class Operation : Surgical_Manipulation
    {
        public Operation(string name, bool Anesthesia, string ChosenTypeName) : base(name, Anesthesia, ChosenTypeName)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"\t\t\t Клиника: {Name}, {chosenTypeName}, Использование анастезии - {anesthesia}";
        }
    }
}
