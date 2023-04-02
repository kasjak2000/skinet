using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        // empty constructor
        public BaseSpecification() { }

        // constructor with 
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;

        }

        public Expression<Func<T, bool>> Criteria { get; }
        // new List<Expression<Func<T, object>>>() means by default empty list
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        // name of the parameter is includeExpression
        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            //
            Includes.Add(includeExpression);
        }




    }
}