using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloOnBreak
{
    public class ClienteColleccion : List<Cliente>
    {
            public Cliente BuscarElRut(string rut)
            {
                try
                {
                    Cliente cli = this.First(c => c.Rut == rut);
                    return cli;
                }
                catch (Exception)
                {
                    return null;
                }
            }

        public List<Cliente> BuscarPosicionRut(string rut)
        {
            try
            {
                List<Cliente> res = (from cliente in this
                                     where cliente.Rut.Contains(rut)
                                     select cliente).ToList();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
