using System.Text;

namespace hw3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] arrayElements = { 5, 44, 13, 51, 78, 200 };
            Array array = new Array(arrayElements);

            array.Show();
            Console.WriteLine();
            array.Show("Це масив!");
            Console.WriteLine();

            Console.WriteLine("Максимальне значення масиву: " + array.Max());
            Console.WriteLine("Мінімальне значення масиву: " + array.Min());
            Console.WriteLine("Середнє арифметичне значення елементів масиву: " + array.Avg());
            Console.WriteLine("Пошук в масиві за значенням: " + array.Search(6));
            Console.WriteLine();

            Console.WriteLine("Сортування масиву за зростанням.");
            array.SortByParam(true);
            array.Show();
            Console.WriteLine();

            Console.WriteLine("Сортування масиву за зменшенням.");
            array.SortByParam(false);
            array.Show();
        }
    }
}