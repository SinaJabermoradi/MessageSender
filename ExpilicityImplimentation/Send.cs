using System;
using System.Collections.Generic;
using System.Text;

namespace ExpilicityImplimentation
{
    public sealed class Send : ISmsSender, IYahooEmailSender, IGmailEmailSender, IOutLookEmailSender, IHotMailEmailSender
    {
        /// <summary>
        /// Explicity Implimentation For SmsSender
        /// </summary>
        /// <param name="information"></param>
        void ISmsSender.Sender(UserInformation information)
        {
            this.Sender("SMS", information, ConsoleColor.DarkBlue);
        }

        /// <summary>
        /// Explicity Implimentation For YahooSender
        /// </summary>
        /// <param name="information"></param>
        void IYahooEmailSender.Sender(UserInformation information)
        {
            this.Sender("YahooEmail", information, ConsoleColor.DarkGray);
        }

        /// <summary>
        /// Explicity Implimentation For GmailSender
        /// </summary>
        /// <param name="information"></param>
        void IGmailEmailSender.Sender(UserInformation information)
        {
            this.Sender("GmailEmail", information, ConsoleColor.DarkCyan);
        }

        /// <summary>
        /// Explicity Implimentation For OutLookSender
        /// </summary>
        /// <param name="information"></param>
        void IOutLookEmailSender.Sender(UserInformation information)
        {
            this.Sender("OutLook", information, ConsoleColor.DarkGreen);
        }

        /// <summary>
        /// Explicity Implimentation For HotMailSender
        /// </summary>
        /// <param name="information"></param>
        void IHotMailEmailSender.Sender(UserInformation information)
        {
            this.Sender("HotMail", information, ConsoleColor.DarkMagenta);
        }

        private string WhoAreYou(Roles userRole)
        {
            switch (userRole)
            {
                case Roles.Manager:
                    {
                        return "Manager";
                    }
                case Roles.Clerk:
                    {

                        return "Clerk";

                    }
                case Roles.Costumer:
                    {

                        return "Costumer";

                    }
                default:
                    {
                        return "";
                    }
            }
        }

        private void Sender(string sender, UserInformation information, ConsoleColor consoleColor)
        {
            Console.WriteLine("---------------------------------------------------------------\n");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine($" This {sender} Is For You : \n" +
                           $" Dear {information.UserFullName} With {information.Id} code , You Are {this.WhoAreYou(information.Role)} . \n" +
                           $" This Message Is For You : {information.MessageToUser}\n");
        }
    }
}
