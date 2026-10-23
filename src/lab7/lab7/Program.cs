using System;

namespace Lab7
{
    /// <summary>
    /// Класс для расчёта скидок в системе заказов компании «Обувь-Маг».
    /// </summary>
    public class DiscountCalculator
    {
        /// <summary>
        /// Рассчитывает цену со скидкой 25%, если по товару
        /// не было заказов в прошлом месяце.
        /// </summary>
        /// <param name="basePrice">Базовая цена товара.</param>
        /// <param name="hasOrdersLastMonth">Были ли заказы в прошлом месяце.</param>
        /// <returns>Цена со скидкой или базовая цена.</returns>
        public decimal GetDiscountedPrice(decimal basePrice, bool hasOrdersLastMonth)
        {
            if (hasOrdersLastMonth)
                return basePrice;
            return basePrice * 0.75m;
        }

        /// <summary>
        /// Выводит информацию о примененной скидке в консоль.
        /// </summary>
        /// <param name="price">Итоговая цена.</param>
        public void PrintInfo(decimal price)
        {
            Console.WriteLine($"Итоговая цена для клиента: {price} руб.");
        }
    }

    class Program
    {
        /// <summary>
        /// Главная точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            var calculator = new DiscountCalculator();
            decimal price = 1000m;

            decimal discounted = calculator.GetDiscountedPrice(price, false);

            Console.WriteLine($"Базовая цена: {price}");
            Console.WriteLine($"Цена со скидкой: {discounted}");
            calculator.PrintInfo(discounted);

            Console.WriteLine("\nВыполнил: Токсар, группа И-43");

            Console.ReadKey();
        }
    }
}