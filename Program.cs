



//!!!как можно проще

// Teachers Kazich = new Teachers() 
// { 
//     name = "Сергей", patronymic= "Геннадьевич", surname = "Казаков",experience = 5, 
//     disciplines = { "матан, дискретная математика","геометрия"}
// };
// Teachers Belim = new Teachers()
// {
//     name = "Светлана",
//     patronymic = "Юрьевна",
//     surname = "Белим",
//     experience = 10,
//     disciplines = { "алгебра, геометрия","теория чисел"}
// };
// Teachers Bread = new Teachers()
// {
//     surname = "Хлебникова",
//     experience = 15,
//     disciplines = { "прд" }
// };
// Special_Workers Svetka = new Special_Workers() { name = "Светлана", surname = "Техничкина", Gender = "female",experience=20};
// Special_Workers Misha = new Special_Workers() { name = "Михаил", surname = "Всяких-Дел-мастер", Gender = "male",experience=15};

// Student Igor = new Student
// {
//     name = "Игорь",
//     surname = "Арбузов",
//     zachetka = { { "матан", "5" }, { "алгебра", "5" }, { "прд", "зач" } }, 
//    Course=4
// };
// Student Irka = new Student
// {
//     name = "Ирина",
//     surname = "Ельник",
//     zachetka = { { "дм", "не сдан" }, { "алгебра", "3" }, { "прд", "незач" } },
//     dolgi = { "прд"},Course=3
// };
// Student Ivan = new Student
// {
//     name = "Иван",
//     surname = "Селезин",
//     zachetka = { { "матан", "не сдано" }, { "алгебра", "не сдано" }, { "прд", "зач" } },
//     dolgi = {"матан","геометрия","алгебра"},Course = 2
// };




// Rulers Anton = new Rulers {name = "Антон", surname = "Депутатов",Gender = "male",post = "ректор",experience=10};
// Rulers Olga = new Rulers { name = "Ольга", surname = "Майорова", Gender = "female", post = "проректор",experience=5};



// Rulers.all.Add(Anton.post + " " + Anton.name, new List<string> 
// { "поднять зарплаты и стипендии на 50%", "Не входить в здание университета с 3 по 5 ноября" });
// Rulers.students.Add(Anton.post + " " + Anton.name, new List<string>
// {
//     "Приказ О зачислении студентов первого курса очной формы обучения на бюджет",
//     "Приказ О зачислении студентов первого курса очной формы обучения на коммерческой"
// });
// Rulers.teachers.Add(Anton.post + " " + Anton.name, new List<string>
// {
//     "Утвердить и вести в действие с 1 сентября 2020 г. 'Порядок установления выплат " +
//         "стимулирующего характера профессорско-преподавательскому составу Университета по " +
//         "результатам оценки эффективности исполнения ими трудовых обязанностей в рамках эффективного контракта'"
// });
// Rulers.students.Add(Olga.post + " " + Olga.name, new List<string>
// {
//     "Ребята! большая просьба завтра прийти всем на мероприятие на уровне факультета"
// });
// Rulers.teachers.Add(Olga.post + " " + Olga.name, new List<string>
// {
//     "Всему профессорско-преподавательскому составу завтра явиться в актовом зале в 18:30"
// });







// Belim.promisers.Add(Ivan.surname, new List<string> { "геометрия", "алгебра" });
// Kazich.promisers.Add(Ivan.surname, new List<string> { "матан"} );
// Bread.promisers.Add(Irka.surname, new List<string> { "прд" });


// Console.WriteLine($"Наши студенты: {Ivan.surname},{Igor.surname}");
// Console.WriteLine($"Наши преподаватели: {Belim.surname},{Kazich.surname}");
// Console.WriteLine($"Спец. работники университета: {Svetka.surname},{Misha.surname}");
// Console.WriteLine($"Управляющий состав университета: {Anton.surname},{Olga.surname}");


