//დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც მომხმარებელს მოსთხოვს შეიყვანოს მასივის ზომა და
//შემდეგ შეავსებინებს მასივის ელემენტებს კონსოლიდან, მასივი უნდა იყოს char-ების, ფუნქციამ უნდა დააბრუნოს
//მომხმარებლის მიერ შევსებული მასივი. დაწერე მეორე ფუნქცია, რომელიც პირველი ფუნქციის დახმარებით პარამეტრად მიიღებს
//უკვე შევსებულ მასივს და სიმბოლოს, თუ ასეთი სიმბოლო მოიძებნა პარამეტრად გადმოცემულ მასივში მაშინ ფუნქციამ უნდა
//დააბრუნოს ის რიცხვი თუ რამდენჯერაც შეგვხდება მასივში გადმოცემული სიმბოლო. მაგალითად: თუ 'a' არის მასივში 2 ჯერ,
//უნდა დააბრუნოს 2. დაწერეთ მესამე ფუნქცია, რომელიც დაბეჭდავს მიღებულ შედეგებს, სიმბოლო 'a' shegvxda 2 jer ასეთი სახით.
Console.WriteLine("masivis zoma:");
int size = int.Parse(Console.ReadLine());
char[] numb = new char[size];
Console.WriteLine("masivis elementebi:");
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"[{i}]");
    char element = char.Parse(Console.ReadLine());
    numb[i] = element;
}void arr(char[] mas)
{
    for (int i = 0; i < size; i++)
    {
       char mass= mas[i];
       Console.WriteLine($"{mass}");
    }
}
arr(numb);
Console.WriteLine("simbolo:");
char symbol = char.Parse(Console.ReadLine());
int func2(char[] arr, char symbol)
{
    int count = 0;
    foreach (char s in arr) if (s == symbol)
    count++;
    func3(count, symbol);
    return count;
}
Console.WriteLine(func2(numb, symbol));
void func3(int count, char symbol)
{
    Console.WriteLine($"{symbol} shegvxda {count}- jer");
}