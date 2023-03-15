using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_1
{
    interface IAccesoDatos
    {
        bool create(Persona persona);
        List<Persona> read();
        bool update(Persona persona, int posicionPersona);
        bool delete(string documentoIdentidad);
    }
}
