Console.WriteLine("Variables!");

//Declaraciones
Console.WriteLine("Declaraciones!");
int age = 37;
char initial = 'E';
string lastName = "\n Gonzalez";
decimal score = 99.99M;
double grade = 45.0D;
float distance = 5647.6547F;

Console.WriteLine(lastName);
Console.WriteLine(age);
Console.WriteLine(initial);
Console.WriteLine(score);
Console.WriteLine(grade);
Console.WriteLine(distance);

//Re-asignaciones
Console.WriteLine("Re-asignaciones!");
age = 38;
initial = 'A';
lastName = "Blanco";


Console.WriteLine(age);
Console.WriteLine(initial);
Console.WriteLine(lastName);

//Operaciones
Console.WriteLine("Operaciones!");
double JoseFScore = 80.0D;
double DavidScore = 89.5D;
double MarioScore = 73.33D;
double JoseIScore = 65.0D;

double average;

double total = JoseFScore + JoseIScore + MarioScore + DavidScore;

average = total / 4;

Console.WriteLine(average);