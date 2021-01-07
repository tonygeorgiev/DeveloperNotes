using SOLIDPrinciples.OCP.BadPractise2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.GoodPractise2
{
    public class ProductFilter
    {
        public IEnumerable<Product> By(IList<Product> products, ProductFilterSpecification filterSpecification)
        {
            return filterSpecification.Filter(products);
        }
    }
}
