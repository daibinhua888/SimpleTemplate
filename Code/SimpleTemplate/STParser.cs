using Antlr4.Runtime.Tree;
using SimpleTemplate.g4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplate
{
    public static class STParser
    {
        public static string GenerateStringView(string template, Dictionary<string, object> variables)
        {
            Antlr4.Runtime.AntlrInputStream input = new Antlr4.Runtime.AntlrInputStream(template);
            TemplateLexer lexer = new TemplateLexer(input);

            Antlr4.Runtime.UnbufferedTokenStream tokens = new Antlr4.Runtime.UnbufferedTokenStream(lexer);
            TemplateParser parser = new TemplateParser(tokens);

            SimpleTemplateErrorListener errorLsn=new SimpleTemplateErrorListener();

            parser.AddErrorListener(errorLsn);

            var tree = parser.parse();

            if (errorLsn.ErrorType != ParseErrorType.Successful)
                throw new Exception(errorLsn.ErrorType.ToString());

            SimpleTemplateVisitor visitor = new SimpleTemplateVisitor(variables);

            string result=visitor.Visit(tree);

            return result;
        }
    }
}
