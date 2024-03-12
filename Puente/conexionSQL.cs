using datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puente
{
    public class conexionSQL
    {
        ConexionSql cn=new ConexionSql();

        public int conSql(string user, string pass)
        {
            return cn.consultalogin(user, pass);
        }

    }
}
