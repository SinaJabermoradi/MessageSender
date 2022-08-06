using System;
using System.Collections.Generic;
using System.Text;

namespace ExpilicityImplimentation
{
    public class UserInformation
    {

        #region Attributes

        private string _userFullName;
        private long _id;
        private string _messageToUser;
        private Roles _role;

        #endregion

        #region Behaviors

        #region Getter & Setter


        public string UserFullName
        {
            get { return _userFullName; }
            set { _userFullName = value; }
        }

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string MessageToUser
        {
            get { return _messageToUser; }
            set { _messageToUser = value; }
        }

        public Roles Role
        {
            get { return _role; }
            set { _role = value; }
        }


        #endregion

        #endregion

    }
}
