using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.AnaliseLib
{
    public class AutomovelDAL
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string ano { get; set; }
        public string cor { get; set; }
        public string chassi { get; set; }
        public string preco { get; set; }




        public void Create(AutomovelDAL Cauto)
        {
            SqlConnection conn = new SqlConnection("Data Source=GRU0539801W10-1;Initial Catalog=Auto;User ID=sa;password=123456");
            conn.Open();

            StringBuilder cmdSQL = new StringBuilder();
            cmdSQL.Append("insert into Carros ");
            cmdSQL.Append("values ('" + Cauto.marca + "','" + Cauto.modelo + "','" + Cauto.ano + "','" + Cauto.cor + "','" + Cauto.chassi + "','" + Cauto.preco + "')");

            SqlCommand cmd = new SqlCommand(cmdSQL.ToString(), conn);
            cmd.ExecuteNonQuery();

        }

        public void Update(AutomovelDAL obj)
        {
            SqlConnection conn = new SqlConnection("Data Source=GRU0539801W10-1;Initial Catalog=Auto;User ID=sa;password=123456");
            conn.Open();

            StringBuilder cmdSQL = new StringBuilder();
            cmdSQL.Append("Update Carros set ");
            cmdSQL.Append("Marca='" + marca + "',Modelo='" + modelo + "',Ano='" + ano + "',Cor='" + cor + "',Chassi='" + chassi + "',Preco='" + preco + "' where id=" + id);

            SqlCommand cmd = new SqlCommand(cmdSQL.ToString(), conn);
            cmd.ExecuteNonQuery();

        }

        public void Delete(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=GRU0539801W10-1;Initial Catalog=Auto;User ID=sa;password=123456");
            conn.Open();

            StringBuilder cmdSQL = new StringBuilder();
            cmdSQL.Append("delete from Carros where id= " + id);
            //cmdSQL.Append("values ('" + Dauto.marca + "','" + Dauto.modelo + "','" + Dauto.ano + "','" + Dauto.cor + "','" + Dauto.chassi + "','" + Dauto.preco + "')");

            SqlCommand cmd = new SqlCommand(cmdSQL.ToString(), conn);
            cmd.ExecuteNonQuery();

        }

        public List<AutomovelDAL> Get()
        {
            SqlConnection conn = new SqlConnection("Data Source=GRU0539801W10-1;Initial Catalog=Auto;User ID=sa;password=123456");
            conn.Open();

            StringBuilder cmdSQL = new StringBuilder();
            cmdSQL.Append("select * from Carros where Marca = '" + marca + "'");

            List<AutomovelDAL> lista = new List<AutomovelDAL>();

            SqlCommand cmd = new SqlCommand(cmdSQL.ToString(), conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                AutomovelDAL automoveis = new AutomovelDAL();
                automoveis.id = (int)dr["Id"];
                automoveis.marca = (string)dr["Modelo"];
                automoveis.modelo = (string)dr["Marca"];
                automoveis.ano = (string)dr["Ano"];
                automoveis.cor = (string)dr["Cor"];
                automoveis.chassi = (string)dr["Chassi"];
                automoveis.preco = (string)dr["Preco"];
                lista.Add(automoveis);
            }

            return lista;

        }

        public AutomovelDAL Get(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=GRU0539801W10-1;Initial Catalog=Auto;User ID=sa;password=123456");
            conn.Open();

            StringBuilder cmdSQL = new StringBuilder();
            cmdSQL.Append("select * from Carros where id = " + id);

            SqlCommand cmd = new SqlCommand(cmdSQL.ToString(), conn);
            SqlDataReader dr = cmd.ExecuteReader();

            AutomovelDAL automoveis = new AutomovelDAL();

            if (dr.Read())
            {
                
                automoveis.marca = (string)dr["Modelo"];
                automoveis.modelo = (string)dr["Marca"];
                automoveis.ano = (string)dr["Ano"];
                automoveis.cor = (string)dr["Cor"];
                automoveis.chassi = (string)dr["Chassi"];
                automoveis.preco = (string)dr["Preco"];

            }

            return automoveis;
            

        }




    }
}
