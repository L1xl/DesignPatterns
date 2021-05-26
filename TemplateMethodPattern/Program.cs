using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPaper paperA = new TestPaperA();
            paperA.Question1();
            paperA.Question2();

            TestPaper paperB = new TestPaperB();
            paperB.Question1();
            paperB.Question2();

            Console.ReadLine();
        }
    }
}
