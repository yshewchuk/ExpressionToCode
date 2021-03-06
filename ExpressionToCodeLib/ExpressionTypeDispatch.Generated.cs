﻿using System;
using System.Linq.Expressions;

namespace ExpressionToCodeLib {
  public interface IExpressionTypeDispatch {
		void DispatchAdd(Expression e);
		void DispatchAddChecked(Expression e);
		void DispatchAnd(Expression e);
		void DispatchAndAlso(Expression e);
		void DispatchArrayLength(Expression e);
		void DispatchArrayIndex(Expression e);
		void DispatchCall(Expression e);
		void DispatchCoalesce(Expression e);
		void DispatchConditional(Expression e);
		void DispatchConstant(Expression e);
		void DispatchConvert(Expression e);
		void DispatchConvertChecked(Expression e);
		void DispatchDivide(Expression e);
		void DispatchEqual(Expression e);
		void DispatchExclusiveOr(Expression e);
		void DispatchGreaterThan(Expression e);
		void DispatchGreaterThanOrEqual(Expression e);
		void DispatchInvoke(Expression e);
		void DispatchLambda(Expression e);
		void DispatchLeftShift(Expression e);
		void DispatchLessThan(Expression e);
		void DispatchLessThanOrEqual(Expression e);
		void DispatchListInit(Expression e);
		void DispatchMemberAccess(Expression e);
		void DispatchMemberInit(Expression e);
		void DispatchModulo(Expression e);
		void DispatchMultiply(Expression e);
		void DispatchMultiplyChecked(Expression e);
		void DispatchNegate(Expression e);
		void DispatchUnaryPlus(Expression e);
		void DispatchNegateChecked(Expression e);
		void DispatchNew(Expression e);
		void DispatchNewArrayInit(Expression e);
		void DispatchNewArrayBounds(Expression e);
		void DispatchNot(Expression e);
		void DispatchNotEqual(Expression e);
		void DispatchOr(Expression e);
		void DispatchOrElse(Expression e);
		void DispatchParameter(Expression e);
		void DispatchPower(Expression e);
		void DispatchQuote(Expression e);
		void DispatchRightShift(Expression e);
		void DispatchSubtract(Expression e);
		void DispatchSubtractChecked(Expression e);
		void DispatchTypeAs(Expression e);
		void DispatchTypeIs(Expression e);
		void DispatchAssign(Expression e);
		void DispatchBlock(Expression e);
		void DispatchDebugInfo(Expression e);
		void DispatchDecrement(Expression e);
		void DispatchDynamic(Expression e);
		void DispatchDefault(Expression e);
		void DispatchExtension(Expression e);
		void DispatchGoto(Expression e);
		void DispatchIncrement(Expression e);
		void DispatchIndex(Expression e);
		void DispatchLabel(Expression e);
		void DispatchRuntimeVariables(Expression e);
		void DispatchLoop(Expression e);
		void DispatchSwitch(Expression e);
		void DispatchThrow(Expression e);
		void DispatchTry(Expression e);
		void DispatchUnbox(Expression e);
		void DispatchAddAssign(Expression e);
		void DispatchAndAssign(Expression e);
		void DispatchDivideAssign(Expression e);
		void DispatchExclusiveOrAssign(Expression e);
		void DispatchLeftShiftAssign(Expression e);
		void DispatchModuloAssign(Expression e);
		void DispatchMultiplyAssign(Expression e);
		void DispatchOrAssign(Expression e);
		void DispatchPowerAssign(Expression e);
		void DispatchRightShiftAssign(Expression e);
		void DispatchSubtractAssign(Expression e);
		void DispatchAddAssignChecked(Expression e);
		void DispatchMultiplyAssignChecked(Expression e);
		void DispatchSubtractAssignChecked(Expression e);
		void DispatchPreIncrementAssign(Expression e);
		void DispatchPreDecrementAssign(Expression e);
		void DispatchPostIncrementAssign(Expression e);
		void DispatchPostDecrementAssign(Expression e);
		void DispatchTypeEqual(Expression e);
		void DispatchOnesComplement(Expression e);
		void DispatchIsTrue(Expression e);
		void DispatchIsFalse(Expression e);
  }

