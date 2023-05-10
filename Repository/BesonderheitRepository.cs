using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class BesonderheitRepository
    {
        private readonly MaterialempfehlungContext _context;

        public BesonderheitRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Besonderheit> GetAll()
        {
            //ToDo implement
            return new List<Besonderheit>();
        }

        public Besonderheit Add(Besonderheit item)
        {
            //ToDo implement
            return new Besonderheit();
        }

        public Besonderheit Update(Besonderheit item)
        {
            //ToDo implement
            return new Besonderheit();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
