using System;

namespace ExpilicityImplimentation
{
    class Program
    {
        public UserInformation AddUser(UserInformation user , string name , long id , Roles roles , string message)
        {
            user.UserFullName = name;
            user.Id = id;
            user.Role = roles;
            user.MessageToUser =message;

            return user;
        }

        static void Main(string[] args)
        {
            UserInformation user = new UserInformation();
            Program u0 = new Program();
            Program u1 = new Program();
            Program u2 = new Program();
            Program u3 = new Program();
            Program u4 = new Program();

            IYahooEmailSender yahooSender = new Send();         // Polymorphism and Explicity Implimentation Notic
            IGmailEmailSender gmailSender = new Send();         // Polymorphism and Explicity Implimentation Notic
            IHotMailEmailSender hotMailSender = new Send();     // Polymorphism and Explicity Implimentation Notic
            IOutLookEmailSender outLookSender = new Send();     // Polymorphism and Explicity Implimentation Notic
            ISmsSender SmsSender = new Send();                  // Polymorphism and Explicity Implimentation Notic

            user[0] = new UserInformation();
            u0.AddUser(user[0], "Sina Jabermoradi",1, Roles.Manager, "You Are Best And Richest Person In The Word . ");
            user[1] = new UserInformation();
            u1.AddUser(user[1], "Sina Falaki" ,2, Roles.Manager , "You Are Best And Richest Person In The Word too . ");
            user[2] = new UserInformation();
            u2.AddUser(user[2], "Samane Sami", 3, Roles.Clerk, "Please Do Your Works Excellent .");
            user[3] = new UserInformation();
            u3.AddUser(user[3], "Saba Sabayi", 4, Roles.Costumer, "We Hope Injoy Your Mahsole . ");
            user[4] = new UserInformation();
            u4.AddUser(user[4], "Toraj Koiomarsi", 5, Roles.Clerk, "Please Do Your Works Excellent . ");


            yahooSender.Sender(user[0]);
            gmailSender.Sender(user[1]);
            hotMailSender.Sender(user[2]);
            outLookSender.Sender(user[3]);
            SmsSender.Sender(user[4]);

            Console.ReadKey();
        }
    }
}
