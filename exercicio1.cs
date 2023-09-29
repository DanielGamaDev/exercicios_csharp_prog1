using System;

class Program{
    static void Main()
    {
        IniciaPrograma();
        Console.Write("Valor de a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Valor de b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Valor de c: ");
        int c = int.Parse(Console.ReadLine());
        int d = CalculaDelta(a, b, c);
        Tuple<int?, int?> resultado = CalculaX(a, b, d);
        MostraResultado(resultado.Item1, resultado.Item2, d);
    }

    static void IniciaPrograma()
    {
        Console.WriteLine("Vamos resolver a fórmula de BHASKARA");
        Console.WriteLine("Informe os valores pedidos abaixo\n");
    }

    static int CalculaDelta(int a, int b, int c)
    {
        int delta = (b * b) - (4 * a * c);
        return delta;
    }

    static Tuple<int?, int?> CalculaX(int a, int b, int delta)
    {
        if (delta >= 0 && a != 0)
        {
            int x1 = (-b + (int)Math.Sqrt(delta)) / (2 * a);
            int x2 = (-b - (int)Math.Sqrt(delta)) / (2 * a);
            return Tuple.Create<int?, int?>(x1, x2);
        }
        else
        {
            return Tuple.Create<int?, int?>(null, null); // Tratamento de erro
        }
    }

    static void MostraResultado(int? x1, int? x2, int delta)
    {
        if (delta >= 0)
        {
            Console.WriteLine($"O valor de Δ(Delta) é {delta}\n");
            Console.WriteLine($"x1 = {x1}\n");
            Console.WriteLine($"x2 = {x2}\n");
        }
        else
        {
            Console.WriteLine("Impossível calcular! Pois o valor de Δ(Delta) é menor que 0(zero)");
        }
    }
}
