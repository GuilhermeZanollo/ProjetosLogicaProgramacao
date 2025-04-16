class Estacionamento
{
    private int capacidade;
    private List<Carro> vagas;

    public Estacionamento(int capacidade)
    {
        this.capacidade = capacidade;
        vagas = new List<Carro>();
    }

    public void AdicionarCarro(string placa)
    {
        if (vagas.Count >= capacidade)
        {
            Console.WriteLine("Estacionamento está cheio.");
            return;
        }

        if (vagas.Exists(c => c.Placa == placa)) // c representa cada item (carro) da lista vagas (ENTENDER)
        {
            Console.WriteLine("Carro com esta placa já está no estacionamento.");
            return;
        }

        vagas.Add(new Carro(placa));
        Console.WriteLine("Carro adicionado com sucesso.");
    }

    public void RemoverCarro(string placa)
    {
        Carro carro = vagas.Find(c => c.Placa == placa); // c representa cada item (carro) da lista vagas (ENTENDER)
        if (carro == null)
        {
            Console.WriteLine("Carro não encontrado.");
            return;
        }

        DateTime horaSaida = DateTime.Now;
        TimeSpan tempoEstacionado = horaSaida - carro.HoraEntrada;

        vagas.Remove(carro);

        Console.WriteLine($"\nCarro removido com sucesso.");
        Console.WriteLine($"Tempo de permanência: {tempoEstacionado.Hours}h {tempoEstacionado.Minutes}min {tempoEstacionado.Seconds}s");
    }

    public void ListarCarros()
    {
        if (vagas.Count == 0)
        {
            Console.WriteLine("\nNão existem carros estacionados.");
            return;
        }

        Console.WriteLine("\nCarros estacionados:");
        for (int i = 0; i < vagas.Count; i++)
        {
            var carro = vagas[i];
            Console.WriteLine($"Carro {i + 1} - Placa: {carro.Placa}, Entrada: {carro.HoraEntrada:HH:mm:ss}");
        }
    }

    public void MostrarVagasDisponiveis()
    {
        Console.WriteLine($"Vagas disponíveis: {capacidade - vagas.Count}/{capacidade}"); // (ENTENDER)
    }
}