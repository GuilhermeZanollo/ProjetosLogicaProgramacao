class Program
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento(5);

        while (true) {
        
            Console.WriteLine("\nGERENCIADOR DE ESTACIONAMENTO\n");
            Console.WriteLine("1. Adicionar carro");
            Console.WriteLine("2. Remover carro");
            Console.WriteLine("3. Listar carros");
            Console.WriteLine("4. Ver vagas disponíveis");
            Console.WriteLine("5. Fechar o sistema\n");
            Console.Write("Digite o número de uma das opções: ");
            
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Opção inválida");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("\nDigite a placa do carro: ");
                    string placaAdd = Console.ReadLine();
                    estacionamento.AdicionarCarro(placaAdd.ToUpper());
                    break;

                case 2:
                    Console.Write("\nDigite a placa do carro: ");
                    string placaRemover = Console.ReadLine();
                    estacionamento.RemoverCarro(placaRemover.ToUpper());
                    break;

                case 3:
                    estacionamento.ListarCarros();
                    break;

                case 4:
                    estacionamento.MostrarVagasDisponiveis();
                    break;

                case 5:
                    Console.WriteLine("\nPrograma fechando...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        }
    }
}