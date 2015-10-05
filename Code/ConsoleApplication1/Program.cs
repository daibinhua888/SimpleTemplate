using SimpleTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = @"
your name: @{name}
your age: @{age}

1
2

3

@{repeat 5}
testing
@{end repeat}
---------------------
@{repeat count}
testing
@{end repeat}
";
            Dictionary<string, object> ctx = new Dictionary<string, object>();

            ctx["name"] = "McKay";
            ctx["age"] = "你猜";
            ctx["count"] = 2;

            Console.WriteLine(STParser.GenerateStringView(template, ctx));

            Console.ReadKey();
        }
    }
}
