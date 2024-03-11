class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("===== MENÚ =====");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Nombre");
                Console.WriteLine("3. Calcular Edad");
                Console.WriteLine("4. Adivinar Número");
                Console.WriteLine("5. Contar Palabras y Vocales");
                Console.WriteLine("6. Verificar Palíndromo");
                Console.WriteLine("0. Salir");
                Console.WriteLine("================");
                Console.Write("Ingrese la opción deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Suma();
                        break;
                    case 2:
                        Nombre();
                        break;
                    case 3:
                        CalcEdad();
                        break;
                    case 4:
                        AdivinarNumero();
                        break;
                    case 5:
                        ContarPalabrasYVocales();
                        break;
                    case 6:
                        VerificarPalindromo();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
                        break;
                }
            } while (opcion != 0);
        }

        static void Suma()
        {
            int respuesta, val1, val2;
            Console.WriteLine("Ingrese el primer valor:");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor:");
            val2 = Convert.ToInt32(Console.ReadLine());
            respuesta = val1 + val2;

            Console.WriteLine("SUMA = " + respuesta);
        }

        static void Nombre()
        {
            Console.WriteLine("¿Cuál es su nombre?");
            string nombre = Console.ReadLine();
            Console.WriteLine("Mucho gusto, " + nombre);
        }

        static void CalcEdad()
        {
            Console.WriteLine("Ingrese el año de nacimiento:");
            int yearborn = Convert.ToInt32(Console.ReadLine());
            int edad = 2024 - yearborn;

            Console.WriteLine("SU EDAD ES = " + edad);
        }

        static void AdivinarNumero()
        {
            
            Console.WriteLine("Piense en un número y siga las instrucciones:");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Anote un número cualquiera:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplica el número por 2: " + numero + " * 2 = " + (numero * 2));
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Suma 8 al resultado anterior: " + (numero * 2 + 8));
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Multiplica el resultado por 5: " + (numero * 2 + 8) * 5);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Ahora ingrese el resultado obtenido:");
            int resultado = Convert.ToInt32(Console.ReadLine());
            string resultadoString = (resultado / 10).ToString(); // Eliminamos la última cifra
            Console.WriteLine("Anula la última cifra: " + resultado.ToString().Substring(0, resultado.ToString().Length - 1));
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("Resta 4 al resultado obtenido: " + (Convert.ToInt32(resultadoString) - 4));
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine("El número que pensó la otra persona es: " + (Convert.ToInt32(resultadoString) - 4));
        }

        static void ContarPalabrasYVocales()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();

            int contadorPalabras = 0;
            int contadorVocales = 0;
            int i = 0;

            while (i < frase.Length)
            {
                while (i < frase.Length && frase[i] == ' ')
                    i++;

                if (i < frase.Length && frase[i] != ' ')
                {
                    contadorPalabras++;

                    char caracter = Char.ToLower(frase[i]);
                    if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
                        contadorVocales++;
                }

                while (i < frase.Length && frase[i] != ' ')
                    i++;
            }

            Console.WriteLine("Número de palabras en la frase: " + contadorPalabras);
            Console.WriteLine("Número de vocales en la frase: " + contadorVocales);
        }

        static void VerificarPalindromo()
        {
            Console.WriteLine("Ingrese una palabra para verificar si es un palíndromo:");
            string palabra = Console.ReadLine();

            bool esPalindromo = true;
            for (int j = 0; j < palabra.Length / 2; j++)
            {
                if (palabra[j] != palabra[palabra.Length - 1 - j])
                {
                    esPalindromo = false;
                    break;
                }
            }

            if (esPalindromo)
                Console.WriteLine("La palabra '" + palabra + "' es un palíndromo.");
            else
                Console.WriteLine("La palabra '" + palabra + "' no es un palíndromo.");
        }
    }