using Oracle.DataAccess.Client;
using System;

namespace Console1 {
    class Program {
        static void Main(string[] args) {
            //string strConnection = "DATA SOURCE=192.168.0.12:1521/orcl;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=7mlgtaw3";
            //using (OracleConnection conn = new OracleConnection(strConnection)) {
            //    try {
            //        conn.Open();

            //        OracleCommand cmd = new OracleCommand();
            //        cmd.Connection = conn;

            //        //cmd.CommandText = "Select * from Employees where Id = :id";
            //        //cmd.Parameters.Add(new OracleParameter("id", 1));

            //        cmd.CommandText = "Select * from HR.Employees";
            //        OracleDataReader rdr = cmd.ExecuteReader();

            //        while (rdr.Read()) {
            //            string s = rdr["First_Name"] as string;
            //            Console.WriteLine(s);
            //        }
            //    }
            //    catch (Exception ex) {
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally {
            //        conn.Close();
            //    }
            //}


            string i = "1234";
            if (i is string) {
                Console.WriteLine(i);
            }

            //TEST
        }
    }
}
