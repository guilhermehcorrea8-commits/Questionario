using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_1012.obj.Debug
{
    public class Util
    {
        public static int LerResposta()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 4)
            {
                Console.Write("Inválido! Digite 0–4: ");
            }
            return n;
        }

        public static string GerarCodigoOrdenado(int R, int I, int A, int S, int E, int C)
        {
            string letras = "RIASEC";
            int[] valores = { R, I, A, S, E, C };

            for (int x = 0; x < valores.Length; x++)
            {
                for (int y = x + 1; y < valores.Length; y++)
                {
                    if (valores[y] > valores[x])
                    {
                        int temp = valores[x];
                        valores[x] = valores[y];
                        valores[y] = temp;

                        char[] arr = letras.ToCharArray();
                        char tempLetra = arr[x];
                        arr[x] = arr[y];
                        arr[y] = tempLetra;
                        letras = new string(arr);
                    }
                }
            }

            return letras.Substring(0, 3);
        }

        public static string NomeCategoria(char letra)
        {
            switch (letra)
            {
                case 'R': return "Realista";
                case 'I': return "Investigativo";
                case 'A': return "Artístico";
                case 'S': return "Social";
                case 'E': return "Empreendedor";
                case 'C': return "Convencional";
                default: return "";
            }
        }

        public static string[] AreasSenai(char letra)
        {
            switch (letra)
            {
                case 'R': return new[] { "Mecânica", "Automação", "Usinagem", "Eletricidade", "Plastico", "Costura" };
                case 'I': return new[] { "Tecnologia da Informação", "Eletroeletrônica", "Manutenção", "Plastico" };
                case 'A': return new[] { "Design de Produto", "Impressão 3D", "Comunicação Visual", "Costura" };
                case 'S': return new[] { "Segurança do Trabalho", "Educação", "Saúde Ocupacional" };
                case 'E': return new[] { "Gestão", "Vendas Técnicas", "Logística" };
                case 'C': return new[] { "Administração", "Controle de Qualidade", "Planejamento" };
                default: return new string[0];
            }
        }
    }
}