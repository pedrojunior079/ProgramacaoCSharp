// OperadoresLogicos.cs
// Demonstrando os operadores lógicos.
using System;

    class OperadoresLogicos
    {
        static void Main(string[] args)
        {
             // testando o operador E condicional (&&)
             Console.WriteLine("Condicional AND (&&)"+
                "\nfalse && false: " + (false && false) +
                "\nfalse  && true: " + (false && true) + 
                "\ntrue && false: " + (true && false) +
                "\nrtrue && true: " + (true && true));

            // testando o operador OU condicional (||)
            Console.WriteLine("\n\nCondicional OR (||)" +
               "\nfalse || false: " + (false || false) +
               "\nfalse  || true: " + (false || true) +
               "\ntrue || false: " + (true || false) +
               "\nrtrue || true: " + (true || true));

           // testando o operador E lógico (&)
           Console.WriteLine("\n\nLógico AND (&)" +
               "\nfalse & false: " + (false & false) +
               "\nfalse  & true: " + (false & true) +
               "\ntrue & false: " + (true & false) +
               "\nrtrue & true: " + (true & true));

           // testando o operador OU lógico (|)
           Console.WriteLine("\n\nLógico OR (|)" +
               "\nfalse | false: " + (false | false) +
               "\nfalse  | true: " + (false | true) +
               "\ntrue | false: " + (true | false) +
               "\nrtrue | true: " + (true | true));

           // testando o operador OU exclusivo lógico (^)
           Console.WriteLine("\n\nExclusivo lógico OR (^)" +
               "\nfalse ^ false: " + (false ^ false) +
               "\nfalse  ^ true: " + (false ^ true) +
               "\ntrue ^ false: " + (true ^ false) +
               "\nrtrue ^ true: " + (true ^ true));

        // testando o operador Não lógico (!)
        Console.WriteLine("\n\nLógica NÃO (!)" +
            "\n!false: " + (!false) +
            "\n!true: " + (!true));
        }
    }

