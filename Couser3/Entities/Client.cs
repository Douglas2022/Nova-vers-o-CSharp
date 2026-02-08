using System;
using System.Collections.Generic;

namespace Couser3.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Client)); //Comapara se é cliente
            {
                return false;
            }
            Client other = obj as Client;    //Donw cats
            return Email.Equals(other.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
