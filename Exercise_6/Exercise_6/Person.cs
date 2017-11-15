using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_6
{

    public class Person
    {

        string name;
        string email;

        private static Person instance;
        // Lock synchronization object
        private static object syncLock = new object();

        private Person(){}


        public static Person LockingCheck() {

            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new Person();
                    }
                }
            }
            return instance;
        }

        public String GetUserName()
        {
            return this.name;
        }

        public void SetUserName(String sentName) {
            this.name = sentName;
        }

        public String GetUserEmail()
        {
            return this.email;
        }

        public void SetUserEmail(String sentEmail)
        {
            this.email = sentEmail;
        }
    }
}