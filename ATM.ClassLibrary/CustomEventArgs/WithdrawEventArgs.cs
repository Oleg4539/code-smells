﻿
namespace ATM.ClassLibrary.CustomEventArgs
{
    public class WithdrawEventArgs : AccountEventArgs
    {
        public bool ATMCashLack { get; private set; }
        public bool AccountBalanceLack { get; private set; }
        public WithdrawEventArgs(string fullName, string cardNumber, bool atmCashLack,
       bool accountBalanceLack) : base(fullName, cardNumber)
        {
            ATMCashLack = atmCashLack;
            AccountBalanceLack = accountBalanceLack;
        }
    }
}