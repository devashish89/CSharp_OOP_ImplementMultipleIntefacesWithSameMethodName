using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_ImplementInterfacesWithSameMethods
{
    interface I1
    {
        void method1();
    }

    interface I2
    {
        void method1();
    }

    public class A: I1, I2
    {
        public void method1()
        {
            Console.WriteLine("method1 called ....");
        }
    }


    // need 2 implementations then Interfacename.method_name()

    public class B: I1, I2
    {
        void I1.method1()
        {
            Console.WriteLine("I1 method1 implementation...");
        }

        void I2.method1()
        {
            Console.WriteLine("I2 method1 implementation...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            I1 i1obj = new A();
            I2 i2obj = new A();

            i1obj.method1();
            i2obj.method1();


            I1 i1obj_new = new B();
            I2 i2obj_new = new B();

            i1obj_new.method1();
            i2obj_new.method1();


        }
    }
}
