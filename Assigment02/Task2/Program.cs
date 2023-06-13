// ქვა / ქაღალდი / მაკრატელი(ე.წ.ჯეირანი):
//შექმენით კონსოლური აპლიკაცია რომელიც მომხმარებელს ეთამაშება ჯეირანს. 
// აპლიკაციამ მომხმარებლისგან უნდა მიიღოს ინფუთი (ქვა, ქაღალდი, მაკრატელი) და უნდა უპასუხოს რენდომ არჩევანით
//(var rand = new Random() ნახეთ ლაბში).
//თუ აპლიკაციის დაგენერირებული არჩევან იუგებს მომხმარებლისას მაშინ აპლიკაცია მოიგებს თუ არადა მომხმარებელი.
//კონსოლში გამოიტანეთ შედეგიც და აპლიკაციის არჩევანიც.  


Console.WriteLine("kva, kagaldi, makrateli:");
string inp = Console.ReadLine();
var rand = new Random();
int randNumber = rand.Next(0, 2);
string inp2;
if (randNumber == 0)
{
    inp2 = "kva";
}
else if (randNumber == 1)
{
    inp2 = "kagaldi";
}
else
{
    inp2 = "makrateli";
}
if
  ((inp == "kva" && inp2 == "kagaldi") ||
  (inp == "kva" && inp2 == "makrateli") ||
  (inp == "makrateli" && inp2 == "kagaldi"))

{
    Console.WriteLine("winner!");
}
else if (inp == inp2)

{
    Console.WriteLine("Fre!");

}
else
{
    Console.WriteLine("Failure!");
}