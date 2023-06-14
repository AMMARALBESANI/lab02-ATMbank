using ATMbank;

namespace ATMbanktest
{
    public class UnitTest1
    {
        [Fact]
        public void viewBalanceTest()
        {
            //ARRANGE
            Program.Balance = 50.0M;


            //ACT
            decimal result = Program.ViewBalance();

            //ASSERT

            Assert.Equal(50.0M, result);

        }

        [Fact]
        public void WithdrawingAmount50FromBalnce100()
        {
            //ARRANG
            Program.Balance = 100.0M;
            decimal amountw = 50.0M;

            //ACT
            decimal result = Program.Withdraw(amountw);

            //ASSERT
            Assert.Equal(50.0M, result);

        }

        [Fact]

        public void WithdrawingAmount100FromBalnce50()
        {
            //ARANGE
            Program.Balance = 50.0M;
            decimal amount = 100.0M;

            //ACT
            decimal result= Program.Withdraw(amount);

            //ASSERT

            Assert.Equal(-1, result);
        }

        [Fact]

        public void DepositAmount100ToBalance()
        {
            //Arrang
            Program.Balance = 0.0M;
            decimal amount = 100.0M;

            //ACT
            decimal result = Program.Deposit(amount);

            //ASSERT

            Assert.Equal(100.0M , result);

        }


        [Fact]
        public void DepositAmountNegativAmountToBalance()
        {
            //Arrang
            Program.Balance = 100.0M;
            decimal amount = -10.0M;

            //ACT
            decimal result = Program.Deposit(amount);

            //ASSERT

            Assert.Equal(-1, result);

        }

        

    }
}