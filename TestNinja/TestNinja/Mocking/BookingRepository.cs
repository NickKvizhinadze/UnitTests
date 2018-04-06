using System.Linq;

namespace TestNinja.Mocking
{
    
    public interface IBookingRepository
    {
        IQueryable<Booking> GetActiveBookings(int? exculdeBookingId = null);
    }

    public class BookingRepository: IBookingRepository
    {
        public IQueryable<Booking> GetActiveBookings(int? exculdeBookingId = null)
        {
            var unitOfWork = new UnitOfWork();

            var bookings = unitOfWork.Query<Booking>()
                .Where(
                    b => b.Status != "Cancelled");

            return exculdeBookingId.HasValue ? bookings.Where(b => b.Id != exculdeBookingId) : bookings;
        }
    }
}
