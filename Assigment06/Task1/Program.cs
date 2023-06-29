//1)შექმენით namespace LibrarySystem;
//2)ამ namespace ში დაამატეთ კლასი Book, რომელსაც ექნება property ები:
//Title
//Author
//Year(სურვილისამებრ დაამატეთ სხვა ველებიც)
//3)შექმენით კლასი Library.Library კლასში უნდა გვქონდეს პრივატული ველი რომელიც იქნება Book ობიექტების მასივი
//3.1)Library კლასს უნდა ჰქონდეს ინდექსერი, რომელიც როგორც დააბრუნებს წიგნს ზემოთ ხსენებული ველიდან, ასევე დასეტავს კიდეც
//3.2)უნდა გვქონდეს Count property რომელიც დაგვიბრუნებს წიგნების რაოდენობას ბიბლიოთეკაში
//3.3)უნდა გვქონდეს AddBook მეთოდი, რომელიც დაამატებს ბიბლიოთეკაში წიგნებს
//3.4)RemoveBook მეთოდი რომელიც წაშლის ბიბლიოთეკიდან წიგნებს
//3.5)FindBook მეთოდი რომელიც მოძებნის ბიბლიოთეკაში წიგნებს
//4)თქვენი შექმნილი კლასები დააინიციალიზირეთ და გატესტეთ ბიბლიოთეკის ფუნქციონალი.
using LibrarySystem;
Book nam = new Book(){Title = "aaa",Author = "bbb",Year =2000, Description="sss"};
Book nam1 = new Book() { Title = "bbbb", Author = "ccc", Year = 2001, Description = "dd" };
Book nam2 = new Book() { Title = "ddd", Author = "eee", Year = 2002, Description = "ff" };
Library library = new Library();
library.Size = 10;
library.AddBook(nam); 
library.AddBook(nam1); 
library.AddBook(nam2);
Console.WriteLine($"{library.Count}");
string title = "ddd";
var bk = library.FindBook(title);
Console.WriteLine($"shesabamisi wignis indexia-{bk}");
library.RemoveBook(nam);
