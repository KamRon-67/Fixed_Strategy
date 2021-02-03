using System;

namespace Fixed_Strategy
{
    class MainApp

    {
        static void Main()
        {
            Login login;

            // Three contexts following different strategies

            login = new Login(new LoginUsingEmail());
            login.LoginWebsite();

            login = new Login(new LoginUsingPhone());
            login.LoginWebsite();

            login = new Login(new LoginUsingSocialMedia());
            login.LoginWebsite();

            // Wait for user

            Console.ReadKey();
        }
    }

    abstract class LoginStrategy

    {
        public abstract void SendLoginRequest();
    }

    class LoginUsingEmail : LoginStrategy

    {
        public override void SendLoginRequest()
        {
            Console.WriteLine(
              "Logging in using LoginUsingEmail");
        }
    }

    class LoginUsingPhone : LoginStrategy

    {
        public override void SendLoginRequest()
        {
            Console.WriteLine(
              "Logging in using LoginUsingPhone");
        }
    }

    class LoginUsingSocialMedia : LoginStrategy

    {
        public override void SendLoginRequest()
        {
            Console.WriteLine(
              "Logging in using LoginUsingSocialMedia");
        }
    }

    class Login

    {
        private LoginStrategy _loginStrategy;

        // Constructor

        public Login(LoginStrategy strategy)
        {
            this._loginStrategy = strategy;
        }

        public void LoginWebsite()
        {
            _loginStrategy.SendLoginRequest();
        }
    }
}
