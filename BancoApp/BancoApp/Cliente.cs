namespace BancoApp
{
    internal class Cliente
    {

        public Cliente(string titular)
        {
            Titular = titular;
        }

        public string Name { get; set; }
        public string Titular { get; set; }

    }
}