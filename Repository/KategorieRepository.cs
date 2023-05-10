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
            //ToDo implement
            return new List<Kategorie>();
        }

        public Kategorie Add(Kategorie item)
        {
            //ToDo implement
            return new Kategorie();
        }

        public Kategorie Update(Kategorie item)
        {
            //ToDo implement
            return new Kategorie();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
