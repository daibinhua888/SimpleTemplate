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
your name: @{user.Name}
your age: @{user.Age}

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

            User usr = new User() { Name = "McKay", Age = "你猜" };
            ctx["user"] = usr;
            ctx["count"] = 2;

            Console.WriteLine(STParser.GenerateStringView(template, ctx));

            Console.ReadKey();
        }
    }

    class User
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
