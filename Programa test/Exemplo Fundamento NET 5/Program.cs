using System.Linq.Expressions;

int[] arrayL = new int[4];

arrayL[0] = 1;
arrayL[1] = 4;
arrayL[2] = 3;
arrayL[3] = 5;

int contador = 0;

foreach (int valor in arrayL)
{
    Console.WriteLine($"O Numero actual e {contador} - {valor} ");
    contador++;
}
