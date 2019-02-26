using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DotNext.Metaprogramming
{
    /// <summary>
    /// Provides extension methods to simplify construction of complex expressions.
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// Constructs unary plus expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>+a</code>
        /// </remarks>
        /// <param name="expression">The operand.</param>
        /// <returns>Unary expression.</returns>
        public static UnaryExpression UnaryPlus(this Expression expression)
            => Expression.UnaryPlus(expression);

        /// <summary>
        /// Constructs negate expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>-a</code>
        /// </remarks>
        /// <param name="expression">The operand.</param>
        /// <returns>Unary expression.</returns>
        public static UnaryExpression Negate(this Expression expression)
            => Expression.Negate(expression);

        /// <summary>
        /// Constructs logical NOT expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>!a</code>
        /// </remarks>
        /// <param name="expression">The operand.</param>
        /// <returns>Unary expression.</returns>
        public static UnaryExpression Not(this Expression expression)
            => Expression.Not(expression);

        /// <summary>
        /// Constructs ones complement.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>~a</code>
        /// </remarks>
        /// <param name="expression">The operand.</param>
        /// <returns>Unary expression.</returns>
        public static UnaryExpression OnesComplement(this Expression expression)
            => Expression.OnesComplement(expression);

        /// <summary>
        /// Constructs binary logical AND expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a &amp; b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression And(this Expression left, Expression right)
            => Expression.And(left, right);

        /// <summary>
        /// Constructs binary logical OR expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a | b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Or(this Expression left, Expression right)
            => Expression.Or(left, right);

        /// <summary>
        /// Constructs binary logical XOR expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a ^ b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Xor(this Expression left, Expression right)
            => Expression.ExclusiveOr(left, right);

        /// <summary>
        /// Constructs arithmetic remainder expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a % b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Modulo(this Expression left, Expression right)
            => Expression.Modulo(left, right);

        /// <summary>
        /// Constructs binary arithmetic addition expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a + b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Add(this Expression left, Expression right)
            => Expression.Add(left, right);

        /// <summary>
        /// Constructs binary arithmetic subtraction expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a - b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Subtract(this Expression left, Expression right)
            => Expression.Subtract(left, right);

        /// <summary>
        /// Constructs binary arithmetic multiplication expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a * b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Multiply(this Expression left, Expression right)
            => Expression.Multiply(left, right);

        /// <summary>
        /// Constructs binary arithmetic division expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a / b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Divide(this Expression left, Expression right)
            => Expression.Divide(left, right);

        /// <summary>
        /// Constructs "greater than" numeric comparison.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a &gt; b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression GreaterThan(this Expression left, Expression right)
            => Expression.GreaterThan(left, right);

        /// <summary>
        /// Constructs "less than" numeric comparison.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a &lt; b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression LessThan(this Expression left, Expression right)
            => Expression.LessThan(left, right);

        /// <summary>
        /// Constructs "greater than or equal" numeric comparison.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a &gt;= b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression GreaterThanOrEqual(this Expression left, Expression right)
            => Expression.GreaterThanOrEqual(left, right);

        /// <summary>
        /// Constructs "less than or equal" numeric comparison.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a &lt;= b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression LessThanOrEqual(this Expression left, Expression right)
            => Expression.LessThanOrEqual(left, right);

        /// <summary>
        /// Constructs equality comparison.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a == b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Equal(this Expression left, Expression right)
            => Expression.Equal(left, right);

        /// <summary>
        /// Constructs inequality comparison.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a != b</code>
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression NotEqual(this Expression left, Expression right)
            => Expression.NotEqual(left, right);

        /// <summary>
        /// Constructs <see langword="null"/> check.
        /// </summary>
        /// <param name="operand">The operand.</param>
        /// <returns><see langword="null"/> check operation.</returns>
        public static BinaryExpression IsNull(this Expression operand)
            => Expression.ReferenceEqual(operand, Expression.Constant(null, operand.Type));

        /// <summary>
        /// Constructs raising a number to a power expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a ^ b</code> in Visual Basic.
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Power(this Expression left, Expression right)
            => Expression.Power(left, right);

        /// <summary>
        /// Constructs bitwise left-shift expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a &lt;&lt; b</code> in Visual Basic.
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression LeftShift(this Expression left, Expression right)
            => Expression.LeftShift(left, right);

        /// <summary>
        /// Constructs bitwise right-shift expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>a &gt;&gt; b</code> in Visual Basic.
        /// </remarks>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression RightShift(this Expression left, Expression right)
            => Expression.RightShift(left, right);

        /// <summary>
        /// Constructs an expression that decrements given expression by 1 and assigns the result back to the expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>--i</code>.
        /// </remarks>
        /// <param name="operand">The operand.</param>
        /// <returns>Unary expression.</returns>
        public static UnaryExpression PreDecrementAssign(this Expression operand)
            => Expression.PreDecrementAssign(operand);

        /// <summary>
        /// Constructs an expression that increments given expression by 1 and assigns the result back to the expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>++i</code>.
        /// </remarks>
        /// <param name="operand">The operand.</param>
        /// <returns>Unary expression.</returns>
        public static UnaryExpression PreIncrementAssign(this Expression operand)
            => Expression.PreIncrementAssign(operand);

        /// <summary>
        /// Constructs an expression that represents the assignment of given expression followed by a subsequent decrement by 1 of the original expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>i--</code>.
        /// </remarks>
        /// <param name="operand">The operand.</param>
        /// <returns>Unary expression.</returns>
        public static UnaryExpression PostDecrementAssign(this Expression operand)
            => Expression.PostDecrementAssign(operand);

        /// <summary>
        /// Constructs an expression that represents the assignment of given expression followed by a subsequent increment by 1 of the original expression.
        /// </summary>
        /// <remarks>
        /// The equal code is <code>i++</code>.
        /// </remarks>
        /// <param name="operand">The operand.</param>
        /// <returns>Unary expression.</returns>
        public static UnaryExpression PostIncrementAssign(this Expression operand)
            => Expression.PostIncrementAssign(operand);

        /// <summary>
        /// Constructs assignment expression.
        /// </summary>
        /// <param name="left">The assignee.</param>
        /// <param name="value">The value to be assigned to the left expression.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Assign(this ParameterExpression left, Expression value)
            => Expression.Assign(left, value);

        /// <summary>
        /// Constructs assignment expression.
        /// </summary>
        /// <param name="left">The assignee.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression AssignDefault(this ParameterExpression left)
            => left.Assign(left.Type.AsDefault());

        /// <summary>
        /// Constructs assignment expression.
        /// </summary>
        /// <param name="left">The assignee.</param>
        /// <param name="value">The value to be assigned to the left expression.</param>
        /// <returns>Binary expression.</returns>
        public static BinaryExpression Assign(this MemberExpression left, Expression value)
            => Expression.Assign(left, value);

        public static BinaryExpression Assign(this IndexExpression left, Expression value)
            => Expression.Assign(left, value);

        public static UnaryExpression Convert(this Expression expression, Type targetType)
            => Expression.Convert(expression, targetType);

        public static UnaryExpression Convert<T>(this Expression expression)
            => expression.Convert(typeof(T));

        public static TypeBinaryExpression InstanceOf(this Expression expression, Type type)
            => Expression.TypeIs(expression, type);

        public static TypeBinaryExpression InstanceOf<T>(this Expression expression)
            => expression.InstanceOf(typeof(T));

        public static UnaryExpression TryConvert(this Expression expression, Type type)
            => Expression.TypeAs(expression, type);

        public static UnaryExpression TryConvert<T>(this Expression expression)
            => expression.TryConvert(typeof(T));

        public static BinaryExpression AndAlso(this Expression left, Expression right)
            => Expression.AndAlso(left, right);

        public static BinaryExpression OrElse(this Expression left, Expression right)
            => Expression.OrElse(left, right);

        public static AwaitExpression Await(this Expression expression)
            => new AwaitExpression(expression);

        public static UnaryExpression Unbox(this Expression expression, Type type)
            => Expression.Unbox(expression, type);

        public static UnaryExpression Unbox<T>(this Expression expression)
            where T : struct
            => expression.Unbox(typeof(T));

        public static InvocationExpression Invoke(this Expression @delegate, params Expression[] arguments)
            => Expression.Invoke(@delegate, arguments);

        public static MethodCallExpression Call(this Expression instance, MethodInfo method, params Expression[] arguments)
            => Expression.Call(instance, method, arguments);

        public static MethodCallExpression Call(this Expression instance, string methodName, params Expression[] arguments)
            => instance.Call(instance.Type, methodName, arguments);

        public static MethodCallExpression Call(this Expression instance, Type interfaceType, string methodName, params Expression[] arguments)
        {
            if (!interfaceType.IsAssignableFrom(instance.Type))
                throw new ArgumentException(ExceptionMessages.InterfaceNotImplemented(instance.Type, interfaceType));
            var method = interfaceType.GetMethod(methodName, arguments.Convert(arg => arg.Type));
            return method is null ?
                throw new MissingMethodException(ExceptionMessages.MissingMethod(methodName, interfaceType)) :
                instance.Call(method, arguments);
        }

        public static Expression Property(this Expression instance, PropertyInfo property, params Expression[] indicies)
            => indicies.LongLength == 0 ? (Expression)Expression.Property(instance, property) : Expression.Property(instance, property, indicies);

        public static Expression Property(this Expression instance, Type interfaceType, string propertyName, params Expression[] indicies)
        {
            var property = interfaceType.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            return property is null ?
                throw new MissingMemberException(ExceptionMessages.MissingProperty(propertyName, interfaceType)) :
                instance.Property(property, indicies);
        }

        public static Expression Property(this Expression instance, string propertyName, params Expression[] indicies)
            => Expression.Property(instance, propertyName, indicies);

        public static MemberExpression Field(this Expression instance, FieldInfo field)
            => Expression.Field(instance, field);

        public static MemberExpression Field(this Expression instance, string fieldName)
            => Expression.Field(instance, fieldName);

        public static IndexExpression ElementAt(this Expression array, params Expression[] indexes)
            => Expression.ArrayAccess(array, indexes);

        public static UnaryExpression ArrayLength(this Expression array)
            => Expression.ArrayLength(array);

        public static LoopExpression Loop(this Expression body, LabelTarget @break, LabelTarget @continue)
            => Expression.Loop(body, @break, @continue);

        public static LoopExpression Loop(this Expression body, LabelTarget @break) => Expression.Loop(body, @break);

        public static LoopExpression Loop(this Expression body) => Expression.Loop(body);

        public static GotoExpression Goto(this LabelTarget label) => Expression.Goto(label);

        public static GotoExpression Goto(this LabelTarget label, Expression value) => Expression.Goto(label, value);

        public static GotoExpression Return(this LabelTarget label) => Expression.Return(label);

        public static GotoExpression Return(this LabelTarget label, Expression value) => Expression.Return(label, value);

        public static GotoExpression Break(this LabelTarget label) => Expression.Break(label);

        public static GotoExpression Break(this LabelTarget label, Expression value) => Expression.Break(label, value);

        public static GotoExpression Continue(this LabelTarget label) => Expression.Continue(label);

        public static LabelExpression LandingSite(this LabelTarget label) => Expression.Label(label);

        public static LabelExpression LandingSite(this LabelTarget label, Expression @default) => Expression.Label(label, @default);

        public static ConditionalExpression Condition(this Expression expression, Expression ifTrue = null, Expression ifFalse = null, Type type = null)
            => Expression.Condition(expression, ifTrue ?? Expression.Empty(), ifFalse ?? Expression.Empty(), type ?? typeof(void));

        public static ConditionalExpression Condition<R>(this Expression expression, Expression ifTrue, Expression ifFalse)
            => expression.Condition(ifTrue, ifFalse, typeof(R));

        public static ConditionalBuilder Condition(this Expression test, ExpressionBuilder parent = null)
            => new ConditionalBuilder(test, parent, false);

        public static TryExpression Finally(this Expression @try, Expression @finally) => Expression.TryFinally(@try, @finally);

        public static UnaryExpression Throw(this Expression exception) => Expression.Throw(exception);

        public static Expression AsConst<T>(this T value)
            => value is Expression expr ? (Expression)Expression.Quote(expr) : Expression.Constant(value, typeof(T));

        public static DefaultExpression AsDefault(this Type type) => Expression.Default(type);

        public static NewExpression New(this Type type, params Expression[] args)
        {
            if (args.LongLength == 0L)
                return Expression.New(type);
            var ctor = type.GetConstructor(args.Convert(arg => arg.Type));
            if (ctor is null)
                throw new MissingMethodException(ExceptionMessages.MissingCtor(type));
            else
                return Expression.New(ctor, args);
        }

        public static TryBuilder Try(this Expression expression, ExpressionBuilder parent = null)
            => new TryBuilder(expression, parent, false);

        public static Expression With(this Expression expression, Action<WithBlockBuilder> scope, ExpressionBuilder parent = null)
            => ExpressionBuilder.Build<Expression, WithBlockBuilder>(new WithBlockBuilder(expression, parent), scope);

        public static Expression Using(this Expression expression, Action<UsingBlockBuilder> scope, ExpressionBuilder parent = null)
            => ExpressionBuilder.Build<Expression, UsingBlockBuilder>(new UsingBlockBuilder(expression, parent), scope);

        public static SwitchBuilder Switch(this Expression switchValue, ExpressionBuilder parent = null)
            => new SwitchBuilder(switchValue, parent, false);

        public static Expression<D> ToAsyncLambda<D>(this Expression<D> lambda)
            where D : Delegate
        {
            using (var builder = new Runtime.CompilerServices.AsyncStateMachineBuilder<D>(lambda.Parameters))
            {
                return builder.Build(lambda.Body, lambda.TailCall);
            }
        }

        internal static Expression AddPrologue(this Expression expression, bool inferType, IReadOnlyCollection<Expression> instructions)
        {
            if (instructions.Count == 0)
                return expression;
            else if (expression is BlockExpression block)
                return Expression.Block(inferType ? block.Type : typeof(void), block.Variables, instructions.Concat(block.Expressions));
            else
                return Expression.Block(inferType ? expression.Type : typeof(void), instructions.Concat(Sequence.Singleton(expression)));
        }

        internal static Expression AddEpilogue(this Expression expression, bool inferType, IReadOnlyCollection<Expression> instructions)
        {
            if (instructions.Count == 0)
                return expression;
            else if (expression is BlockExpression block)
                return Expression.Block(inferType ? block.Type : typeof(void), block.Variables, block.Expressions.Concat(instructions));
            else
                return Expression.Block(inferType ? instructions.Last().Type : typeof(void), Sequence.Singleton(expression).Concat(instructions));
        }

        internal static Expression AddPrologue(this Expression expression, bool inferType, params Expression[] instructions)
            => AddPrologue(expression, inferType, (IReadOnlyCollection<Expression>)instructions);

        internal static Expression AddEpilogue(this Expression expression, bool inferType, params Expression[] instructions)
            => AddEpilogue(expression, inferType, (IReadOnlyCollection<Expression>)instructions);
    }
}