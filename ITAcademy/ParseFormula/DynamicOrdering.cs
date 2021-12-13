using System.Linq.Expressions;

namespace ParseFormula
{
    internal class DynamicOrdering
    {
        public Expression Selector;
        public bool Ascending;
    }
}