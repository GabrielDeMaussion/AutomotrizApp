﻿using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz
{
    public interface IPresupuestoDao
    {
        bool CrearPresupuesto(Presupuesto presupuesto);
        List<Producto> ObtenerProductos();
        List<Cliente> ObtenerCliente();
        bool Cliente(Cliente cliente);
        bool EliminarPresupuesto(Presupuesto presupuesto);
    }
}
