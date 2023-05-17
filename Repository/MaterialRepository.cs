using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Datenbank
{
    public class MaterialRepository
    {
        private readonly MaterialempfehlungContext _context;

        public MaterialRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public Material? GetByArtikelnummer(string artikelnummer) 
        {
            return _context.Materialien.Where(o => o.Artikelnummer_Carini == artikelnummer).FirstOrDefault();           
        }

        public List<Material> GetAll()
        { 
            return _context.Materialien.ToList();
        }

        public List<Material> GetByBereich(string bereich, string feld)
        {
            //ToDo implement
            return new List<Material>();
        }

        public Material? Add(Material item) 
        {
            _context.Materialien.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Material? Update(Material item) 
        {
            _context.Materialien.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id) 
        {
            var item = _context.Materialien.Where(o => o.Id == id);
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
