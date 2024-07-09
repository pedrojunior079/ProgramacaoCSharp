// Analise.cs
// Análise dos resultados do exame
using System;

class Analise
{
    static void Main(string[] args)
    {
        int aprovados = 0,       // número de aprovados
            reprovados = 0,      // número de reprovados
            alunos = 1,          // contador de alunos
            resultado;          // resultado de um exame

        // processa 10 alunos; laço controlado por contador
        while(alunos <= 10)
        {
            Console.WriteLine("Entre com resultado (1-aprovado, 2-resprovado): ");
            resultado = Int32.Parse(Console.ReadLine());

            if (resultado == 1)
                aprovados = aprovados + 1;

            else
                reprovados = reprovados + 1;
                alunos = alunos + 1;
        }

        // fase de conclusão
        Console.WriteLine();
        Console.WriteLine("Aprovados: " + aprovados);
        Console.WriteLine("Reprovados: " + reprovados);

        if (aprovados > 8)
            Console.WriteLine("Aumento da mensalidade\n");
    } // fim do método Main    
} // fim da classe Analise
