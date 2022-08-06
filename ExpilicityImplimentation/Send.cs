using System;
using System.Collections.Generic;
using System.Text;

namespace ExpilicityImplimentation
{
    public sealed class Send : ISmsSender, IYahooEmailSender, IGmailEmailSender, IOutLookEmailSender, IHotMailEmailSender
    {
        void ISmsSender.Sender(UserInformation information)
        {
            this.Sender("SMS", information);
        }

        void IYahooEmailSender.Sender(UserInformation information)
        {
            this.Sender("YahooEmail", information);
        }

        void IGmailEmailSender.Sender(UserInformation information)
        {
            this.Sender("GmailEmail", information);
        }

        void IOutLookEmailSender.Sender(UserInformation information)
        {
            this.Sender("OutLook", information);
        }

        void IHotMailEmailSender.Sender(UserInformation information)
        {
            this.Sender("HotMail", information);
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

        private void Sender(string sender, UserInformation information)
        {
            Console.WriteLine($"  This {sender} Is For U : \n" +
                           $" Dear {information.UserFullName} With {information.Id} code , You Are {this.WhoAreYou(information.Role)} . \n" +
                           $" This Message Is For You : {information.MessageToUser}");
        }
    }
}
