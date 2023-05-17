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
            return _context.Besonderheiten.ToList();
        }

        public Besonderheit? Add(Besonderheit item)
        {
            _context.Besonderheiten.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Besonderheit? Update(Besonderheit item)
        {
            _context.Besonderheiten.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var item = _context.Besonderheiten.Where(o => o.Id == id);
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
