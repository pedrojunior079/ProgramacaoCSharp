// Media1.cs
// Média da turma com repetição controlada por contador.

using System;

class Media1
{
    static void Main(string[] args)
    {
        int total,                // soma das notas
            notasContador,       // número das notas
            notasvalor,          // valor das notas
            media;              // média de todas as notas

        // fase da inicialização
        total = 0;          // limpa o total
        notasContador = 1; // prepara para o laço

        // fase dce processamento
        while(notasContador <= 10) // repete o laço 10 vezes
        {
            // solicita a entrada e le a nota do usuario
            Console.Write("Rntre com notas inteiras: ");

            // le a entrada e converte para inteiro
            notasvalor = Int32.Parse(Console.ReadLine());

            // soma notasValor ao total
            total = total + notasvalor;

            // soma 1 a notasContador
            notasContador = notasContador + 1;
        }

        // fase de conclusão
        media = total / 10; // divisão inteira

        Console.WriteLine("\nClasse media foi {0}", media);

    } // fim de main    

}  // fim da classe Media1   
