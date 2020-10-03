using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        /* Итак, будет сложно но попробую объяснить
        У тебя два потока: главный - в нем работают все кнопки, кроме кнопки "активация" и второй поток (DroidThrd) в котором прорабатывается логика дроида
        Эта логика основана на таймере котоырй через каждые 2 секунды тикает и ставит переменную DoSmth в true, а в логике это значит что если true, тогда
        дроид выполняет одно действие и сбрасывает флаг, и получается логика всегда крутится в цикле пока есть юниты на поле
        Все данные хранятся в одном единственном словаре в котором ключ - Тип юнита, а значение это его Количество на поле
        В главном потоке кнопки вызывают функции на добавление и убавление и самое ГЛАВНОЕ: нельзя взаимодействовать с элементами на форме, созданными
        в главном потоке, из других потоков
        Для этого я создал переменную  (flagToUpdate) которая по сути нужна для уничтожения юнитов с поля боя логикой дроида
        Напрямую удалить из списка не получалось и простым решением было создать переменную в которую буду записывать что нужно удалить, а таймер проверял
        если это поле не пустое - то запустить функцию удаление (это ты сможешь увидеть в методе timer_Tick)
        И если юнитов больше нет на поле то в качестве статуса второй поток передает слова что боевая операция завершена и таймер если видит такие слова останавливается
        */

        Thread DroidThrd; // поток для логики дроида
        Dictionary<string, int> BattleFieldObjects; // словарь для хранения всех единиц (юнитов) на поле
        bool DoSmth = true; // переменная необходима для срабатывания дроида каждые 2 секунды, когда она true проиходит событие и сразу же переводится в false чтобы ждать 2 секунды в методе таймера timer1_Tick
        string TextToOut; // переменная куда записывается вывод статуса ибо обратиться напрямую к полю статуса созданного в главном потоке невозможно из другого, нового потока
        string flagToUpdate = ""; // переменная для уничтожения техники и связи элемента вывода между потоками

        public Form1()
        {
            InitializeComponent();
            BattleFieldObjects = new Dictionary<string, int>(); // инициализация массива в котором будем хрнить имя юнита и их количество
        }

        // <------------------------------------------------------------------------------------------------------->
        // <------------------------------------------------------------------------------------------------------->
        private void UpdateField() // кастомный метод на обновление списка единиц на поле
        {
            field_listbox.Items.Clear();
            SubUpdate("Вражеский солдат"); // передаем имя
            SubUpdate("Вражеский танк");
            SubUpdate("Вражеский самолет");
            SubUpdate("Наш офицер");
        }

        private void SubUpdate(string unitName) // помощник кастомного вывода)))))))) - заполняет лист определенным типом единиц
        {
            if (BattleFieldObjects.ContainsKey(unitName))
            {
                for (var i = 1; i <= BattleFieldObjects[unitName]; i++)
                {
                    field_listbox.Items.Add($"{unitName} №{i}"); // просто выводим в лист с номером
                }
            }
        }
        // <------------------------------------------------------------------------------------------------------->
        // <------------------------------------------------------------------------------------------------------->

        private void DroidActons() // логика дроида
        {
            while (BattleFieldObjects.Count > 0) // пока на поле боя есть объекты
            {
                if (DoSmth == true) // если прошло 2 секунды (DoSmth == true) - выводим
                {
                    if (BattleFieldObjects.ContainsKey("Наш офицер")) // видим офицера
                    {
                        TextToOut = "Защищаю офицера";
                        DoSmth = false;
                    }
                    else if (BattleFieldObjects.ContainsKey("Вражеский самолет"))
                    {
                        TextToOut = "Прячусь";
                        DoSmth = false;
                    }
                    else if (BattleFieldObjects.ContainsKey("Вражеский танк"))
                    {
                        TextToOut = "Уничтожаю танки";
                        flagToUpdate = "Вражеский танк";
                        DoSmth = false;
                    }
                    else if (BattleFieldObjects.ContainsKey("Вражеский солдат"))
                    {
                        TextToOut = "Уничтожаю солдат";
                        flagToUpdate = "Вражеский солдат";
                        DoSmth = false;
                    }
                    else
                    {

                    }
                }
            }

            TextToOut = "Боевая операция выполнена";
        }

        private void b_activate_Click(object sender, EventArgs e)
        {
            TextToOut = "Активация";
            status_box.Text = TextToOut; // нужно чтобы при первой активации не ждать 2 секунды до отрисовки статуса
            timer1.Start();
            DroidThrd = new Thread(DroidActons); // инициализируем поток
            DroidThrd.Start(); // запуск потока на выполнение
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status_box.Text = TextToOut; // вывод статуса
            if (flagToUpdate != "")
            {
                MinusFunc(flagToUpdate);
                flagToUpdate = "";
            }
            else if (TextToOut == "Боевая операция выполнена") // выключаем таймер в конце операции
            {
                timer1.Stop();
            }
            DoSmth = true; // активация действий дроида
        }

        //<---------------------------------------------------------------------------------------------------------------------------------------->
        //<---------------------------------------------------------------------------------------------------------------------------------------->
        // так как во всех кнопках + и - одинаковый код а меняется только имя единицы - напишу две функции с приемом имени - так будел логичнее и меньше по объему
        private void PlusFunc(string unitName)
        {
            if (!BattleFieldObjects.ContainsKey(unitName)) // если ни одного офицера
            {
                BattleFieldObjects.Add(unitName, 1); // то создадим эту единицу, а в последующих случаях будем просто увеличивать их количество
            }
            else
            {
                BattleFieldObjects[unitName]++; // если есть то добавить еще
            }
            UpdateField(); // обновляем весь лист вывода
        }

        private void MinusFunc(string unitName)
        {
            if (BattleFieldObjects.ContainsKey(unitName) && BattleFieldObjects[unitName] == 1) // если остался последний - удаляем из словаря
            {
                BattleFieldObjects.Remove(unitName);
            }
            else if (BattleFieldObjects.ContainsKey(unitName)) // если их много - уменьшаем количество на единицу
            {
                BattleFieldObjects[unitName]--;
            }
            else
            {
                // если их вообще нету то и делать ничего не нужно
            }
            UpdateField(); // обновляем весь лист вывода
        }
        //<---------------------------------------------------------------------------------------------------------------------------------------->
        //<---------------------------------------------------------------------------------------------------------------------------------------->

        private void b_officer_pl_Click(object sender, EventArgs e)
        {
            PlusFunc("Наш офицер"); // функция на добавление 
        }

        private void b_officer_mi_Click(object sender, EventArgs e)
        {
            MinusFunc("Наш офицер"); // функция на убавление
        }

        private void b_plane_pl_Click(object sender, EventArgs e)
        {
            PlusFunc("Вражеский самолет");
        }

        private void b_plane_mi_Click(object sender, EventArgs e)
        {
            MinusFunc("Вражеский самолет");
        }

        private void b_tank_pl_Click(object sender, EventArgs e)
        {
            PlusFunc("Вражеский танк");
        }

        private void b_tank_mi_Click(object sender, EventArgs e)
        {
            MinusFunc("Вражеский танк");
        }

        private void b_soldier_pl_Click(object sender, EventArgs e)
        {
            PlusFunc("Вражеский солдат");
        }

        private void b_soldier_mi_Click(object sender, EventArgs e)
        {
            MinusFunc("Вражеский солдат");
        }
    }
}
