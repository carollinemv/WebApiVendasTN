namespace WebApiVendasTN.Dominio
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private string telefone;
        private string endereco;

        public Cliente()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
