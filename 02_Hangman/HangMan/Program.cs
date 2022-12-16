string[] words = new String[] {
    "code", "videogame", "dog", "mouse", 
    "bootle", "computer", "cat", "internet",
    "nintendo", "university", "pencil", "program",
    "pokemon"
};

char[] guesses;
string[] fails;
string secretWord;
bool won, lost;

Random random = new Random();
int index = random.Next(words.Length);
secretWord = words[index];
guesses = new char[secretWord.Length];
Array.Fill(guesses, '*');
fails = new string[0];
won = false;
lost = false;

Console.WriteLine("\n\n Bienvenido al juego de ahorcado!\n\n"); // a
GameCicle(); // b

void GameCicle(){
    Console.WriteLine($"La palabra secreta es { new String(guesses) } "); // c
    if(lost){
        Console.WriteLine("Perdiste!");
    }
    else if (won){
        Console.WriteLine("Felicidades, GANASTE!");
    }
    else{
        PlayerTurn();
        GameCicle();
        PrintHangMan();
    }
}

void PrintHangMan(){
    Console.Write("Intentos fallidos: ");
    for (int i = 0; i < fails.Length; i ++){
        Console.Write(fails[i] + ' ');
    }
    int f = fails.Length;
    Console.WriteLine();
    Console.WriteLine("|---|");    
    Console.WriteLine($"| {( f>0 ? 'o' : ' ')}");
    Console.WriteLine($"| {( f>2 ? '/' : ' ')}{( f>1 ? '|' : ' ')}{(f>3 ? '\\' : ' ')}");
    Console.WriteLine($"| {( f>4 ? '/' : ' ')}{(f>5 ? '\\' : ' ')}");
    Console.WriteLine();



}

void PlayerTurn(){
    Console.Write("Ingrese una letra o adivine la palabra: "); // e
    string attempt = Console.ReadLine() ?? ""; // f
    if (attempt.Length == 0) // g
    {
        Console.WriteLine("Intente de nuevo"); // g1
    }
    else if (attempt.Length == 1)
    {
        TryALetter(attempt[0]);
    }
    else
    {
        TryAWord(attempt);
    }
}

string name = "David Castro";
char firstLetter = name[0];

void TryALetter(char letter)
{
    Console.WriteLine("Buscando letra...");
    if (secretWord.IndexOf(letter) > -1)
    {
        Console.WriteLine($"La letra {letter} si esta");
        for (int i = 0; 1 < secretWord.Length; i++)
        {
            if(secretWord[i] == letter)
            {
                guesses[i] = letter;
            }
        }
        won = Array.IndexOf(guesses, '*') == -1;
    }
    else
    {
        Console.WriteLine($"La letra {letter} no esta");
        Array.Resize(ref fails, fails.Length + 1);
        fails.SetValue(letter.ToString(), fails.Length);
    }
}

void TryAWord(string word)
{
    if (word == secretWord)
    {
        Console.WriteLine($"La palabra {word} SI es!");
        guesses = secretWord.ToCharArray();
        won = true;

    }
    else{
        Console.WriteLine($"La palabra {word} No es!");
        Array.Resize(ref fails, fails.Length + 1);
        fails.SetValue(word, fails.Length - 1);
    }
}

Console.Write("Game over"); // i

