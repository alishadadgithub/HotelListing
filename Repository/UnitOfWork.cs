using HotelListing.Controllers.Data;
using HotelListing.IRepository;

namespace HotelListing.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DatabaseContext _context;

        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotel> _hotels;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context; 
        }

        public IGenericRepository<Country> Countries => _countries ??= new GenericReposiroty<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericReposiroty<Hotel>(_context);


        public void Dispose()
        {
           _context.Dispose(); // kill any connection
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
           await _context.SaveChangesAsync(); 
        }
    }
}
