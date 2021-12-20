using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.BUSINESS
{
    public static class OnMarcas
    {
        public static List<Marcas> GetMarcas()
        {
            try
            {
                using (var db = new DBProjetoFinalEntities())
                {
                    var dados =  db.Marcas.ToList();
                    return dados;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
