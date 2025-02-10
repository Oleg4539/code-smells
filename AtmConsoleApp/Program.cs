using ATM.ClassLibrary;
using ATM.ClassLibrary.Classes;
using ATM.ConsoleApp;
string customersDataPath = @"C:\Users\kemir\Desktop\ATM.ClassLibrary\customers.json";
var atms = new List<AutomatedTellerMachine> 
    { new AutomatedTellerMachine("12", "Korolyova 24b", 1000000) };
var bank = new Bank("Privat23", atms, customersDataPath);
int atmId = 0;
new ATMConsole(new Session(bank, atmId));