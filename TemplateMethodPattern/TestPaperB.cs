using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    class TestPaperB:TestPaper
    {
        public override string Answer1()
        {
            return "C";
        }
        public override string Answer2()
        {
            return "D";
        }
    }
}
