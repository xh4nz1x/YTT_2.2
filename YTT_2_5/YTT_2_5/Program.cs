/* УП Практическая работа 2.2
Задание 5. Создать класс с двумя свойствами.
Добавить конструктор с входными параметрами.
Добавить конструктор, инициализирующий свойства по умолчанию.
Добавить деструктор, выводящий на экран сообщение об удалении объекта.
Написать программу, демонстрирующую все возможности класса */

namespace YTT_2_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class object1 = new Class();

            bool work1 = true;
            while (work1)
            {
                Console.WriteLine();
                Console.Write("| Главное меню |\n1 - Вывести свойства объекта \n2 - Редактирование свойств объекта \n3 - Удалить объект \n4 - Выход \n\nВыберите нужное действие: ");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        if (object1 == null)
                        {
                            Console.WriteLine("-----\nОбъект не существует (удален)!");
                            work1 = false;
                            break;
                        }
                        object1.OutputProperties();
                        break;
                    case 2:
                        bool work2 = true;
                        while (work2)
                        {
                            Console.WriteLine();
                            Console.Write("| Меню объекта |\n1 - Изменить первое свойство \n2 - Изменить второе свойство \n3 - Назад \n\nВыберите нужное действие: ");
                            int menu2 = Convert.ToInt32(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    Console.Write("Введите значение первого свойства (string): ");
                                    string property1 = Console.ReadLine();
                                    object1 = new Class(property1, object1.Property2);
                                    break;
                                case 2:
                                    Console.Write("Введите значение второго свойства (int): ");
                                    int property2 = Convert.ToInt32(Console.ReadLine());
                                    object1 = new Class(object1.Property1, property2);
                                    break;
                                case 3:
                                    work2 = false;
                                    break;
                                default:
                                    Console.WriteLine("-----\nНеизвестное действие!");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        object1.Dispose();
                        object1 = null;
                        break;
                    case 4:
                        work1 = false;
                        break;
                    default:
                        Console.WriteLine("-----\nНеизвестное действие!");
                        break;
                }
            }
        }
    }

    class Class : IDisposable
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
        
        public Class ()
        {
            Property1 = "default text";
            Property2 = 0;
        }
        
        public Class (string property1, int property2)
        {
            Property1 = property1;
            Property2 = property2;
        }
        
        public void OutputProperties ()
        {
            Console.WriteLine($"-----\nПервое свойство: {Property1}");
            Console.WriteLine($"Второе свойство: {Property2}");
        }
        
        public void Dispose()
        {
            Console.WriteLine("Объект удален!");
        }
    }
}