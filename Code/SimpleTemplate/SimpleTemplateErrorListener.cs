using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplate
{
    class SimpleTemplateErrorListener : Antlr4.Runtime.BaseErrorListener
    {
        private ParseErrorType errorType = ParseErrorType.Successful;
        public ParseErrorType ErrorType
        {
            get
            {
                return this.errorType;
            }
        }


        public override void ReportAmbiguity(Antlr4.Runtime.Parser recognizer, Antlr4.Runtime.Dfa.DFA dfa, int startIndex, int stopIndex, bool exact, Antlr4.Runtime.Sharpen.BitSet ambigAlts, Antlr4.Runtime.Atn.ATNConfigSet configs)
        {
            errorType = ParseErrorType.ReportAmbiguity;
        }

        public override void SyntaxError(Antlr4.Runtime.IRecognizer recognizer, Antlr4.Runtime.IToken offendingSymbol, int line, int charPositionInLine, string msg, Antlr4.Runtime.RecognitionException e)
        {
            errorType = ParseErrorType.SyntaxError;
        }
    }
}