// var s = new Student[] { Igor, Irka, Ivan }; 
// var p = new Teachers[] { Bread, Belim, Kazich };
// var workers = new Human[] { Svetka, Misha,Bread,Belim,Kazich };
// while (true)
// {
//     Console.WriteLine("Пожалуйсте, выберете, что вас интересует: ");
//     Console.WriteLine("1) Студенты с долгами");
//     Console.WriteLine("2) Преподаватели 'с долгами'");
//     Console.WriteLine("3) Приказы");
//     Console.WriteLine("4) Список дисциплин преподавателя");
//     Console.WriteLine("5) Узнать курс студента/стаж работника учзаведения");
//     int main = Convert.ToInt32(Console.ReadLine());
//     switch (main)
//     {
//         case 1:
            
//             for (int i = 0; i < s.Length; i++)
//             {
//                 if (s[i].dolgi.Count != 0) Console.WriteLine($"Сейчас будем позорить студента по имени {s[i].surname}\nДолги на следующих предметов: ");
//                 for (int j = 0; j < s[i].dolgi.Count; j++) Console.WriteLine(s[i].dolgi[j]);
//             }
//             break;
//         case 2:
            
//             for (int i = 0; i < p.Length; i++)
//             {
//                 Console.WriteLine($"У преподавателя {p[i].surname} следующие должники:");
//                 foreach (var key in p[i].promisers.Keys)
//                 {
//                     Console.WriteLine($"Должник по фамилии {key} имеет след. долги:");
//                     foreach (var v in p[i].promisers[key]) Console.WriteLine(v);
//                 }
//             }
//             break;
//         case 3:
//             Console.WriteLine("Кому: \n1) общие,\n2) студентам,\n3) преподавателям,\n4) специальному персоналу,");
//             int n1 = Convert.ToInt32(Console.ReadLine());
//             switch(n1)
//             {
//                 case 1:
//                     foreach (var r in Rulers.all.Keys)
//                     {
//                         Console.WriteLine($"От кого: {r}");
//                         foreach (var v in Rulers.all[r]) Console.WriteLine(v);
//                     }
//                     break;
//                 case 2:
//                     foreach (var r in Rulers.students.Keys)
//                     {
//                         Console.WriteLine($"От кого: {r}");
//                         foreach (var v in Rulers.students[r]) Console.WriteLine(v);
//                     }
//                     break;
//                 case 3:
//                     foreach (var r in Rulers.teachers.Keys)
//                     {
//                         Console.WriteLine($"От кого: {r}");
//                         foreach (var v in Rulers.teachers[r]) Console.WriteLine(v);
//                     }
//                     break;
//                 case 4:
//                     foreach (var r in Rulers.special_workers.Keys)
//                     {
//                         Console.WriteLine($"От кого: {r}");
//                         foreach (var v in Rulers.special_workers[r]) Console.WriteLine(v);
//                     }
//                     break;
//             }
//             break;
//         case 4:
//             foreach(var prep in p)
//             {
//                 Console.WriteLine($"Преподаватель {prep.surname} ведёт след. предметы: ");
//                 foreach (var sub in prep.disciplines) Console.WriteLine(sub);
//             }
//             break;
//         case 5:
//             Console.WriteLine($"Студент?(да/нет)");
//             string ans = Console.ReadLine();
//             if (ans == "да") foreach (var stud in s) Console.WriteLine(($"{stud.surname} {stud.name}: {stud.Course}  курс"));
//             else foreach (var w in workers) Console.WriteLine($"{w.surname} {w.name}: {w.experience}  лет");
//             break;
//     }
//     Console.WriteLine();
//     Console.WriteLine("1) Вернуться к выборке");
//     Console.WriteLine("2) Завершить программу");
//     int c = Convert.ToInt32(Console.ReadLine());
//     if (c == 2) break;
// }







// class Human
// {
//     public string name = "not stated";
//     public string surname = "not stated";
//     public string patronymic = "not stated";
//     public int salary;
//     public string educ = "not stated";
//     private string gender = "not stated";
//     public int experience;
//     public string Gender
//     {
//         get {return gender;}
//         set {
//             if (value == "male" || value == "female") gender = value;
//             else Console.WriteLine("Значение не присвоено, вводите в формате 'male'/'female'");}
//     }
//     public void inf()
//     {
//         Console.WriteLine($"Имя: {name}, фамилия: {surname}, образование: {educ}");
//     }
// }
// class Student: Human
// {
//     public Dictionary<string, string> zachetka = new Dictionary<string, string>();
//     public List<string> dolgi = new  List<string>();
//     private int course;

