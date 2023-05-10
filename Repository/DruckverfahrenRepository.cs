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
            //ToDo implement
            return new List<Druckverfahren>();
        }

        public Druckverfahren Add(Druckverfahren item)
        {
            //ToDo implement
            return new Druckverfahren();
        }

        public Druckverfahren Update(Druckverfahren item)
        {
            //ToDo implement
            return new Druckverfahren();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
