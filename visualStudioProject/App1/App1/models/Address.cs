namespace App1.services.models
{
    class Address
    {
        public string Cep { get; set; } = "";
        public string Logradouro { get; set; } = "";
        public string Complemento { get; set; } = "";
        public string Bairro { get; set; } = "";
        public string Localidade { get; set; } = "";
        public string uf { get; set; } = "";
        public string Unidade { get; set; } = "";
        public string Ibge { get; set; } = "";
        public string Gia { get; set; } = "";

        public bool Success { get; set; } = true;

        public string minify()
        {
            string response = "";
            response += "cep: " + Cep + "\n";
            response += "logradouro: " + Logradouro + "\n";
            response += "complemento: " + Complemento + "\n";
            response += "bairro: " + Bairro + "\n";
            response += "localidade: " + Localidade + "\n";
            response += "uf: " + uf + "\n";
            response += "unidade: " + Unidade + "\n";
            response += "ibge: " + Ibge + "\n";
            response += "gia: " + Gia + "\n";
            return response;
        }
    }
}
