using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExpilicityImplimentation
{
    public class UserInformation 
    {

        #region Attributes
        
        /// <summary>
        /// This Fild For Indexer
        /// </summary>
        private UserInformation[] _users;  
        private string _userFullName;
        private long _id;
        private string _messageToUser;
        private Roles _role;

        #endregion

        #region Behaviors

        #region Constructors

        public UserInformation()
        {
            _users = new UserInformation[2000];
        }

        #endregion

        #region Getter & Setter

        /// <summary>
        /// This is Indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public UserInformation this[long index]
        {
            get
            {
                return _users[index];
            }
            set 
            {
                _users[index] = value;
            }
        }

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
