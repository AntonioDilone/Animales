using Animales;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Perro> Perros = new List<Perro>();
        Console.WriteLine("Que tantos perros desea agregar?");
        int cantPerros = int.Parse(Console.ReadLine());
        Dictionary<string,int> razasCant= new Dictionary<string,int>();

        for (int i = 0; i < cantPerros ; i++)
        {
            Perro perro = new Perro();
            Console.WriteLine("Cual es el nombre del perro?");
            perro.nombre = Console.ReadLine();
            Console.WriteLine("Cual es la raza del perro?");
            perro.raza = Console.ReadLine();
            Console.WriteLine("Cual es la edad del perro?");
            perro.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Cual es el peso del perro");
            perro.peso = double.Parse(Console.ReadLine());
            Perros.Add(perro);
            Console.Clear();
        }

        foreach (var item in Perros)
        {
            Console.WriteLine(item.nombre + " es un perro de raza " + item.raza + " de " + item.edad + " años de edad y un peso de " +item.peso+"lb.");
            
            if (razasCant.ContainsKey(item.raza))
            {
                razasCant[item.raza]++;
            }
            else
            {
                razasCant[item.raza] = 1;
            }
        }
        foreach (var item in razasCant) {
            Console.WriteLine("La cantidad de perro de raza " + item.Key + " es de " + item.Value);
        }
    }

}