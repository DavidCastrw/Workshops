Console.WriteLine("Guess the number! 🎲🎲\n\n");

// TODO Generate a random number
int secretNumber = 55;
// TODO Use the difficulty level to define the range (1-100 Easy, 1-500 Medium, 1-1000 Hard)
int from = 0;
int to = 100;
int guess;
bool won = false;
// TODO The player should have lives depending on the level of difficulty (10 Easy, 5 Medium, 3 Hard)

while (!won){
    Console.WriteLine("🧠 Think on a number between" + from + " and " + to + "...");
    string? input = Console.ReadLine();

    bool isValid = int.TryParse(input, out guess);

    if (isValid){

        if (secretNumber == guess){
            Console.WriteLine("\n🏆 Correcto!!! 🏆");
            won = true;
        }else{
            
            // TODO Tell the player if the number is bigger than, or less than the secret number
            Console.WriteLine("\no Numero Incorrecto");
            // TODO Lose a live
        }
    } else
    {
        Console.WriteLine("\n Valor ingresado es incorrecto, intente de nuevo");
    }
}

Console.WriteLine("\n🍻 fin del juego");

// Extra points!🎁

// TODO Add sounds for missing, loosing and winning
// TODO Colors in the terminal messages
