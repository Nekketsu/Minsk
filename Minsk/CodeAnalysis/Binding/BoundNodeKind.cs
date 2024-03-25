namespace Minsk.CodeAnalysis.Binding;

internal enum BoundNodeKind
{
    // Statements
    BlockStatement,
    ExpressionStatement,

    // Expressions
    LiteralExpression,
    UnaryExpression,
    AssignmentExpression,
    BinaryExpression,
    VariableExpression,
}
