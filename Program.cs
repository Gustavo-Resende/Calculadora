class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a operação: ");
        char operacao = char.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

    if (operacao == '+')
        {
            int resultado = valor1 + valor2;
            Console.Write($"A soma de {valor1} + {valor2} = {resultado}");
        }

    if (operacao == '-')
        {
            int resultado = valor1 - valor2;
            Console.Write($"A subtração de {valor1} - {valor2} = {resultado}");
        }
    
    if (operacao == '*')
        {
            int resultado = valor1 * valor2;
            Console.Write($"A multiplicação de {valor1} * {valor2} = {resultado}");
        }

    if (operacao == '/')
        {
            int resultado = valor1 / valor2;
            Console.Write($"A divisão de {valor1} / {valor2} = {resultado}");
        }
    }
}