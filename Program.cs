// permite al usuario ingresar n cantidad de palbras en un array cuantas cuantas vocales tiene cada palabra

int numero_palabras;
int contador = 0;


Console.Clear();
System.Console.WriteLine("ingrese el numero de palabras que quieras ingresar:");
numero_palabras = Convert.ToInt16(Console.ReadLine())!;

string[] palabras = new string[numero_palabras];

for (int i = 0; i < palabras.Length; i++)
{
    System.Console.WriteLine($"ingrese las palabras {i + 1}");
    palabras[i] = Console.ReadLine()!;
}

string palabra;
for (int i = 0; i < palabras.Length; i++)
{
    palabra = palabras[i];
    for (int a = 0; a < palabra.Length; a++)
    {
        if (palabra[a] == 'a' || palabra[a] == 'e' || palabra[a] == 'i' || palabra[a] == 'o' || palabra[a] == 'u')
        {
            contador++;
        }
    }
    System.Console.WriteLine($"{palabra} tiene {contador} vocales");
    contador = 0;
}

