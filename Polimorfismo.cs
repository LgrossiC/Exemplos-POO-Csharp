using System;
namespace Polimorfismo
{
    public abstract class Empregado
    {
        public virtual void nomeLider()
        {
        }
    }

    public class rhDepartamento : Empregado
    {
        public override void nomeLider()
        {
            Console.WriteLine("AAA");
        }
    }
    public class tiDepartamento : Empregado
    {
        public override void nomeLider()
        {
            Console.WriteLine("BBB");
        }
    }

    public class finDepartamento : Empregado
    {
        public override void nomeLider()
        {
            Console.WriteLine("CCC");
        }
    }

    class PolymorphismDemo
    {
        static void Main(string[] args)
        {
            rhDepartamento obj1 = new rhDepartamento();
            tiDepartamento obj2 = new tiDepartamento();
            finDepartamento obj3 = new finDepartamento();

            obj1.nomeLider();
            obj2.nomeLider();
            obj3.nomeLider();

            Console.ReadKey();
        }
    }
}