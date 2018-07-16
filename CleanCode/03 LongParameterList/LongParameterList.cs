
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(ReservationFilterSearch filterSearch)
        {
            if (filterSearch.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (filterSearch.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(ReservationFilterSearch filterSearch)
        {
            if (filterSearch.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (filterSearch.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(ReservationFilterSearch filterSearch, ReservationDefinition reservationDefinition)
        {
            if (filterSearch.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (filterSearch.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(Reservation reservation)
        {
            if (reservation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int LocationId { get; set; }
    }

    public class ReservationFilterSearch
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public User User { get; set; }
        public int LocationId { get; set; }
        public LocationType LocationType { get; set; }
        public int? CustomerId { get; set; }

    }
}
