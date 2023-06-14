using System.Numerics;

namespace ATMbank
{
    public class Program
    {
        static public decimal Balance;
        static public string process = "";
        static void Main(string[] args)
        {
            try
            {
                usrInterface();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           // finally { Console.WriteLine(process);
            //}
        }

        static void usrInterface()
        {
            Console.WriteLine("Welcome our costumer");
            
            bool situation = true;
            while (situation)
            {
                Console.WriteLine("Select the transaction number: 1-View Balance 2-Withdraw 3-Deposit 4-Exit");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                   Console.WriteLine(ViewBalance());
                }
                if (number == 2)
                {
                    Console.WriteLine("Enter the amount you want to withdraw:");
                     decimal amountW = Convert.ToDecimal(Console.ReadLine());
                     Withdraw(amountW);
                    process += $"you withdraw {amountW} for your Balance \n\n";
                    Console.WriteLine(ViewBalance());

                }
                if (number == 3)
                {

                    Console.WriteLine("Enter the amount you want to deposit:");
                     decimal amountD = Convert.ToDecimal(Console.ReadLine());
                     Deposit(amountD);
                    process += $"you deposit {amountD} for your Balance \n\n";
                    Console.WriteLine(ViewBalance());


                }
                else if (number == 4)
                {
                    Console.WriteLine(process);
                    situation = false;
                }
            }
        }

        static public decimal ViewBalance()
        {
            return Balance;
        }

        static public decimal Withdraw(decimal amountW)
        {
           // Console.WriteLine("Enter the amount you want to withdraw:");
           // decimal amountW = Convert.ToDecimal(Console.ReadLine());
            if (amountW > Balance || amountW <= 0)
            {
                //throw new Exception("You cannot perform this transaction.");
                Console.WriteLine("You cannot perform this transaction.");
                return -1;
            }
            Balance -= amountW;
            return Balance;
        }

        static public decimal Deposit(decimal amountD)
        {
            //Console.WriteLine("Enter the amount you want to deposit:");
           // decimal amountD = Convert.ToDecimal(Console.ReadLine());
            if (amountD <= 0)
            {
                //throw new Exception("You cannot perform this transaction.");
                Console.WriteLine("You cannot perform this transaction.");
                return -1;
            }
            Balance += amountD;
            return Balance; 
        }
    }
}

