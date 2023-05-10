using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class OberflächeFormRepository
    {
        private readonly MaterialempfehlungContext _context;

        public OberflächeFormRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Oberfläche_Form> GetAll()
        {
            //ToDo implement
            return new List<Oberfläche_Form>();
        }

        public Oberfläche_Form Add(Oberfläche_Form item)
        {
            //ToDo implement
            return new Oberfläche_Form();
        }

        public Oberfläche_Form Update(Oberfläche_Form item)
        {
            //ToDo implement
            return new Oberfläche_Form();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
