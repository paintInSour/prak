using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak2
{
    abstract class Operation
    {
        public double operator_1;
        public double operator_2;
        public abstract double Execute();
        public string GetInfo()
        {
            return nameof(Operation);
        }
    }

     class Add : Operation
    {
        public sealed override double Execute()
        {
            return operator_1 + operator_2;
        }
        public new string GetInfo()
        {
            return base.GetInfo();
        }


    }

    class Subtract:Operation
    {
        public override double Execute()
        {
            return operator_1 - operator_2;
        }
        public new string GetInfo()
        {
            return nameof(Subtract);
        }
    }
     class Multiply:Operation
    {
        public override double Execute()
        {
            return operator_1 * operator_2;
        }
        public new string GetInfo()
        {
            return nameof(Multiply);
        }
    }
    class Divide:Operation
    {
        public override double Execute()
        {
            return operator_1 / operator_2;
        }
        public new string GetInfo()
        {
            return nameof(Divide);
        }
    }
}
