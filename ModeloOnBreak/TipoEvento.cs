using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloOnBreak
{
    class TipoEvento
    {
        private string _idTipoEvento;
        private string _descripcion;
        private int _valorBase;
        private int _personalBase;

        public string IdTipoEvento
        {
            get
            {
                return _idTipoEvento;
            }

            set
            {
                _idTipoEvento = value;
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

        public int ValorBase
        {
            get
            {
                return _valorBase;
            }

            set
            {
                _valorBase = value;
            }
        }

        public int PersonalBase
        {
            get
            {
                return _personalBase;
            }

            set
            {
                _personalBase = value;
            }
        }
    }
}
