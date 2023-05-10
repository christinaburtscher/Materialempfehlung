using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class VeredelungRepository
    {
        private readonly MaterialempfehlungContext _context;

        public VeredelungRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Veredelung> GetAll()
        {
            return _context.Veredelungen.ToList();
        }

        public Veredelung? Add(Veredelung item)
        {
            _context.Veredelungen.Add(item);
            var result = _context.SaveChanges();
            if ( result >= 1)            
            {
                return item;
            }

            return null;
        }

        public Veredelung? Update(Veredelung item)
        {
            _context.Veredelungen.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var item = _context.Veredelungen.Where(o => o.Id == id);
            _context.Remove(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return true;
            }

            return false;
        }
    }
}
