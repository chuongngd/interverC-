using System;
using System.Linq;
namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String HelloString = new String("Hello ");
            HelloString += new String("word");
            Console.WriteLine(HelloString);
            int[] arr = { 1, 3, 3,6,8, 8, 9 };
            int[] arr2 = { 4, 6, 8 };
            printArray(MergeArray(arr, arr2));

            string s1 = "Fsfsg fsgsghjgj";
            string s2 = "hji fs hytutu";
            Console.WriteLine(stringConcat(s1, s2));
            int [] arr1 = arr.Distinct().ToArray();
            var query = from index in arr orderby index descending select index  ;
            foreach(var i in query)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");
        }
        public static void printArray(int[] a)
        {
            for (int i = 0; i<a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        public static string stringConcat(string s1, string s2)
        {
            char[] s1Arr = s1.ToCharArray();
            char[] s2Arr = s2.ToCharArray();
            char[] sArr = new char[s1Arr.Length + s2Arr.Length];
            int i = 0;
            while(i<s1Arr.Length)
            {
                sArr[i] = s1Arr[i];
                i++;
            }
            int j = 0;
            while (j < s2Arr.Length)
            {
                sArr[i] = s2Arr[j];
                i++;
                j++;
            }
            return new string(sArr);
        }

        public static int[] MergeArray(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0;
            while (i < arr1.Length)
            {
                arr3[i] = arr1[i];
                i++;
            }
            int j = 0;
            while (j < arr2.Length)
            {
                arr3[i] = arr2[j];
                i++; j++;
            }
            return arr3;
        }
    }
}

   
    public interface Bird
    {
        public void fly(int speed);
        public void eat(string food);
        public void run();
        public void sound();
    }
    class Peacock : Bird
    {
        public void eat(string food)
        {

            Console.WriteLine("Peacock eat " + food);
        }

        public void fly(int speed)
        {
            Console.WriteLine("Peacock speed: " + speed);
        }

        public void run()
        {
            throw new NotImplementedException();
        }

        public void sound()
        {
            throw new NotImplementedException();
        }

    class String
    {
        string s = "";
        public String(string s)
        {
            this.s = s;
        }
        public static String operator+ (String s1, String s2)
        {
            return new String(s1.s + s2.s);
        }
        public String concat(String s1)
        {
            return new String(this.s + s1.s);
        }
        public override string ToString()
        {
            return this.s;
        }
    }
    }



    

