using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class KlebstoffRepository
    {
        private readonly MaterialempfehlungContext _context;

        public KlebstoffRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Klebstoff> GetAll()
        {
            return _context.Klebstoffe.ToList();
        }

        public Klebstoff? Add(Klebstoff item)
        {
            _context.Klebstoffe.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Klebstoff? Update(Klebstoff item)
        {
            _context.Klebstoffe.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var item = _context.Klebstoffe.Where(o => o.Id == id);
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
