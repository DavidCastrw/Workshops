Console.WriteLine("Batalla de RPG!");

int fuego = 200;
int aire = 200;
int roca = 200;
int agua = 200;
int dañoF2;
int dañoA2;
int dañoA;
int dañoR2;
int dañoR;
int dañoAg2;
int dañoF;
int dañoAg;

dañoF2 = fuego - aire;
dañoA2 = fuego - 50;
dañoA = aire - roca;
dañoR2 = aire -50;
dañoR = roca - agua;
dañoAg2 = agua - 50;
dañoF = agua - fuego;
dañoAg = fuego - 50;



//Ataque de fuego al aire
Console.WriteLine("\nAtaque de fuego al aire: ");
Console.WriteLine(dañoF2);
//Ataque aire al fuego
Console.WriteLine("\nAtaque del aire al fuego: ");
Console.WriteLine(dañoA2);

//Ataque aire a la roca
Console.WriteLine("\nAtaque de del aire a la roca:");
Console.WriteLine(dañoA);
//Ataque roca al aire
Console.WriteLine("\nAtaque del la roca al aire: ");
Console.WriteLine(dañoR2);

//Ataque roca a el agua
Console.WriteLine("\nAtaque de la roca al agua: ");
Console.WriteLine(dañoR);
//Ataque agua a la roca
Console.WriteLine("\nAtaque del agua a la roca: ");
Console.WriteLine(dañoAg2);

//Ataque agua al fuego
Console.WriteLine("\nAtaque del agua al fuego: ");
Console.WriteLine(dañoF);
//Ataque fuego al aire
Console.WriteLine("\nAtaque del fuego al agua: ");
Console.WriteLine(dañoAg);