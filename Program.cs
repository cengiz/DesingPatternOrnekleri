using System;

namespace DesingPatternOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Memento Desing Pattern
            Product p = new Product() { Name = "C# Book", Price = 150 };
            Console.WriteLine("Product Name: {0} , Price: {1}", p.Name, p.Price);

            MementoCareTake m = new MementoCareTake();
            m._MementoCareTake = p.MementoSave();

            p.Price = 200;
            p.Name = "C# Kitabı";

            Console.WriteLine("Product Name: {0} , Price: {1}", p.Name, p.Price);

            p = p.Undo(m._MementoCareTake);
            Console.WriteLine("Product Name: {0} , Price: {1}", p.Name, p.Price);

            Console.ReadKey();
        }
    }
}
