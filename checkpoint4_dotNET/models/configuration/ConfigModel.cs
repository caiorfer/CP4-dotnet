namespace models.configuration
{
    public class ConfigModel
    {
        private static ConfigModel _instance;
        public string ApiKey { get; private set; }

        private ConfigModel()
        {
            // Carregar a chave de API de um arquivo de configuração, variáveis de ambiente, etc.
            ApiKey = "https://v6.exchangerate-api.com/v6/feb628771760a04e158f0340/latest/USD";
        }

        public static ConfigModel Instance => _instance ??= new ConfigModel();
    }
}