//     public int Course
//     {
//         set { if (1 <= value || value <= 5) course = value; }
//         get { return course;}
//     }
// }
// class Teachers : Human
// {
//     public List<string> disciplines = new List<string>();
//     public Dictionary<string, List<string>> promisers = new Dictionary<string, List<string>>();

// }
// class Special_Workers: Human
// {
//     public void Service_in_Cafe(string student_name, string food)
//     {
//         Console.WriteLine($"{name} продаёт {food} студенту по имени {student_name}");
//     }
//     public void To_Wash_Floor(int stage)
//     {
//         Console.WriteLine($"{name} моет пол на этаже номер {stage}");
//     }
//     public void Fix(int stage, string broken)
//     {
//         Console.WriteLine($"{name} чинит {broken} на этаже номер {stage}");
//     }
// }
// class Rulers : Human
// {
//     public string post;
//     static public Dictionary<string, List<string>> all = new Dictionary<string, List<string>>();
//     static public Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();
//     static public Dictionary<string, List<string>> special_workers = new Dictionary<string, List<string>>();
//     static public Dictionary<string, List<string>> teachers = new Dictionary<string, List<string>>();
// }


// Console.WriteLine("кол-во книг: ");
// int n = Convert.ToInt32(Console.ReadLine());
// List<List<string>> Library = new List<List<string>>();
// List<List<string>> Returning = new List<List<string>>();
// List<List<string>> Giving = new List<List<string>>();
// bool f = false;
// for (int i = 0; i < Library.Count(); i++)
//     for (int j = 0; j < Library[i].Count(); j++)
//     {
//         Console.WriteLine(Library[i][j]);
//     }
// for (int j = 0; j < n; j++)
// {
//     Console.WriteLine("Введите имя: ");
//     string name = Console.ReadLine();
//     Console.WriteLine("Введите фамилию писателя: ");
//     string surname = Console.ReadLine();
//     Console.WriteLine("Введите название произведения: ");
//     string composion_name = Console.ReadLine();
//     Console.WriteLine("Введите место печати: ");
//     string publishing_office_name = Console.ReadLine();
//     Console.WriteLine("Введите жанр: ");
//     string genre = Console.ReadLine();
//     Console.WriteLine("Введите идентификационный номер: ");
//     string id = Console.ReadLine();
//     Console.WriteLine("Введите год издания произведения: ");
//     string year = Console.ReadLine();

//     Console.WriteLine("Введите кол-во книг, отданных студентам: ");
//     Book Current = new Book(name, surname, composion_name, publishing_office_name, genre, id, year);
//     List<string> book = new List<string>() { name, surname, composion_name, publishing_office_name, genre, id, year };
//     int z = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите даты выдачи: ");
//     for (int i = 0; i < z; i++)
//     {
//         Current.given.Add(Console.ReadLine());
//     }
//     Console.WriteLine("Введите кол-во книг, возвращённых студентами: ");
//     z = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите даты сдачи: ");
//     for (int i = 0; i < z; i++)
//     {
//         Current.returned.Add(Console.ReadLine());
//     }
//     Returning.Add(Current.returned);
//     Giving.Add(Current.given);
//     Library.Add(book);
// }
// while (true)
// {
//     int c = 0;
//     Console.WriteLine("Выберете тип выборки: ");
//     Console.WriteLine("1) По автору");
//     Console.WriteLine("2) По издательству");
//     Console.WriteLine("3) По жанру");
//     Console.WriteLine("4) По дате");
//     int main = Convert.ToInt32(Console.ReadLine());
//     switch (main)
//     {
//         case 1:
//             Console.WriteLine("Введите автора, книги которого хотели бы увидеть: ");
//             Console.WriteLine("Имя: ");
//             string a = Console.ReadLine();
//             Console.WriteLine("Фамилию: ");
//             string b = Console.ReadLine();

