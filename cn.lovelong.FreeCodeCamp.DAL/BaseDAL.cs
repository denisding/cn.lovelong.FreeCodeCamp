using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.lovelong.FreeCodeCamp.DAL
{
    public class BaseDAL
    {
        private IDbConnection _conn;
        public IDbConnection Conn => _conn ?? (_conn = ConnectionFactory.CreateConnection());
    }
}
