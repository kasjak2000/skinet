using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        // An expression takes a function of type T, returns a bool , in this case Criteria (WHERE Criteria) of the thing, what we gonna get
        Expression<Func<T, bool>> Criteria { get; }
        // List takes an expression and use the function of type T, returns an object
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
// take certain amount of products
        int Take { get; }
        // skip certain amount of products
        int Skip { get; }
        bool IsPagingEnabled { get; }

    }
}