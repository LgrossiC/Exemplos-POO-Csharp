using System;
namespace Interface
{
    // interface
    public interface xyz
    {
        void metodoA();
        void metodoB();
    }

    // implementação de interface
    class testeInterface : xyz
    {
        public void metodoA()
        {
            Console.WriteLine("metodoA");
        }
        public void metodoB()
        {
            Console.WriteLine("metodoB");
        }
    }
    class interfaceDemo
    {
        static void Main(string[] args)
        {
            testeInterface obj = new testeInterface();
            obj.metodoA();
            obj.metodoB();
        }
    }
}