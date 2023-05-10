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

        public List<Äußerer_Einfluss> GetAll()
        {
            //ToDo implement
            return new List<Äußerer_Einfluss>();
        }

        public Oberfläche_Beschaffenheit Add(Oberfläche_Beschaffenheit item)
        {
            //ToDo implement
            return new Oberfläche_Beschaffenheit();
        }

        public Oberfläche_Beschaffenheit Update(Oberfläche_Beschaffenheit item)
        {
            //ToDo implement
            return new Oberfläche_Beschaffenheit();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
