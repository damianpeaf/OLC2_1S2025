//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./Language.g4 by ANTLR 4.13.2

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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class LanguageParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, INT=26, BOOL=27, FLOAT=28, STRING=29, WS=30, ID=31, COMMENT=32, 
		ML_COMMENT=33;
	public const int
		RULE_program = 0, RULE_dcl = 1, RULE_varDcl = 2, RULE_stmt = 3, RULE_forInit = 4, 
		RULE_expr = 5, RULE_call = 6, RULE_args = 7;
	public static readonly string[] ruleNames = {
		"program", "dcl", "varDcl", "stmt", "forInit", "expr", "call", "args"
	};

	private static readonly string[] _LiteralNames = {
		null, "'var'", "'='", "';'", "'{'", "'}'", "'if'", "'('", "')'", "'else'", 
		"'while'", "'for'", "'break'", "'continue'", "'return'", "'-'", "'*'", 
		"'/'", "'+'", "'>'", "'<'", "'>='", "'<='", "'=='", "'!='", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, "INT", "BOOL", "FLOAT", "STRING", "WS", "ID", "COMMENT", "ML_COMMENT"
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

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static LanguageParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public LanguageParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public LanguageParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgramContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DclContext[] dcl() {
			return GetRuleContexts<DclContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DclContext dcl(int i) {
			return GetRuleContext<DclContext>(i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 3154181330L) != 0)) {
				{
				{
				State = 16;
				dcl();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DclContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VarDclContext varDcl() {
			return GetRuleContext<VarDclContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StmtContext stmt() {
			return GetRuleContext<StmtContext>(0);
		}
		public DclContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dcl; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDcl(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DclContext dcl() {
		DclContext _localctx = new DclContext(Context, State);
		EnterRule(_localctx, 2, RULE_dcl);
		try {
			State = 24;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 22;
				varDcl();
				}
				break;
			case T__3:
			case T__5:
			case T__6:
			case T__9:
			case T__10:
			case T__11:
			case T__12:
			case T__13:
			case T__14:
			case INT:
			case BOOL:
			case FLOAT:
			case STRING:
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 23;
				stmt();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VarDclContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(LanguageParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public VarDclContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_varDcl; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVarDcl(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VarDclContext varDcl() {
		VarDclContext _localctx = new VarDclContext(Context, State);
		EnterRule(_localctx, 4, RULE_varDcl);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26;
			Match(T__0);
			State = 27;
			Match(ID);
			State = 28;
			Match(T__1);
			State = 29;
			expr(0);
			State = 30;
			Match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StmtContext : ParserRuleContext {
		public StmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stmt; } }
	 
		public StmtContext() { }
		public virtual void CopyFrom(StmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ContinueStmtContext : StmtContext {
		public ContinueStmtContext(StmtContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitContinueStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IfStmtContext : StmtContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StmtContext[] stmt() {
			return GetRuleContexts<StmtContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StmtContext stmt(int i) {
			return GetRuleContext<StmtContext>(i);
		}
		public IfStmtContext(StmtContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIfStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExprStmtContext : StmtContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ExprStmtContext(StmtContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class WhileStmtContext : StmtContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StmtContext stmt() {
			return GetRuleContext<StmtContext>(0);
		}
		public WhileStmtContext(StmtContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWhileStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BreakStmtContext : StmtContext {
		public BreakStmtContext(StmtContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBreakStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BlockStmtContext : StmtContext {
		[System.Diagnostics.DebuggerNonUserCode] public DclContext[] dcl() {
			return GetRuleContexts<DclContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DclContext dcl(int i) {
			return GetRuleContext<DclContext>(i);
		}
		public BlockStmtContext(StmtContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlockStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ForStmtContext : StmtContext {
		[System.Diagnostics.DebuggerNonUserCode] public ForInitContext forInit() {
			return GetRuleContext<ForInitContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StmtContext stmt() {
			return GetRuleContext<StmtContext>(0);
		}
		public ForStmtContext(StmtContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitForStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ReturnStmtContext : StmtContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ReturnStmtContext(StmtContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitReturnStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StmtContext stmt() {
		StmtContext _localctx = new StmtContext(Context, State);
		EnterRule(_localctx, 6, RULE_stmt);
		int _la;
		try {
			State = 76;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__6:
			case T__14:
			case INT:
			case BOOL:
			case FLOAT:
			case STRING:
			case ID:
				_localctx = new ExprStmtContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 32;
				expr(0);
				State = 33;
				Match(T__2);
				}
				break;
			case T__3:
				_localctx = new BlockStmtContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 35;
				Match(T__3);
				State = 39;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 3154181330L) != 0)) {
					{
					{
					State = 36;
					dcl();
					}
					}
					State = 41;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 42;
				Match(T__4);
				}
				break;
			case T__5:
				_localctx = new IfStmtContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 43;
				Match(T__5);
				State = 44;
				Match(T__6);
				State = 45;
				expr(0);
				State = 46;
				Match(T__7);
				State = 47;
				stmt();
				State = 50;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
				case 1:
					{
					State = 48;
					Match(T__8);
					State = 49;
					stmt();
					}
					break;
				}
				}
				break;
			case T__9:
				_localctx = new WhileStmtContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 52;
				Match(T__9);
				State = 53;
				Match(T__6);
				State = 54;
				expr(0);
				State = 55;
				Match(T__7);
				State = 56;
				stmt();
				}
				break;
			case T__10:
				_localctx = new ForStmtContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 58;
				Match(T__10);
				State = 59;
				Match(T__6);
				State = 60;
				forInit();
				State = 61;
				expr(0);
				State = 62;
				Match(T__2);
				State = 63;
				expr(0);
				State = 64;
				Match(T__7);
				State = 65;
				stmt();
				}
				break;
			case T__11:
				_localctx = new BreakStmtContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 67;
				Match(T__11);
				State = 68;
				Match(T__2);
				}
				break;
			case T__12:
				_localctx = new ContinueStmtContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 69;
				Match(T__12);
				State = 70;
				Match(T__2);
				}
				break;
			case T__13:
				_localctx = new ReturnStmtContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 71;
				Match(T__13);
				State = 73;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & 3154149504L) != 0)) {
					{
					State = 72;
					expr(0);
					}
				}

				State = 75;
				Match(T__2);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ForInitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VarDclContext varDcl() {
			return GetRuleContext<VarDclContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ForInitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forInit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitForInit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ForInitContext forInit() {
		ForInitContext _localctx = new ForInitContext(Context, State);
		EnterRule(_localctx, 8, RULE_forInit);
		try {
			State = 82;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 78;
				varDcl();
				}
				break;
			case T__6:
			case T__14:
			case INT:
			case BOOL:
			case FLOAT:
			case STRING:
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 79;
				expr(0);
				State = 80;
				Match(T__2);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class CalleeContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CallContext[] call() {
			return GetRuleContexts<CallContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CallContext call(int i) {
			return GetRuleContext<CallContext>(i);
		}
		public CalleeContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCallee(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MulDivContext : ExprContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public MulDivContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMulDiv(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AddSubContext : ExprContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public AddSubContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddSub(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParensContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ParensContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParens(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RelationalContext : ExprContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public RelationalContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRelational(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StringContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING() { return GetToken(LanguageParser.STRING, 0); }
		public StringContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IntContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(LanguageParser.INT, 0); }
		public IntContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class FloatContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FLOAT() { return GetToken(LanguageParser.FLOAT, 0); }
		public FloatContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFloat(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdentifierContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(LanguageParser.ID, 0); }
		public IdentifierContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifier(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AssignContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(LanguageParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public AssignContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAssign(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NegateContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public NegateContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNegate(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class EqualityContext : ExprContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public EqualityContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEquality(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BooleanContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOL() { return GetToken(LanguageParser.BOOL, 0); }
		public BooleanContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBoolean(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 10;
		EnterRecursionRule(_localctx, 10, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 99;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
			case 1:
				{
				_localctx = new NegateContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 85;
				Match(T__14);
				State = 86;
				expr(13);
				}
				break;
			case 2:
				{
				_localctx = new AssignContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 87;
				Match(ID);
				State = 88;
				Match(T__1);
				State = 89;
				expr(7);
				}
				break;
			case 3:
				{
				_localctx = new BooleanContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 90;
				Match(BOOL);
				}
				break;
			case 4:
				{
				_localctx = new FloatContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 91;
				Match(FLOAT);
				}
				break;
			case 5:
				{
				_localctx = new StringContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 92;
				Match(STRING);
				}
				break;
			case 6:
				{
				_localctx = new IntContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 93;
				Match(INT);
				}
				break;
			case 7:
				{
				_localctx = new IdentifierContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 94;
				Match(ID);
				}
				break;
			case 8:
				{
				_localctx = new ParensContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 95;
				Match(T__6);
				State = 96;
				expr(0);
				State = 97;
				Match(T__7);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 121;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,10,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 119;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,9,Context) ) {
					case 1:
						{
						_localctx = new MulDivContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 101;
						if (!(Precpred(Context, 11))) throw new FailedPredicateException(this, "Precpred(Context, 11)");
						State = 102;
						((MulDivContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==T__15 || _la==T__16) ) {
							((MulDivContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 103;
						expr(12);
						}
						break;
					case 2:
						{
						_localctx = new AddSubContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 104;
						if (!(Precpred(Context, 10))) throw new FailedPredicateException(this, "Precpred(Context, 10)");
						State = 105;
						((AddSubContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==T__14 || _la==T__17) ) {
							((AddSubContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 106;
						expr(11);
						}
						break;
					case 3:
						{
						_localctx = new RelationalContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 107;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 108;
						((RelationalContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 7864320L) != 0)) ) {
							((RelationalContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 109;
						expr(10);
						}
						break;
					case 4:
						{
						_localctx = new EqualityContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 110;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 111;
						((EqualityContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==T__22 || _la==T__23) ) {
							((EqualityContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 112;
						expr(9);
						}
						break;
					case 5:
						{
						_localctx = new CalleeContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 113;
						if (!(Precpred(Context, 12))) throw new FailedPredicateException(this, "Precpred(Context, 12)");
						State = 115;
						ErrorHandler.Sync(this);
						_alt = 1;
						do {
							switch (_alt) {
							case 1:
								{
								{
								State = 114;
								call();
								}
								}
								break;
							default:
								throw new NoViableAltException(this);
							}
							State = 117;
							ErrorHandler.Sync(this);
							_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
						} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
						}
						break;
					}
					} 
				}
				State = 123;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,10,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class CallContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ArgsContext args() {
			return GetRuleContext<ArgsContext>(0);
		}
		public CallContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_call; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCall(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CallContext call() {
		CallContext _localctx = new CallContext(Context, State);
		EnterRule(_localctx, 12, RULE_call);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 124;
			Match(T__6);
			State = 126;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & 3154149504L) != 0)) {
				{
				State = 125;
				args();
				}
			}

			State = 128;
			Match(T__7);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArgsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ArgsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_args; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILanguageVisitor<TResult> typedVisitor = visitor as ILanguageVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArgs(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ArgsContext args() {
		ArgsContext _localctx = new ArgsContext(Context, State);
		EnterRule(_localctx, 14, RULE_args);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 130;
			expr(0);
			State = 135;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__24) {
				{
				{
				State = 131;
				Match(T__24);
				State = 132;
				expr(0);
				}
				}
				State = 137;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 5: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 11);
		case 1: return Precpred(Context, 10);
		case 2: return Precpred(Context, 9);
		case 3: return Precpred(Context, 8);
		case 4: return Precpred(Context, 12);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,33,139,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,1,0,5,0,18,8,0,10,0,12,0,21,9,0,1,1,1,1,3,1,25,8,1,1,2,1,2,1,2,1,2,
		1,2,1,2,1,3,1,3,1,3,1,3,1,3,5,3,38,8,3,10,3,12,3,41,9,3,1,3,1,3,1,3,1,
		3,1,3,1,3,1,3,1,3,3,3,51,8,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,
		3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,3,3,74,8,3,1,3,3,3,77,8,3,1,
		4,1,4,1,4,1,4,3,4,83,8,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,
		5,1,5,1,5,1,5,3,5,100,8,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,
		1,5,1,5,1,5,4,5,116,8,5,11,5,12,5,117,5,5,120,8,5,10,5,12,5,123,9,5,1,
		6,1,6,3,6,127,8,6,1,6,1,6,1,7,1,7,1,7,5,7,134,8,7,10,7,12,7,137,9,7,1,
		7,0,1,10,8,0,2,4,6,8,10,12,14,0,4,1,0,16,17,2,0,15,15,18,18,1,0,19,22,
		1,0,23,24,158,0,19,1,0,0,0,2,24,1,0,0,0,4,26,1,0,0,0,6,76,1,0,0,0,8,82,
		1,0,0,0,10,99,1,0,0,0,12,124,1,0,0,0,14,130,1,0,0,0,16,18,3,2,1,0,17,16,
		1,0,0,0,18,21,1,0,0,0,19,17,1,0,0,0,19,20,1,0,0,0,20,1,1,0,0,0,21,19,1,
		0,0,0,22,25,3,4,2,0,23,25,3,6,3,0,24,22,1,0,0,0,24,23,1,0,0,0,25,3,1,0,
		0,0,26,27,5,1,0,0,27,28,5,31,0,0,28,29,5,2,0,0,29,30,3,10,5,0,30,31,5,
		3,0,0,31,5,1,0,0,0,32,33,3,10,5,0,33,34,5,3,0,0,34,77,1,0,0,0,35,39,5,
		4,0,0,36,38,3,2,1,0,37,36,1,0,0,0,38,41,1,0,0,0,39,37,1,0,0,0,39,40,1,
		0,0,0,40,42,1,0,0,0,41,39,1,0,0,0,42,77,5,5,0,0,43,44,5,6,0,0,44,45,5,
		7,0,0,45,46,3,10,5,0,46,47,5,8,0,0,47,50,3,6,3,0,48,49,5,9,0,0,49,51,3,
		6,3,0,50,48,1,0,0,0,50,51,1,0,0,0,51,77,1,0,0,0,52,53,5,10,0,0,53,54,5,
		7,0,0,54,55,3,10,5,0,55,56,5,8,0,0,56,57,3,6,3,0,57,77,1,0,0,0,58,59,5,
		11,0,0,59,60,5,7,0,0,60,61,3,8,4,0,61,62,3,10,5,0,62,63,5,3,0,0,63,64,
		3,10,5,0,64,65,5,8,0,0,65,66,3,6,3,0,66,77,1,0,0,0,67,68,5,12,0,0,68,77,
		5,3,0,0,69,70,5,13,0,0,70,77,5,3,0,0,71,73,5,14,0,0,72,74,3,10,5,0,73,
		72,1,0,0,0,73,74,1,0,0,0,74,75,1,0,0,0,75,77,5,3,0,0,76,32,1,0,0,0,76,
		35,1,0,0,0,76,43,1,0,0,0,76,52,1,0,0,0,76,58,1,0,0,0,76,67,1,0,0,0,76,
		69,1,0,0,0,76,71,1,0,0,0,77,7,1,0,0,0,78,83,3,4,2,0,79,80,3,10,5,0,80,
		81,5,3,0,0,81,83,1,0,0,0,82,78,1,0,0,0,82,79,1,0,0,0,83,9,1,0,0,0,84,85,
		6,5,-1,0,85,86,5,15,0,0,86,100,3,10,5,13,87,88,5,31,0,0,88,89,5,2,0,0,
		89,100,3,10,5,7,90,100,5,27,0,0,91,100,5,28,0,0,92,100,5,29,0,0,93,100,
		5,26,0,0,94,100,5,31,0,0,95,96,5,7,0,0,96,97,3,10,5,0,97,98,5,8,0,0,98,
		100,1,0,0,0,99,84,1,0,0,0,99,87,1,0,0,0,99,90,1,0,0,0,99,91,1,0,0,0,99,
		92,1,0,0,0,99,93,1,0,0,0,99,94,1,0,0,0,99,95,1,0,0,0,100,121,1,0,0,0,101,
		102,10,11,0,0,102,103,7,0,0,0,103,120,3,10,5,12,104,105,10,10,0,0,105,
		106,7,1,0,0,106,120,3,10,5,11,107,108,10,9,0,0,108,109,7,2,0,0,109,120,
		3,10,5,10,110,111,10,8,0,0,111,112,7,3,0,0,112,120,3,10,5,9,113,115,10,
		12,0,0,114,116,3,12,6,0,115,114,1,0,0,0,116,117,1,0,0,0,117,115,1,0,0,
		0,117,118,1,0,0,0,118,120,1,0,0,0,119,101,1,0,0,0,119,104,1,0,0,0,119,
		107,1,0,0,0,119,110,1,0,0,0,119,113,1,0,0,0,120,123,1,0,0,0,121,119,1,
		0,0,0,121,122,1,0,0,0,122,11,1,0,0,0,123,121,1,0,0,0,124,126,5,7,0,0,125,
		127,3,14,7,0,126,125,1,0,0,0,126,127,1,0,0,0,127,128,1,0,0,0,128,129,5,
		8,0,0,129,13,1,0,0,0,130,135,3,10,5,0,131,132,5,25,0,0,132,134,3,10,5,
		0,133,131,1,0,0,0,134,137,1,0,0,0,135,133,1,0,0,0,135,136,1,0,0,0,136,
		15,1,0,0,0,137,135,1,0,0,0,13,19,24,39,50,73,76,82,99,117,119,121,126,
		135
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace analyzer
