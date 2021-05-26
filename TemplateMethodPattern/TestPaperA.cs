using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    class TestPaperA : TestPaper
    {
        public override string Answer1()
        {
            return "A";
        }
        public override string Answer2()
        {
            return "B";
        }
    }
}
