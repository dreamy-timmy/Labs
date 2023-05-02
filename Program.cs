/*
1)коллекции, которые реализуем:
для каждой коллекции будет отдельная менюшка для каждого с методами

Array(уже есть), ArrayList, HashTable, Stack, Queue, Dictionary,
List, SortedList, HashSet/SortedSet

2) Задачка для стека:
на вход подаётся строка, в которой могут присутствовать скобки 3-х типов: ),],}
Необходимо определить правильно ли расставлены скобки?(чтобы внутренние скобки закрывались раньше внешних)
 */
using System.Collections;
//строка, которую отправляемм на проверку
string t = "}{{}})";

Stack<char> st = new Stack<char>() {};
char[] opening = new char[] { '(', '[', '{'};
char[] closing = new char[] { ')', ']', '}' };


while (closing.Contains(t[^1]))
{
    st.Push(t[^1]);
    t = t[..^1]; 
}
bool f = true;

if (st.Count != 0)
{
    while (t != "")
    {
        if (Array.IndexOf(opening, t[^1]) == Array.IndexOf(closing, st.Peek())) t = t[..^1];
        else
        {
            f = false;
            break;
        }
    }
    
}
else f=false;

if (f == true) Console.WriteLine("Всё расставлено правильно");
else Console.WriteLine("Неправильно!");


