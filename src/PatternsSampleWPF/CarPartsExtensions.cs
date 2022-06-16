using System;
using System.Linq.Expressions;
using System.Reflection;
using PatternsSampleWPF.Models;

namespace PatternsSampleWPF
{
    internal static class CarPartsExtensions
    {
        internal static bool IsCarPartBuilt(this Car car, Expression<Func<string>> carPartAccessorExpression)
        {
            var carPropertyInfo = ((MemberExpression)carPartAccessorExpression.Body).Member as PropertyInfo;
            if (carPropertyInfo is null)
            {
                throw new ArgumentException("The lambda expression 'property' should point to a valid Property");
            }

            var partAccessed = carPartAccessorExpression.Compile()();
            return !string.IsNullOrEmpty(partAccessed);
        }
    }
}
