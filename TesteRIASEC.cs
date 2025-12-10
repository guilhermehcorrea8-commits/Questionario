using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_1012.obj.Debug;

namespace aula_1012.obj
{
    public class TesteRIASEC
    {
        public void Iniciar()
        {
            // Variáveis simples para pontuação
            int R = 0, I = 0, A = 0, S = 0, E = 0, C = 0;

            Console.WriteLine("=== TESTE RIASEC ===");
            Console.WriteLine("Responda cada item com 0 (nada) a 4 (totalmente)\n");

            // --- R ---
            Console.WriteLine("Categoria REALISTA (R)");
            Console.Write("1. Gosto de trabalhar com ferramentas, máquinas ou objetos: "); R += Util.LerResposta();
            Console.Write("2. Prefiro atividades práticas a discussões teóricas: "); R += Util.LerResposta();
            Console.Write("3. Gosto de consertar, montar ou construir coisas: "); R += Util.LerResposta();
            Console.Write("4. Prefiro ambientes organizados e tarefas manuais: "); R += Util.LerResposta();

            // --- I ---
            Console.WriteLine("\nCategoria INVESTIGATIVO (I)");
            Console.Write("1. Gosto de resolver problemas complexos: "); I += Util.LerResposta();
            Console.Write("2. Tenho interesse em ciência, pesquisa ou experimentos: "); I += Util.LerResposta();
            Console.Write("3. Gosto de analisar informações e entender como as coisas funcionam: "); I += Util.LerResposta();
            Console.Write("4. Prefiro atividades que envolvam reflexão e lógica: "); I += Util.LerResposta();

            // --- A ---
            Console.WriteLine("\nCategoria ARTÍSTICO (A)");
            Console.Write("1. Gosto de criar, desenhar, inventar ou expressar ideias: "); A += Util.LerResposta();
            Console.Write("2. Prefiro atividades com liberdade e sem regras rígidas: "); A += Util.LerResposta();
            Console.Write("3. Gosto de música, artes visuais, escrita ou atuação: "); A += Util.LerResposta();
            Console.Write("4. Sou imaginativo(a) e busco formas diferentes de fazer as coisas: "); A += Util.LerResposta();

            // --- S ---
            Console.WriteLine("\nCategoria SOCIAL (S)");
            Console.Write("1. Gosto de ajudar, orientar ou cuidar de pessoas: "); S += Util.LerResposta();
            Console.Write("2. Tenho facilidade para ouvir e compreender os outros: "); S += Util.LerResposta();
            Console.Write("3. Prefiro atividades que envolvem ensinar ou apoiar alguém: "); S += Util.LerResposta();
            Console.Write("4. Gosto de trabalhar em equipe e apoiar o bem-estar coletivo: "); S += Util.LerResposta();

            // --- E ---
            Console.WriteLine("\nCategoria EMPREENDEDOR (E)");
            Console.Write("1. Gosto de liderar, convencer ou motivar pessoas: "); E += Util.LerResposta();
            Console.Write("2. Tenho iniciativa e gosto de tomar decisões: "); E += Util.LerResposta();
            Console.Write("3. Prefiro desafios que envolvam resultados e metas: "); E += Util.LerResposta();
            Console.Write("4. Gosto de criar projetos e colocar ideias em prática: "); E += Util.LerResposta();

            // --- C ---
            Console.WriteLine("\nCategoria CONVENCIONAL (C)");
            Console.Write("1. Gosto de organizar, planejar e manter tudo em ordem: "); C += Util.LerResposta();
            Console.Write("2. Prefiro atividades com regras claras e rotina: "); C += Util.LerResposta();
            Console.Write("3. Gosto de trabalhar com documentos, tabelas ou registros: "); C += Util.LerResposta();
            Console.Write("4. Sou detalhista e cuidadoso(a) com informações: "); C += Util.LerResposta();

            // --- RESULTADOS ---
            Console.Clear();
            Console.WriteLine("=== RESULTADOS ===");
            Console.WriteLine($"R (Realista) = {R}");
            Console.WriteLine($"I (Investigativo) = {I}");
            Console.WriteLine($"A (Artístico) = {A}");
            Console.WriteLine($"S (Social) = {S}");
            Console.WriteLine($"E (Empreendedor) = {E}");
            Console.WriteLine($"C (Convencional) = {C}");

            string codigo = Util.GerarCodigoOrdenado(R, I, A, S, E, C);
            Console.WriteLine($"\nSeu código RIASEC: {codigo}");

            Console.WriteLine("\n=== ÁREAS SENAI SUGERIDAS ===");
            foreach (char letra in codigo)
            {
                Console.WriteLine($"\n{letra} - {Util.NomeCategoria(letra)}");

                string[] areas = Util.AreasSenai(letra);
                foreach (string area in areas)
                {
                    Console.WriteLine("• " + area);
                }
            }

            // --- PERFIL PRINCIPAL ---
            int maior = R;
            string perfil = "Realista";

            if (I > maior) { maior = I; perfil = "Investigativo"; }
            if (A > maior) { maior = A; perfil = "Artístico"; }
            if (S > maior) { maior = S; perfil = "Social"; }
            if (E > maior) { maior = E; perfil = "Empreendedor"; }
            if (C > maior) { maior = C; perfil = "Convencional"; }

            Console.WriteLine($"\nDe acordo com suas respostas, você se encaixa melhor no perfil: {perfil}");

            Console.WriteLine("\nPressione ENTER para voltar ao menu...");
            Console.ReadLine();
        }
    }
}