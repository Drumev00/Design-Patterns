﻿using ClassicVisitor_DoubleDispatch.Abstractions;

namespace ClassicVisitor_DoubleDispatch
{
	internal class ExpressionCalculator : IExpressionVisitor
	{
		public double Result { get; set; }

		public void Visit(DoubleExpression de)
		{
			Result = de.Value;	
		}

		public void Visit(AdditionExpression ae)
		{
			ae.Left.Accept(this);
			var a = Result;
			ae.Right.Accept(this);
			var b = Result;
			Result = a + b;
		}
	}
}
