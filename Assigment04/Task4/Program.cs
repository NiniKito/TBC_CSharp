//შესაქმნელია კონსოლური აპლიკაცია რომელსაც გადაეცემა მატრიცა 2 x 2 ან 3 x 3
//და შედეგად დაიბეჭდება თავად შეყვანილი მატრიცა და მატრიცის დეტერმინანტი.
Console.WriteLine("matricis elementebi:");
int[,] matrix = new int[3,3];
int i,j,det = 0;
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        Console.Write("element [{0}],[{1}]: ", i, j);
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    Console.Write("{0}  ", matrix[i, j]);
    Console.Write("\n");
}
for (i = 0; i < 3; i++)
det = det + (matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - 
matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]));
Console.Write("\nmatricis determinantia: {0}\n\n", det);