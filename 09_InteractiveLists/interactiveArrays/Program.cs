
Console.WriteLine("Interactive Arrays / Arreglos Interactivos!");

Console.WriteLine("\nIngrese la cantidad de valores de la nota: ");

decimal[] grades;
int size;
string? input = Console.ReadLine();
bool isValid = int.TryParse(input, out size);

if(isValid)
{
    grades = new decimal[size];
    for (int i = 0; i < grades.Length; i++)
    {
       Console.WriteLine("\nPor favor ingrese la" + i + "nota: "); 
       if (!decimal.TryParse(Console.ReadLine(), out grades[i]))
       {
        Console.WriteLine("La nota no está en un formato válid.");
        i --; // i = 0 -1;
       }
    }
    Console.WriteLine("\nCalculando nota final... \n");

    decimal subTotal = 0;

    for (int k = 0; k < grades.Length; k++)
    {
        subTotal += grades[k]; //subTotal = subTotal + grades[k];
    }

    decimal finalGrade = subTotal / size;
    Console.WriteLine("\n La nota final es:  \n" + finalGrade);




}else{
    Console.WriteLine("Imposible crear el registro de notas.");
}



