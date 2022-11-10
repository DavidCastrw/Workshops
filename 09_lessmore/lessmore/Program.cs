
Console.WriteLine("Mayot, igual o mayor!");


string salutation ="Less, equal and greater number!";
Console.WriteLine(salutation);

Console.WriteLine("Inserte un número");
string input = Console.ReadLine() ?? "0";
int number = Int32.Parse(input);

int x = 2;
int y = 1;


if (number % x < y){
    Console.WriteLine("es mayor a y");
}
else if (number % x > y){
    Console.WriteLine("es menor a x");
}
else if (number % x == y){
    Console.WriteLine("Es igual a x eh y");
}
