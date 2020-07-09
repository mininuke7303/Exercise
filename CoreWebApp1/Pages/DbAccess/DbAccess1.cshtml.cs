using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Oracle.ManagedDataAccess.Client;

namespace CoreWebApp1.Pages.DbAccess {
    public class DbAccess1Model : PageModel {
        public void OnGet() {
            doOracle2();
        }

        public void doOracle2() {

            string constr = "DATA SOURCE=192.168.0.12:1521/orcl;USER ID=HR;PASSWORD=7mlgtaw3";
            OracleConnection con = new OracleConnection(constr);
            con.Open();

            OracleCommand cmd = new OracleCommand("select * from HR.Employees", con);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                Response.WriteAsync("Data: " + reader.GetString(1) + " " + reader.GetString(2) + "\n");
            }
            reader.Dispose();
            cmd.Dispose();
            con.Dispose();
        }
    }
}