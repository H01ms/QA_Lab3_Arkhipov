using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_lab3_Arkhipov
{
    /// \author Oleg Arkhipov
    /// <summary>
    /// Вспомогательный класс Product содержит информацию о продукте в диете.
    /// </summary>
    class Product
    {
        private int kalorii; //Калории
        private double cost;// Ценность продукта
        int kolhleb;// Количество хлебных единиц
        /// <summary>
        /// Метод инициализации данных продукта
        /// </summary>
        /// <param name="k">Калории продукта</param>
        /// <param name="c">Ценность продукта</param>
        /// <param name="Kol">Количество хлебных единиц</param>
        /// \callergraph
        public void Init(int k, double c, int Kol)//Инициализция данных продукта
        {
            kalorii = k;//Калории
            cost = c;//Ценность
            kolhleb = Kol;//Хлебные единицы
            if (kalorii <= 0)//Калории должны быть больше 0
            {
                throw new ArgumentOutOfRangeException(nameof(kalorii));
            }
            if (cost <= 0)//Ценность должна быть больше 0
            {
                throw new ArgumentOutOfRangeException(nameof(cost));
            }
            if (kolhleb <= 0)//Хлебные единицы должны быть больше 0
            {
                throw new ArgumentOutOfRangeException(nameof(kolhleb));
            }
        }
        /// <summary>
        /// Метод чтения данных продукта с консоли
        /// </summary>
        public void Read()//Чтение данных продукта
        {
            string s = "";
            s = Console.ReadLine();
            string[] s1 = s.Split(new char[] { ' ', '\t' },
            StringSplitOptions.RemoveEmptyEntries);
            kalorii = Convert.ToInt32(s1[0]);
            cost = Convert.ToDouble(s1[1]);
        }
        /// <summary>
        /// Добавление удвоенного числа хлебных единиц в знаменатель
        /// </summary>
        /// <returns></returns>
        public double Cost()
        {
            return Math.Round(cost / (kalorii + 2 * kolhleb), 2, MidpointRounding.AwayFromZero);
        }
        /// <summary>
        /// Метод отображения данных продуктов в консоли
        /// </summary>
        public void Display()//Вывод данных
        {
            Console.WriteLine("Калории:" + kalorii.ToString()); ;
            Console.WriteLine("Стоимость:" + cost.ToString());
            Console.WriteLine("Хлебных единиц: " + kolhleb.ToString());
        }
    }
}
