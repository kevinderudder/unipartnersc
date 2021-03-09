using System;
using ATM.Logic;

namespace ATM.Ui
{
    class Program
    {
        static BankAccount bankAccount;

        static void Main(string[] args)
        {
            LoadBankAccount();
            ShowMainMenu();
        }

        static void LoadBankAccount()
        {
            bankAccount = new BankAccount("12345678");
        }

        static void ShowMainMenu()
        {

            string input;

            do
            {
                Console.WriteLine("> 1. Haal geld van zichtrekening");
                Console.WriteLine("> 2. Haal geld van spaarrekening");
                Console.WriteLine("> 3. Stort geld op zichtrekening");
                Console.WriteLine("> 4. Stort geld op spaarrekening");
                Console.WriteLine("> 5. Saldoweergave");
                Console.WriteLine("> 6. Zet euro om naar dollar");
                Console.WriteLine("> 7. Zet dollar om naar euro");
                Console.WriteLine("> Maak een keuze, druk X om te stoppen");

                input = Console.ReadLine();

                if (input.ToUpper() == "X")
                {
                    Console.WriteLine("Bedankt, prettige dag nog.");
                }
                else
                {
                    //int choice = Convert.ToInt32(input);

                    int choice = 5;
                    Int32.TryParse(input, out choice);

                    switch (choice)
                    {
                        case 1: WithdrawFromDeposit(); break;
                        case 2: WithdrawFromSavings(); break;
                        case 3: AddToDeposit(); break;
                        case 4: AddToSavings(); break;
                        case 6: ConvertToEur();break;
                        case 7: ConvertToDollar();break;
                        case 5:
                        default: Console.WriteLine(bankAccount); break;
                    }

                    Console.WriteLine($"bedankt voor u keuze: {choice}");
                }
            }
            while (input.ToUpper() != "X");
        }

        private static void ConvertToDollar()
        {
            double amount = ShowHowMuchMoneyToConvertLine();
            double amountInDollar = Math.Round(Money.ConvertToDollar(amount));
            Console.WriteLine($"> {amount}euro is gelijk aan {amountInDollar}dollar");

        }

        private static double ShowHowMuchMoneyToConvertLine()
        {
            Console.WriteLine("> Hoeveel geld wil je omzetten?");
            double amount = Convert.ToDouble(Console.ReadLine());
            return amount;
          
        }

        private static void ConvertToEur()
        {
            throw new NotImplementedException();
        }

        public static void AddToDeposit()
        {
            double amount = ShowHowMuchMoneyLine(false);
            bankAccount.AddToDeposit(amount);
            Console.WriteLine($"uw zichtrekeningsaldo is {bankAccount.Deposit}€");
        }

        public static void AddToSavings()
        {
            double amount = ShowHowMuchMoneyLine(false);
            bankAccount.AddToSavings(amount);
            Console.WriteLine($"uw spaarrekeningsaldo is {bankAccount.Savings}€");
        }

        public static void WithdrawFromDeposit()
        {
            try
            {
                double amount = ShowHowMuchMoneyLine(true);
                bankAccount.WithdrawFromDeposit(amount);
                Console.WriteLine($"uw zichtrekeningsaldo is {bankAccount.Deposit}€");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine("*****");
                Console.WriteLine($" > U probeerde {ex.RequestedAmount}euro af te halen, er is maar {ex.AvailableAmount}euro beschikbaar");
            }
        }

        public static void WithdrawFromSavings()
        {
            try {
                double amount = ShowHowMuchMoneyLine(true);
                bankAccount.WithdrawFromSavings(amount);
                Console.WriteLine($"uw spaarrekeningsaldo is {bankAccount.Savings}€");
            }
            catch (InsufficientFundsException ex) {
                Console.WriteLine("ERROR");
                Console.WriteLine("*****");
                Console.WriteLine($" > U probeerde {ex.RequestedAmount}euro af te halen, er is maar {ex.AvailableAmount}euro beschikbaar");
            }
        }

        public static double ShowHowMuchMoneyLine(bool isWithdraw)
        {
            if (isWithdraw)
            {
                Console.WriteLine("> Hoeveel geld had u willen opnemen");
            }
            else
            {
                Console.WriteLine("> Hoeveel geld had u willen storten");
            }

            string input = Console.ReadLine();
            double amount = 0;
            double.TryParse(input, out amount);

            return amount;
        }

    }
}
