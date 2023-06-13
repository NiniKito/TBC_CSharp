//დაწერეთ კონსოლური აპლიკაცია რომელიც მომხმარებლისგან მიიღებს შემავალ პარამეტრად რიცხვს და
//შემდეგ დაბეჭდავს ამ რიცხვის შესაბამისი სართულების "პირამიდას". იხილეთ სურათი.

Console.WriteLine("ritskhvi:");
int inp = int.Parse(Console.ReadLine());
for (int i = 0; i< inp; i++)
{
    for (int j = 0; j< inp-i; j++)
    {
        Console.Write(" ");
    }
    for (int m = 0; m <= i * 2; m++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

