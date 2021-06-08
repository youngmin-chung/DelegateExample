using System;

namespace InClassActivity
{
    public delegate int NumberChanger(int a);
    public class Program
    {
        private static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiNum(int q)
        {
            num *= q;
            return num;
        }

        //The power of num
        public static int PowerNum(int q)
        {
            num = (int)Math.Pow(num, q);
            return num;
        }

        static void Main(string[] args)
        {
            //Create delegate instances using the customized delegate
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);
            NumberChanger nc3 = new NumberChanger(PowerNum);
            //Calling the methods using the delegate objects
            Console.WriteLine("A customized Delegate for each method");
            Console.WriteLine("------------------------\n");
            nc1(25);
            Console.WriteLine("Value of Num: {0}", num);
            nc2(5);
            Console.WriteLine("Value of Num: {0}", num);
            nc3(2);
            Console.WriteLine("Value of Num: {0}", num);

            //Reset the value of num
            num = 10;
            //The built-in Func delegate
            Console.WriteLine("A built-in Delegate for each method");
            Console.WriteLine("------------------------\n");
            Func<int, int> add = AddNum;
            Console.WriteLine("Call the adding method = " + add(2));

            Func<int, int> Mult = MultiNum;
            Console.WriteLine("Call the adding method = " + Mult(2));

            Func<int, int> Power = PowerNum;
            Console.WriteLine("Call the adding method = " + Power(2) + "\n");

            //Reset the value of num
            num = 10;
            //Chain all methods with using only one delegate
            Console.WriteLine("Only one built-in Delegate for all methods");
            Console.WriteLine("------------------------\n");
            Func<int, int> chainedDelegate = AddNum;
            chainedDelegate += MultiNum;
            chainedDelegate += PowerNum;

            Console.WriteLine("The value of num after running the chained delegate = " + chainedDelegate(2));


            Console.ReadKey();

        }
        
    }
}
