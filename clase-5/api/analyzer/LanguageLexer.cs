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
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, INT=22, BOOL=23, FLOAT=24, STRING=25, 
		WS=26, ID=27;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "INT", "BOOL", "FLOAT", "STRING", 
		"WS", "ID"
	};


	public LanguageLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public LanguageLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'var'", "'='", "';'", "'print('", "')'", "'{'", "'}'", "'if'", 
		"'('", "'else'", "'while'", "'-'", "'*'", "'/'", "'+'", "'>'", "'<'", 
		"'>='", "'<='", "'=='", "'!='"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, "INT", "BOOL", 
		"FLOAT", "STRING", "WS", "ID"
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
		4,0,27,164,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,1,0,1,0,1,0,1,0,
		1,1,1,1,1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,
		7,1,7,1,7,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,10,1,10,1,
		11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,1,15,1,15,1,16,1,16,1,17,1,17,1,
		17,1,18,1,18,1,18,1,19,1,19,1,19,1,20,1,20,1,20,1,21,4,21,118,8,21,11,
		21,12,21,119,1,22,1,22,1,22,1,22,1,22,1,22,1,22,1,22,1,22,3,22,131,8,22,
		1,23,4,23,134,8,23,11,23,12,23,135,1,23,1,23,4,23,140,8,23,11,23,12,23,
		141,1,24,1,24,5,24,146,8,24,10,24,12,24,149,9,24,1,24,1,24,1,25,4,25,154,
		8,25,11,25,12,25,155,1,25,1,25,1,26,4,26,161,8,26,11,26,12,26,162,0,0,
		27,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,
		14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,
		26,53,27,1,0,4,1,0,48,57,1,0,34,34,3,0,9,10,13,13,32,32,2,0,65,90,97,122,
		170,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,
		0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,
		0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,
		1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,
		0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,1,55,
		1,0,0,0,3,59,1,0,0,0,5,61,1,0,0,0,7,63,1,0,0,0,9,70,1,0,0,0,11,72,1,0,
		0,0,13,74,1,0,0,0,15,76,1,0,0,0,17,79,1,0,0,0,19,81,1,0,0,0,21,86,1,0,
		0,0,23,92,1,0,0,0,25,94,1,0,0,0,27,96,1,0,0,0,29,98,1,0,0,0,31,100,1,0,
		0,0,33,102,1,0,0,0,35,104,1,0,0,0,37,107,1,0,0,0,39,110,1,0,0,0,41,113,
		1,0,0,0,43,117,1,0,0,0,45,130,1,0,0,0,47,133,1,0,0,0,49,143,1,0,0,0,51,
		153,1,0,0,0,53,160,1,0,0,0,55,56,5,118,0,0,56,57,5,97,0,0,57,58,5,114,
		0,0,58,2,1,0,0,0,59,60,5,61,0,0,60,4,1,0,0,0,61,62,5,59,0,0,62,6,1,0,0,
		0,63,64,5,112,0,0,64,65,5,114,0,0,65,66,5,105,0,0,66,67,5,110,0,0,67,68,
		5,116,0,0,68,69,5,40,0,0,69,8,1,0,0,0,70,71,5,41,0,0,71,10,1,0,0,0,72,
		73,5,123,0,0,73,12,1,0,0,0,74,75,5,125,0,0,75,14,1,0,0,0,76,77,5,105,0,
		0,77,78,5,102,0,0,78,16,1,0,0,0,79,80,5,40,0,0,80,18,1,0,0,0,81,82,5,101,
		0,0,82,83,5,108,0,0,83,84,5,115,0,0,84,85,5,101,0,0,85,20,1,0,0,0,86,87,
		5,119,0,0,87,88,5,104,0,0,88,89,5,105,0,0,89,90,5,108,0,0,90,91,5,101,
		0,0,91,22,1,0,0,0,92,93,5,45,0,0,93,24,1,0,0,0,94,95,5,42,0,0,95,26,1,
		0,0,0,96,97,5,47,0,0,97,28,1,0,0,0,98,99,5,43,0,0,99,30,1,0,0,0,100,101,
		5,62,0,0,101,32,1,0,0,0,102,103,5,60,0,0,103,34,1,0,0,0,104,105,5,62,0,
		0,105,106,5,61,0,0,106,36,1,0,0,0,107,108,5,60,0,0,108,109,5,61,0,0,109,
		38,1,0,0,0,110,111,5,61,0,0,111,112,5,61,0,0,112,40,1,0,0,0,113,114,5,
		33,0,0,114,115,5,61,0,0,115,42,1,0,0,0,116,118,7,0,0,0,117,116,1,0,0,0,
		118,119,1,0,0,0,119,117,1,0,0,0,119,120,1,0,0,0,120,44,1,0,0,0,121,122,
		5,116,0,0,122,123,5,114,0,0,123,124,5,117,0,0,124,131,5,101,0,0,125,126,
		5,102,0,0,126,127,5,97,0,0,127,128,5,108,0,0,128,129,5,115,0,0,129,131,
		5,101,0,0,130,121,1,0,0,0,130,125,1,0,0,0,131,46,1,0,0,0,132,134,7,0,0,
		0,133,132,1,0,0,0,134,135,1,0,0,0,135,133,1,0,0,0,135,136,1,0,0,0,136,
		137,1,0,0,0,137,139,5,46,0,0,138,140,7,0,0,0,139,138,1,0,0,0,140,141,1,
		0,0,0,141,139,1,0,0,0,141,142,1,0,0,0,142,48,1,0,0,0,143,147,5,34,0,0,
		144,146,8,1,0,0,145,144,1,0,0,0,146,149,1,0,0,0,147,145,1,0,0,0,147,148,
		1,0,0,0,148,150,1,0,0,0,149,147,1,0,0,0,150,151,5,34,0,0,151,50,1,0,0,
		0,152,154,7,2,0,0,153,152,1,0,0,0,154,155,1,0,0,0,155,153,1,0,0,0,155,
		156,1,0,0,0,156,157,1,0,0,0,157,158,6,25,0,0,158,52,1,0,0,0,159,161,7,
		3,0,0,160,159,1,0,0,0,161,162,1,0,0,0,162,160,1,0,0,0,162,163,1,0,0,0,
		163,54,1,0,0,0,8,0,119,130,135,141,147,155,162,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace analyzer
