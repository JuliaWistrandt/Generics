using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;

namespace Generic
{
    public delegate void OutputHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            //call it with a non ref type
            Pair<int, char> firstPair = new Pair<int, char>(6, 'h');
            Pair<byte, char> secondPair = new Pair<byte, char>(101, 'A');
            Pair<double, long> thirdPair = new Pair<double, long>(6.34, 12345678);


            //call it with a ref type
            PairClass<string, string> fourthPair = new PairClass<string, string>("String 1 value 2", "string 1 value 2");
            PairClass<string, string> fifthPair = new PairClass<string, string>("String 2 value 1", "string 2 value 2");


            ComparablePair<int, string> cpOne = new ComparablePair<int, string>(6, "13");
            ComparablePair<int, string> cpTwo = new ComparablePair<int, string>(101, "2");
            ComparablePair<int, int> cpThree = new ComparablePair<int, int>(20, 660);
            ComparablePair<int, int> cpFour = new ComparablePair<int, int>(10, 990);

            Console.WriteLine(cpOne.CompareTo(cpTwo));
            Console.WriteLine(cpThree.CompareTo(cpFour));




            //Classwork


            #region Classwork


            // Classwork 09 jan 2023

            int first = 10; // int? first = 10 is a fail signature because struct takes no null value
            int second = 20;
            Swap(ref first, ref second);
            Console.WriteLine($"first number is {first}, second number is {second}");

            string frt = "first value";
            string scnd = "second value";
            Swap(ref frt, ref scnd);
            Console.WriteLine($"first number is {frt}, second number is {scnd}");
            #endregion Classwork

        }

        public static void Swap<T>(ref T first, ref T second)  //where T : struct
        {
            T ret = first;
            first = second;
            second = ret;
        }

            
    }

}