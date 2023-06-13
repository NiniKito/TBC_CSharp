//დაწერეთ პროგრამა რომელსაც კონსოლიდან გადავცემთ რიცხვს და პასუხად დაბეჭდავს რიცხვი მარტივია თუ შედგენილი.
Console.WriteLine("ritskhvi:");
int numb=int.Parse(Console.ReadLine());
for (var i = 2; i <= Math.Sqrt(numb); i++)
{
    if(numb % i ==0)
    {
        Console.WriteLine("martivia");
        break;
}
    else
    {
        Console.WriteLine("shedgenilia");
        break;
    }
}