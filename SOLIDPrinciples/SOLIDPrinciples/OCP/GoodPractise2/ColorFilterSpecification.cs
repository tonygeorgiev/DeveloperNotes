using SOLIDPrinciples.OCP.BadPractise2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.GoodPractise2
{
    public class ColorFilterSpecification : ProductFilterSpecification
    {
        private readonly ProductColor productColor;
        public ColorFilterSpecification(ProductColor productColor)
        {
            this.productColor = productColor;
        }
        protected override IEnumerable<Product> ApplyFilter(IList<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Color == productColor)
                    yield return product;
            }
        }
    }

}
