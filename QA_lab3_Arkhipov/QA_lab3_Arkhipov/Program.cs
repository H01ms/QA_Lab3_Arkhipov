using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_lab3_Arkhipov
{
    /// \author Oleg Arkhipov
    /// <summary>
    /// \brief Исполняемый класс программы с методом Main. Производится ввод данных и выводится соотвествующая информация.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dieta a = new Dieta();
            Console.WriteLine("Продукт: ");
            a.Init(300, 400, (double)125.5, (double)111.7, 100);
            double Sum = a.Cost();//Общая ценность продуктов
            a.Display();//Вывод данных
            Console.Write("\nСумма = " + Sum + "\n");
        }
    }
}
