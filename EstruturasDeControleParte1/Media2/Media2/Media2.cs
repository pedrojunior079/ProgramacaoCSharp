// Media2.cs
// Média da turma com repetição controlada por sentinela

using System;

class Media2
{
    static void Main(string[] args)
    {
        int total,             // soma das notas
            notasContador,     // número de notas fornecidas
            notasValor;        // valor da nota

        double media;          // média de todas as notas

        // fase de inicialização
        total = 0;             // limpa total
        notasContador = 0;     // prepara para o laço

        // fase de processamento
        // solicita entrada e conmverte para inteiro
        Console.Write("Entre com primeiro inteiro para nota, ou -1 para Sair: ");
        notasValor = Int32.Parse(Console.ReadLine());

        // repete o laço até que -1 sej fornecido pelo usuario
        while(notasValor != -1)
        {
            // soma notasValor ao total
            total = total + notasValor;

            // soma 1 a notasContador
            notasContador = notasContador + 1;

            // solicita entrada e le a nota do usuario
            //converte a nota de string para inteiro
            Console.Write("Enre com nota inteira, ou -1 para Sair: ");
            notasValor = Int32.Parse(Console.ReadLine());
        } // fim do while
        
        // fase de exclusão
        if(notasContador !=0)
        {
            media = (double) total / notasContador;

            // exibe a média das notas do teste
            Console.WriteLine("\nClasse média é {0}", media);
        }
        else
        {
            Console.WriteLine("Nenhuma nota foi inserida.");
        }     
    } // fim do método Main    
}  // fim da classe Media2   
