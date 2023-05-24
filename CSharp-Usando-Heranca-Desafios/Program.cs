using CSharp_Usando_Heranca_Desafios.Calculadora;

public class Program
{
    
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("-----------------------");

            while (true)
            {

                Console.WriteLine("Selecione a operação desejada");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                Console.WriteLine("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segunda número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Calculadora calculadora = new Calculadora(numero1, numero2);

                switch (opcao)
                {

                    case 1:
                        Console.WriteLine($"Resultado: {calculadora.Somar()}");
                        break;

                    case 2:
                        Console.WriteLine($"Resultado: {calculadora.Subtrair()}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {calculadora.Multiplicar()}");
                        break;
                    case 4:
                        Console.WriteLine($"Resultado: {calculadora.Dividir()}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("--------------------------------------");
            }


        }

    }
