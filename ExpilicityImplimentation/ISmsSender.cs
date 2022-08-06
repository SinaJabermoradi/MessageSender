using System;
using System.Collections.Generic;
using System.Text;

namespace ExpilicityImplimentation
{
    public interface ISmsSender 
    {
        public void Sender(UserInformation information);

    }
}
