using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class ProductA1 : IProductA
    {
        public string FunctionA()
        {
            return "This is product A1";
        }
    }
}
