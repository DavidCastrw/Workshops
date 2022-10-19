string salutation ="Even Odd numbers!";
Console.WriteLine(salutation);

Console.WriteLine("Inserte un número");
string input = Console.ReadLine() ?? "0";
int number = Int32.Parse(input);

if(number % 2 == 0){
   Console.WriteLine("Es par!"); 
}

if(number % 2 == 1){
    Console.WriteLine("Es impar!");
}

Console.WriteLine("Fin del programa..");

