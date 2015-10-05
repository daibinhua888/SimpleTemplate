//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Administrator\Documents\Visual Studio 2012\Projects\SimpleTemplate\SimpleTemplate\g4\Template.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace SimpleTemplate.g4 {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="TemplateParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface ITemplateVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] TemplateParser.CompileUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParse([NotNull] TemplateParser.ParseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] TemplateParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.repeater_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeater_stmt([NotNull] TemplateParser.Repeater_stmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.repeater_stmt_begin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeater_stmt_begin([NotNull] TemplateParser.Repeater_stmt_beginContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.repeater_stmt_end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeater_stmt_end([NotNull] TemplateParser.Repeater_stmt_endContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.repeater_stmt_count"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeater_stmt_count([NotNull] TemplateParser.Repeater_stmt_countContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.newlines"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewlines([NotNull] TemplateParser.NewlinesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.stringtext"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringtext([NotNull] TemplateParser.StringtextContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.placeholderChar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPlaceholderChar([NotNull] TemplateParser.PlaceholderCharContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.simple_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple_variable([NotNull] TemplateParser.Simple_variableContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.complex_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComplex_variable([NotNull] TemplateParser.Complex_variableContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.simple_variable_inner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple_variable_inner([NotNull] TemplateParser.Simple_variable_innerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.complex_variable_inner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComplex_variable_inner([NotNull] TemplateParser.Complex_variable_innerContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.identity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentity([NotNull] TemplateParser.IdentityContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="TemplateParser.digital"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDigital([NotNull] TemplateParser.DigitalContext context);
}
} // namespace SimpleTemplate.g4