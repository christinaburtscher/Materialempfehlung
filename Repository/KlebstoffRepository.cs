using Materialempfehlung.Context;
using Materialempfehlung.Models;

namespace Materialempfehlung.Repository
{
    public class KlebstoffRepository
    {
        private readonly MaterialempfehlungContext _context;

        public KlebstoffRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Klebstoff> GetAll()
        {
            //ToDo implement
            return new List<Klebstoff>();
        }

        public Klebstoff Add(Klebstoff item)
        {
            //ToDo implement
            return new Klebstoff();
        }

        public Klebstoff Update(Klebstoff item)
        {
            //ToDo implement
            return new Klebstoff();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
