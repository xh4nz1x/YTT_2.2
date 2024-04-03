/* УП Практическая работа 2.2
Задание 2. Создайте класс с именем Train, содержащий свойства: название пункта
назначения, номер поезда, время отправления.
Добавить возможность вывода информации о поезде, номер которого введен пользователем.
Написать программу, демонстрирующую все возможности класса */

namespace YTT_2_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Train[] trains = new Train[5];

            trains[0] = new Train("Moscow", 1, new TimeOnly(12, 00));
            trains[1] = new Train("Vladivostok", 2, new TimeOnly(10, 10));
            trains[2] = new Train("Krasnoyarsk", 3, new TimeOnly(20, 45));
            trains[3] = new Train("Omsk", 4, new TimeOnly(11, 05));
            trains[4] = new Train("Sochi", 5, new TimeOnly(15, 20));

            bool work1 = true;
            while (work1)
            {
                Console.WriteLine();
                Console.Write("Главное меню -> Выберите нужное действие (1 - Просмотр информации о поезде; 2 - Вывести все номера поездов; 3 - Выход): ");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        bool work2 = true;
                        while (work2)
                        {
                            Console.WriteLine();
                            Console.Write("Введите номер поезда: ");
                            int trainNum = Convert.ToInt32(Console.ReadLine());

                            bool foundNum = false;
                            foreach (var n in trains)
                            {
                                if (n.TrainNumber == trainNum)
                                {
                                    n.OutputInfo();
                                    foundNum = true;
                                }
                            }

                            if (!foundNum)
                            {
                                Console.WriteLine("Данный поезд не найден!");
                                break;
                            }

                        }
                        break;
                    case 2:
                        List<int> nums = new List<int>();
                        foreach (var n in trains)
                        {
                            nums.Add(n.OutputNum());
                        }

                        foreach (var n in nums)
                        {
                            Console.Write($"{n} ");
                        }
                        break;
                    case 3:
                        work1 = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестное действие!");
                        break;
                }
            }
        }
    }

    class Train
    {
        public string NameOfDestination { get; set; }
        public int TrainNumber { get; set; }
        public TimeOnly DepartureTime { get; set; }

        public Train(string nameOfDestination, int trainNumber, TimeOnly departureTime)
        {
            NameOfDestination = nameOfDestination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }
        
        public void OutputInfo ()
        {
            Console.WriteLine("| | | | |");
            Console.WriteLine($"Название пункта назначения: {NameOfDestination}");
            Console.WriteLine($"Номер поезда: {TrainNumber}");
            Console.WriteLine($"Время отправления: {DepartureTime}");
            Console.WriteLine("| | | | |");
        }
        public int OutputNum ()
        {
            return TrainNumber;
        }
    }
}