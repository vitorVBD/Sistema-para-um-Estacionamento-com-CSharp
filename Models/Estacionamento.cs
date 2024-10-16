namespace desafioCSharp.Models
{

    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            string placa;
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Convert.ToString(Console.ReadLine());
            veiculos.Add(placa);
            Console.WriteLine("Veículo estacionado!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                Console.WriteLine("Digite a quantidade de horas que o veiculo ficou estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoHora * horas);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total é de {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se a placa digitada está correta.");
            }
        }

        public void ListarVeiculos()
        {
            if(veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados");
            }
        }
    }
}