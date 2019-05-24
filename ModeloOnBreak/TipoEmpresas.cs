using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloOnBreak
{
    class TipoEmpresas
    {
        private int _id;
        private string descripcion;

        public TipoEmpresas(int _id, string descripcion)
        {
            this._id = _id;
            this.descripcion = descripcion;
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
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
    }
}
