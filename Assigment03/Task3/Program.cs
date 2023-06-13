//დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს N რიცხვს და
//გამოიტანს დადებითების საშუალო არითმეტიკულს და ჯამს.

int inp=-1;
double raod = 0;
int jami = 0;
while (inp != 0)
{
    Console.Write("ritskhvi: ");
    inp = int.Parse(Console.ReadLine());

    if (inp > 0)
    {
        jami += inp;
        raod++;
    }
}
Console.WriteLine($"dadebitebis sashualo aritmetikulia:{jami/raod:0.00} ");