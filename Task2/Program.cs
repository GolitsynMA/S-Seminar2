Random rand = new Random();
int randomNumber = rand.Next(100, 1000);
Console.WriteLine(randomNumber);


int a = randomNumber / 100;
int b = randomNumber % 10;
Console.WriteLine($"{a}{b}");