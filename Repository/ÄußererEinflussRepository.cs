using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public  class ÄußererEinflussRepository : IMaterialempfehlungRepository<Äußerer_Einfluss>
    {
        private readonly MaterialempfehlungContext _context;

        public ÄußererEinflussRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Äußerer_Einfluss> GetAll()
        {
            return _context.Äußere_Einflüsse.ToList();
        }

        public Äußerer_Einfluss? Add(Äußerer_Einfluss item)
        {
            _context.Äußere_Einflüsse.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Äußerer_Einfluss? Update(Äußerer_Einfluss item)
        {
            _context.Äußere_Einflüsse.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var item = _context.Äußere_Einflüsse.Where(o => o.Id == id);
            _context.Remove(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return true;
            }

            return false;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