while (true)
{
   int c;
   Console.WriteLine("Выберете, методы какой коллекции хотите воспользоваться: \n1)Array\n2)ListArray\n3)HashTable\n4)Stack" +
                     "\n5)Queue\n6)Dictionary\n7)List\n8)SortedList\n9)SortedSet");
   int data_type = Convert.ToInt32(Console.ReadLine());
   switch(data_type)
   {
       case 1:
           while (true)
           {
               Console.WriteLine("Выберете, какой тип данных будет у вас в массиве: \n1)integer\n2)string\n3)character");
                data_type = Convert.ToInt32(Console.ReadLine());
               while (data_type != 1 && data_type != 2 && data_type != 3)
               {
                   Console.WriteLine("Введите пожалуйста 1,2 или 3");
                   data_type = Convert.ToInt32(Console.ReadLine());
               }
               switch (data_type)
               {
                   case 1:
                       Console.WriteLine("Введите,сколько элементов будет в массиве типа int: ");
                       int size_of_array = Convert.ToInt32(Console.ReadLine());
                       var a = new int[size_of_array];
                       Console.WriteLine("Введите элементы массива: ");
                       for (int i = 0; i < a.Length; i++)
                       {
                           a[i] = Convert.ToInt32(Console.ReadLine());
                       }
                       while (true)
                       {
                           Console.WriteLine("Выберете, что вы хотите сделать с данным массивом: ");
                           Console.WriteLine("1) Array.Sort");
                           Console.WriteLine("2) Array.Resize");
                           Console.WriteLine("3) Array.Reverse");
                           Console.WriteLine("4) Array.BinarySearch");
                           Console.WriteLine("5) Array.Clear");
                           Console.WriteLine("6) Array.Copy");
                           int main = Convert.ToInt32(Console.ReadLine());
                           switch (main)
                           {
                               case 1:
                                   Array.Sort(a);
                                   break;
                               case 2:
                                   Console.WriteLine("Введите новый размер массива: ");
                                   int dim = Convert.ToInt32(Console.ReadLine());
                                   Array.Resize(ref a, dim);
                                   break;
                               case 3:
                                   Array.Reverse(a);
                                   break;
                               case 4:
                                   Array.Sort(a);
                                   Console.WriteLine("Input the value you want us to find in the array: ");
                                   int search = Convert.ToInt32(Console.ReadLine());
                                   Console.Write("Индекс равен: ");
                                   Console.WriteLine(Array.BinarySearch(a, search));
                                   break;
                               case 5:
                                   Array.Clear(a);
                                   break;
                               case 6:
                                   Console.WriteLine("Введите длину, сколько будем копировать");
                                   int l = Convert.ToInt32(Console.ReadLine());
                                   int[] copy = new int[size_of_array];
                                   Array.Copy(a, copy, l);
                                   for (int i = 0; i < copy.Length; i++) Console.WriteLine(copy[i]);
                                   break;
                           }
                           F.Output(a);
                           Console.WriteLine("1) Вернуться к выборке");
                           Console.WriteLine("2) Вернуться к внешней программе");
                           c = Convert.ToInt32(Console.ReadLine());
                           if (c == 2) break;
                       }
                       break;
                   case 2:
                       Console.WriteLine("Введите,сколько элементов будет в массиве типа string: ");
                       size_of_array = Convert.ToInt32(Console.ReadLine());
                       var str = new string[size_of_array];
                       Console.WriteLine("Введите элементы массива: ");
                       for (int i = 0; i < str.Length; i++)
                       {
                           str[i] = Console.ReadLine();
                       }

                       while (true)
                       {
                           Console.WriteLine("Выберете, что вы хотите сделать с данным массивом: ");
                           Console.WriteLine("1) Array.Sort");
                           Console.WriteLine("2) Array.Resize");
                           Console.WriteLine("3) Array.Reverse");
                           Console.WriteLine("4) Array.BinarySearch");
                           Console.WriteLine("5) Array.Clear");
                           Console.WriteLine("6) Array.Copy");
                           int main = Convert.ToInt32(Console.ReadLine());
                           switch (main)
                           {
                               case 1:
                                   Array.Sort(str);
                                   Console.WriteLine();
                                   break;
                               case 2:
                                   Console.WriteLine("Введите новый размер массива: ");
                                   int dim = Convert.ToInt32(Console.ReadLine());
                                   Array.Resize(ref str, dim);
                                   break;
                               case 3:
                                   Array.Reverse(str);
                                   Console.WriteLine(str.Length);
                                   Console.WriteLine();
                                   break;
                               case 4:
                                   Array.Sort(str);
                                   Console.WriteLine("Input the value you want us to find in a array");
                                   string search = Console.ReadLine();
                                   Console.WriteLine(Array.BinarySearch(str, search));
                                   break;
                               case 5:
                                   Array.Clear(str);
                                   break;
                               case 6:
                                   Console.WriteLine("Введите длину, сколько будем копировать");
                                   int l = Convert.ToInt32(Console.ReadLine());
                                   int[] copy = new int[size_of_array];
                                   Array.Copy(str, copy, l);
                                   for (int i = 0; i < copy.Length; i++) Console.WriteLine(copy[i]);
                                   break;
                           }
                           F.Output(str);
                           Console.WriteLine();
                           Console.WriteLine("1) Вернуться к выборке");
                           Console.WriteLine("2) Вернуться к внешней программе");
                           c = Convert.ToInt32(Console.ReadLine());
                           if (c == 2) break;
                       }
                       break;
                   case 3:
                       Console.WriteLine("Введите,сколько элементов будет в массиве типа char: ");
                       size_of_array = Convert.ToInt32(Console.ReadLine());
                       var ch = new char[size_of_array];
                       Console.WriteLine("Введите элементы массива: ");
                       for (int i = 0; i < ch.Length; i++)
                       {
                           ch[i] = Convert.ToChar(Console.ReadLine());
                       }

                       while (true)
                       {
                           Console.WriteLine("Выберете, что вы хотите сделать с данным массивом: ");
                           Console.WriteLine("1) Array.Sort");
                           Console.WriteLine("2) Array.Resize");
                           Console.WriteLine("3) Array.Reverse");
                           Console.WriteLine("4) Array.BinarySearch");
                           Console.WriteLine("5) Array.Clear");
                           Console.WriteLine("6) Array.Copy");
                           int main = Convert.ToInt32(Console.ReadLine());
                           switch (main)
                           {
                               case 1:
                                   Array.Sort(ch);
                                   break;
                               case 2:
                                   Console.WriteLine("Введите новый размер массива: ");
                                   int dim = Convert.ToInt32(Console.ReadLine());
                                   Array.Resize(ref ch, dim);
                                   break;
                               case 3:
                                   Array.Reverse(ch);
                                   break;
                               case 4:
                                   Array.Sort(ch);
                                   Console.WriteLine("Input the value you want us to find in a array:");
                                   char search = Convert.ToChar(Console.ReadLine());
                                   Console.WriteLine(Array.BinarySearch(ch, search));
                                   break;
                               case 5:
                                   Array.Clear(ch);
                                   break;
                               case 6:
                                   Console.WriteLine("Введите длину, сколько будем копировать");
                                   int l = Convert.ToInt32(Console.ReadLine());
                                   int[] copy = new int[size_of_array];
                                   Array.Copy(ch, copy, l);
                                   for (int i = 0; i < copy.Length; i++) Console.WriteLine(copy[i]);
                                   break;
                           }
                           F.Output(ch);
                           for (int i = 0; i < ch.Length; i++) Console.WriteLine(ch[i]);
                           Console.WriteLine();
                           Console.WriteLine("1) Вернуться к выборке");
                           Console.WriteLine("2) Вернуться к внешней программе");
                           c = Convert.ToInt32(Console.ReadLine());
                           if (c == 2) break;
                       }
                       break;
               }
               Console.WriteLine("1) Заново запустить программу");
               Console.WriteLine("2) Завершить программу");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;





       case 2:
           var al = new ArrayList() { 1, 2, 3,"Tim", new int[] { 0, 6, 9, 6 } };
           for (int i = 0; i < al.Count; i++)
           {
               Console.Write(al[i]+", "); ;
           }
           Console.WriteLine();
           Array copy2 = new int[10];
           while (true)
           {
               Console.WriteLine("Выберете, что вы хотите сделать с данной коллекцией: ");
               Console.WriteLine("1) int Add(object value)" +
                   "\n2) void AddRange(ICollection col)" +
                   "\n3) bool Contains(object value)\n" +
                   "4) Reverse() " +
                   "\n5) Sort() " +
                   "\n6) Clear()" +
                   "\n7) CopyTo(Array array)." +
                   "\n8)RemoveObject(Удаляет первое вхождение указанного объекта из коллекции ArrayList)");
               int main = Convert.ToInt32(Console.ReadLine());
               switch (main)
               {
                   case 1:
                       Console.WriteLine("Добавим эл 'Tim'");
                       al.Add("Tim");
                       break;
                   case 3:
                       Console.WriteLine("Проверим, есть ли эл 'Sam' в коллекции");
                       Console.WriteLine(al.Contains("Sam"));
                       break;
                   case 2:
                       Console.WriteLine("Добавим в коллекцию список {1,2,3}");
                       al.AddRange(new List<int>() { 1, 2, 3 });
                       break;
                   case 4:
                       al.Reverse();
                       break;
                   case 5:
                       al.Sort();
                       break;
                   case 6:
                       al.Clear();
                       break;
                   case 7:
                       Console.WriteLine("Введите индекс в ArrayList, с которого будем копировать;\n" +
                           "индекс  массива, с которого будем вставлять эл;\nкол-во эл, соответственно:");
                       int ind_osn = Convert.ToInt32(Console.ReadLine()), ind = Convert.ToInt32(Console.ReadLine()), dlina = Convert.ToInt32(Console.ReadLine());
                       al.CopyTo(ind_osn,copy2,ind,dlina);
                       Console.WriteLine("Массив, который получился: ");
                       foreach (int i in copy2) Console.WriteLine(i);
                       break;
               }
               //for (int i = 0; i < ch.Length; i++) Console.WriteLine(ch[i]);
               F.Output(al);
               Console.WriteLine();
               Console.WriteLine("1) Вернуться к выборке");
               Console.WriteLine("2) Вернуться к внешней программе");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;



       case 3:
           Hashtable ht = new Hashtable(new Dictionary<int, string>()
           {
               { 1, "Tom"},
               {2,"Sam"}
           });
           Console.WriteLine("Исходная коллекция:");
           F.Output(ht);
           Console.WriteLine();
           while (true)
           {
               Console.WriteLine("Выберете, что вы хотите сделать с данной коллекцией: ");
               Console.WriteLine("1) Add(Object, Object)\n2) Clear()\n3) Clone()\n" +
                   "4) Remove(Object) (удаляет эл с указ ключем)" +
                   "\n5) ContainsKey(Object)" +
                   "\n6) ContainsValue(Object)" +
                   "\n7) CopyTo(Array, Int32) (либо из ключей, либо из значений)" +
                   "\n8) Equals(Object)");
               int main = Convert.ToInt32(Console.ReadLine());
               int k;
               string v;
               Hashtable test = new Hashtable();
               switch (main)
               {
                   case 1:
                       Console.WriteLine("Введите пару ключ-значение <int, string>");
                       k = Convert.ToInt32(Console.ReadLine());
                       v = Console.ReadLine();
                       ht.Add(k,v);
                       F.Output(ht);
                       break;
                   case 2:
                       ht.Clear();
                       F.Output(ht);
                       break;
                   case 3:
                       test = (Hashtable)ht.Clone();
                       F.Output(test);
                       break;
                   case 4:
                       Console.WriteLine("Напиши, какой ключ ты не хочешь видеть в новой хеш-таблице:");
                       ht.Remove(Convert.ToInt32(Console.ReadLine()));
                       F.Output(test);
                       break;
                   case 5:
                       Console.WriteLine("Введите ключ, который хотите проверить, есть ли он: ");
                       Console.WriteLine(ht.ContainsKey(Convert.ToInt32(Console.ReadLine())));
                       break;
                   case 6:
                       Console.WriteLine("Введите значение, которое хотите проверить, есть ли оно: ");
                       Console.WriteLine(ht.ContainsValue(Console.ReadLine()));
                       break;
                   case 7:
                       int[] ar = new int[ht.Keys.Count+2];
                       ar[0] = 0;
                       ar[1] = 1;
                       ar[2] = 2;
                       Console.WriteLine("Введите индекс в массиве, с которого будем вставлять хэш-таблицу (0/1/2)");
                       ht.Keys.CopyTo(ar,Convert.ToInt32(Console.ReadLine()));
                       foreach (var el in ar)
                       {
                           Console.Write(el+" ");   
                       }
                       Console.WriteLine();
                       break;
                   case 8:
                       Console.WriteLine("Проверим, равен ли эл в коллекции под ключём 1 с эл Tom");
                       try
                       {
                           Console.WriteLine(ht[1].Equals("Tom"));
                       }
                       catch (NullReferenceException ex)
                       {
                           Console.WriteLine(ex.Message);
                       }
                       break;
               }

               Console.WriteLine();
               Console.WriteLine("1) Вернуться к выборке");
               Console.WriteLine("2) Вернуться к внешней программе");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;


       case 4:
           Stack<string> stack = new Stack<string>(new List<string>( ) { "Tom", "Sam", "Bob" });
           Console.WriteLine("Исходный стек:");
           F.Output(stack);
           Console.WriteLine();
           while (true)
           {
               Console.WriteLine("Выберете, что вы хотите сделать с данной коллекцией: ");
               Console.WriteLine("1) Push (добавляет элемент)\n2) Clear()\n3) Pop\n4) Peek\n5) Try.Pop\n6) Try.Peek\n7) Contains"); 
               int main = Convert.ToInt32(Console.ReadLine());
               string str;
               switch (main)
               {
                   case 1:
                       Console.WriteLine("Введите имя, которое будет следующим: ");
                       str  = Console.ReadLine(); 
                       stack.Push(str);
                       F.Output(stack);
                       break;
                   case 2:
                       stack.Clear();
                       break;

                   case 5:
                       Console.WriteLine(stack.TryPop(out str));
                       Console.WriteLine($"извлечённое значение: {str}");
                       break;
                   case 6:
                       Console.WriteLine(stack.TryPeek(out str));
                       Console.WriteLine($"извлечённое значение: {str}");
                       break;
                   case 4:
                       Console.WriteLine(stack.Peek());
                       break;
                   case 7:
                       Console.WriteLine("Введите имя, которое будем проверять есть ли оно в стеке: ");
                       str  = Console.ReadLine();
                       Console.WriteLine((stack.Contains(str)));
                       break;
               }
               F.Output(stack);
               Console.WriteLine();
               Console.WriteLine("1) Вернуться к выборке");
               Console.WriteLine("2) Вернуться к внешней программе");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;


       case 5:
           Queue<string> q = new Queue<string>(new List<string>() { "Tim", "Tom", "Sam" });
           Console.WriteLine("Исходная очередь:");
           F.Output(q);
           Console.WriteLine();
           while (true)
           {
               Console.WriteLine("Выберете, что вы хотите сделать с данной коллекцией: ");
               Console.WriteLine("1) Enqueue()\n2) Dequeue()\n3) Clear()\n4) Clone()\n5) GetType()\n6) ToString()\n7) Peek()" +
                                 "\n8) Contains"); 
               int main = Convert.ToInt32(Console.ReadLine());
               string str;
               switch (main)
               {
                   case 1:
                       Console.WriteLine("Введите имя, которое поставим в очередь: ");
                       str  = Console.ReadLine(); 
                       q.Enqueue(str);
                       F.Output(q);
                       break;
                   case 2:
                       q.Dequeue();
                       break;
                   case 3:
                       q.Clear();
                       break;
                   case 4:
                       var v = (string[])q.ToArray().Clone();
                       Console.WriteLine("Введите эл, который не хотите видеть в клоне: ");
                       str = Console.ReadLine();
                       for (int i = 0; i < v.Length; i++)
                       {
                           if (v[i] == str) v[i] = default;
                       }
                       F.Output(v);
                       break;
                   case 5:
                       Console.WriteLine(q.GetType());
                       break;
                   case 6:
                       Console.WriteLine(q.ToString());
                       break;
                   case 7:
                       Console.WriteLine(q.Peek());
                       break;
                   case 8:
                       Console.WriteLine("Введите имя, которое будем проверять есть ли оно в очереди: ");
                       str  = Console.ReadLine();
                       Console.WriteLine((q.Contains(str)));
                       break;
               }
               F.Output(q);
               Console.WriteLine(); 
               Console.WriteLine("1) Вернуться к выборке");
               Console.WriteLine("2) Вернуться к внешней программе");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;


       case 6:
           Dictionary<string, int> dict = new Dictionary<string, int>()
           {
               {"Tom",5},
               {"Tim",4},
               {"Sam",3}
           };
           Console.WriteLine("Исходная коллекция:");
           F.Output(dict);
           Console.WriteLine();
           while (true)
           {
               Console.WriteLine("Выберете, что вы хотите сделать с данной коллекцией: ");
               Console.WriteLine("1) Add(TKey, TValue)\n2) ContainsKey(TKey)()\n3) Clear()\n4) ContainsValue(TValue)" +
                                 "\n5) Remove(TKey)\n6) TryGetValue(TKey, TValue)"); 
               int main = Convert.ToInt32(Console.ReadLine());
               string str;
               int dg;
               switch (main)
               {
                   case 1:
                        Console.WriteLine("Введите имя/оценку, которое добавим:"); 
                        str  = Console.ReadLine();
                        dg = Convert.ToInt32(Console.ReadLine());
                       dict.Add(str,dg);
                       break;
                   case 2:
                       Console.WriteLine("Введите имя(key), которое будем проверять есть ли оно:"); 
                       str  = Console.ReadLine();
                       Console.WriteLine(dict.ContainsKey(str));
                       break;
                   case 4:
                       Console.WriteLine("Введите оценку(value), которое будем проверять есть ли оно:"); 
                       dg = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine(dict.ContainsValue(dg));
                       break;
                   case 3:
                       dict.Clear();
                       break;
                   case 5:
                       Console.WriteLine("Введите имя(key), которое будем удалять:"); 
                       str  = Console.ReadLine();
                       dict.Remove(str);
                       break;
                   case 6:
                       Console.WriteLine("Введите имя, которое хотите найти:"); 
                       str  = Console.ReadLine();
                       if (dict.TryGetValue(str, out dg)) Console.WriteLine(dg);
                       else Console.WriteLine("Nothing found D:");
                       break;
               }
               F.Output(dict);
               Console.WriteLine(); 
               Console.WriteLine("1) Вернуться к выборке");
               Console.WriteLine("2) Вернуться к внешней программе");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;
       case 7:
           List<int> digits = new List<int>() { 1, 2, 3 };
           Console.WriteLine("Исходная коллекция:");
           F.Output(digits);
           Console.WriteLine();
           while (true)
           {
               Console.WriteLine("Выберете, что вы хотите сделать с данной коллекцией: ");
               Console.WriteLine("1) Add(T)\n2) BinarySearch(T)\n3) Clear()\n4) Contains(T)" +
                                 "\n5) CopyTo(T[])\n6) Insert(Int32, T)\n7) Remove(T)"); 
               int main = Convert.ToInt32(Console.ReadLine());
               string str;
               int dg;
               switch (main)
               {
                   case 1:
                       Console.WriteLine("Введите эл, который будем добавлять: ");
                       dg = Convert.ToInt32(Console.ReadLine());
                       digits.Add(dg);
                       break;
                   case 2:
                       digits.Sort();
                       Console.WriteLine("Введите элемент, индекс которого хотите найти с помощью BinarySearch:"); 
                       dg = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine(digits.BinarySearch(dg));
                       break;
                   case 4:
                       Console.WriteLine("Введите число, которое будем проверять есть ли оно:"); 
                       dg = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine(digits.Contains(dg));
                       break;
                   case 3:
                       digits.Clear();
                       break;
                   case 5:
                       int[] test = new int[digits.Count];
                       digits.CopyTo(test);
                       Console.WriteLine($"Тип данных куда скопировали: {test.GetType()}, занулим первый индекс");
                       test[0] = 0;
                       F.Output(test);
                       break;
                   case 6:
                       Console.WriteLine("Введите индекс-элемент, которые вставим: ");
                       dg = Convert.ToInt32(Console.ReadLine());
                       int el = Convert.ToInt32(Console.ReadLine());
                       digits.Insert(dg,el);
                       break;
                   case 7:
                       Console.WriteLine("Введите эл, который удалим: ");
                       digits.Remove(Convert.ToInt32(Console.ReadLine()));
                       break;
               }
               F.Output(digits);
               Console.WriteLine(); 
               Console.WriteLine("1) Вернуться к выборке");
               Console.WriteLine("2) Вернуться к внешней программе");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;
       case 8:
           SortedList sl = new SortedList()
           {
               { "c", 3 },
               { "b", 2 },
               { "a", 1 }
           };
           Console.WriteLine("Исходная коллекция:");
           F.Output(sl);
           Console.WriteLine();
           while (true)
           {
               Console.WriteLine("Выберете, что вы хотите сделать с данной коллекцией: ");
               Console.WriteLine("1) Add(Object, Object)\n2) ContainsKey(Object)\n3) Clear()\n4) ContainsValue(Object)" +
                                 "\n5)GetByIndex(Int32)\n6) GetKey(Int32)\n7) GetKeyList()\n8)  Remove(Object) (Удаляет элемент с указанным ключом)"); 
               int main = Convert.ToInt32(Console.ReadLine());
               string str;
               int dg;
               switch (main)
               {
                   case 1:
                       Console.WriteLine("Введите ключ-значение: ");
                       sl.Add(Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
                       break;
                   case 2: 
                       Console.WriteLine("Введите ключ которое будем искать:");
                       Console.WriteLine(sl.ContainsKey(Console.ReadLine()));
                       break;
                   case 4:
                       Console.WriteLine("Введите значение которое будем искать:");
                       Console.WriteLine(sl.ContainsKey(Convert.ToInt32(Console.ReadLine())));
                       break;
                   case 3:
                       sl.Clear();
                       break;
                   case 5:
                       Console.WriteLine("Напишите индекс, значение которого хотите: ");
                       Console.WriteLine(sl.GetByIndex(Convert.ToInt32(Console.ReadLine())));
                       break;
                   case 6:
                       Console.WriteLine("Напишите индекс, ключ которого хотите: ");
                       Console.WriteLine(sl.GetKey(Convert.ToInt32(Console.ReadLine())));
                       break;
                   case 7:
                       F.Output(sl.GetKeyList());
                       break;
                   case 8:
                       Console.WriteLine("Введите ключ элемента, который удалим: ");
                       sl.Remove(Console.ReadLine());
                       break;
               }
               F.Output(sl);
               Console.WriteLine(); 
               Console.WriteLine("1) Вернуться к выборке");
               Console.WriteLine("2) Вернуться к внешней программе");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;
       case 9:
           SortedSet<int> set = new SortedSet<int>() { 20, 12, 1 };
           Console.WriteLine("Исходная коллекция:");
           F.Output(set);
           Console.WriteLine();
           while (true)
           {
               Console.WriteLine("Выберете, что вы хотите сделать с данной коллекцией: ");
               Console.WriteLine("1) Add(T)\n2) Contains(T)\n3) Clear()\n4) ExceptWith(IEnumerable<T>) (вычитание)" +
                                 "\n5)IntersectWith(IEnumerable<T>) (пересечение)\n6) IsProperSubsetOf(IEnumerable<T>)\n" +
                                 "7) IsSubsetOf(IEnumerable<T>)\n8) Remove(T) " +
                                 "\n9) Overlaps(IEnumerable<T>) (общие элементы)"); 
               int main = Convert.ToInt32(Console.ReadLine());
               int[] test =  {1,12,2,3,4};
               switch (main)
               {
                   case 1:
                       Console.WriteLine("Введите число: ");
                       set.Add(Convert.ToInt32(Console.ReadLine()));
                       break;
                   case 2:
                       Console.WriteLine("Введите число: ");
                       set.Contains(Convert.ToInt32(Console.ReadLine()));
                       break;
                   case 3:
                       set.Clear();
                       break;
                   case 4:
                       Console.WriteLine("Выведем коллекцию, которую будем вычитать из нашего мн-ва: ");
                       F.Output(test);
                       set.ExceptWith(test);
                       break;
                   case 5:
                       set.IntersectWith(test);
                       break;
                   case 6:
                       Console.WriteLine(set.IsProperSubsetOf(test));
                       break;
                   case 7:
                       Console.WriteLine(set.IsSubsetOf(new List<int>(set) ));
                       break;
                   case 8:
                       Console.WriteLine("Введите элемент, который удалим: ");
                       set.Remove(Convert.ToInt32(Console.ReadLine()));
                       break;
                   case 9:
                       Console.WriteLine(set.Overlaps(test));
                       break;
               }
               F.Output(set);
               Console.WriteLine(); 
               Console.WriteLine("1) Вернуться к выборке");
               Console.WriteLine("2) Вернуться к внешней программе");
               c = Convert.ToInt32(Console.ReadLine());
               if (c == 2) break;
           }
           break;
   }
   Console.WriteLine("1) Заново запустить программу");
   Console.WriteLine("2) Завершить программу");
   c = Convert.ToInt32(Console.ReadLine());
   if (c == 2) break;
//}



class F
{
    public static void input(ref string[] col)
    {
        for(int i =0;i<col.Length;i++) col[i] = Console.ReadLine();
        Console.WriteLine();
    }
    public static void input(ref int[] col)
    {
        for (int i = 0; i < col.Length; i++) col[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    public static void Output(ICollection col)
    { 
        
        if (col.GetType() == (typeof(Hashtable)) || col.GetType() == typeof(SortedList))
        {
            foreach (DictionaryEntry v in col) Console.WriteLine($"Key: {v.Key}, value: {v.Value}");
            Console.WriteLine();
        }
        else
        {
            foreach (var el in col) Console.Write(el + " ");
            Console.WriteLine();
        }
    }
   
    public static void Output(IEnumerable col)
    {
        foreach (DictionaryEntry v in col) Console.WriteLine($"Key: {v.Key}, value: {v.Value}");
        Console.WriteLine();
    }
}



// Обобщения:
// Реализовать обобщенный класс, который позволяет хранить в массиве объекты любого типа. 
//В данном классе определить методы для добавления данных в массив, удаления из массива, получения элемента из массива по индексу.
// Written with Max
Massiv<string> mass = new Massiv<string>(5);
mass.Set("aboba", 0);

Console.WriteLine(mass.Get(0));
mass.Remove(0);
Console.WriteLine(mass.Get(0));

Massiv<int> massiv2 = new Massiv<int>(2);
massiv2.Set(12435, 0);
massiv2.Set(-134, 1);
massiv2.Print();
massiv2.Remove(0);
massiv2.Print();

class Massiv<T>
{
    T[] ar;
    
    public Massiv(int length) 
    { 
        this.ar = new T[length];
    }
    public void Set (T el, int index)
    {
        ar[index] = el;
    }
    public T Get(int index)
    {
        return ar[index];
    }
    public void Remove(int index)
    {
        ar[index] = default(T);
    }
    public void Print()
    {
        foreach(T el in ar)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine();
    }
};



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



