using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OCP.BadPractise2
{
    public class ProductFilter
    {
        public IEnumerable<Product> ByColor(IList<Product> products, ProductColor productColor)
        {
            foreach (var product in products)
            {
                if (product.Color == productColor)
                    yield return product;
            }
        }
        public IEnumerable<Product> ByColorAndSize(IList<Product> products, ProductColor productColor,
        ProductSize productSize)
        {
            foreach (var product in products)
            {
                if ((product.Color == productColor) &&
                (product.Size == productSize))
                    yield return product;
            }
        }
        public IEnumerable<Product> BySize(IList<Product> products,
        ProductSize productSize)
        {
            foreach (var product in products)
            {
                if ((product.Size == productSize))
                    yield return product;
            }
        }
    }

}
