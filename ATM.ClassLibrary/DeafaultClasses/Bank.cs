using Newtonsoft.Json;
namespace ATM.ClassLibrary
{
    public class Bank
    {
        private string dataPath;
        public string Name { get; private set; }
        public List<AutomatedTellerMachine> ATMs { get; private set; }
        private List<Account> Accounts { get; set; }
        public Bank(string name, List<AutomatedTellerMachine> atms, string
       customersDataPath)
        {
            dataPath = customersDataPath;
            Name = name;
            ATMs = atms;
            LoadCustomersData();
        }
        public void LoadCustomersData()
        {
            string json = File.ReadAllText(dataPath);
            Accounts = JsonConvert.DeserializeObject<List<Account>>(json)!;
        }
        public Account GetAccount(string cardNumber)
        {
            return Accounts.Where(customer => customer.CardNumber == cardNumber).FirstOrDefault();
        }
    }
}
