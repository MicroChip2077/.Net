using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.Dato;

namespace ModeloOnBreak
{
    public class Contrato
    {
        private string _numeroContrato;
        private string _rutCliente;
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraTermino;
        private string _direccion;
        private string _staVigente;
        private TipoEventos _tipoEvento = new TipoEventos();
        private string _observaciones;

        public Contrato()
        {

        }

        public Contrato(string _numeroContrato, string _rutCliente, DateTime _fechaHoraInicio, DateTime _fechaHoraTermino, string _direccion, string _staVigente, TipoEventos _tipoEvento, string _observaciones)
        {
            this._numeroContrato = string.Empty;
            this._rutCliente = string.Empty;
            this._fechaHoraInicio = _fechaHoraInicio;
            this._fechaHoraTermino = _fechaHoraTermino;
            this._direccion = string.Empty;
            this._staVigente = string.Empty;
            this._tipoEvento = _tipoEvento;
            this._observaciones = string.Empty;
        }

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
