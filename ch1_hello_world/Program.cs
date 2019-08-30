using System;

namespace ch1_hello_world
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string hello = "hello world";
            DateTime now = DateTime.Now;
            Console.Write(hello);
            Console.WriteLine("the date is " + now.ToLongDateString());
        }
    }
}
