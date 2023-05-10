using Materialempfehlung.Context;
using Materialempfehlung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materialempfehlung.Repository
{
    public class OberflächeFarbeRepository
    {
        private readonly MaterialempfehlungContext _context;

        public OberflächeFarbeRepository(MaterialempfehlungContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public List<Oberfläche_Farbe> GetAll()
        {
            //ToDo implement
            return new List<Oberfläche_Farbe>();
        }

        public Oberfläche_Farbe Add(Oberfläche_Farbe item)
        {
            //ToDo implement
            return new Oberfläche_Farbe();
        }

        public Oberfläche_Farbe Update(Oberfläche_Farbe item)
        {
            //ToDo implement
            return new Oberfläche_Farbe();
        }

        public bool Delete(int id)
        {
            //ToDo implement
            return true;
        }
    }
}
