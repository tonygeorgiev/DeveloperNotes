using SOLIDPrinciples.OCP.BadPractise2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.GoodPractise2
{
    public abstract class ProductFilterSpecification
    {
        public IEnumerable<Product> Filter(IList<Product> products)
        {
            return ApplyFilter(products);
        }
        protected abstract IEnumerable<Product> ApplyFilter(IList<Product> products);
    }
}
