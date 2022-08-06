using System;
using System.Collections.Generic;
using System.Text;

namespace ExpilicityImplimentation
{
   public interface IGmailEmailSender 
    {
        public void Sender(UserInformation information);
    
    }
}
