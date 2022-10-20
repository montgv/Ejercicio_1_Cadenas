namespace Ejercicio_1_Cadenas
{
    class Ejercicio_1_Cadenas
    {
        static void Main(String[] args)
        {
            /*//Escribe por pantalla caracter a caracter la cadena introducida por teclado
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

            char buscar;
            int contador = 0;

            Console.WriteLine("Escribe un carácter a buscar: ");
            buscar = (char) Console.Read();
            if (Char.IsLetter(buscar))
            {
                 foreach (char caracter in entrada3)
                 {
                     if (caracter.Equals(buscar))
                     {
                         contador++;
                     }
                 }
                 Console.WriteLine("El carácter aparece " + contador + " veces.");
            } else
                {
                    Console.WriteLine("Carácter no valido.");
                }
            Console.WriteLine();

            //Muestra cuantas palabras tiene una frase introducida por teclado
            Console.WriteLine("Ejercicio 4: ");
            Console.WriteLine("Escribe una frase: ");
            string entrada4 = Console.ReadLine();

            string[] palabra = entrada4.Split(' ');

            Console.WriteLine("Tiene " + palabra.Length + " palabras.");
            Console.WriteLine();

            //Muestra las iniciales del nombre guardado en mayusculas
            Console.WriteLine("Ejercicio 5: ");
            string nombreCompleto = "juan antonio garcia perez";
            string[] partesNombre = nombreCompleto.Split(' ');
            for (int i = 0; i < partesNombre.Length; i++)
            {
                for (int j = 0; j < partesNombre[i].Length; j++)
                {
                    partesNombre[i][0] = partesNombre[i][0].T
                }
            }

            //Muestra una cadena de caracteres que es el resultado de invertir otra cadena
            Console.WriteLine("Ejercicio 6: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada6 = "";
            entrada6 = Console.ReadLine();
            string cadenaInvertida = "";
            for (int i = 0; i < entrada6.Length; i++)
            {
                cadenaInvertida = entrada6[i] + cadenaInvertida;
            }
            Console.WriteLine(cadenaInvertida);*/

            //Sustituye el caracter a buscar por el indicado en la cadena dada
            Console.WriteLine("Ejercicio 7: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada7 = "";
            entrada7 = Console.ReadLine();

            Console.WriteLine("Escribe el carácter que deseas cambiar: ");
            char buscar = (char)Console.Read();

            Console.WriteLine("Escribe el carácter que desear poner en su lugar: ");
            char cambiar = (char)Console.Read();

            string cadenaFinal = "";

            if (Char.IsLetter(buscar) && Char.IsLetter(cambiar))
            {
                cadenaFinal = entrada7.Replace(buscar, cambiar);
            }
            else
            {
                Console.WriteLine("Carácter no valido.");
            }
            Console.WriteLine();

            //Convierte las mayusculas en minusculas y al reves en una cadena introducida por teclado
            Console.WriteLine("Ejercicio 8: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada8 = "";
            entrada8 = Console.ReadLine();

            foreach (string caracter in entrada8)
            {
                if (caracter.Equals(caracter.ToUpper))
                {

                }
            }
            Console.WriteLine();

            //Comprueba si la cadena introducida contiene la subcadena introducida
            Console.WriteLine("Ejercicio 9: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada9 = "";
            entrada9 = Console.ReadLine();

            Console.WriteLine("Escribe la subcadena a buscar: ");
            string subcadena = "";
            subcadena = Console.ReadLine();

            if (entrada9.Contains(subcadena))
            {
                Console.WriteLine("La cadena contiene la subcadena.");
            } else
            {
                Console.WriteLine("La cadena no contiene la subcadena.");

            }

            //Comprobar si la cadena introducida des un palindromo
            Console.WriteLine("Ejercicio 10: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada10 = "";
            entrada10 = Console.ReadLine();

        }
    }
}