//შესაქმნელია კონსოლური აპლიკაცია რომელსაც გადაეცემა ორი მატრიცია N x M და M x K ზომებით.
//პირველი მატრიცის სვერების რაოდენობა უნდა უდრიდეს მეორე მატრიცის ხაზების რაოდენობას,
//წინააღმდეგ შემთხვევაში გამოვიდეს შეტყობინება და მატრიცების შეყვანა მოითხოვოს თავიდან.
//პროგრამამ უნდა გამოთვალოს მატრიცების ნამრავლი და დაბეჭდოს შედეგად მიღებული მატრიცა. N x M * M x K = N x K
Console.WriteLine("pirveli matricis N zoma");
int nmat1= int.Parse(Console.ReadLine());
Console.WriteLine("pirveli matricis M zoma: ");
int mmat1 = int.Parse(Console.ReadLine());
int[,] mat = new int[nmat1, mmat1];
for (int i = 0; i < nmat1; i++)
{
    for (int j = 0; j < mmat1; j++)
    {
        Console.WriteLine($"[{i}][{j}]");
        int element = int.Parse(Console.ReadLine());
        mat[i, j] = element;
    }
}
Console.WriteLine("meore matricis M zoma");
int mmat2 = int.Parse(Console.ReadLine());
Console.WriteLine("meore matricis K zoma: ");
int kmat2 = int.Parse(Console.ReadLine());
int[,] mat2 = new int[mmat2, kmat2];
for (int i = 0; i < mmat2; i++)
{
    for (int j = 0; j < kmat2; j++)
    {
        Console.WriteLine($"[{i}][{j}]");
        int element2 = int.Parse(Console.ReadLine());
        mat2[i, j] = element2;
    }
}
Console.WriteLine("migebuli matrica aris:");
int[,] matrix = new int[nmat1, kmat2];
if (mmat1 == mmat2)
{
    int m, n, k;
    for (m = 0; m < nmat1; m++)
    {
        for (n = 0; n < kmat2; n++)
        {
            matrix[m, n] = 0;
            for (k = 0; k < mmat2; k++)
                matrix[m, n] += mat[m, k] * mat2[k, n];
            Console.Write(matrix[m, n] + "\t");
        }
        Console.WriteLine();
    }
}
else {
    Console.WriteLine("gamravleba ver mokherkhda");
}
    