//             for (int j = 0; j < Library.Count; j++)
//             {
//                 if (a == Library[j][0] && b == Library[j][1])
//                 {
//                     Console.WriteLine(Library[j][2]);
//                     f = true;
//                 }

//             }
//             if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
//             break;
//         case 2:
//             Console.WriteLine("Укажите место печати, книги которого хотели бы увидеть: ");
//             a = Console.ReadLine();

//             for (int j = 0; j < Library.Count; j++)
//             {
//                 if (a == Library[j][3])
//                 {
//                     Console.WriteLine(Library[j][2]);
//                     Console.WriteLine(1);
//                     f = true;
//                 }
//             }
//             if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
//             break;
//         case 3:
//             Console.WriteLine("Введите жанр, книги которого хотели бы увидеть: ");
//             a = Console.ReadLine();
//             for (int j = 0; j < Library.Count; j++)
//             {
//                 if (a == Library[j][4])
//                 {
//                     Console.WriteLine(Library[j][2]);
//                     Console.WriteLine(1);
//                     f = true;
//                 }
//             }
//             if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
//             break;
//         case 4:
//             Console.WriteLine("Введите временной интервал, информация о книгах на котором вас интересует(вводите дату только одного года в формате дд.мм.гг)");
//             Console.WriteLine("От какой даты: ");
//             string begin = Console.ReadLine();
//             Console.WriteLine("До какой даты: ");
//             string end = Console.ReadLine();

//             int b_y = Convert.ToInt32(begin[6] + "" + begin[7]);
//             int end_y = Convert.ToInt32(end[6] + "" + end[7]);
//             int b_mnth = Convert.ToInt32(begin[3] + "" + begin[4]);
//             int end_mnth = Convert.ToInt32(end[3] + "" + end[4]);
//             Console.WriteLine("Выберете, что вас интересует:\n1) Книги на руках,\n2) Сколько выдано");
//             int num = Convert.ToInt32(Console.ReadLine());
//             switch (num)
//             {
//                 case 1:
//                     for (int i = 0; i < Giving.Count; i++)
//                     {
//                         for (int j = 0; j < Giving[i].Count; j++)
//                         {
//                             var y = Convert.ToInt32(Giving[i][j][6] + "" + Giving[i][j][7]);
//                             var mnth = Convert.ToInt32(Giving[i][j][3] + "" + Giving[i][j][4]);
//                             if ((b_y <= y && y <= end_y) && (b_mnth <= mnth && mnth <= end_mnth))
//                             {
//                                 f = true;
//                                 bool f1 = false;
//                                 for (int h = 0; h < Returning[i].Count; h++)
//                                 {
//                                     y = Convert.ToInt32(Returning[i][h][6] + "" + Returning[i][h][7]);
//                                     mnth = Convert.ToInt32(Returning[i][h][3] + "" + Returning[i][h][4]);
//                                     if (((b_y <= y && y <= end_y) &&
//                                         b_mnth <= mnth && mnth <= end_mnth))
//                                         f1 = true;
//                                     if (h == (Returning[i].Count - 1) && f1 == false) Console.WriteLine(Library[i][2]);
//                                 }
//                             }
//                         }
//                     }
//                     if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
//                     break;
//                 case 2:
//                     for (int i = 0; i < Giving.Count; i++)
//                     {
//                         f = false;
//                         for (int j = 0; j < Giving[i].Count; j++)
//                         {
//                             var y = Convert.ToInt32(Giving[i][j][6] + "" + Giving[i][j][7]);
//                             var mnth = Convert.ToInt32(Giving[i][j][3] + "" + Giving[i][j][4]);
//                             if (b_y <= y && y <= end_y && f == false)
//                                 if (b_mnth <= mnth && mnth <= end_mnth)
//                                 {
//                                     Console.WriteLine(Library[i][2]);
//                                     f = true;
//                                 }
//                         }
//                     }
//                     if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
//                     break;
//                 default:
//                     Console.WriteLine("Проверьте ещё раз, пожалуйста, ввод должен состоять из числа '1' или '2'");
//                     break;
//             }
//             break;
//     }
//     Console.WriteLine();
//     Console.WriteLine("1) Вернуться к выборке");
//     Console.WriteLine("2) Завершить программу");
//      c = Convert.ToInt32(Console.ReadLine());
//     if (c == 2) break;
// }
// class Book
// {
//     public string name, surname, composion_name, publishing_office_name, genre, id, year;
//     public List<string> returned = new List<string>();
//     public List<string> given = new List<string>();
//     public Book(string name, string surname, string composion_name, string id, string year, string publishing_office_name, string genre)
//     {
//         this.name = name;
//         this.surname = surname;
//         this.id = id;
//         this.composion_name = composion_name;
//         this.year = year;
//         this.publishing_office_name = publishing_office_name;
//         this.genre = genre;
//     }
// }

















