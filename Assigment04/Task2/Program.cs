//შესაქმნელია კონსოლური აპლიკაცია რომელსაც გადაეცემა ერთგანზომილებიანი მასივის ზომა N, და მასვის ელემენტები,
//სიტყვები. ყველა ელემენტის შეყვანის შემდეგ პროგრამამ უნდა გვთხოვოს მეორე მასივის ზომის და ელემენტების, რიცხვების შეყვანა.
//მეორე მასივის ყველა ელემენტის შეყვანის შემდეგ პირველი და მეროე მასივი უნდა გაერთიანდეს ისე რომ პირველი
//მასივის პირველი ელემენტის შემდეგ იდგეს მეორე მასივის პირველი ელემენტი და ა.შ. კონსოლში უნდა დაიბეჭდოს
//გაერთიანებული მასივის ყველა ელემენტი.
Console.WriteLine("masivis zoma:");
int size = int.Parse(Console.ReadLine());
String[] str = new String[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"masivis elementi[{i}]");
    string element = Console.ReadLine();
    str[i] = element;
}
Console.WriteLine("masivis zoma:");
int size1 = int.Parse(Console.ReadLine());
int[] numb = new int[size1];
for (int i = 0; i < size1; i++)
{
    Console.WriteLine($"masivis elementi[{i}]");
    int element1 = int.Parse(Console.ReadLine());
    numb[i] = element1;
}
for (int i = 0; i < size1; i++)
    {
        Console.Write($"{str[i]} " + $"{numb[i]} ");
    }
