namespace Calculadora.Atvd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine(" --- Calculadora ---");

                Console.WriteLine();

                Console.WriteLine(" Digite 1 para Somar");
                Console.WriteLine(" Digite 2 para Subtrair");
                Console.WriteLine(" Digite 3 para Multiplicar");
                Console.WriteLine(" Digite 4 para Dividir");
                Console.WriteLine(" Digite S para sair");

                Console.WriteLine();

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao == "s")
                {
                    Console.WriteLine("Operação Inválida, tente novamente!");
                    Console.ReadLine();
                    continue; 
                }

                Console.WriteLine();

                Console.Write(" Digite o primeiro número: ");

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write(" Digite o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;
                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (operacao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("O segundo número não pode ser ZERO, tente novamente.");

                        Console.ReadLine();

                        Console.Write("Digite o segundo número: ");

                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                }

                decimal resultadoFormatado = Math.Round(resultado, 2);

                Console.WriteLine(" O resultado da sua operação é: " + resultadoFormatado);

                Console.ReadLine();

               } while (true);

            }
    }
}