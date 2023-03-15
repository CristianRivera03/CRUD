using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_1
{
    abstract class Auditoria
    {
        public  DateTime fechaRegistro { get; set; }
        public DateTime fechaModificacion { get; set; }
    }
}
