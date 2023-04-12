Console.WriteLine(" Cuantos registros de notas ingresara: ");
int n=int.Parse(Console.ReadLine());

int[] notas=new int[n];
string[] nombres=new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Ingrese el nombre del estudiante numero {i+1}: ");
    nombres[i]=Console.ReadLine();
    Console.WriteLine($"Ingrese la nota del estudiante numero {i+1}: ");
    notas[i]=int.Parse(Console.ReadLine());

}
int notas1, j, j1;
notas1 = j = j1 = 0;

foreach (int n1 in notas)
{
    j++;
    if (n1 > notas1)
    {
        notas1 = n1;
        j1 = j;
    }
}
Console.WriteLine($"El alumno con mayor nota es {nombres[j1 - 1]} con un total de {notas1} puntos");
int n3 = 100;
int r, r1;
r = r1 = 0;
foreach(int n2 in notas)
{
    r++;
    if (n2 < n3)
    {
        n3 = n2;
        r1= r;
    }
}
Console.WriteLine($"El alumno con menor nota es {nombres[r1 - 1]} con un total de {n3} puntos");
