Console.WriteLine("Arrays in C#!");

// String array
string[] daysOfTheWeek = new string[7];

daysOfTheWeek[0] = "Monday";
daysOfTheWeek[1] = "Tuesday";
daysOfTheWeek[2] = "Wednesday";
daysOfTheWeek[3] = "Thursday";
daysOfTheWeek[4] = "Friday";
daysOfTheWeek[5] = "Saturday";
daysOfTheWeek[6] = "Sunday";

Console.WriteLine("Days of the week!");

Console.WriteLine(daysOfTheWeek[0]); //"Monday"
Console.WriteLine(daysOfTheWeek[3]); //"Thursday"
Console.WriteLine(daysOfTheWeek[6]); //"Sunday"

// int array with loop
int[] primes = new int[]{2, 3, 5, 7, 11, 13};

Console.WriteLine("Prime numbers!");

for(int i = 0; i < primes.Length; i++)
{
    Console.WriteLine(primes[i]);
}

//["a", "b", "c", "d", "e", "f", "g"]