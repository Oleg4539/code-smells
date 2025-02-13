﻿
namespace ATM.ClassLibrary.CustomEventArgs
{
    public class AuthorizeEventArgs : AccountEventArgs
    {
        public bool Success { get; private set; }
        public AuthorizeEventArgs(string fullName, string cardNumber, bool success) :
       base(fullName, cardNumber)
        {
            Success = success;
        }
    }
}