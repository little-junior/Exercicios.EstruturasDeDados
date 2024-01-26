namespace Exercicios.EstruturasDeDados.ExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>{
               "Idiossincrasia",
               "Ambivalente",
               "Quimérica",
               "Perpendicular",
               "Efêmero",
               "Pletora",
               "Obnubilado",
               "Xilografia",
               "Quixote",
               "Inefável"
            };

            var formatedList = FormatList(input);

            foreach (var item in formatedList)
            {
                Console.WriteLine(item);
            }
        }

        /*
        Escreva uma função que receba uma lista de strings e retorne uma nova lista contendo somente strings que contenham 10 ou mais caracteres.
        Use a estrutura de dados List<> para resolver. Não use métodos de extensão Linq, implemente sua função usando estruturas de repetição (laços, loopings).
        */

        public static List<string> FormatList(List<string> list)
        {
            var newList = new List<string>();

            foreach (var item in list)
            {
                if (item.Length >= 10)
                    newList.Add(item);
            }

            return newList;
        }
    }




}
