using System;
using ATM.Logic;

namespace ATM.Ui
{
    class Program
    {

        static BankAccount bankAccount;

        static void Main(string[] args)
        {

            //Customer c = new Customer("kevin", "derudder");
            //// POLYMORPHISM
            //c.Bank = new KbcBank();

            ////BankAccount ba = c.Bank.CreateBankAccount();

            ////c.Bank = new IngBank();
            ////c.Bank = new Bloedworst(); // ERROR

            LoadBankAccount();
            ShowMainMenu();

            //Person p = new Person();
           
            
        }

        static void LoadBankAccount() {
            bankAccount = new BankAccount("12345678");
        }

        static void ShowMainMenu() {

            string input;

            do {
                Console.WriteLine("> 1. Haal geld van zichtrekening");
                Console.WriteLine("> 2. Haal geld van spaarrekening");
                Console.WriteLine("> 3. Stort geld op zichtrekening");
                Console.WriteLine("> 4. Stort geld op spaarrekening");
                Console.WriteLine("> 5. Saldoweergave");
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

                    switch (choice) {
                        case 1: WithdrawFromDeposit();break;
                        case 2: WithdrawFromSavings(); break;
                        case 3: AddToDeposit();break;
                        case 4: AddToSavings();break;
                        case 5:
                        default: Console.WriteLine(bankAccount);break;
                    }

                    Console.WriteLine($"bedankt voor u keuze: {choice}");
                }
            }
            while (input.ToUpper() != "X");
            

        }

        public static void AddToDeposit() {
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

        public static void WithdrawFromDeposit() {
            double amount = ShowHowMuchMoneyLine(true);
            bankAccount.WithdrawFromDeposit(amount);
            Console.WriteLine($"uw zichtrekeningsaldo is {bankAccount.Deposit}€");
        }

        public static void WithdrawFromSavings()
        {
            double amount = ShowHowMuchMoneyLine(true);
            bankAccount.WithdrawFromSavings(amount);
            Console.WriteLine($"uw spaarrekeningsaldo is {bankAccount.Savings}€");
        }

        public static double ShowHowMuchMoneyLine(bool isWithdraw) {
            if (isWithdraw)
            {
                Console.WriteLine("> Hoeveel geld had u willen opnemen");
            }
            else {
                Console.WriteLine("> Hoeveel geld had u willen storten");
            }
            
            string input = Console.ReadLine();
            double amount = 0;
            double.TryParse(input, out amount);

            return amount;
        }

    }
}
