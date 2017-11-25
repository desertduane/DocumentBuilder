using DocumentBuilder.Classes;
using System;

namespace DocumentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Documents JoeResume = new SoYouDontHaveTo();
            JoeResume.GetDocument("Resume");
            Console.WriteLine();

            Documents EssayCheater = new SoYouDontHaveTo();
            EssayCheater.GetDocument("Essay");


            Console.Read();
        }
    }
}
