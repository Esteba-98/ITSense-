﻿using Entities;
using System.Collections.Generic;

namespace Business
{
    public interface IPersona
    {
        void Insertar(Personas persona);
        IEnumerable<Personas> Obtener();
        Personas ObtenerById(int id);
        void Actualizar(Personas persona);
    }
}
