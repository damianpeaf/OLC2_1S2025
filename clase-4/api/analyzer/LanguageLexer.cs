//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Language.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace analyzer {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class LanguageLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, INT=11, WS=12, ID=13;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "INT", "WS", "ID"
	};


	public LanguageLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public LanguageLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'var'", "'='", "';'", "'print('", "')'", "'-'", "'*'", "'/'", "'+'", 
		"'('"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, "INT", 
		"WS", "ID"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Language.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static LanguageLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,13,71,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,
		2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,1,0,1,0,1,0,1,0,
		1,1,1,1,1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,
		7,1,7,1,8,1,8,1,9,1,9,1,10,4,10,56,8,10,11,10,12,10,57,1,11,4,11,61,8,
		11,11,11,12,11,62,1,11,1,11,1,12,4,12,68,8,12,11,12,12,12,69,0,0,13,1,
		1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,1,0,3,1,
		0,48,57,3,0,9,10,13,13,32,32,2,0,65,90,97,122,73,0,1,1,0,0,0,0,3,1,0,0,
		0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,
		0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,
		1,27,1,0,0,0,3,31,1,0,0,0,5,33,1,0,0,0,7,35,1,0,0,0,9,42,1,0,0,0,11,44,
		1,0,0,0,13,46,1,0,0,0,15,48,1,0,0,0,17,50,1,0,0,0,19,52,1,0,0,0,21,55,
		1,0,0,0,23,60,1,0,0,0,25,67,1,0,0,0,27,28,5,118,0,0,28,29,5,97,0,0,29,
		30,5,114,0,0,30,2,1,0,0,0,31,32,5,61,0,0,32,4,1,0,0,0,33,34,5,59,0,0,34,
		6,1,0,0,0,35,36,5,112,0,0,36,37,5,114,0,0,37,38,5,105,0,0,38,39,5,110,
		0,0,39,40,5,116,0,0,40,41,5,40,0,0,41,8,1,0,0,0,42,43,5,41,0,0,43,10,1,
		0,0,0,44,45,5,45,0,0,45,12,1,0,0,0,46,47,5,42,0,0,47,14,1,0,0,0,48,49,
		5,47,0,0,49,16,1,0,0,0,50,51,5,43,0,0,51,18,1,0,0,0,52,53,5,40,0,0,53,
		20,1,0,0,0,54,56,7,0,0,0,55,54,1,0,0,0,56,57,1,0,0,0,57,55,1,0,0,0,57,
		58,1,0,0,0,58,22,1,0,0,0,59,61,7,1,0,0,60,59,1,0,0,0,61,62,1,0,0,0,62,
		60,1,0,0,0,62,63,1,0,0,0,63,64,1,0,0,0,64,65,6,11,0,0,65,24,1,0,0,0,66,
		68,7,2,0,0,67,66,1,0,0,0,68,69,1,0,0,0,69,67,1,0,0,0,69,70,1,0,0,0,70,
		26,1,0,0,0,4,0,57,62,69,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace analyzer
