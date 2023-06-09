﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_1
{

    class AccesoDatos : IAccesoDatos
    {
        public bool create(Persona persona)
        {
            Datos.dataPersona.Add(persona);

            return true;
        }

        public bool delete(string documentoIdentidad)
        {
            int posicionPersona = 0;
            bool existePersona = false;

            foreach (Persona item in Datos.dataPersona)
            {
                if (item.documentoIdentidad == documentoIdentidad)
                {

                    //SI EXITE UN REGISTRO EN LA LISTA PERSONA
                    existePersona = true;

                    break;

                }

                posicionPersona++;
            }

            if (existePersona)
            {
                Datos.dataPersona.RemoveAt(posicionPersona);
                return true;

            }
            else
            {
                return false;
            }
        }

        public List<Persona> read()
        {
            return Datos.dataPersona;
        }

        public bool update(Persona persona, int posicionPersona)
        {
            Datos.dataPersona[posicionPersona - 1].nombre = persona.nombre;
            Datos.dataPersona[posicionPersona - 1].apellido = persona.apellido;
            Datos.dataPersona[posicionPersona - 1].documentoIdentidad = persona.documentoIdentidad;
            Datos.dataPersona[posicionPersona - 1].sexo = persona.sexo;
            Datos.dataPersona[posicionPersona - 1].fechaNacimiento = persona.fechaNacimiento;
            Datos.dataPersona[posicionPersona - 1].estatura = persona.estatura;
            Datos.dataPersona[posicionPersona - 1].fechaModificacion = persona.fechaModificacion;

            return true;
        }
    }
}
