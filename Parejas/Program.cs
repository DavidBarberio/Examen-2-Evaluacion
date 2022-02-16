using System;

namespace Parejas
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();

            List<Persona> Personas = new();
            Personas.Add(Persona a);
            Personas.Add(Persona b);
           
            var parejas = sistema.PosibleParejas(sistema.Personas);
            parejas.ForEach(p=> Console.WriteLine($"{p.Item1} {p.Item2}"));
        }
    }
}
