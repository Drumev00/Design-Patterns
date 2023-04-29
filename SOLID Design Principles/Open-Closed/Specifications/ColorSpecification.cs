using Open_Closed.Abstractions;
using Open_Closed.Enums;

namespace Open_Closed.Specifications
{
    internal class ColorSpecification : ISpecification<Product>
    {
        private Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product entity)
        {
            return entity.Color == _color;
        }
    }
}
