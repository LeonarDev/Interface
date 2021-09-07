using System;

namespace Interface.Entities
{
    class CarRental
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime startDate, DateTime finishDate, Vehicle vehicle)
        {
            StartDate = startDate;
            FinishDate = finishDate;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
