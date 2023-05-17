using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class DruckverfahrenRepository
    {
        private readonly MaterialempfehlungContext _context;

        public DruckverfahrenRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Druckverfahren> GetAll()
        {
            return _context.Druckverfahren.ToList();
        }

        public Druckverfahren? Add(Druckverfahren item)
        {
            _context.Druckverfahren.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Druckverfahren? Update(Druckverfahren item)
        {
            _context.Druckverfahren.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var item = _context.Druckverfahren.Where(o => o.Id == id);
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
