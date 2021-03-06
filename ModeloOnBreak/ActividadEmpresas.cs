﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloOnBreak
{
    class ActividadEmpresas
    {
        private int _id;
        private string _descripcion;

        public ActividadEmpresas(int _id, string _descripcion)
        {
            this._id = _id;
            this._descripcion = _descripcion;
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }
    }
}
