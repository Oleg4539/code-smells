
namespace ATM.ClassLibrary.CustomEventArgs
{
    public class CheckBalanceEventArgs : AccountEventArgs
    {
        public int Balance { get; private set; }
        public CheckBalanceEventArgs(string fullName, string cardNumber, int balance) :
       base(fullName, cardNumber)
        {
            Balance = balance;
        }

    }
}