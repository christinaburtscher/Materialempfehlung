using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    internal class ÄußererEinflussRepository
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
            //ToDo implement
            return new List<Äußerer_Einfluss>();
        }

        public Äußerer_Einfluss Add(Äußerer_Einfluss item)
        {
            //ToDo implement
            return new Äußerer_Einfluss();
        }

        public Äußerer_Einfluss Update(Äußerer_Einfluss item)
        {
            //ToDo implement
            return new Äußerer_Einfluss();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
