namespace Exercicios.EstruturasDeDados.ExercicioPilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsBalanceada("(2 + 1)80 / 7 - ([{√9 + 4² *0}])"));
            Console.WriteLine(IsBalanceada("([{35 - 2} + 53} + 0 / 15) - [3 + 5³] * 11)"));
        }

        /*
        Escreva uma função que receba uma expressão mátemática como entrada e verifique se a expressão está balanceada. 
        Uma expressão está balanceada se para cada parênteses de abertura, existe um parênteses de fechamento correspondente.
        Use a estrutura de dados Stack<> para resolver. Considere todos os 3 tipos de parênteses como ((), {}, []).
        Não use métodos de extensão Linq, implemente sua função usando estruturas de repetição (laços, loopings).
        */
        public static bool IsBalanceada(string expression)
        {
            var pilha = new Stack<char>();

            var openingChars = new char[]{ '[', '{', '(' };
            var closingChars = new char[] { ']', '}', ')' };

            foreach (var caracter in expression)
            {
                if (ArrayContains(openingChars, caracter))
                {
                    pilha.Push(caracter);
                }
                else if (ArrayContains(closingChars, caracter))
                {
                    if (pilha.Count == 0 || !OpeningClosingMatches(openingChars, pilha.Pop(), closingChars, caracter)){
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool ArrayContains(char[] chars, char caracter)
        {
            foreach (var c in chars) 
            {
                if (c == caracter) 
                    return true;
            }

            return false;
        }

        private static bool OpeningClosingMatches(char[] openingChars, char openingChar, char[] closingChars, char closingChar)
        {
            return Array.IndexOf(openingChars, openingChar) == Array.IndexOf(closingChars, closingChar);
        }
    }
}
