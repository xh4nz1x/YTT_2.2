/* УП Практическая работа 2.2
Задание 4. Описать класс, реализующий счетчик, который может увеличивать или уменьшать свое значение на единицу.
Предусмотреть инициализацию счетчика со значением по умолчанию и произвольным значением.
Счетчик имеет два метода: увеличения и уменьшения, — и свойство, позволяющее получить его текущее состояние.
Написать программу, демонстрирующую все возможности класса */

namespace YTT_2_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Counter number = new Counter();

            bool work1 = true;
            while (work1)
            {
                Console.WriteLine();
                Console.Write("| Главное меню |\n1 - Вывести текущее состояние \n2 - Ввести свое значение \n3 - Увеличить значение (+1) \n4 - Уменьшить значение (-1) \n5 - Выход \n\nВыберите нужное действие: ");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        number.OutputCounter();
                        break;
                    case 2:
                        Console.Write("Введите число: ");
                        int newNumber = Convert.ToInt32(Console.ReadLine());
                        number.ChangeCounter(newNumber);
                        break;
                    case 3:
                        number.IncreaseByOne();
                        break;
                    case 4:
                        number.DecreaseByOne();
                        break;
                    case 5:
                        work1 = false;
                        break;
                    default:
                        Console.WriteLine("-----\nНеизвестное действие!");
                        break;
                }
            }
        }
    }

    class Counter
    {
        public int Number { get; set; }
        
        public Counter ()
        {
            Number = 0;
        }
        
        public Counter (int number)
        {
            Number = number;
        }
        
        public void IncreaseByOne ()
        {
            Number += 1;
            Console.WriteLine("-----\nЗначение увеличено на единицу");
        }
        
        public void ChangeCounter (int newNumber)
        {
            Number = newNumber;
            Console.WriteLine("-----\nНовое значение уставлено");
        }
        
        public void DecreaseByOne ()
        {
            Number -= 1;
            Console.WriteLine("-----\nЗначение уменьшено на единицу");
        }
        
        public void OutputCounter ()
        {
            Console.WriteLine($"-----\nТекущее состояние счетчика: {Number}");
        }
    }
}