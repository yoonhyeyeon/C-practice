using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod
{
    class Base
    {
        public virtual void SealMe()
        {
        }
    }
    class Derived : Base
    {
        public sealed override void SealMe()
        {
        }
    }
    class WantToOverrid : Derived
    {
        public override void SealMe()
        {
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}
