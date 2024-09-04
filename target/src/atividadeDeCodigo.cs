using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace target.src
{
    static class atividadesDeCodigo
    {
        static public void fibonacciMenu()
        {

            Console.WriteLine("digite um numero para verificar se ele faz parte da sequencia de fibonacci: ");
            try { 
            int numero = Convert.ToInt32(Console.ReadLine());
            


            if (EFibonacci(numero))
            {
                Console.WriteLine($"o numero: {numero} faz sim parte da sequencia de fibonacci");
            }
            else
            {
                Console.WriteLine($"o numero: {numero} nao faz parte da sequencia de fibonacci");
            }
            } catch (FormatException) {
                Console.WriteLine("digite apenas numeros por favor!");
            }

        }
        static public bool EFibonacci(int numero)
        {

            if (numero == 0 || numero == 1)
            {
                return true;
            }

            int a = 0; int b = 1; int c = a + b;

            while (c <= numero)
            {

                if (c == numero)
                    return true;

                a = b; b = c; c = a + b;
            }
            return false;

        }

        public static void temOCaracterAMenu()
        {
           
            char letra = 'a';

            Console.WriteLine("esse programa verifica se uma string tem a letra a");
            Console.WriteLine("para começar digite uma palavra ou frase: ");
            String entrada = Console.ReadLine();

            while (entrada.Length == 0)
            {
                Console.WriteLine("para começar digite uma palavra ou frase: ");
                entrada = Console.ReadLine();
            }
            
            String verifica = entrada.ToLower();

            int contador = quantosCaracteresA(verifica, letra);

            if(contador == 0)
            {
                Console.WriteLine($"na string {entrada} a letra {letra} nao aparece");
            }
            else
            {
                Console.WriteLine($"na string {entrada} a letra {letra} aparece {contador} vezes");
            }

        } 
        public static int quantosCaracteresA(String texto, char letra) { 
            
            int contador = 0;

            foreach (char c in texto) { 
                
                if(c == letra)
                    contador++;

            }

            return contador;
        }

        public static void QuestoesDiscursivasMenu()
        {
            
            Console.WriteLine("----------------------------");
            Console.WriteLine("|   QUESTOES DISCURSIVAS   |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|  DIGITE A OPÇÂO DESEJADA |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|   1.Q3                   |");
            Console.WriteLine("|   2.Q4                   |");
            Console.WriteLine("|   3.Q5                   |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|   0.Sair                 |");
            Console.WriteLine("----------------------------");

            char controle = Console.ReadKey().KeyChar;

            switch (controle)
            {
                case '1':
                    Console.Clear();
                    
                    Console.WriteLine("3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1;\n enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA); \nAo final do processamento, qual será o valor da variável SOMA? \n\n\n");
                    
                    int indice = 12, Soma = 0, k = 1;
                    
                    while(k<indice)
                    {
                        k++;
                        Soma = Soma + k;
                    }

                    Console.WriteLine($"o valor da variavel soma sera de {Soma}");
                    
                    //Console.ReadKey();
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine("4) Descubra a lógica e complete o próximo elemento: ");
                    Console.WriteLine("\na) 1, 3, 5, 7, ___ \nResposta: 9, sao os numeros impares");
                    Console.WriteLine("\nb) 2, 4, 8, 16, 32, 64, ___\nResposta: 128, é 2 elevado a posição do elemento");
                    Console.WriteLine("\nc) 0, 1, 4, 9, 16, 25, 36, ___\nReposta: 49, é a posição elevada ao quadrado");
                    Console.WriteLine("\nd) 4, 16, 36, 64, ___\nResposta: 100, são os numeros pares elevados ao quadrado");
                    Console.WriteLine("\ne) 1, 1, 2, 3, 5, 8, ___\nResposta: 13, é a sequencia de fibonacci");
                    Console.WriteLine("\nf) 2, 10, 12, 16, 17, 18, 19, ___\nResposta: 200, essa foi mais dificil,mas falando em voz alta, percebi que todas começam com a letra D ");

                    break;

                case '3':
                    Console.Clear();
                    Console.WriteLine("Primeiro eu ligo uma lâmpada, e vou em uma sala,\n\n Caso acesa eu sei o interruptor dessa sala,\n\n então eu volto e ligo outro, vou em outra sala, \nse tbm estiver acesa eu sei o interruptor dessa sala\nconsequentemente eu deduzo o ultimo interruptor por eliminação\n caso esteja desligada eu deduzo o ultimo interruptor por eliminação tambem.\n\nPorem, se a primeira sala que eu entrei não estiver com a lampada acesa,\n desligo o interruptor que eu havia ligado, ligo outro interruptor\n\nentro em uma sala diferente se a sala estiver ligada eu descubro o interruptor dela\n pois é o unico ligado, e o que eu desliguei é da sala que eu não entrei e o que eu nao mexi é o da primeira sala que eu entrei\n\n caso a sala esteja desliga o interruptor correspondente é o que eu desliguei,\n o aceso é a sala que eu não entrei\n e o que eu não mexi é da primeira sala que eu entrei.");
                    break;
                case '0':
                    break;

                default:
                    Console.WriteLine("selecione uma opção que existe");
                    break;

            }
        }

    }
}
