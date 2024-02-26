namespace RM98502.Models
{
    public class Usuario
    {
        private string Nome;

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataNascimento { get; set; }

        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException("O campo deve conter um valor");
            }
            else
            {
                Nome = nome;
            }
        }
    }
}
