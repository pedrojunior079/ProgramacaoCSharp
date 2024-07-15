// WhileContador.cs
// Repetição conrolada por contador.
using System;

class WhileContador
{
    static void Main(string[] args)
    {
        int contador = 1;        // inicialização
        while(contador <=5 )     // condição de repetição
        {
            Console.WriteLine(contador);
            contador++;
        } // fim do while     
    } // fim do método Main    
} // fim da classe WhileContador    
