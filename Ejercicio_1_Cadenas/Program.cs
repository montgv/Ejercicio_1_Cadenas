namespace Ejercicio_1_Cadenas
{
    class Ejercicio_1_Cadenas
    {
        static void Main(String[] args)
        {
            string entrada = "";
            Console.WriteLine("Escribe una cadena: ");
            entrada = Console.ReadLine();

            foreach(char caracter in entrada) {
                Console.WriteLine(caracter);
            }
        }
    }
}