using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloOnBreak
{
    class Contrato
    {
        private string _numeroContrato;
        private string _rutCliente;
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraTermino;
        private string _direccion;
        private string _staVigente;
        private TipoEventos _tipoEvento = new TipoEventos();
        private string _observaciones;

        public string NumeroContrato
        {
            get
            {
                return _numeroContrato;
            }

            set
            {
                _numeroContrato = value;
            }
        }

        public string RutCliente
        {
            get
            {
                return _rutCliente;
            }

            set
            {
                _rutCliente = value;
            }
        }

        public DateTime FechaHoraInicio
        {
            get
            {
                return _fechaHoraInicio;
            }

            set
            {
                _fechaHoraInicio = value;
            }
        }

        public DateTime FechaHoraTermino
        {
            get
            {
                return _fechaHoraTermino;
            }

            set
            {
                _fechaHoraTermino = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public string StaVigente
        {
            get
            {
                return _staVigente;
            }

            set
            {
                _staVigente = value;
            }
        }

        public TipoEventos TipoEvento
        {
            get
            {
                return _tipoEvento;
            }

            set
            {
                _tipoEvento = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return _observaciones;
            }

            set
            {
                _observaciones = value;
            }
        }
    }
}
