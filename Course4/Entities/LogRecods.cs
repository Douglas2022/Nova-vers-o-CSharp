using System;

namespace Course4.Entities
{
    internal class LogRecods
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is LogRecods))
            {
                return false;
            }
            LogRecods other = obj as LogRecods;
            return UserName.Equals(other.UserName);
        }
    }
}
