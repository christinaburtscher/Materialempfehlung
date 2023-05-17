using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class KategorieRepository
    {
        private readonly MaterialempfehlungContext _context;

        public KategorieRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Kategorie> GetAll()
        {
            return _context.Kategorien.ToList();
        }

        public Kategorie? Add(Kategorie item)
        {
            _context.Kategorien.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Kategorie? Update(Kategorie item)
        {
            _context.Kategorien.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var item = _context.Kategorien.Where(o => o.Id == id);
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
