using System.ComponentModel.Design;
using Tyuiu.HoteevaEV.Sprint2.Task6.V2.Lib;

namespace Tyuiu.HoteevaEV.Sprint2.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Хотеева Е. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенный оператор switch,     *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число месяца: ");
            int chm = Convert.ToInt32(Console.ReadLine());
            string rslt = ds.FindMonthSeason(chm);
            string res;
            if (rslt == "Зима")
            {
                res = "Это зимний месяц";
            }
            else if (rslt == "Весна")
            {
                res = "Это весенний месяц";
            }

            else if (rslt == "Лето")
            {
                res = "Это летний месяц";
            }

            else
            {
                res = "Это осенний мксяц";
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
