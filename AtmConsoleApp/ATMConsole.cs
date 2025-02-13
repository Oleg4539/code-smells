﻿using ATM.ClassLibrary.Classes;
using ATM.ClassLibrary.CustomEventArgs;

namespace ATM.ConsoleApp
{
    public class ATMConsole
    {
        public Session Session { get; set; }
        public ATMConsole(Session session)
        {
            Session = session;
            SetAccountHandlers();
            Authorize();
            DisplayMenu();
        }
        protected void SetAccountHandlers()
        {
            Session.SetAccountHandlers(authorizeHandler!, checkBalanceHandler!,
            putHandler!, withdrawHandler!, transferHandler!);
        }
        public void Authorize()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("\n\tAuthorization\n\n Card Number: ");
                string cardNumber = Console.ReadLine()!;
                Console.Write(" PIN: ");
                string password = SecureInputPassword();

                if (Session.Authorize(cardNumber, password))
                    break;

                Console.Clear();
                Console.Write("\tAccount number is incorrect! Try again.\n\n");
            }
        }
        public string SecureInputPassword()
        {
            var password = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;
                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    Console.Write("\b \b");
                    password = password[0..^1];
                }

                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return password;
        }
        void authorizeHandler(object sender, AuthorizeEventArgs e)
        {
            Console.Clear();
            if (e.Success == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Your password is incorrect!");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                Authorize();
            }
            else
            {
                Console.Write($"\n\n\tWelcome, {e.FullName}!");
                Thread.Sleep(800);
                DisplayMenu();
            }
        }
        void checkBalanceHandler(object sender, CheckBalanceEventArgs e)
        {
            Console.WriteLine($"\n\tBalance: {e.Balance}$");
        }
        void withdrawHandler(object sender, WithdrawEventArgs e)
        {
            if (e.AccountBalanceLack)
                Console.WriteLine($"\n Lack of money on account balance!");
            else if (e.ATMCashLack)
                Console.WriteLine($"\n Lack of cash in ATM!");
            else
                Console.WriteLine($"\n Take your money.");
        }
        void putHandler(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"\n Money got to your account balance safely.");
        }
        void transferHandler(object sender, TransferEventArgs e)
        {
            if (e.AccountBalanceLack)
                Console.WriteLine($"\n Lack of money on account balance!");
            else if (e.RecipientDoesntExist)
                Console.WriteLine($"\n Recipient account can not be fount.");
            else
                Console.WriteLine($"\n Money transfered successfully!");
        }
        public void Transfer()
        {
            string recipient;
            while (true)
            {
                Console.Write("\n Recipient card number: ");
                recipient = Console.ReadLine()!;
                if (Session.Bank.GetAccount(recipient) == null)
                    break;
                Console.Write("\n Enter a valid card number.");
            }
            int sum;
            while (true)
            {
                Console.Write($"\n Sum: ");
                if (int.TryParse(Console.ReadLine(), out sum))
                {
                    Session.Transfer(recipient, sum);
                    break;
                }
                else
                    Console.WriteLine($"\n Enter a valid sum.");
            }
        }
        public void Exit()
        {
            Authorize();
        }
        private int GetValidAmount(string message)
        {
            int amount;
            while (true)
            {
                Console.Write($"\n {message}: ");
                if (int.TryParse(Console.ReadLine(), out amount))
                    return amount;
                Console.WriteLine($"\n Enter a valid sum.");
            }
        }
        public void Withdraw()
        {
            int sum = GetValidAmount("Sum");
            Session.Withdraw(sum);
        }

        public void Put()
        {
            int amount = GetValidAmount("Sum");
            Session.Account.Put(amount);
        }
        public void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                var options = new List<Tuple<string, Action>>()
        {
            new Tuple<string, Action>("Check balance", Session.CheckBalance),
            new Tuple<string, Action>("Withdraw", Withdraw),
            new Tuple<string, Action>("Put", Put),
            new Tuple<string, Action>("Transfer", Transfer),
            new Tuple<string, Action>("Exit", () => Environment.Exit(0))
        };

                Console.WriteLine("\n\tMenu\n");
                for (int i = 1; i <= options.Count; i++)
                {
                    Console.WriteLine($" {i} - {options[i - 1].Item1}");
                }

                int selected;
                while (true)
                {
                    Console.Write("\n Option: ");
                    if (int.TryParse(Console.ReadLine(), out selected) && selected >= 1 && selected <= options.Count)
                        break;

                    Console.WriteLine($"\nEnter a valid option number.");
                }

                options[selected - 1].Item2();
                Console.Write("\n Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