//FileInfo f = new FileInfo(@"C:\Users\Тимофей\source\repos\ConsoleApp1\ConsoleApp1\testing.txt");

//StreamWriter sw = f.AppendText();
//sw.WriteLine("Строка 1");
//sw.WriteLine("Строка 2");
//sw.WriteLine("Строка 3");
//sw.Close();

//StreamReader sr =  f.OpenText();
//string s = sr.ReadLine();
//while (s != null)
//{
//    Console.WriteLine(s);
//    s = sr.ReadLine();
//}
//11.11.22 лаба
//массив m*n
//Необходимо отсортировать столбцы по убыванию произведений полож эл столбцов (sort запрещён)
/*
 3 3   - 3   3
 4 12  - 12  4
 */
//int[,] m = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
//for (int i = 0; i < m.GetLength(0); i++)
//    for (int j = 0; j < m.GetLength(0); j++)
//        m[i, j] = Convert.ToInt32(Console.ReadLine());

//int[,] curr = new int[m.GetLength(0), m.GetLength(1)];
//for (int i = 0; i <)



/******************************************************************************
массив n*m(лаба - доделать)
необходимо определить номера пар столбцов, которые содержат одни и те же элементы
2 0
1 2
0 1

0 1 1
0 0 2

1 1 1
1 2 0
если есть "0":
кол-во "0" == в массиве:
0 0 2 2 -4,4
0 0 3 1 -4,
*******************************************************************************/
//using System;
//class HelloWorld
//{
//    static void Main()
//    {
//        int n = Convert.ToInt32(Console.ReadLine()), m = Convert.ToInt32(Console.ReadLine());
//        int c0 = 0;
//        int[,] s = new int[n, m];
//        int[] zero = new int[m];
//        int[] sm = new int[m];
//        int[] umn = new int[m];
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                s[i, j] = Convert.ToInt32(Console.ReadLine());
//            }
//        }
//        Console.WriteLine();
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write(s[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//        //ищем 0
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (s[i, j] == 0)
//                    zero[j]++;
//            }
//        }
//        for(int j =0;j < zero.Length;j++)
//        {
//            for(int k = j+1;k<zero.Length ;k++)
//            {
//                if(zero[j] == zero[k])

//                {
//                    if (sm[j] == 0 && umn[j] == 0)
//                    {
//                        for (int g = 0; g < n; g++)
//                        {
//                            if (s[g, j] != 0)
//                            {
//                                sm[j] += s[g, j];
//                                umn[j] += s[g, j];
//                            }
//                        }
//                    }
//                    if (sm[k] == 0 && umn[k] == 0)
//                    {
//                        for (int g = 0; g < n; g++)
//                        {
//                            if (s[g, k] != 0)
//                            {
//                                sm[k] += s[g, k];
//                                umn[k] += s[g, k];
//                            }
//                        } 
//                    }

//                    if (sm[k] == sm[j] && umn[k] == umn[j])
//                        Console.WriteLine($"номера пар столбцов, которые содержат одни и те же элементы: {j+1} {k+1}");
//                }
//            }
//        }
//    }
//}

