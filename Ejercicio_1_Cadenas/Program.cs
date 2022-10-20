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

            string buscar3;
            int contador3 = 0;

            Console.WriteLine("Escribe un carácter a buscar: ");
            buscar3 = Console.ReadLine();
            char caracterBuscar3 = buscar3.ToCharArray()[0];
            if (Char.IsLetter(caracterBuscar3))
            {
                 foreach (char caracter in entrada3)
                 {
                     if (caracter.Equals(caracterBuscar3))
                     {
                         contador3++;
                     }
                 }
                 Console.WriteLine("El carácter aparece " + contador3 + " veces.");
            } else
                {
                    Console.WriteLine("Carácter no valido.");
                }
            Console.WriteLine();

            //Muestra cuantas palabras tiene una frase introducida por teclado
            Console.WriteLine("Ejercicio 4: ");
            Console.WriteLine("Escribe una frase: ");
            string entrada4 = Console.ReadLine();

            string[] palabra4 = entrada4.Split(' ');

            Console.WriteLine("Tiene " + palabra4.Length + " palabras.");
            Console.WriteLine();

            //Muestra las iniciales del nombre guardado en mayusculas
            Console.WriteLine("Ejercicio 5: ");
            string nombreCompleto5 = Console.ReadLine();

            string[] partesNombre5 = nombreCompleto5.Split(' ');
            string iniciales = "";
            foreach (string nombreSeparado in partesNombre5)
            {
                iniciales += nombreSeparado.ToUpper().ToCharArray()[0];
            }
            Console.WriteLine(iniciales);
            Console.WriteLine();

            //Muestra una cadena de caracteres que es el resultado de invertir otra cadena
            Console.WriteLine("Ejercicio 6: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada6 = "";
            entrada6 = Console.ReadLine();
            string cadenaInvertida6 = "";
            for (int i = 0; i < entrada6.Length; i++)
            {
                cadenaInvertida6 = entrada6[i] + cadenaInvertida6;
            }
            Console.WriteLine(cadenaInvertida6);
            Console.WriteLine();

            //Sustituye el caracter a buscar por el indicado en la cadena dada
            Console.WriteLine("Ejercicio 7: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada7 = "";
            entrada7 = Console.ReadLine();

            Console.WriteLine("Escribe el carácter que deseas cambiar: ");
            string buscar7 = Console.ReadLine();
            char carBuscar7 = buscar7.ToCharArray()[0];

            Console.WriteLine("Escribe el carácter que desear poner en su lugar: ");
            string cambiar7 = Console.ReadLine();
            char carCambiar7 = buscar7.ToCharArray()[0];

            string cadenaFinal = "";

            if (Char.IsLetter(carBuscar7) && Char.IsLetter(carCambiar7))
            {
                cadenaFinal = entrada7.Replace(carBuscar7, carCambiar7);
            }
            else
            {
                Console.WriteLine("Carácter no valido.");
            }
            Console.WriteLine(cadenaFinal);
            Console.WriteLine();

            //Convierte las mayusculas en minusculas y al reves en una cadena introducida por teclado
            Console.WriteLine("Ejercicio 8: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada8 = "";
            entrada8 = Console.ReadLine();
            string resultado8 = "";

            foreach (char caracter in entrada8)
            {
                if (char.IsUpper(caracter))
                {
                    resultado8 += Char.ToLower(caracter);
                } else
                {
                    resultado8 += Char.ToUpper(caracter);
                }
            }
            Console.WriteLine(resultado8);
            Console.WriteLine();

            // Comprueba si la cadena introducida contiene la subcadena introducida
            Console.WriteLine("Ejercicio 9: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada9 = "";
            entrada9 = Console.ReadLine();

            Console.WriteLine("Escribe la subcadena a buscar: ");
            string subcadena9 = "";
            subcadena9 = Console.ReadLine();

            if (entrada9.Contains(subcadena9))
            {
                Console.WriteLine("La cadena contiene la subcadena.");
            } else
            {
                Console.WriteLine("La cadena no contiene la subcadena.");
            }
            Console.WriteLine();

            //Comprobar si la cadena introducida des un palindromo
            Console.WriteLine("Ejercicio 10: ");
            Console.WriteLine("Escribe una cadena: ");
            string entrada10 = "";
            entrada10 = Console.ReadLine();

            string cadenaInvertida10 = "";
            for (int i = 0; i < entrada10.Length; i++)
            {
                cadenaInvertida10 = entrada10[i] + cadenaInvertida10;
            }

            if (entrada10.Equals(cadenaInvertida10))
            {
                Console.WriteLine("La cadena '" + entrada10 + "' es un palindromo.");
            } else
            {
                Console.WriteLine("La cadena '" + entrada10 + "' no es un palindromo.");
            }
        }
    }
}