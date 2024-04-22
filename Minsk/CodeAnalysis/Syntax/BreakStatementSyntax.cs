namespace Minsk.CodeAnalysis.Syntax
{
    public class BreakStatementSyntax : StatementSyntax
    {
        public BreakStatementSyntax(SyntaxToken keyword)
        {
            Keyword = keyword;
        }

        public override SyntaxKind Kind => SyntaxKind.BreakStatement;
        public SyntaxToken Keyword { get; }
    }
}
