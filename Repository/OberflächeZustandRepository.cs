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
            return _context.Oberfläche_Zustände.ToList();
        }

        public Oberfläche_Zustand? Add(Oberfläche_Zustand item)
        {
            _context.Oberfläche_Zustände.Add(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public Oberfläche_Zustand? Update(Oberfläche_Zustand item)
        {
            _context.Oberfläche_Zustände.Update(item);
            var result = _context.SaveChanges();
            if (result >= 1)
            {
                return item;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var item = _context.Oberfläche_Zustände.Where(o => o.Id == id);
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
