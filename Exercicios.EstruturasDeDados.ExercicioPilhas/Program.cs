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
            var stack = new Stack<char>();

            // A estrutura de dados ideal para esse tipo de comparação seria mesmo o dicionário, pois assim você não precisaria
            // ficar escaneando o array repetidamente, mas conhecendo a chave, já cegaria diretamente ao valor
            var matchingChars = new Dictionary<char, char> {
                { '[', ']' },
                { '{', '}' },
                { '(', ')' }
            };

            foreach (var caracter in expression)
            {
                if (matchingChars.ContainsKey(caracter))
                {
                    stack.Push(caracter);
                }
                else if (matchingChars.ContainsValue(caracter))
                {
                    // Aqui você também poderia resolver com um switch, mas usar o dicionário torna o código mais simples:
                    if (stack.Count == 0 || matchingChars[stack.Pop()] != caracter)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
