using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.Dato;

namespace ModeloOnBreak
{
    public class Cliente
    {
        private string _rut;
        private string _razonSocial;
        private string _direccion;
        private string telefono;
        private ActividadEmpresa _actividadEmpresa;
        private TipoEmpresa _tipoEmpresa;
        private string _nombreContacto;
        private string _mailContacto;

        private TipoEmpresas _estadosEmpresas;
        private int _idEmp;
        private ActividadEmpresas _actividadEmpresas;
        private int _idActEmp;

        /// <summary>
        /// contructor sin parametros
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// contructor con parametros
        /// </summary>
        /// <param name="_rut"></param>
        /// <param name="_razonSocial"></param>
        /// <param name="_direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="_actividad"></param>
        /// <param name="_tipo"></param>
        /// <param name="_nombreContacto"></param>
        /// <param name="_mailContacto"></param>
        public Cliente(string _rut, string _razonSocial, string _direccion, string telefono, ActividadEmpresa _actividad, TipoEmpresa _tipo, string _nombreContacto, string _mailContacto)
        {
            this.Rut = string.Empty;
            this.RazonSocial = string.Empty;
            this.Direccion = string.Empty;
            this.Telefono = string.Empty;
            this.ActividadEmpresa = _actividad;
            this.TipoEmpresa = _tipo;
            this.NombreContacto = string.Empty;
            this.MailContacto = string.Empty;
        }

        /// <summary>
        /// get and set
        /// </summary>
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

        public ActividadEmpresa ActividadEmpresa
        {
            get
            {
                return _actividadEmpresa;
            }

            set
            {
                _actividadEmpresa = value;
            }
        }

        public TipoEmpresa TipoEmpresa
        {
            get
            {
                return _tipoEmpresa;
            }

            set
            {
                _tipoEmpresa = value;
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

        internal TipoEmpresas EstadosEmpresas
        {
            get
            {
                return _estadosEmpresas;
            }

            set
            {
                _estadosEmpresas = value;
            }
        }

        public int IdEmp
        {
            get
            {
                return _idEmp;
            }

            set
            {
                _idEmp = value;
            }
        }

        internal ActividadEmpresas ActividadEmpresas
        {
            get
            {
                return _actividadEmpresas;
            }

            set
            {
                _actividadEmpresas = value;
            }
        }

        public int IdActEmp
        {
            get
            {
                return _idActEmp;
            }

            set
            {
                _idActEmp = value;
            }
        }



    }
}

