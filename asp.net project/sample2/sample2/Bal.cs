using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

class Bal
{
    public int InsertPartyAddress(String name, string address)
    {
        Dal d1 = new Dal();
        d1.InsertPartyAddress(name, address);
        return 1;
    }
}