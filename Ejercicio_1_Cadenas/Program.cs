namespace Ejercicio_1_Cadenas
{
    class Ejercicio_1_Cadenas
    {
        static void Main(String[] args)
        {
            //Escribe por pantalla caracter a caracter la cadena introducida por teclado
            Console.WriteLine("Ejercicio 1: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada1 = Console.ReadLine();

            foreach(char caracter in entrada1) {
                Console.WriteLine(caracter);
            }
            Console.WriteLine();

            //Comprueba si la cadena introducida por pantala comienza por la subcadena introducida por teclado
            Console.WriteLine("Ejercicio 2: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada2 = Console.ReadLine();
            
            Console.WriteLine("Escribe la subcadena a buscar: ");
            string subcadena2 = Console.ReadLine();
            
            if (entrada2.Substring(0, subcadena2.Length) == subcadena2)
            {
                Console.WriteLine("Si comienza por la subcadena.");
            } else
            {
                Console.WriteLine("No comienza por la subcadena.");
            }
            Console.WriteLine();

            //Muestra cuantas veces aparece el caracter en la cadena introducida por teclado
            Console.WriteLine("Ejercicio 3: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada3 = Console.ReadLine();

            Console.WriteLine("Escribe la subcadena a buscar: ");
            string subcadena3 = Console.ReadLine();

            if (entrada3.Substring(0, subcadena3.Length) == subcadena3)
            {
                Console.WriteLine("Si comienza por la subcadena.");
            }
            else
            {
                Console.WriteLine("No comienza por la subcadena.");
            }
            Console.WriteLine();
        }
    }
}