class Program
{
    static void Main()
    {
    while (true)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a operação: ");
            int operacao = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int resultado = Calcular(valor1, operacao, valor2);

            Console.WriteLine($"O resultado da operação é: {resultado}");
        }
    }

    static int Calcular(int valor1, int operacao, int valor2)
    {
        switch (operacao)
        {
            case '+':
                return valor1 + valor2;
            case '-':
                return valor1 - valor2;
            case '*':
                return valor1 * valor2;
            case '/':
                return valor1 / valor2;

            default:
                Console.WriteLine("Operação inválida.");
                return 0;
        }
    }
}