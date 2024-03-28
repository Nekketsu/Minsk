namespace Minsk.CodeAnalysis.Binding;

internal enum BoundNodeKind
{
    // Statements
    BlockStatement,
    VariableDeclaration,
    IfStatement,
    WhileStatement,
    ForStatement,
    ExpressionStatement,

    // Expressions
    LiteralExpression,
    UnaryExpression,
    AssignmentExpression,
    BinaryExpression,
    VariableExpression,
}
