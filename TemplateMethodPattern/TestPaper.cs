using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    class TestPaper
    {
        public void Question1()
        {
            Console.WriteLine("question 1's answer is"+Answer1());
        }
        
        public void Question2()
        {
            Console.WriteLine("question 2's answer is"+Answer2());
        }

        public virtual string Answer1()
        {
            return null;
        }
        public virtual string Answer2()
        {
            return null;
        }
    }
}
