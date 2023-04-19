using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoSintaxe.ParadigmaEstrutural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comentária de uma linha 

            /*
             * Comentário de múltiplaslinhas 
             */

            //declaração de variáveis 
            int idade = 43;
            float altura = 1.79f;
            decimal salario = 9000;
            double media = 6.78;

            //Documentação oficial dos tipos
            //Microsoft e Tabelas do Google
            //variáveis de referenência 
            string nome = "Romulo Cesar Silvestre Stralong";
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(nome);
            Console.WriteLine(nome.Substring(23));

            //Estruturas
            //Estrutura de Seleção (Condição)
            if (idade >= 42)
                Console.WriteLine("Super Jovem Jovem");

            if (idade <= 16)
            {
                Console.WriteLine("Hiper Jovem Jovem");
            }

            //Se o Gabriel.H acertar na mega sena
            //Muito Dinheiro --- Verdadeiro
            //Senão
            //Vai ter que trabalhar --- Falso
            var vencedor = "Gabriel.H";
            bool venceu = true;
            if (venceu)
            {
                Console.WriteLine("É muito Dinheiro! para o :" + vencedor);
            }
            else
            {
                Console.WriteLine(vencedor + "  Vai ter que trabalhar!");
            }

            //Switc (if compacto)
            var mes = 2;

            if (mes == 1)
            {
                Console.WriteLine("Janeiro");
            }
            else if (mes == 2)
            {
                Console.WriteLine("Fevereiro");
            }
            else if (mes == 3)
            {
                Console.WriteLine("Março");
            }
            else if (mes == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (mes == 5)
            {
                Console.WriteLine("Maio");
            }
            else if (mes == 6)
            {
                Console.WriteLine("Junho");
            }
            else if (mes == 7)
            {
                Console.WriteLine("Julho");
            }
            else if (mes == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (mes == 9)
            {
                Console.WriteLine("Setembro");
            }
            else if (mes == 10)
            {
                Console.WriteLine("Outubro");
            }
            else if (mes == 11)
            {
                Console.WriteLine("Novembro");
            }
            else if (mes == 12)
            {
                Console.WriteLine("Dezmbro");
            }
            else
            {
                Console.WriteLine("Não existe esse valor");
            }

            switch (mes)
            {
                case 1: Console.WriteLine("janeiro");break;
                case 2: Console.WriteLine("Fevereiro"); break;
                case 3: Console.WriteLine("Março"); break;
                case 4: Console.WriteLine("Abril"); break;
                case 5: Console.WriteLine("Maio"); break;
                case 6: Console.WriteLine("Junho"); break;
                case 7: Console.WriteLine("Julho"); break;
                case 8: Console.WriteLine("Agosto"); break;
                case 9: Console.WriteLine("Setembro"); break;
                case 10: Console.WriteLine("Outubro"); break;
                case 11: Console.WriteLine("Novembro"); break;
                case 12: Console.WriteLine("Dezembro"); break;
                default: Console.WriteLine("Dado inválido"); break;

            }
            int contador = 1;

            while(contador <= 3)
            {
                Console.WriteLine("Gabriel Henrique");
                contador = contador + 1;
            }
            Console.WriteLine("--------Áagora ultilizando do while---------");
            do
            {
                Console.WriteLine("Gabriel Henrique");
                contador = contador + 1;

            } while (contador <= 3);

            for (int i=1;i<=3;i=i+1)
            {
                Console.WriteLine("gabriel");
            }

                Console.ReadKey();

        }   
    }
}
