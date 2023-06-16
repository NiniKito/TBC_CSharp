//შესაქმნელია კონსოლური აპლიკაცია რომელიც მიიღებს ორი ერთგანზომილებიან მასივს, დალაგების მიმართლებას,
//ზრდადებოთ (ASC) ან კლებადობით (DESC) გააერთიანებს მათ, დაალაგებს შესაბამისად და დაბეჭდავს შედეს.
Console.WriteLine("masivis zoma:");
int size = int.Parse(Console.ReadLine());
int[] numb = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"masivis elementi[{i}]");
    int element = int.Parse(Console.ReadLine());
    numb[i] = element;
}
Console.WriteLine("masivis zoma:");
int size1 = int.Parse(Console.ReadLine());
int[] numb1 = new int[size1];
for (int i = 0; i < size1; i++)
{
    Console.WriteLine($"masivis elementi[{i}]");
    int element1 = int.Parse(Console.ReadLine());
    numb1[i] = element1;
}
int[] arr = new int[size + size1];

    for (int i = 0; i < size; i++)
    {
        arr[i] = numb[i];
    }
    for (int i = 0; i < size1; i++)
    {
        arr[size + i] = numb1[i];
    }
Console.WriteLine("rogor dalagdes zrdadobit Tu klebadobiT, zrdadobis shemtkhvevashi datseret ASC,klebadobis shemtkhvevashi DESC");
string sort = Console.ReadLine();
        if (sort == "ASC")
    {
        Array.Sort(arr);
        Console.WriteLine("Ascending: ");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
    }
     else
    {
       Array.Reverse(arr);
        Console.WriteLine("\n\nDescending: ");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
    }