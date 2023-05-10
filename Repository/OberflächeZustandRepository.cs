using Materialempfehlung.Context;
using Materialempfehlung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materialempfehlung.Repository
{
    public class OberflächeZustandRepository
    {
        private readonly MaterialempfehlungContext _context;

        public OberflächeZustandRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Oberfläche_Zustand> GetAll()
        {
            //ToDo implement
            return new List<Oberfläche_Zustand>();
        }

        public Oberfläche_Zustand Add(Oberfläche_Zustand item)
        {
            //ToDo implement
            return new Oberfläche_Zustand();
        }

        public Oberfläche_Zustand Update(Oberfläche_Zustand item)
        {
            //ToDo implement
            return new Oberfläche_Zustand();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
