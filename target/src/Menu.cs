using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target.src
{
    public class Menu
    {
        
       public static void menuPrograma()
        {
            
            bool continuar = true;

            while (continuar)
            {
                char controle = ' ';
                bool continuarNaAtividade = true;

                Console.Clear();

                Console.WriteLine("----------------------------");
                Console.WriteLine("|    MENU TESTE PRATICO    |");
                Console.WriteLine("|                          |");
                Console.WriteLine("|  DIGITE A OPÇÂO DESEJADA |");
                Console.WriteLine("|                          |");
                Console.WriteLine("|   1.Verifica fibonacci   |");
                Console.WriteLine("|   2.Verifica A           |");
                Console.WriteLine("|   3.Resposta Q3 Q4 Q5    |");
                Console.WriteLine("|   4.Autor do codigo      |");
                Console.WriteLine("|                          |");
                Console.WriteLine("|   0.Sair                 |");
                Console.WriteLine("----------------------------");

                controle = Console.ReadKey().KeyChar;

                switch (controle)
                {
                    case '1':
                        
                        
                        while (continuarNaAtividade)
                        {
                            Console.Clear();
                            atividadesDeCodigo.fibonacciMenu();
                            continuarNaAtividade = desejaContinuar();
                        }
                        break;
                    
                    case '2':

                        
                        while (continuarNaAtividade)
                        {
                            Console.Clear();
                            atividadesDeCodigo.temOCaracterAMenu();
                            continuarNaAtividade = desejaContinuar();
                        }
                        break;
                    case '3':

                        
                        while (continuarNaAtividade)
                        {
                            Console.Clear();
                            atividadesDeCodigo.QuestoesDiscursivasMenu();
                            continuarNaAtividade = desejaContinuar();
                        }
                        break;
                    case '4':
                        
                        while (continuarNaAtividade)
                        {
                            Console.Clear();
                            Console.WriteLine("autor:Gabriel Henrique de Olivereira Pereira");
                            Console.WriteLine("obrigado por olhar");
                            continuarNaAtividade = desejaContinuar();
                        }
                        break;

                    case '0':
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("tente uma opção que existe");
                        break;
                }
            }
        }

        public static bool desejaContinuar()
        {

            String continuar;
            
            Console.WriteLine("\n\n\nVoce deseja continuar nessa atividade(S para sim / N para nao)? ");
            continuar = Console.ReadLine();
            continuar = continuar.ToUpper();
            if (continuar == "S") { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
