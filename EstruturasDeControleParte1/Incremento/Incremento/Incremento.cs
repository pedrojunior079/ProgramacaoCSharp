// Incremento.cs
// Pré-incremento e pós-incemento
using System;

class Incremento
{
    static void Main(string[] args)
    {
        int c;
        c = 5;
        Console.WriteLine(c);     // imprime 5
        Console.WriteLine(c++);   // imprime 5 e pós- incrementa
        Console.WriteLine(c);     // imprime 6

        Console.WriteLine();      // pula uma linha

        c = 5;
        Console.WriteLine(c);    // imprime 5
        Console.WriteLine(++c);  // pré-incremento e depois imprime 6
        Console.WriteLine(c);    // imprime 6

    } // fim do método Main     
} // fim da classe Incremento
