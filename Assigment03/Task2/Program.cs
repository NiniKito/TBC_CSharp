//დაწერეთ პროგრამა რომელსაც კონსოლიდან გადავცემთ რიცხვს და პასუხად დაბეჭდავს შეყვანილი
//რიცხვის გამყოფების რაოდენობას. მაგალითად, თუ შევიყვანთ 6-ს, უნდა დაიბეჭდოს 4-ს (1, 6, 2, 3).

Console.WriteLine("ritskhvi:");
int numb = int.Parse(Console.ReadLine());
int sum = 0;
for (var i = 1; i <= numb; i++)
{
    if (numb % i == 0)
    {
        Console.WriteLine(i);
        sum += i;
    }
}
       
        


