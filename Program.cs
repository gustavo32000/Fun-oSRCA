using System;

namespace FunçãoSRCA
{
    class Program
    {
        static void Main(string[] args)
        {
            calculos(10,10,"/");
        }

        /// <summary>
        /// A função calculos realiza uma das quatro operações matemáticas e exibe o resultado em tela de console. 
        /// Você precisa passar 2 números e depois passar um operador de quatro possibilidades, que são:
        /// + -> soma
        /// - -> subtração
        /// * -> multiplicação
        /// / -> divisão
        /// </summary>
        /// <param name="n1">Passe um número inteiro</param>
        /// <param name="n2">Passe um número inteiro</param>
        /// <param name="operacao">Passe o símbolo entre aspas</param>
        static void calculos(int n1, int n2, string operacao){
            if (operacao.Equals("+")){
                Console.WriteLine("O resultado da soma é " +(n1+n2));
            }
            else if (operacao.Equals("-")){
                Console.WriteLine("O resultado da subtração é " +(n1-n2));
            }
            else if (operacao.Equals("*")){
                Console.WriteLine("O resultado da multiplicação é " +(n1*n2));            
            }
            else if (operacao.Equals("/")){
                Console.WriteLine("O resultado da divisão é " +(n1/n2));            
            }
            else 
                Console.WriteLine("Essa operação não existe!");

        }
    }
}
