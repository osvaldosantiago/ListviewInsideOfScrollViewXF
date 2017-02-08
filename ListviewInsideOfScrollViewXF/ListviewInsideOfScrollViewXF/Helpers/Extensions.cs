using System;
using Xamarin.Forms;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
namespace ListviewInsideOfScrollViewXF
{
	public static class Extensions 
	{
		public static string BindTo<T>(this T sender, Expression<Func<T, object>> propertyExpression)
		{
			if (propertyExpression.Body is UnaryExpression)
			{
				var result = (propertyExpression.Body as UnaryExpression).Operand.ToString();
				return result.Substring(2, result.Length - 2);
			}
			else if (propertyExpression.Body is MemberExpression)
			{
				return GetProperties<T>(propertyExpression)
					.Select(property => property.Name)
					.Intersperse(".")
					.Concat();
			}

			return String.Empty;
		}
		private static string Concat(this IEnumerable<string> items)
		{
			return items.Aggregate("", (agg, item) => agg + item);
		}
		private static IEnumerable<T> Intersperse<T>(this IEnumerable<T> items, T separator)
		{
			var first = true;
			foreach (var item in items)
			{
				if (first) first = false;
				else
				{
					yield return separator;
				}
				yield return item;
			}
		}
		public static IEnumerable<PropertyInfo> GetProperties<T>(Expression<Func<T, object>> propertyExpression)
		{
			return GetProperties(propertyExpression.Body);
		}
		private static IEnumerable<PropertyInfo> GetProperties(Expression expression)
		{
			var memberExpression = expression as MemberExpression;
			if (memberExpression == null) yield break;

			var property = memberExpression.Member as PropertyInfo;
			if (property == null)
			{
				throw new Exception("Expression is not a property accessor");
			}
			foreach (var propertyInfo in GetProperties(memberExpression.Expression))
			{
				yield return propertyInfo;
			}
			yield return property;
		}
	}
}

