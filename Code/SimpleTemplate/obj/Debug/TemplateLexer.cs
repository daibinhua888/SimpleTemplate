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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class TemplateLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, NEWLINE=12, NUMBER=13, CHAR=14, UNDERLINE=15, SPACE=16, 
		DOT=17, V_START=18, V_END=19;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "NEWLINE", "NUMBER", "CHAR", "UNDERLINE", "SPACE", "DOT", 
		"V_START", "V_END"
	};


	public TemplateLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'repeat'", "'end repeat'", "':'", "'''", "'\"'", "'<'", "'>'", 
		"'+'", "'-'", "'*'", "'/'", null, null, null, "'_'", "' '", "'.'", "'@{'", 
		"'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"NEWLINE", "NUMBER", "CHAR", "UNDERLINE", "SPACE", "DOT", "V_START", "V_END"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Template.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x15\x61\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3"+
		"\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x5\rO\n"+
		"\r\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12"+
		"\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x2\x2\x2\x15\x3\x2\x3\x5\x2"+
		"\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17"+
		"\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14"+
		"\'\x2\x15\x3\x2\x3\x4\x2\x43\\\x63|\x61\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2"+
		"\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2"+
		"\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3"+
		"\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2"+
		"\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2"+
		"%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x3)\x3\x2\x2\x2\x5\x30\x3\x2\x2\x2\a;\x3"+
		"\x2\x2\x2\t=\x3\x2\x2\x2\v?\x3\x2\x2\x2\r\x41\x3\x2\x2\x2\xF\x43\x3\x2"+
		"\x2\x2\x11\x45\x3\x2\x2\x2\x13G\x3\x2\x2\x2\x15I\x3\x2\x2\x2\x17K\x3\x2"+
		"\x2\x2\x19N\x3\x2\x2\x2\x1BR\x3\x2\x2\x2\x1DT\x3\x2\x2\x2\x1FV\x3\x2\x2"+
		"\x2!X\x3\x2\x2\x2#Z\x3\x2\x2\x2%\\\x3\x2\x2\x2\'_\x3\x2\x2\x2)*\at\x2"+
		"\x2*+\ag\x2\x2+,\ar\x2\x2,-\ag\x2\x2-.\a\x63\x2\x2./\av\x2\x2/\x4\x3\x2"+
		"\x2\x2\x30\x31\ag\x2\x2\x31\x32\ap\x2\x2\x32\x33\a\x66\x2\x2\x33\x34\a"+
		"\"\x2\x2\x34\x35\at\x2\x2\x35\x36\ag\x2\x2\x36\x37\ar\x2\x2\x37\x38\a"+
		"g\x2\x2\x38\x39\a\x63\x2\x2\x39:\av\x2\x2:\x6\x3\x2\x2\x2;<\a<\x2\x2<"+
		"\b\x3\x2\x2\x2=>\a)\x2\x2>\n\x3\x2\x2\x2?@\a$\x2\x2@\f\x3\x2\x2\x2\x41"+
		"\x42\a>\x2\x2\x42\xE\x3\x2\x2\x2\x43\x44\a@\x2\x2\x44\x10\x3\x2\x2\x2"+
		"\x45\x46\a-\x2\x2\x46\x12\x3\x2\x2\x2GH\a/\x2\x2H\x14\x3\x2\x2\x2IJ\a"+
		",\x2\x2J\x16\x3\x2\x2\x2KL\a\x31\x2\x2L\x18\x3\x2\x2\x2MO\a\xF\x2\x2N"+
		"M\x3\x2\x2\x2NO\x3\x2\x2\x2OP\x3\x2\x2\x2PQ\a\f\x2\x2Q\x1A\x3\x2\x2\x2"+
		"RS\x4\x32;\x2S\x1C\x3\x2\x2\x2TU\t\x2\x2\x2U\x1E\x3\x2\x2\x2VW\a\x61\x2"+
		"\x2W \x3\x2\x2\x2XY\a\"\x2\x2Y\"\x3\x2\x2\x2Z[\a\x30\x2\x2[$\x3\x2\x2"+
		"\x2\\]\a\x42\x2\x2]^\a}\x2\x2^&\x3\x2\x2\x2_`\a\x7F\x2\x2`(\x3\x2\x2\x2"+
		"\x4\x2N\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace SimpleTemplate.g4
