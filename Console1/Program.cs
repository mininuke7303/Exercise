using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;

namespace Console1 {

    public enum SampleType {
        Type1,
        Type2,
        Type3
    }

    public class Book {
        public string Title { get; set; }
        public string Author { get; set; }
    }



    class Program {

        public enum animal {
            dog,
            cat,
            monkey
        }


        static void Main(string[] args) {

            SendMessageToTarget1();

            for(int i=0; i<30_000; i++) {


            }



            Dictionary<string, string> todos = new Dictionary<string, string>();
            todos.Add("1", "C#");
            todos.Add("2", "VS");
            todos.Add("4", "Java");

            foreach (var item in todos) {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            var t = todos.Keys.Tols

            Console.WriteLine(todos.Keys);
            
            //for (int i = 0; i < todos.Count; i++) {
            //    Console.WriteLine(todos["1"].Value);
            //}










            List<Book> books = new List<Book>();

            Book book1 = new Book();
            book1.Title = "책 제목1";
            book1.Author = "책 저자1";

            books.Add(book1);

            Console.WriteLine(books.Count);












            List<string> list = new List<string>();

            list.Add("가");
            list.Add("나");
            list.Add("다");

            foreach (var item in list) {
                Console.WriteLine(item);
            }



            ////ArrayList list = new ArrayList();
            ////list.Add("가");
            ////list.Add("나");
            ////list.Add("다");


            //Hashtable hashTable = new Hashtable();
            //hashTable[0] = "가";
            //hashTable[1] = "나";
            //hashTable[2] = "다";
            //hashTable[3] = "라";


            //for(int i=0; i<hashTable.Count; i++) {
            //    Console.WriteLine(hashTable[i]);
            //}

            //foreach (var item in hashTable) {
            //    Console.WriteLine(item[);
            //}



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




            //TEST
        }

        private static void SendMessageToTarget1() {
            throw new NotImplementedException();
        }
    }
}
