using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class BedingungRepository
    {
        private readonly MaterialempfehlungContext _context;

        public BedingungRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Bedingung> GetAll()
        {
            //ToDo implement
            return new List<Bedingung>();
        }

        public Bedingung Add(Bedingung item)
        {
            //ToDo implement
            return new Bedingung();
        }

        public Bedingung Update(Bedingung item)
        {
            //ToDo implement
            return new Bedingung();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
