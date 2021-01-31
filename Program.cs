using System;

namespace Д.з__4__3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию: ");
            string surname = Console.ReadLine();

            double salary = 0;
            

            Employee jobs = new Employee(name, surname, salary);

            Console.Write("Введите номер доступоной вакансии:\n" +
                "1) C# Developer;\n" +
                "2) Python Developer;\n" +
                "3) JavaScript Developer;\n" +
                "4) PHP Developer\n");
            string jobvacancy = Console.ReadLine();

            Console.Write("Введите ваш опыт работы: ");
            int experience = int.Parse(Console.ReadLine());

            if (jobvacancy == "1")
            {
                switch (jobvacancy)
                {
                    case "1":
                        Console.Write(jobs.JobvacancyCsharDeveloper(experience));
                        break;
                    case "2":
                        Console.Write(jobs.JobvacancyCsharDeveloper(experience));
                        break;
                    case "3":
                        Console.Write(jobs.JobvacancyCsharDeveloper(experience));
                        break;
                    default:
                        Console.Write(jobs.JobvacancyCsharDeveloper(experience));
                        break;
                }
            }
            else if(jobvacancy == "2")
            {
                switch (jobvacancy)
                {
                    case "1":
                        Console.Write(jobs.JobvacancypythonDeveloper(experience));
                        break;
                    case "2":
                        Console.Write(jobs.JobvacancypythonDeveloper(experience));
                        break;
                    case "3":
                        Console.Write(jobs.JobvacancypythonDeveloper(experience));
                        break;
                    default:
                        Console.Write(jobs.JobvacancypythonDeveloper(experience));
                        break;
                }
            }
            else if(jobvacancy == "3")
            {
                switch (jobvacancy)
                {
                    case "1":
                        Console.Write(jobs.JobvacancyjavascriptDeveloper(experience));
                        break;
                    case "2":
                        Console.Write(jobs.JobvacancyjavascriptDeveloper(experience));
                        break;
                    case "3":
                        Console.Write(jobs.JobvacancyjavascriptDeveloper(experience));
                        break;
                    default:
                        Console.Write(jobs.JobvacancyjavascriptDeveloper(experience));
                        break;
                }
            }
            else if(jobvacancy == "4")
            {
                switch (jobvacancy)
                {
                    case "1":
                        Console.Write(jobs.JobvacancyphpDeveloper(experience));
                        break;
                    case "2":
                        Console.Write(jobs.JobvacancyphpDeveloper(experience));
                        break;
                    case "3":
                        Console.Write(jobs.JobvacancyphpDeveloper(experience));
                        break;
                    default:
                        Console.Write(jobs.JobvacancyphpDeveloper(experience));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите цифру из списка!");
            }



        }
        public class Employee
        {
            public string name { get; set; }
            public string surname { get; set; }
            

            public double salary;

            public string jobvacancy;

            public int experience;
            public Employee(string name, string surname, double salary)
            {
                this.name = name;
                this.surname = surname;
            }

            public double JobvacancyCsharDeveloper(double experience)
            {
                switch (experience)
                {
                    case 1:
                        salary = 2000 - (2000 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность CsharDeveloper с учетом " +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда " +
                            $"составит : $ {salary}");
                    break;
                    case 2:
                        salary = 2500 - (2500 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность CsharDeveloper с учетом " +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда " +
                            $"составит : $ {salary}");
                        break;
                    case 3:
                        salary = 3800 - (3800 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность CsharDeveloper с учетом " +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда " +
                            $"составит : $ {salary}");
                        break;
                    default:
                        salary = 3800 - (3800 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность CsharDeveloper с учетом" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда " +
                            $"составит : $ {salary}");
                        break;
                }
                return experience;
            }

            public double JobvacancypythonDeveloper(double experience)
            {
                switch (experience)
                {
                    case 1:
                        salary = 2200 - (2200 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность PythonDeveloper с учетом\n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда\n " +
                            $"составит : $ {salary}");
                        break;
                    case 2:
                        salary = 2750 - (2750 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность PythonDeveloper с учетом\n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда\n " +
                            $"составит : $ {salary}");
                        break;
                    case 3:
                        salary = 3950 - (3950 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность PythonDeveloper с учетом\n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                    default:
                        salary = 3950 - (3950 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность PythonDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                }
                return experience;
            }

            public double JobvacancyjavascriptDeveloper(double experience)
            {
                switch (experience)
                {
                    case 1:
                        salary = 1200 - (1200 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность JavaScriptDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                    case 2:
                        salary = 1500 - (1500 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность JavaScriptDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                    case 3:
                        salary = 2250 - (2250 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность JavaScriptDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                    default:
                        salary = 2250 - (2250 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность JavaScriptDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                }
                return experience;
            }


            public double JobvacancyphpDeveloper(double experience)
            {
                switch (experience)
                {
                    case 1:
                        salary = 1100 - (1100 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность PHPDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда " +
                            $"составит : $ {salary}");
                        break;
                    case 2:
                        salary = 1380 - (1380 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность PHPDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                    case 3:
                        salary = 1650 - (1650 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность PHPDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                    default:
                        salary = 2250 - (2250 * 14 / 100);
                        Console.WriteLine($"Ваша заработанная плата на должность PHPDeveloper с учетом \n" +
                            $"вашего опыта работы и с вычетом налогово сбора 13% и 1% пенсионного фонда \n" +
                            $"составит : $ {salary}");
                        break;
                }
                return experience;
            }

        }

        
    }
}
