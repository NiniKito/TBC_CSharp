//დაწერეთ აპლიკაცია რომელიც ინფუთად მიიღებს დაბადების წელს და
//კონსოლში დაბეჭდავს რის წელშია დაბადებული

Console.WriteLine("input your birthdate:");
int birthyear = Convert.ToInt32(Console.ReadLine());
int zodiac = birthyear % 12;
switch (zodiac)
{
    case 0:
        Console.WriteLine("maimuni");
        break;
    case 1:
        Console.WriteLine("mamali");
        break;
    case 2:
        Console.WriteLine("dzagli");
        break;
    case 3:
        Console.WriteLine("gori");
        break;
    case 4:
        Console.WriteLine("vitkha");
        break;
    case 5:
        Console.WriteLine("khari");
        break;
    case 6:
        Console.WriteLine("vefkhvi");
        break;
    case 7:
        Console.WriteLine("kata");
        break;
    case 8:
        Console.WriteLine("drakoni");
        break;
    case 9:
        Console.WriteLine("gveli");
        break;
    case 10:
        Console.WriteLine("tskeni");
        break;
    case 11:
        Console.WriteLine("tkha");
        break;
}