    public static class ExpressionTypeDispatcher {
		public static void ExpressionDispatch(this IExpressionTypeDispatch dispatcher, Expression e) {
			try{
				switch(e.NodeType) {
					case ExpressionType.Add: dispatcher.DispatchAdd(e); return;
					case ExpressionType.AddChecked: dispatcher.DispatchAddChecked(e); return;
					case ExpressionType.And: dispatcher.DispatchAnd(e); return;
					case ExpressionType.AndAlso: dispatcher.DispatchAndAlso(e); return;
					case ExpressionType.ArrayLength: dispatcher.DispatchArrayLength(e); return;
					case ExpressionType.ArrayIndex: dispatcher.DispatchArrayIndex(e); return;
					case ExpressionType.Call: dispatcher.DispatchCall(e); return;
					case ExpressionType.Coalesce: dispatcher.DispatchCoalesce(e); return;
					case ExpressionType.Conditional: dispatcher.DispatchConditional(e); return;
					case ExpressionType.Constant: dispatcher.DispatchConstant(e); return;
					case ExpressionType.Convert: dispatcher.DispatchConvert(e); return;
					case ExpressionType.ConvertChecked: dispatcher.DispatchConvertChecked(e); return;
					case ExpressionType.Divide: dispatcher.DispatchDivide(e); return;
					case ExpressionType.Equal: dispatcher.DispatchEqual(e); return;
					case ExpressionType.ExclusiveOr: dispatcher.DispatchExclusiveOr(e); return;
					case ExpressionType.GreaterThan: dispatcher.DispatchGreaterThan(e); return;
					case ExpressionType.GreaterThanOrEqual: dispatcher.DispatchGreaterThanOrEqual(e); return;
					case ExpressionType.Invoke: dispatcher.DispatchInvoke(e); return;
					case ExpressionType.Lambda: dispatcher.DispatchLambda(e); return;
					case ExpressionType.LeftShift: dispatcher.DispatchLeftShift(e); return;
					case ExpressionType.LessThan: dispatcher.DispatchLessThan(e); return;
					case ExpressionType.LessThanOrEqual: dispatcher.DispatchLessThanOrEqual(e); return;
					case ExpressionType.ListInit: dispatcher.DispatchListInit(e); return;
					case ExpressionType.MemberAccess: dispatcher.DispatchMemberAccess(e); return;
					case ExpressionType.MemberInit: dispatcher.DispatchMemberInit(e); return;
					case ExpressionType.Modulo: dispatcher.DispatchModulo(e); return;
					case ExpressionType.Multiply: dispatcher.DispatchMultiply(e); return;
					case ExpressionType.MultiplyChecked: dispatcher.DispatchMultiplyChecked(e); return;
					case ExpressionType.Negate: dispatcher.DispatchNegate(e); return;
					case ExpressionType.UnaryPlus: dispatcher.DispatchUnaryPlus(e); return;
					case ExpressionType.NegateChecked: dispatcher.DispatchNegateChecked(e); return;
					case ExpressionType.New: dispatcher.DispatchNew(e); return;
					case ExpressionType.NewArrayInit: dispatcher.DispatchNewArrayInit(e); return;
					case ExpressionType.NewArrayBounds: dispatcher.DispatchNewArrayBounds(e); return;
					case ExpressionType.Not: dispatcher.DispatchNot(e); return;
					case ExpressionType.NotEqual: dispatcher.DispatchNotEqual(e); return;
					case ExpressionType.Or: dispatcher.DispatchOr(e); return;
					case ExpressionType.OrElse: dispatcher.DispatchOrElse(e); return;
					case ExpressionType.Parameter: dispatcher.DispatchParameter(e); return;
					case ExpressionType.Power: dispatcher.DispatchPower(e); return;
					case ExpressionType.Quote: dispatcher.DispatchQuote(e); return;
					case ExpressionType.RightShift: dispatcher.DispatchRightShift(e); return;
					case ExpressionType.Subtract: dispatcher.DispatchSubtract(e); return;
					case ExpressionType.SubtractChecked: dispatcher.DispatchSubtractChecked(e); return;
					case ExpressionType.TypeAs: dispatcher.DispatchTypeAs(e); return;
					case ExpressionType.TypeIs: dispatcher.DispatchTypeIs(e); return;
					case ExpressionType.Assign: dispatcher.DispatchAssign(e); return;
					case ExpressionType.Block: dispatcher.DispatchBlock(e); return;
					case ExpressionType.DebugInfo: dispatcher.DispatchDebugInfo(e); return;
					case ExpressionType.Decrement: dispatcher.DispatchDecrement(e); return;
					case ExpressionType.Dynamic: dispatcher.DispatchDynamic(e); return;
					case ExpressionType.Default: dispatcher.DispatchDefault(e); return;
					case ExpressionType.Extension: dispatcher.DispatchExtension(e); return;
					case ExpressionType.Goto: dispatcher.DispatchGoto(e); return;
					case ExpressionType.Increment: dispatcher.DispatchIncrement(e); return;
					case ExpressionType.Index: dispatcher.DispatchIndex(e); return;
					case ExpressionType.Label: dispatcher.DispatchLabel(e); return;
					case ExpressionType.RuntimeVariables: dispatcher.DispatchRuntimeVariables(e); return;
					case ExpressionType.Loop: dispatcher.DispatchLoop(e); return;
					case ExpressionType.Switch: dispatcher.DispatchSwitch(e); return;
					case ExpressionType.Throw: dispatcher.DispatchThrow(e); return;
					case ExpressionType.Try: dispatcher.DispatchTry(e); return;
					case ExpressionType.Unbox: dispatcher.DispatchUnbox(e); return;
					case ExpressionType.AddAssign: dispatcher.DispatchAddAssign(e); return;
					case ExpressionType.AndAssign: dispatcher.DispatchAndAssign(e); return;
					case ExpressionType.DivideAssign: dispatcher.DispatchDivideAssign(e); return;
					case ExpressionType.ExclusiveOrAssign: dispatcher.DispatchExclusiveOrAssign(e); return;
					case ExpressionType.LeftShiftAssign: dispatcher.DispatchLeftShiftAssign(e); return;
					case ExpressionType.ModuloAssign: dispatcher.DispatchModuloAssign(e); return;
					case ExpressionType.MultiplyAssign: dispatcher.DispatchMultiplyAssign(e); return;
					case ExpressionType.OrAssign: dispatcher.DispatchOrAssign(e); return;
					case ExpressionType.PowerAssign: dispatcher.DispatchPowerAssign(e); return;
					case ExpressionType.RightShiftAssign: dispatcher.DispatchRightShiftAssign(e); return;
					case ExpressionType.SubtractAssign: dispatcher.DispatchSubtractAssign(e); return;
					case ExpressionType.AddAssignChecked: dispatcher.DispatchAddAssignChecked(e); return;
					case ExpressionType.MultiplyAssignChecked: dispatcher.DispatchMultiplyAssignChecked(e); return;
					case ExpressionType.SubtractAssignChecked: dispatcher.DispatchSubtractAssignChecked(e); return;
					case ExpressionType.PreIncrementAssign: dispatcher.DispatchPreIncrementAssign(e); return;
					case ExpressionType.PreDecrementAssign: dispatcher.DispatchPreDecrementAssign(e); return;
					case ExpressionType.PostIncrementAssign: dispatcher.DispatchPostIncrementAssign(e); return;
					case ExpressionType.PostDecrementAssign: dispatcher.DispatchPostDecrementAssign(e); return;
					case ExpressionType.TypeEqual: dispatcher.DispatchTypeEqual(e); return;
					case ExpressionType.OnesComplement: dispatcher.DispatchOnesComplement(e); return;
					case ExpressionType.IsTrue: dispatcher.DispatchIsTrue(e); return;
					case ExpressionType.IsFalse: dispatcher.DispatchIsFalse(e); return;
					default:
						if(Enum.IsDefined(typeof(ExpressionType),e.NodeType))
							throw new NotImplementedException("ExpressionToCode supports .NET 3.5 expressions only");
						else
							throw new ArgumentOutOfRangeException("Impossible enum value:"+(int)e.NodeType);
				}
			} catch(NotImplementedException nie) {
				throw new ArgumentOutOfRangeException("Could not dispatch expr with nodetype "+e.NodeType+" and type " +e.GetType().Name,nie);
			}
		}
	}
}
 
