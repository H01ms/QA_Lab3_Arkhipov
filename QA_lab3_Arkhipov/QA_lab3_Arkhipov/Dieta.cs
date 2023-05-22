using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_lab3_Arkhipov
{
    /// \ author Oleg Arkhipov
    /// <summary>
    /// \brief Основной класс Dieta содержит информацию о продуктах и использует вспомогательный класс Product
    /// </summary>
    /// \image html dieta.jpg
    /// \callergraph
    class Dieta
    {
        private Product e1 = new Product();// 1 продукт
        private Product e2 = new Product();// 2 продукт
        /// <summary>
        /// Метод инициализации данных диеты с двумя продуктами
        /// </summary>
        /// <param name="k1">Калории первого продукта</param>
        /// <param name="k2">Калории второго продукта</param>
        /// <param name="c1">Стоимость первого продукта</param>
        /// <param name="c2">Стоимость второго продукта</param>
        /// <param name="Kol">Количество хлебных единиц</param>
        public void Init(int k1, int k2, double c1, double c2, int Kol)
        {   // Инициализация данных продукта
            e1.Init(k1, c1, Kol);//1 продукт
            e2.Init(k2, c2, Kol);//2 продукт
        }
        /// <summary>
        /// Метод чтения данных продуктов с консоли
        /// </summary>
        public void Read()//Чтение данных продуктов с консоли
        {
            Console.WriteLine("Продукт-1:");
            e1.Read();
            Console.WriteLine("Продукт-2:");
            e2.Read();
        }
        /// <summary>
        /// Метод подсчитывающий общую ценность продуктов
        /// </summary>
        /// <returns>Метод возвращает общую ценность продуктов</returns>
        public double Cost()
        {
            double cosT = e1.Cost() + e2.Cost();
            return cosT;
        }
        /// <summary>
        /// Метод отображения данных продуктов в консоли
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Продукт-1:");
            e1.Display();
            Console.WriteLine("Продукт-2:");
            e2.Display();
        }
    }
}
