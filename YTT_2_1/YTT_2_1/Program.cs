/* УП Практическая работа 2.2
Задание 1. Создайте класс с именем Student, содержащий свойства: фамилия, дата
рождения, номер группы, успеваемость (массив из пяти элементов).
Добавить возможность изменения фамилии, даты рождения и номера группы.
Добавить возможность вывода информации о студенте, фамилия и дата рождения которого введены пользователем.
Написать программу, демонстрирующую все возможности класса */

namespace YTT_2_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Petrov", new DateOnly(2002, 02, 02), 122, new int[] {4, 5, 5, 3, 5});

            bool work1 = true;
            while (work1)
            {
                Console.WriteLine();
                Console.Write("Главное меню -> Выберите нужное действие (1 - Просмотр информации о студенте; 2 - Редактирование информации; 3 - Выход): ");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        student.OutputInfo();
                        break;
                    case 2:
                        bool work2 = true;
                        while (work2)
                        {
                            Console.WriteLine();
                            Console.Write("Меню редактирования -> Выберите нужное действие (1 - Изменить фамилию; 2 - Изменить дату рождения; 3 - Изменить номер группы; 4 - Назад): ");
                            int menu2 = Convert.ToInt32(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    Console.Write("Введите фамилию: ");
                                    string newSurname = Console.ReadLine();
                                    student.ChangeSurname(newSurname);
                                    break;
                                case 2:
                                    Console.Write("Введите дату рождения (пример: '01.01.2000'): ");
                                    DateOnly newDate = DateOnly.Parse(Console.ReadLine());
                                    student.ChangeDateOfBirth(newDate);
                                    break;
                                case 3:
                                    Console.Write("Введите номер группы: ");
                                    int newNumber = Convert.ToInt32(Console.ReadLine());
                                    student.ChangeGroupNumber(newNumber);
                                    break;
                                case 4:
                                    work2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Неизвестное действие!");
                                    break;
                            }
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

    class Student
    {
        public string Surname { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int GroupNumber { get; set; }
        public int[] Estimates  { get; set; }

        public Student(string surname, DateOnly dayOfBirth, int groupNumber, int[] estimates)
        {
            Surname = surname;
            DateOfBirth = dayOfBirth;
            GroupNumber = groupNumber;
            Estimates = estimates;
        }
        public void ChangeSurname(string newSurname)
        {
            Surname = newSurname;
        }
        public void ChangeDateOfBirth(DateOnly newDate)
        {
            DateOfBirth = newDate;
        }
        public void ChangeGroupNumber(int newNumber)
        {
            GroupNumber = newNumber;
        }
        public void OutputInfo()
        {
            Console.WriteLine($"Фамилия студента: {Surname}");
            Console.WriteLine($"Дата рождения студента: {DateOfBirth}");
            Console.WriteLine($"Номер группы студента: {GroupNumber}");
            Console.WriteLine("Успеваемость (оценки):");
            foreach (var n in Estimates)
            {
                Console.Write($"{n} ");
            }
        }
    }
}