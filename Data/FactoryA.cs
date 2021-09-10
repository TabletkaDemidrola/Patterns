using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class FactoryA : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
