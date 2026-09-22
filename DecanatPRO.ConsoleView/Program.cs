using DecanatPRO.BusinessLogic;
using System;
using System.Linq;

namespace DecanatPRO.ConsoleView
{
    class Program
    {
        static Logic logic = new Logic();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("\n ~~~~~~~~~~ ДЕКАНАТ PRO ~~~~~~~~~~~");
                Console.WriteLine("1. добавить студента");
                Console.WriteLine("2. удалить студента");
                Console.WriteLine("3. вывести список студентов");
                Console.WriteLine("4. показать гистограмму по специальностям");
                Console.WriteLine("0. выход");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        AddStudent();
                        PauseBeforeMenu();
                        break;
                    case "2":
                        Console.Clear();
                        DeleteStudent();
                        PauseBeforeMenu();
                        break;
                    case "3":
                        Console.Clear();
                        ShowAllStudents();
                        PauseBeforeMenu();
                        break;
                    case "4":
                        Console.Clear();
                        ShowSpecialityDistribution();
                        PauseBeforeMenu();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("до свидания!");
                        return;
                    default:
                        Console.WriteLine("неверный выбор!");
                        System.Threading.Thread.Sleep(1500);
                        break;
                }
            }
        }

        static void PauseBeforeMenu()
        {
            Console.WriteLine("\nнажмите Enter для возврата в меню...");
            Console.ReadLine();
        }

        static void AddStudent()
        {
            Console.WriteLine("~~~ ДОБАВЛЕНИЕ СТУДЕНТА ~~~\n");

            Console.Write("введите ФИО студента: ");
            string name = Console.ReadLine();

            Console.Write("введите специальность: ");
            string speciality = Console.ReadLine();

            Console.Write("введите группу: ");
            string group = Console.ReadLine();

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(speciality) || string.IsNullOrWhiteSpace(group))
            {
                Console.WriteLine("\n✗ ошибка! все поля должны быть заполнены!");
                return;
            }

            logic.AddStudent(name, speciality, group);
            Console.WriteLine("\nстудент добавлен!");
        }

        static void DeleteStudent()
        {
            var students = logic.GetAllStudents();

            if (students.Count == 0)
            {
                Console.WriteLine("\nсписок студентов пуст. удалять некого!");
                return;
            }

            Console.WriteLine("~~~ УДАЛЕНИЕ СТУДЕНТА ~~~\n");
            Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,-10}", "№", "ФИО", "специальность", "группа");
            Console.WriteLine(new string('_', 75));

            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,-10}",
                    (i + 1), student.Name, student.Speciality, student.Group);
            }

            Console.Write("\nвведите номер студента для удаления (0 - отмена): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number > 0 && number <= students.Count)
            {
                var studentToDelete = students[number - 1];
                logic.DeleteStudent(studentToDelete.Name, studentToDelete.Speciality, studentToDelete.Group);
                Console.WriteLine("\n✓ студент удален!");
            }
            else if (number == 0)
            {
                Console.WriteLine("\nотмена удаления.");
            }
            else
            {
                Console.WriteLine("\nневерный номер!");
            }
        }

        static void ShowAllStudents()
        {
            var students = logic.GetAllStudents();

            if (students.Count == 0)
            {
                Console.WriteLine("\nсписок студентов пуст.");
                return;
            }

            Console.WriteLine("~~~ СПИСОК СТУДЕНТОВ ~~~\n");
            Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,-10}", "№", "ФИО", "специальность", "группа");
            Console.WriteLine(new string('_', 75));

            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                Console.WriteLine("{0,-5} {1,-30} {2,-25} {3,-10}",
                    (i + 1), student.Name, student.Speciality, student.Group);
            }
        }

        static void ShowSpecialityDistribution()
        {
            var distribution = logic.GetSpecialityDistribution();

            if (distribution.Count == 0)
            {
                Console.WriteLine("\nнет данных для отображения.");
                return;
            }

            Console.WriteLine("~~~ РАСПРЕДЕЛЕНИЕ ПО СПЕЦИАЛЬНОСТЯМ ~~~\n");

            int maxCount = distribution.Values.Max();

            foreach (var item in distribution)
            {
                Console.Write($"{item.Key,-20}: ");

                int barLength = (int)((double)item.Value / maxCount * 40);
                Console.Write(new string('█', barLength));
                Console.WriteLine($" ({item.Value})");
            }
        }
    }
}