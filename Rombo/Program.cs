Console.Write("El numero es: ");
int lim = int.Parse(Console.ReadLine());
int MAX = (2 * lim) - 1;
int cont = 0;
int esp2 = 0;
while (cont < MAX)
{
    int esp1 = 0;
    if (cont < lim)
    {
        esp1 = lim - (cont + 1);
    }
    else
    {
        esp1 = (cont - lim) + 1;
    }
    for (int i = 0; i < esp1; i++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    if (cont != 0 && cont < MAX - 1)
    {
        if (cont > 0 && cont < lim)
        {
            esp2 = (2 * cont) - 1;
        }
        else
        {
            esp2 -= 2;
        }
        for (int j = 0; j < esp2; j++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
    }
    cont++;
    Console.WriteLine("");
}