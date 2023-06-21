//დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც პირველ პარამეტრად იღებს მთელი რიცხვების მასივს,
//მეორე პარამეტრად იღებს მთელ რიცხვს (index), ფუნქციამ უნდა დაითვალოს იმ ელემენტის ციფრების ჯამი,
//რომლის ინდექსი არის მეორე პარამეტრი. მაგალითად: თუ ინდექს 2-ზე წერია ელემენტი 123 ფუნქციამ უნდა დააბრუნოს 6.
Console.WriteLine("masivis zoma:");
int size= int.Parse(Console.ReadLine());
int[] numb = new int[size];
Console.WriteLine("masivis elementebi:");
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"[{i}]");
    int element = int.Parse(Console.ReadLine());
    numb[i] = element;
}
Console.WriteLine("parametri");
int index = int.Parse(Console.ReadLine());
void func(int[] array, int index)
{
    int jami = 0;
    for (int i = 0; i <= index; i++)
            jami += numb[i];
Console.WriteLine($"ciprebis jami shesabamis index-ze aris: {jami}");
}
func(numb, index);


