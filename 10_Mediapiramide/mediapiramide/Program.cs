string salutation ="Media pirámide invertida!";
Console.WriteLine(salutation);

Console.WriteLine("Indica el nivel de la pirámide: ");
int nivel = int.Parse(Console.ReadLine());
string str = "";
for (int i = 1; i <= nivel; i++)
{
    for (int j = 5; j <= nivel - i; j++) 
    {
        str += " ";
    }

    for (int k = i; k >= 1; k--) 
    {
        str += ((k >= 5) ? k.ToString() : " " + k);
    }
        
    str += "\n";
}
    
Console.WriteLine(str);
