using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnBreak.Dato;

namespace ModeloOnBreak
{
    public class ClienteColleccion
    {
        private List<Cliente> _clientes = new List<Cliente>();

        //Creamos un objeto para ingresar a la bd. Este objeto es punto de entrada a la BD
        OnBreakEntities bd = new OnBreakEntities();

        public List<Cliente> Clientes
        {
            get
            {
                return _clientes;
            }

            set
            {
                _clientes = value;
            }
        }
        
        //METODOS   
        public bool AgregarCliente(Cliente cliente)
        {
            try
            {
                OnBreak.Dato.Cliente c = new OnBreak.Dato.Cliente();
                c.RutCliente = cliente.Rut;
                c.RazonSocial = cliente.RazonSocial;
                c.NombreContacto = cliente.NombreContacto;
                c.MailContacto = cliente.MailContacto;
                c.Direccion = cliente.Direccion;
                c.Telefono = cliente.Telefono;
                c.IdActividadEmpresa = cliente.IdActEmp;
                c.IdTipoEmpresa = cliente.IdActEmp;

                this.bd.Cliente.Add(c);
                this.bd.SaveChanges(); //aca guardara los cambios sin necesidad de hacer insert into Manual
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        //public bool ModificarCliente(Cliente cliente)
        //{
        //    try
        //    {
        //        //para modificar, primero debemos buscar el cliente
        //        OnBreak.Dato.Cliente c = this.bd.Cliente.Find(cliente.Rut); //Find lo que hace es buscar por id o FK
        //        //c.RutCliente = cliente.Rut;
        //        c.RazonSocial = cliente.RazonSocial;
        //        c.NombreContacto = cliente.NombreContacto;
        //        c.MailContacto = cliente.MailContacto;
        //        c.Direccion = cliente.Direccion;
        //        c.Telefono = cliente.Telefono;
        //        c.IdActividadEmpresa = cliente.IdActEmp;
        //        c.IdTipoEmpresa = cliente.IdActEmp;

        //        this.bd.Entry(c).State = System.Data.EntityState.Modified;
        //        this.bd.SaveChanges(); //aca guardara los cambios sin necesidad de hacer insert into Manual
        //        return true;

        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public bool EliminarCliente(string rut)
        {
            try
            {
                OnBreak.Dato.Cliente c = bd.Cliente.Find(rut);
                bd.Cliente.Remove(c);
                bd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Filtrar por Empresa
        /// </summary>
        /// <param name="tipoEmpresa"></param>
        /// <returns></returns>
        public List<Cliente> clientesPorEmpresas(TipoEmpresa tipoEmpresa)
        {
            return (from c in this.Clientes
                    where c.TipoEmpresa == tipoEmpresa
                    select c).ToList();
        }

        public Cliente BuscarClientePorRut(string rut)
        {
            try
            {
                return (from c in this.bd.Cliente
                        where c.RutCliente == rut
                        select new Cliente()
                        {
                            Rut = c.RutCliente,
                            RazonSocial = c.RazonSocial,
                            NombreContacto = c.NombreContacto,
                            MailContacto = c.MailContacto,
                            Direccion = c.Direccion,
                            Telefono = c.Telefono,
                            IdActEmp = (int)c.IdActividadEmpresa,
                            IdEmp= (int)c.IdTipoEmpresa,
                        }).First(); 
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<object> ReadAll()
        {
            return (from c in this.bd.Cliente
                    select c).ToList();
        }

        
    }
}
