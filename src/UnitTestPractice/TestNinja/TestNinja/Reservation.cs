using System;
using System.Reflection.Metadata;

namespace TestNinja
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user == null)
                return false;

            return (user.IsAdmin || user == MadeBy);
            
        }
    }
}
