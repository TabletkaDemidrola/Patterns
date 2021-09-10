using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class FactoryB : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
