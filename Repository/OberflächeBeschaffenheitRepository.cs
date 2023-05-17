using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class OberflächeBeschaffenheitRepository
    {
        private readonly MaterialempfehlungContext _context;

        public OberflächeBeschaffenheitRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Oberfläche_Beschaffenheit> GetAll()
        {
            return _context.Oberfläche_Beschaffenheiten.ToList();
        }

        public Oberfläche_Beschaffenheit? Add(Oberfläche_Beschaffenheit item)
        {
            _context.Oberfläche_Beschaffenheiten.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Oberfläche_Beschaffenheit? Update(Oberfläche_Beschaffenheit item)
        {
            _context.Oberfläche_Beschaffenheiten.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var item = _context.Oberfläche_Beschaffenheiten.Where(o => o.Id == id);
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
