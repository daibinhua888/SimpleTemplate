using SimpleTemplate.Stmts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplate
{
    class SimpleTemplateVisitor:g4.TemplateBaseVisitor<object>
    {
        private Dictionary<string, object> ctx;

        public SimpleTemplateVisitor(Dictionary<string, object> ctx)
        {
            this.ctx = ctx;
        }

        public override object VisitParse(g4.TemplateParser.ParseContext context)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var exp in context.expression())
                sb.Append(VisitExpression(exp));

            return sb.ToString();
        }

        public override object VisitNewlines(g4.TemplateParser.NewlinesContext context)
        {
            return context.GetText();
        }

        public override object VisitStringtext(g4.TemplateParser.StringtextContext context)
        {
            return context.GetText();
        }

        public override object VisitRepeater_stmt(g4.TemplateParser.Repeater_stmtContext context)
        {
            StringBuilder sb_repeat_stmt = new StringBuilder();
            StringBuilder sb_expressions = new StringBuilder();

            int repeat_count = int.Parse((string)VisitRepeater_stmt_count(context.repeater_stmt_begin().repeater_stmt_count()));

            foreach(var exp in context.expression())
                sb_expressions.Append(VisitExpression(exp));

            for (var i = 0; i < repeat_count; i++)
                sb_repeat_stmt.Append(sb_expressions.ToString());

            return sb_repeat_stmt.ToString();
        }

        public override object VisitRepeater_stmt_count(g4.TemplateParser.Repeater_stmt_countContext context)
        {
            if (context.digital() != null)
                return context.digital().GetText();

            if (context.simple_variable_inner() != null)
                return VisitSimple_variable_inner(context.simple_variable_inner());

            if (context.complex_variable_inner() != null)
                return VisitComplex_variable_inner(context.complex_variable_inner());

            throw new NotSupportedException();
        }

        public override object VisitSimple_variable(g4.TemplateParser.Simple_variableContext context)
        {
            return VisitSimple_variable_inner(context.simple_variable_inner());
        }

        public override object VisitComplex_variable(g4.TemplateParser.Complex_variableContext context)
        {
            return VisitComplex_variable_inner(context.complex_variable_inner());
        }

        public override object VisitSimple_variable_inner(g4.TemplateParser.Simple_variable_innerContext context)
        {
            string var_name = context.identity().GetText();

            if (!ctx.ContainsKey(var_name))
                throw new NullReferenceException(var_name);

            return Convert.ToString(ctx[var_name]);
        }

        public override object VisitComplex_variable_inner(g4.TemplateParser.Complex_variable_innerContext context)
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

        public override object VisitIf_stmt(g4.TemplateParser.If_stmtContext context)
        {
            IfStmt_ConditionsResult if_conditions_result = (IfStmt_ConditionsResult)VisitIf_stmt_conditions_block(context.if_stmt_conditions_block());

            if (if_conditions_result.DoesTestOK)
                return if_conditions_result.Result;

            if (context.if_stmt_else_block() == null)
                return string.Empty;

            IfStmt_ElseResult else_result = (IfStmt_ElseResult)VisitIf_stmt_else_block(context.if_stmt_else_block());

            return else_result.Result;
        }

        public override object VisitIf_stmt_else_block(g4.TemplateParser.If_stmt_else_blockContext context)
        {
            IfStmt_ElseResult else_result = new IfStmt_ElseResult();

            else_result.Result = context.if_stmt_else_body().GetText();

            return else_result;
        }

        public override object VisitIf_stmt_conditions(g4.TemplateParser.If_stmt_conditionsContext context)
        {
            bool result = false;

            result = (bool)VisitIf_stmt_condition(context.if_stmt_condition());

            return result;
        }

        public override object VisitIf_stmt_condition(g4.TemplateParser.If_stmt_conditionContext context)
        {
            var left_digital=context.left_op().digital();

            var left_simple_var = context.left_op().simple_variable_inner();

            var left_complex_var = context.left_op().complex_variable_inner();

            string left_value=string.Empty;

            if (left_digital != null)
                left_value = (string)VisitDigital(left_digital);
            else if (left_simple_var != null)
                left_value = (string)VisitSimple_variable_inner(left_simple_var);
            else if (left_complex_var != null)
                left_value = (string)VisitComplex_variable_inner(left_complex_var);
            else
                throw new NotSupportedException();



            var right_digital = context.right_op().digital();

            var right_simple_var = context.right_op().simple_variable_inner();

            var right_complex_var = context.right_op().complex_variable_inner();

            string right_value = string.Empty;

            if (right_digital != null)
                right_value = (string)VisitDigital(right_digital);
            else if (right_simple_var != null)
                right_value = (string)VisitSimple_variable_inner(right_simple_var);
            else if (right_complex_var != null)
                right_value = (string)VisitComplex_variable_inner(right_complex_var);
            else
                throw new NotSupportedException();

            string op = context.op().GetText();

            bool result = false;
            if (op == "=")
                result= left_value==right_value;
            else if (op == ">")
                result = left_value.CompareTo(right_value)>0;
            else if (op == ">=")
                result = left_value.CompareTo(right_value) >= 0;
            else if (op == "<")
                result = left_value.CompareTo(right_value) < 0;
            else if (op == "<=")
                result = left_value.CompareTo(right_value) <= 0;

            return result;
        }

        public override object VisitDigital(g4.TemplateParser.DigitalContext context)
        {
            return context.GetText();
        }

        public override object VisitIf_stmt_conditions_block(g4.TemplateParser.If_stmt_conditions_blockContext context)
        {
            bool result = (bool)VisitIf_stmt_conditions(context.if_stmt_conditions());

            IfStmt_ConditionsResult if_conditions_result = new IfStmt_ConditionsResult();

            if_conditions_result.DoesTestOK = result;
            if_conditions_result.Result = context.if_stmt_conditions_body().GetText();

            return if_conditions_result;
        }
    }
}
