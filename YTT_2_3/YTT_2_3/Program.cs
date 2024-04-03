/* УП Практическая работа 2.2
Задание 3. Создайте класс с двумя свойствами для хранения целых чисел.
Добавить метод для вывода на экран и метод для изменения этих чисел.
Добавить метод, который находит сумму значений этих чисел, и метод который находит наибольшее значение из этих чисел.
Написать программу, демонстрирующую все возможности класса */

namespace YTT_2_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Numbers numbers = new Numbers(1, 5);

            bool work1 = true;
            while (work1)
            {
                Console.WriteLine();
                Console.Write("Главное меню -> Выберите нужное действие (1 - Вывести числа; 2 - Изменить числа; 3 - Найти наибольшее; 4 - Найти сумму; 5 - Выход): ");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        numbers.OutputNumbers();
                        break;
                    case 2:
                        bool work2 = true;
                        while (work2)
                        {
                            Console.WriteLine();
                            Console.Write("Меню редактирования -> Выберите нужное действие (1 - Изменить первое число; 2 - Изменить второе число; 3 - Назад): ");
                            int menu2 = Convert.ToInt32(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    Console.Write("Введите число: ");
                                    int newNumber1 = Convert.ToInt32(Console.ReadLine());
                                    numbers.ChangeNumber(newNumber1, numbers.Number2);
                                    break;
                                case 2:
                                    Console.Write("Введите число: ");
                                    int newNumber2 = Convert.ToInt32(Console.ReadLine());
                                    numbers.ChangeNumber(numbers.Number1, newNumber2);
                                    break;
                                case 3:
                                    work2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Неизвестное действие!");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        numbers.MaxNumbers();
                        break;
                    case 4:
                        numbers.SumNumbers();
                        break;
                    case 5:
                        work1 = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестное действие!");
                        break;
                }
            }
        }
    }

    class Numbers
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        
        public Numbers (int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public void ChangeNumber(int newNumber1, int newNumber2)
        {
            Number1 = newNumber1;
            Number2 = newNumber2;
        }

        public void SumNumbers()
        {
            Console.WriteLine($"Сумма двух чисел: {Number1 + Number2}");
        }

        public void MaxNumbers()
        {
            if (Number1 >= Number2)
            {
                Console.WriteLine($"Наибольшее число: {Number1}");
            }
            else
            {
                Console.WriteLine($"Наибольшее число: {Number2}");
            }
        }
        public void OutputNumbers ()
        {
            Console.WriteLine($"Первое число: {Number1}");
            Console.WriteLine($"Второе число: {Number2}");
        }
    }
}