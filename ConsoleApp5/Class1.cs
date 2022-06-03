using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class1
    {
        public static void ref_use(ref int a)
        {
            a = a + 1;
            Console.WriteLine(a);

        }
        public static int ref_use2(ref int b)
        {
            b += 1;
            return b;
        }
        public static void out_use(out int d)
        {
            d = 0;
            d = d + 1;

        }
        public const int z = 1;
        /*public static void Main()
        {
            int a = 50;
            ref_use(ref a);
            Console.WriteLine(a);
            Console.WriteLine("ref 2");
            int c = 1;
            ref_use2(ref c);
            Console.WriteLine(c);
            Console.WriteLine("out");
            int d;
            out_use(out d);
            Console.WriteLine(d);
            Console.WriteLine("cons");
            
            Console.WriteLine(z);



        }*/
    }
    public class class2
    {
        public static void params_use(params int[] rollno)// we can add as may number we want
        {
            Console.WriteLine("rollno");
            for (int i = 0; i < rollno.Length; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void params_use2(params string[] names)
        {
            Console.WriteLine("names");
            for(int a = 0; a < names.Length; a++)
            {
                Console.WriteLine(a);
            }
        }
        /*public static void Main()
        {
            params_use(1, 2, 3, 4, 5, 6);
            params_use2("anush", "akash", "rahul");
            //string a = null;
            //int b = null; // error
            //Nullable<int> b = null;
         
        }*/
    }
    public class class3
    {
        public static void jaggedarray_use()
        {
            int[][] rollno = new int[2][];
            rollno[0] = new int[4] { 1, 2, 3, 4 };
            rollno[1] = new int[6] {5,6,7,8,9,10};
            for(int i = 0; i < rollno.Length; i++)
            {
                for(int j = 0; j < rollno[i].Length; j++)
                {
                    Console.Write(rollno[i][j]);
                }
            }
        }
       /* public static void Main()
        {
            jaggedarray_use();
           
        }*/
       
    }
   /* struct struct_use
    {
        int id;
        string name;
        int phoneNo;
        public  void str_use()
        {
            id = 1;
            name = "anush";
            phoneNo = 807648555;

        }
      
    }*/
   public class car
    {
        public void carname()
        {
            Console.WriteLine("lamborghini");
        }
        public class engine
        {
            public void carengine()
            {
                Console.WriteLine("Petrol");
            }
            public class piston_in_engine
            {
                public void piston()
                {
                    Console.WriteLine("8");
                }
            }

        }
        /*public static void Main()
        {
            car obj = new car();
            obj.carname();
            car.engine obj2 = new car.engine();
            obj2.carengine();
            engine.piston_in_engine obj3 = new engine.piston_in_engine();
            obj3.piston();
        }*/

    }
    public class class4
    {
        public void tuple_use()
        {
            var a = new Tuple<int, string, int>(1, "anush", 807648555);
            Console.WriteLine(a.Item1 + a.Item2 + a.Item3);
        }
        public void tuple_use2()
        {
            (int, double) t1 = (17, 3.14);
            (double First, double Second) t2 = (0.0, 1.0);
            t2 = t1;
            Console.WriteLine(t2.First+t2.Second);
           

            (double A, double B) t3 = (5.0, 7.0);
            t3 = t2;
            Console.WriteLine(t3.A+t3.B);
        }
        public static void Main()
        {
            class4 obj = new class4();
            obj.tuple_use();
            obj.tuple_use2();
        }
    }
    public class OPERATOR_OVERLOADING
    {
        public string a;
        public int b;

       /* public static OPERATOR_OVERLOADING operator +(OPERATOR_OVERLOADING obj , OPERATOR_OVERLOADING obj2)
        {
            OPERATOR_OVERLOADING obj3 = new OPERATOR_OVERLOADING();
            obj3.a = obj.a + obj2.a;
            obj3.b = obj.b + obj2.b;
            return obj3;
        }
        public static void Main()
        {
            OPERATOR_OVERLOADING obj = new OPERATOR_OVERLOADING();
            obj.a = "anush";
            obj.b = 20;

            OPERATOR_OVERLOADING obj2 = new OPERATOR_OVERLOADING();
            obj2.a = "gupta";
            obj2.b = 30;

            OPERATOR_OVERLOADING obj3= new OPERATOR_OVERLOADING();

            obj3.a = obj.a + obj2.a;
            obj3.b = obj.b + obj2.b;

            Console.WriteLine(obj3.a);
            Console.WriteLine(obj3.b);

        }*/
    }






}

