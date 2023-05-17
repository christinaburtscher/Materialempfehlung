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
           return _context.Oberfläche_Farben.ToList();
        }

        public Oberfläche_Farbe? Add(Oberfläche_Farbe item)
        {
            _context.Oberfläche_Farben.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Oberfläche_Farbe? Update(Oberfläche_Farbe item)
        {
            _context.Oberfläche_Farben.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }    

        public bool Delete(int id)
        {
            var item = _context.Oberfläche_Farben.Where(o => o.Id == id);
            _context.Remove(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return true;
            }

            return false;
        }
    }
}
