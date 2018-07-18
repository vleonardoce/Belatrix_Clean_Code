using System;

namespace CleanCode.NestedConditionals
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }
    }

    public class Reservation
    {
        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public DateTime From { get; set; }
        public Customer Customer { get; set; }
        public bool IsCanceled { get; set; }

        public enum ClientTypesHours : int
        {
            Gold = 24,
            Regular = 48
        }

        public void Cancel()
        {
            // Gold customers can cancel up to 24 hours before
            if (Customer.LoyaltyPoints > 100)
            {
                ValidateHours(From, ClientTypesHours.Gold);
            }
            else
            {
                // Regular customers can cancel up to 48 hours before
                ValidateHours(From, ClientTypesHours.Regular);
            }
            IsCanceled = true;
        }

        public void ValidateHours(DateTime From, ClientTypesHours Hours)
        {
            // If reservation already started throw exception
            if (DateTime.Now > From || (From - DateTime.Now).TotalHours < (int)Hours)
            {
                throw new InvalidOperationException("It's too late to cancel.");
            }
        }

    }
}
