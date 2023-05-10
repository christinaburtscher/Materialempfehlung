using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class OberflächeRepository
    {
        private readonly MaterialempfehlungContext _context;

        public OberflächeRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Oberfläche> GetAll()
        {
            //ToDo implement
            return new List<Oberfläche>();
        }

        public Oberfläche Add(Oberfläche item)
        {
            //ToDo implement
            return new Oberfläche();
        }

        public Oberfläche Update(Oberfläche item)
        {
            //ToDo implement
            return new Oberfläche();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
