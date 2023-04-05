using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TintSysClass;
using MySql.Data.MySqlClient;

namespace ClassLibrary2
{
    public class Produto
    {

        public int Id { get; set; }
        public string Descricao { get; set;}
        public string Unidade { get; set;}
        public string CodBar { get; set;}
        public double Preco { get; set;}
        public double Desconto { get; set;}
        public bool Descontinuado { get; set;}


        // construtores
        public Produto()
        {

        }

        public Produto(string descricao, string unidade, string codBar, double preco, double desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto(string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        
        public Produto(int id, string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        //métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert produtos (descricao, unidade, CodBar, Preco, Desconto, Descontinuado)" +
                "value(@descricao,@unidade, @codbar, @preco, @desconto, 0)";,
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Unidade;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = CodBar;
            cmd.Parameters.Add("@descricao", MySqlDbType.Decimal).Value = Preco;
            cmd.Parameters.Add("@descricao", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public List<Produto> Listar(string descricao = "") 
        {
            List<Produto> lista = new List<Produto>();
            MySqlCommand cmd = Banco.Abrir();
            if (descricao.Length > 0)
                cmd.CommandText = "select * from produtos where descricao = '%" + descricao + "%'";
            else
                cmd.CommandText = "select * from produtos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto;
            List<Produto> lista = new List<Produto>();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandText = "select * from produtos where id = "+ id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                    );
            }
            Banco.Fechar(cmd);
            return produto;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update produtos set descricao = @Descricao, unidade = @Unidade, codbar = @CodBar, preco = @preco, desconto, descontinuado" +
                "value(@descricao,@unidade, @codbar, @preco, @desconto, 0)";,
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Unidade;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = CodBar;
            cmd.Parameters.Add("@descricao", MySqlDbType.Decimal).Value = Preco;
            cmd.Parameters.Add("@descricao", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public void Arquivar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update produtos set descontinuado = @Descontinuado"            
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public void Restaurar()
        {

        }
    }
}

