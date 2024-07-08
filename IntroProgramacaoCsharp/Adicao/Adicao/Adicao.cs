// Adicao.cs
// Um programa de soma
using System;

class Adicao
{
    static void Main(string[] args)
    {
        string primeiroNumero, // primeira string fornecida pelo usuario
               segundoNumero;  // segunda string fornecida pelo usuario

        int numero1,          // primeiro número a somar 
            numero2,          // segundo número a somar
            soma;            // soma de numero1 e numero2

        // solicita e le o primeiro número do usuario como string
        Console.Write("por favor entre com o primeiro inteiro: ");
        primeiroNumero = Console.ReadLine();

        // le o segundo número do usuario como string
        Console.Write("\nPor favor entre com o segundo inteiro: ");
        segundoNumero = Console.ReadLine();

        // converte números de tipos string para tipo int
        numero1 = Int32.Parse(primeiroNumero);
        numero2 = Int32.Parse(segundoNumero);

        // soma os números
        soma = numero1 + numero2;

        // exibe o resultado
        Console.WriteLine("\nA soma foi {0}.", soma);

    } // fim do método Main     
} // fim da classe Adicao













