namespace Minsk.CodeAnalysis.Binding;

internal enum BoundNodeKind
{
    // Statements
    BlockStatement,
    VariableDeclaration,
    IfStatement,
    ExpressionStatement,

    // Expressions
    LiteralExpression,
    UnaryExpression,
    AssignmentExpression,
    BinaryExpression,
    VariableExpression,
}
