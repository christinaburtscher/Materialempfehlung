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

        public Material GetByArtikelnummer(string artikelnummer) 
        {
            //ToDo implement
            return new Material();       
        }

        public List<Material> GetAll()
        { 
            //ToDo implement
            return new List<Material>();
        }

        public List<Material> GetByBereich(string bereich, string feld)
        {
            //ToDo implement
            return new List<Material>();
        }

        public bool Add(Material material) 
        {
            //ToDo implement
            return true;
        }

        public Material Update(Material material) 
        {
            //ToDo implement
            return new Material();
        }

        public bool Delete(int id) 
        {
            //ToDo implement
            return true;
        }
    }
}
