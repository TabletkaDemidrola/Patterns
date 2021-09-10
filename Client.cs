using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Client
    {
        public void main()
        {
            Console.WriteLine("Factory A : ");
            Method(new FactoryA());

            Console.WriteLine("Now Factory B : ");
            Method(new FactoryB());
            Console.ReadLine();
        }

        public void Method(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productA.FunctionA());
            Console.WriteLine(productB.FunctionB() + "\n");
        }
    }
}
