using System;

namespace StateDemo
{
    class StateDemo
    {
        public static void InitializeDemo()
        {
            Account account = new Account("Jonny Bravo");
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            Console.ReadKey();
        }
    }

    public class SilverState : State
    {

        public SilverState(State state) :this(state.Balance, state.Acount)
        {
        }

        public SilverState(double balance,Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            interest = 0.0;
            lowerLimit = 0.0;
            uperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override void WithDraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < lowerLimit) {
                account.State = new RedState(this);
            }

            else if (balance > uperLimit)
            {
                account.State = new GoldenState(this);
            }
        }
    }

    public class RedState : State
    {
        private double serviceFee;
        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Acount;
            Initialize();

        }

        private void Initialize()
        {
            interest = 0.0;
            lowerLimit = -100.0;
            uperLimit = 0.0;
            serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            
        }

        public override void WithDraw(double amount)
        {
            amount = amount - serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        private void StateChangeCheck()
        {
            if (balance > uperLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }

    public class GoldenState : State
    {

        // Overloaded constructors

        public GoldenState(State state)
      : this(state.Balance, state.Acount)
    {
        }

        public GoldenState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            interest = 0.05;
            lowerLimit = 1000.0;
            uperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override void WithDraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }



    public class Account
    {
        private string owner;
        private State state;

        public Account(string owner)
        {
            this.owner = owner;
            this.state = new SilverState(0.0, this);
        }

        public double Balance
        {
            get { return state.Balance; }
        }

        public State State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}",
              this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            state.WithDraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",
              this.State.GetType().Name);
        }

        public void PayInterest()
        {
            state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",
              this.State.GetType().Name);
        }
    }

    public abstract class State
    {
        protected Account account;
        protected double balance;

        protected double interest;
        protected double lowerLimit;
        protected double uperLimit;

        public Account Acount
        {
            get { return this.account; }
            set { this.account = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public abstract void Deposit(double amount);
        public abstract void WithDraw(double amount);
        public abstract void PayInterest();
    }
}
