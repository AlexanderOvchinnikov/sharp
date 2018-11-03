using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Test
{
    class ClassA
    {

        //int field1, field2;
        //public ClassA (int a, int b) {
        //    field1 = a;
        //    field2 = b;
        //}
        

    //    public virtual int MMM(int m, int k)
    //    {
    //        return m + k;
    //    }

    public int data;

    //    //    public static void Print()
    //    //{
    //    //    Console.WriteLine("Hello");
    //    //}
    }
    //public class ClassB : ClassA
    //{
    //    int field3;

        //ClassB(int c, int a, int b)
        //{
        //    ClassA(a, b);
        //    field3 = c;
        //}

        // !!!!!Верный!!!!
        //ClassB (int c, int a, int b) : base(a, b) 
        //{
        //    field3 = c;
        //}

        //ClassB (int c, int a, int b)
        //{
        //    super(a, b);
        //    field3 = c;
        //}
        
    }
//{
//    public override int MMM(int m, int a) { 


//        return m;
//    }
//}
class Program

{
    public static void Stop()
    {
        Console.ReadLine();
    }


    static void Main()
    {

        ClassA A = new ClassA();
        A.data = 10;


        //Dictionary<string, int> metrica = new Dictionary<string, int> { { "mm", 1 }, { "cm", 10 }, { "dm", 100 } };
        //Console.WriteLine(metrica["km"]);
        //Stop();

        // Ответ 1
        //int a = 0, b = 0;
        //a = 120;
        //b = 120;
        //if (a < 100 ^ b < 100)                 //!!!!!!!
        //{
        //    Console.WriteLine("Работает 1");   //!!!!!!!
        //}
        //if (a < 100 || b < 100)
        //{
        //    Console.WriteLine("Работает 2");
        //}
        //if (a<100 && b < 100)
        //{
        //    Console.WriteLine("Работает 3");
        //}
        //Stop();



        //Stack stack = new Stack();
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);
        //while (stack.Count != 0)
        //{
        //    Console.WriteLine("{0}", stack.Pop().ToString());
        //}
        //Stop();


        //Ответ ира
        //char[] a = { 'м', 'и', 'р', 'а', 'ж' };
        //string line = new string(a, 1, 3);
        //Console.WriteLine(line);
        //Stop();


        //FileStream input = new FileStream("file.txt", FileMode.Open);
        //{
        //    Dictionary<string, string> numbers = new Dictionary<string, string>();
        //    numbers["1"] = "One";
        //    numbers["2"] = "Two";
        //    numbers["3"] = "Three";
        //    foreach (KeyValuePair<string, string> pair in numbers)
        //    {
        //        Console.WriteLine("{0}", pair);
        //    }
        //    Stop();

        //    FileStream.Lenght


        //ClassA A = new ClassA();
        //A.data = 10;
        //Console.WriteLine(ClassA.data);
        //ClassA.data = 44;
        //Console.WriteLine(ClassA.data);
        //ClassA.Print();
        //Console.ReadLine();

        //int[,,] a = new int[5, 2, 4];
        //Console.WriteLine(a.Length);
        //Console.ReadLine();


        //FileStream input = new FileStream("file.txt", FileMode.Create);

        //Dictionary

        //char a = 'z';
        //Console.WriteLine((int)a);
        //Stop();

        //StreamWriter

        //FileStream.Lenght;

        //int i, j, s = 0;
        //for (i = 1, j = 5; i<j; ++i, --j)
        //{
        //    s += i;
        //}
        //Console.WriteLine(s);
        //Console.ReadLine();

        //double[] array = new double[5];
        //for (int i = 1; i <= array.Length; i++)
        //    array[i] = i;
        //Console.WriteLine("Vfff");

        // Ответ 1
        //string line = "кол около колокола";
        //char[] a = { 'л', 'о' };
        //Console.WriteLine(line.IndexOfAny(a));
        //Stop();

        //Ответ кл кла-клкла
        //StringBuilder str =new StringBuilder( "около о кола-колокола");
        //str.Replace("о", "");
        //Console.WriteLine(str);
        //Console.ReadLine();

        //int[,] С = new int[4, 5];
        ////метод возвращающий количество столбцов
        //Console.WriteLine(С.GetLength(1));  !!!!!!!!!!
        ////Console.WriteLine(С.Length[0]);
        //Console.WriteLine(С.GetLength(0));
        ////Console.WriteLine(С.Rank(0));
        ////Console.WriteLine(С.Length[1]);
        //Console.ReadLine();

        //// Цикл не выполнится ни разу
        //int y = 100;
        //while (y < 0)
        //{
        //    Console.WriteLine("{0}", y);
        //    y = y - 30;
        //}
        //Stop();

        //// Результат "3"
        //int i, j, s = 0;
        //for (i =1, j = 5; i < j; ++i, --j)
        //{
        //    s += i;
        //}
        //Console.WriteLine(s);
        //Stop();

        //int x = 100;
        //do
        //{
        //    Console.WriteLine("{0}", x);
        //    x = x - 30;
        //}
        //while (x > 0);
        //Stop();

        //double[] array = new double[5];
        //for (int i = 1; i <= array.Length; i++) array[i] = i;
        //Console.WriteLine("Массив заполнен");
        //Stop();

        // Ответ 9
        //int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //int s = a.Length;
        //Console.WriteLine(s);
        //Stop();

        //int[,,] a = new int[5, 2, 4];
        //Console.WriteLine(a.Length);
        //Stop();

        //int a = -2;
        //int b = -4;
        //if (!(a * b >= 0)) Console.WriteLine("Оба числа одинакового знака");
        //if (a * b < 0) Console.WriteLine("Оба числа одинакового знака");
        //if (a * b > 0) Console.WriteLine("Числа имеют разный знак");
        //Stop();

        //BinaryReader binReader = new BinaryReader(File.Open("sd.txt", FileMode.Open));

        //int x = 2;
        //if (x / 2 == 0) Console.WriteLine("x четное"); else Console.WriteLine("x нечетное");
        //if (x%2!=0) Console.WriteLine("x нечетное"); else Console.WriteLine("x четное");           //!!!!!!!!!!
        //if (x%2==0) Console.WriteLine("x четное"); else Console.WriteLine("x нечетное");          //!!!!!!!!!!
        //if (x%2!=0) Console.WriteLine("x четное"); else Console.WriteLine("x нечетное");
        //Stop();
    }
}

 


