using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionChequePharmacie
{
    class Provider
    {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestProdPharma;Integrated Security=True");
        public static DataSet ds = new DataSet();
        public static void RemplirTable(string req, string table)
        {

            if (ds.Tables.Contains(table)) { ds.Tables[table].Rows.Clear(); }
            using (SqlDataAdapter da = new SqlDataAdapter(req, cnx))
            {
                da.Fill(ds, table);
                ds.Tables[table].PrimaryKey = new DataColumn[] { ds.Tables[table].Columns[0] };

            }
        }
        public static void Ajouter(DataRow dr , string Table)
        {
            ds.Tables[Table].Rows.Add(dr);

        }
        public static void Enregistrer(string Table)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("select *from "+Table+"", cnx))
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds,Table);
            }

        }

    }
}
