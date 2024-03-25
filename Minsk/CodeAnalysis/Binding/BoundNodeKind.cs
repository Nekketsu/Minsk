namespace Minsk.CodeAnalysis.Binding;

internal enum BoundNodeKind
{
    // Statements
    BlockStatement,
    VariableDeclaration,
    ExpressionStatement,

    // Expressions
    LiteralExpression,
    UnaryExpression,
    AssignmentExpression,
    BinaryExpression,
    VariableExpression,
}
