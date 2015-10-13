using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplate
{
    class SimpleTemplateVisitor:g4.TemplateBaseVisitor<string>
    {
        private Dictionary<string, object> ctx;

        public SimpleTemplateVisitor(Dictionary<string, object> ctx)
        {
            this.ctx = ctx;
        }

        public override string VisitParse(g4.TemplateParser.ParseContext context)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var exp in context.expression())
                sb.Append(VisitExpression(exp));

            return sb.ToString();
        }

        public override string VisitNewlines(g4.TemplateParser.NewlinesContext context)
        {
            return context.GetText();
        }

        public override string VisitStringtext(g4.TemplateParser.StringtextContext context)
        {
            return context.GetText();
        }

        public override string VisitRepeater_stmt(g4.TemplateParser.Repeater_stmtContext context)
        {
            StringBuilder sb_repeat_stmt = new StringBuilder();
            StringBuilder sb_expressions = new StringBuilder();

            int repeat_count = int.Parse(VisitRepeater_stmt_count(context.repeater_stmt_begin().repeater_stmt_count()));

            foreach(var exp in context.expression())
                sb_expressions.Append(VisitExpression(exp));

            for (var i = 0; i < repeat_count; i++)
                sb_repeat_stmt.Append(sb_expressions.ToString());

            return sb_repeat_stmt.ToString();
        }

        public override string VisitRepeater_stmt_count(g4.TemplateParser.Repeater_stmt_countContext context)
        {
            if (context.digital() != null)
                return context.digital().GetText();

            if (context.simple_variable_inner() != null)
                return VisitSimple_variable_inner(context.simple_variable_inner());

            if (context.complex_variable_inner() != null)
                return VisitComplex_variable_inner(context.complex_variable_inner());

            throw new NotSupportedException();
        }

        public override string VisitSimple_variable(g4.TemplateParser.Simple_variableContext context)
        {
            return VisitSimple_variable_inner(context.simple_variable_inner());
        }

        public override string VisitComplex_variable(g4.TemplateParser.Complex_variableContext context)
        {
            return VisitComplex_variable_inner(context.complex_variable_inner());
        }

        public override string VisitSimple_variable_inner(g4.TemplateParser.Simple_variable_innerContext context)
        {
            string var_name = context.identity().GetText();

            if (!ctx.ContainsKey(var_name))
                throw new NullReferenceException(var_name);

            return Convert.ToString(ctx[var_name]);
        }

        public override string VisitComplex_variable_inner(g4.TemplateParser.Complex_variable_innerContext context)
        {
            string var_name = context.identity()[0].GetText();

            if (!ctx.ContainsKey(var_name))
                throw new NullReferenceException(var_name);

            string propertyName = context.identity()[1].GetText();

            object obj = ctx[var_name];

            Type t = obj.GetType();
            PropertyInfo propertyInfo = t.GetProperty(propertyName);

            var value = propertyInfo.GetValue(obj, null);

            string string_value = Convert.ToString(value);

            return string_value;
        }

        public override string VisitIf_stmt(g4.TemplateParser.If_stmtContext context)
        {
            return base.VisitIf_stmt(context);
        }
    }
}
