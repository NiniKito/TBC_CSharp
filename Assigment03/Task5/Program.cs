//დაწერეთ პროგრამა რომელსაც გადასცემთ რიცხვის დიაპაზონს (დიაპაზონის მინიმალური და მაქსიმალური რიცხვი),
//პროგრამა დიაპაზონიდან დააგენერირებს შემთხვევით რიცხვს და შემოგთავაზებთ მის გამოცნობას მანამ სანამ არ გამოიცნობთ,
//და დაბეჭდავს რამდენ ცდაში გამოიცანით რიცხვი. გამოცნობის შემდეგ პროგრამა გვკითხოს გვსურს თუ არა გაგრძელება,
//Yes ან No შეყვანით, თანხმობის შემთხვევაში თავიდან შემოგვთავაზოს ახალი დიაპაზონის შეყვანას და რიცხვის გამოცნობას,
//უარის შემთხვევაში კონსოლი დაიხუროს.

Console.WriteLine("minimaluri ritskhvi:");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("maksimaluri ritskhvi:");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("sheikvanet ritskhvebi:");
var rand = new Random();
int random= rand.Next(min, max);
int jami = 1;
while (true)
{
    int numb = int.Parse(Console.ReadLine());
    if (numb == random)
    {
        Console.WriteLine("tkven gamoicanit " + jami + " cdashi");
        Console.WriteLine("gsurs tu ara gagrdzeleba Yes/No");
        string pas = Console.ReadLine();
        if (pas == "Yes")
        {
            jami = 1;
            Console.WriteLine("minimaluri ritskhvi");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("maqsimaluri ritskvi");
            max = int.Parse(Console.ReadLine());
            Console.WriteLine("sheikvanet ritskhvebi:");
            random = rand.Next(min, max);
        }
        else
        {
            break;
        }

    }
        else
        {
        jami++;
        }
    } 
