using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloOnBreak
{
    public class Cliente
    {
        private string _rut;
        private string _razonSocial;
        private string _direccion;
        private string telefono;
        private ActividadEmpresa _actividad;
        private TipoEmpresa _tipo;
        private string _nombreContacto;
        private string _mailContacto;

        public string Rut
        {
            get
            {
                return _rut;
            }

            set
            {
                _rut = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return _razonSocial;
            }

            set
            {
                _razonSocial = value;
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

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        internal ActividadEmpresa Actividad
        {
            get
            {
                return _actividad;
            }

            set
            {
                _actividad = value;
            }
        }

        internal TipoEmpresa Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
            }
        }

        public string NombreContacto
        {
            get
            {
                return _nombreContacto;
            }

            set
            {
                _nombreContacto = value;
            }
        }

        public string MailContacto
        {
            get
            {
                return _mailContacto;
            }

            set
            {
                _mailContacto = value;
            }
        }
    }
    }

