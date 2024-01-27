namespace Exercicios.EstruturasDeDados.ExerciciosFilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BatataQuente(5);
        }

        /*
         Escreva uma função que simule o jogo de batata quente. Nesse jogo, jogadores passam a batata quente por um círculo até ela explodir. O jogador que estiver com a batata quando explodir está fora do jogo.
         Use a estrutura de dados Queue<> para resolver. A função deve receber o número de jogadores como parâmetro de entrada. A função deve selecionar um número aleatório entre 1 e 100 que será a quantidade de passes até a batata explodir. 
         Cada jogador que "sobreviver" à passagem da batata deve ir para o fim da fila, até que a batata exploda. Não use métodos de extensão Linq, implemente sua função usando estruturas de repetição (laços, loopings).
        */

        public static void BatataQuente(int numeroJogadores)
        {
            int numeroAleatorio = new Random().Next(1, 101);
            var fila = new Queue<string>(numeroJogadores);

            for (int i = 1; i <= numeroJogadores; i++)
            {
                fila.Enqueue(i.ToString());
            }
            // Adicionei algum texto para que todo a execução pudesse ser verificada no console
            Console.WriteLine("JOGO INICIADO.\n\n Jogadores: {0}\n A batata vai explodir após: {1} rodada(s)", fila.Count, numeroAleatorio);

            string pessoaComBatata;

            for (int i = 0; i < numeroAleatorio; i++)
            {
                pessoaComBatata = fila.Dequeue();
                Console.WriteLine("Passando pelo Jogador {0}", pessoaComBatata);
                fila.Enqueue(pessoaComBatata);
            }

            string perdedor = fila.Peek();

            Console.WriteLine("EXPLODIU NO JOGADOR {0}", perdedor);
        }
    }
}
