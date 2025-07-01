using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> clientes = new Dictionary<int, string>();

        clientes.Add(1, "Lucas");
        clientes.Add(2, "Carla");
        clientes.Add(3, "João");
        clientes.Add(4, "Marcos");
        clientes.Add(5, "Juliana");

        var clientesFiltrados = clientes.Where(c => c.Key >= 3);

        Console.WriteLine("Clientes filtrados (ID >= 3):");
        foreach (var cliente in clientesFiltrados)
        {
            Console.WriteLine($"ID: {cliente.Key}, Nome: {cliente.Value}");
        }

        Console.WriteLine();

        Queue<string> filaAtendimento = new Queue<string>();

        filaAtendimento.Enqueue("Lucas");
        filaAtendimento.Enqueue("Carla");
        filaAtendimento.Enqueue("João");
        filaAtendimento.Enqueue("Marcos");
        filaAtendimento.Enqueue("Juliana");

        Console.WriteLine("Iniciando atendimento:");
        while (filaAtendimento.Count > 0)
        {
            Console.WriteLine($"Atendendo cliente: {filaAtendimento.Dequeue()}");
        }
        Console.WriteLine("Atendimento encerrado. ");
    }
}
