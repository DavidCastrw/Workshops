// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] listaNumeros = new int[15]{ 3, 4, 5, 6, 22, 33, 22, 11, 23, 345, 4535, 123, 233, 34, 3 };

           

            Array.Sort(listaNumeros);
            Console.WriteLine("El numero menor es: "+listaNumeros[0]);
             Array.Reverse(listaNumeros);
             Console.WriteLine("El numero mayor es: " + listaNumeros[0]);
             Console.WriteLine();
            for (int i = 0; i < 14;i++ )
            {
                Console.WriteLine("La posicion es: "+i+"  "+listaNumeros[i]);

            }

Console.WriteLine("Fin del programa..");