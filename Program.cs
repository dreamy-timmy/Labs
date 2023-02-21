//!!!как можно проще
Console.WriteLine("кол-во книг: ");
int n = Convert.ToInt32(Console.ReadLine());
List<List<string>> Library = new List<List<string>>();
List<List<string>> Returning = new List<List<string>>();
List<List<string>> Giving = new List<List<string>>();
bool f = false;
for (int i = 0; i < Library.Count(); i++)
    for (int j = 0; j < Library[i].Count(); j++)
    {
        Console.WriteLine(Library[i][j]);
    }
for (int j = 0; j < n; j++)
{
    Console.WriteLine("Введите имя: ");
    string name = Console.ReadLine();
    Console.WriteLine("Введите фамилию писателя: ");
    string surname = Console.ReadLine();
    Console.WriteLine("Введите название произведения: ");
    string composion_name = Console.ReadLine();
    Console.WriteLine("Введите место печати: ");
    string publishing_office_name = Console.ReadLine();
    Console.WriteLine("Введите жанр: ");
    string genre = Console.ReadLine();
    Console.WriteLine("Введите идентификационный номер: ");
    string id = Console.ReadLine();
    Console.WriteLine("Введите год издания произведения: ");
    string year = Console.ReadLine();

    Console.WriteLine("Введите кол-во книг, отданных студентам: ");
    Book Current = new Book(name, surname, composion_name, publishing_office_name, genre, id, year);
    List<string> book = new List<string>() { name, surname, composion_name, publishing_office_name, genre, id, year };
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите даты выдачи: ");
    for (int i = 0; i < z; i++)
    {
        Current.given.Add(Console.ReadLine());
    }
    Console.WriteLine("Введите кол-во книг, возвращённых студентами: ");
    z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите даты сдачи: ");
    for (int i = 0; i < z; i++)
    {
        Current.returned.Add(Console.ReadLine());
    }
    Returning.Add(Current.returned);
    Giving.Add(Current.given);
    Library.Add(book);
}
while (true)
{
    int c = 0;
    Console.WriteLine("Выберете тип выборки: ");
    Console.WriteLine("1) По автору");
    Console.WriteLine("2) По издательству");
    Console.WriteLine("3) По жанру");
    Console.WriteLine("4) По дате");
    int main = Convert.ToInt32(Console.ReadLine());
    switch (main)
    {
        case 1:
            Console.WriteLine("Введите автора, книги которого хотели бы увидеть: ");
            Console.WriteLine("Имя: ");
            string a = Console.ReadLine();
            Console.WriteLine("Фамилию: ");
            string b = Console.ReadLine();

            for (int j = 0; j < Library.Count; j++)
            {
                if (a == Library[j][0] && b == Library[j][1])
                {
                    Console.WriteLine(Library[j][2]);
                    f = true;
                }

            }
            if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
            break;
        case 2:
            Console.WriteLine("Укажите место печати, книги которого хотели бы увидеть: ");
            a = Console.ReadLine();

            for (int j = 0; j < Library.Count; j++)
            {
                if (a == Library[j][3])
                {
                    Console.WriteLine(Library[j][2]);
                    Console.WriteLine(1);
                    f = true;
                }
            }
            if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
            break;
        case 3:
            Console.WriteLine("Введите жанр, книги которого хотели бы увидеть: ");
            a = Console.ReadLine();
            for (int j = 0; j < Library.Count; j++)
            {
                if (a == Library[j][4])
                {
                    Console.WriteLine(Library[j][2]);
                    Console.WriteLine(1);
                    f = true;
                }
            }
            if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
            break;
        case 4:
            Console.WriteLine("Введите временной интервал, информация о книгах на котором вас интересует(вводите дату только одного года в формате дд.мм.гг)");
            Console.WriteLine("От какой даты: ");
            string begin = Console.ReadLine();
            Console.WriteLine("До какой даты: ");
            string end = Console.ReadLine();

            int b_y = Convert.ToInt32(begin[6] + "" + begin[7]);
            int end_y = Convert.ToInt32(end[6] + "" + end[7]);
            int b_mnth = Convert.ToInt32(begin[3] + "" + begin[4]);
            int end_mnth = Convert.ToInt32(end[3] + "" + end[4]);
            Console.WriteLine("Выберете, что вас интересует:\n1) Книги на руках,\n2) Сколько выдано");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    for (int i = 0; i < Giving.Count; i++)
                    {
                        for (int j = 0; j < Giving[i].Count; j++)
                        {
                            var y = Convert.ToInt32(Giving[i][j][6] + "" + Giving[i][j][7]);
                            var mnth = Convert.ToInt32(Giving[i][j][3] + "" + Giving[i][j][4]);
                            if ((b_y <= y && y <= end_y) && (b_mnth <= mnth && mnth <= end_mnth))
                            {
                                f = true;
                                bool f1 = false;
                                for (int h = 0; h < Returning[i].Count; h++)
                                {
                                    y = Convert.ToInt32(Returning[i][h][6] + "" + Returning[i][h][7]);
                                    mnth = Convert.ToInt32(Returning[i][h][3] + "" + Returning[i][h][4]);
                                    if (((b_y <= y && y <= end_y) &&
                                        b_mnth <= mnth && mnth <= end_mnth))
                                        f1 = true;
                                    if (h == (Returning[i].Count - 1) && f1 == false) Console.WriteLine(Library[i][2]);
                                }
                            }
                        }
                    }
                    if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
                    break;
                case 2:
                    for (int i = 0; i < Giving.Count; i++)
                    {
                        f = false;
                        for (int j = 0; j < Giving[i].Count; j++)
                        {
                            var y = Convert.ToInt32(Giving[i][j][6] + "" + Giving[i][j][7]);
                            var mnth = Convert.ToInt32(Giving[i][j][3] + "" + Giving[i][j][4]);
                            if (b_y <= y && y <= end_y && f == false)
                                if (b_mnth <= mnth && mnth <= end_mnth)
                                {
                                    Console.WriteLine(Library[i][2]);
                                    f = true;
                                }
                        }
                    }
                    if (f == false) Console.WriteLine("По данному запросу ничего не найдено :(");
                    break;
                default:
                    Console.WriteLine("Проверьте ещё раз, пожалуйста, ввод должен состоять из числа '1' или '2'");
                    break;
            }
            break;
    }
    Console.WriteLine();
    Console.WriteLine("1) Вернуться к выборке");
    Console.WriteLine("2) Завершить программу");
     c = Convert.ToInt32(Console.ReadLine());
    if (c == 2) break;
}
class Book
{
    public string name, surname, composion_name, publishing_office_name, genre, id, year;
    public List<string> returned = new List<string>();
    public List<string> given = new List<string>();
    public Book(string name, string surname, string composion_name, string id, string year, string publishing_office_name, string genre)
    {
        this.name = name;
        this.surname = surname;
        this.id = id;
        this.composion_name = composion_name;
        this.year = year;
        this.publishing_office_name = publishing_office_name;
        this.genre = genre;
    }
}

















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

