using ClassLibrary2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TintSysClass
{
    internal class Pedido
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set;}
        public Cliente Cliente { get; set;}
        public Usuario Usuario { get; set;}
        public DateTime Arquivado_em { get; set; }
        public string Hashcode { get; set; }

        // construtores
        public Pedido()
        {

        }
        public Pedido(DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivado_em)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Arquivado_em = arquivado_em;
        }
        public Pedido(DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivado_em, string hashcode)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Arquivado_em = arquivado_em;
            Hashcode = hashcode;
        }
        public Pedido(int id, DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivado_em, string hashcode)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Arquivado_em = arquivado_em;
            Hashcode = hashcode;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert pedidos (data, status, desconto, cliente_id, usuario_id, arquivado_em, hashcode) " +
                "values(default, @status, @desconto, @cliente, @usuario, @arquivado_em, @hashcode) ";
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
            cmd.Parameters.Add("@desconto", MySqlDbType.VarChar).Value = Desconto;
            cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = Cliente.Id;
            cmd.Parameters.Add("@usuario", MySqlDbType.Int32).Value = Usuario.Id;
            cmd.Parameters.Add("@arquivado_em", MySqlDbType.Int32).Value = Arquivado_em;
            cmd.Parameters.Add("@hashcode", MySqlDbType.Int32).Value = Hashcode;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }

        public static Pedido ObterPorId(int _id)
        {
            Pedido pedido = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new Pedido(
                        dr.GetInt32(0),
                        dr.GetDateTime(1),
                        dr.GetString(2),
                        dr.GetDouble(3),
                        Cliente.ObterPorId(dr.GetInt32(4)),
                        Usuario.ObterPorId(dr.GetInt32(5)),
                        dr.GetDateTime(6),
                        dr.GetString(7)
                    );
            }
            Banco.Fechar(cmd);
            return pedido;
        }

        public static List<Pedido> Listar(string _nome = "")//string _nome = ""
        {
            List<Usuario> lista = new List<Usuario>();

            var cmd = Banco.Abrir();
            if (_nome != string.Empty)
                cmd.CommandText = "select * from usuarios where nome like '%" + _nome + "%'";
            else
                cmd.CommandText = "select * from usuarios";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar()
        {
            var moimoi = Banco.Abrir();
            moimoi.CommandText = "update usuarios set nome = @nome, senha = md5(@senha), " +
                "nivel_id = @nivel where id =" + Id;
            moimoi.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            moimoi.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            moimoi.Parameters.Add("@nivel", MySqlDbType.Int32).Value = Nivel.Id;
            moimoi.ExecuteNonQuery();
            Banco.Fechar(moimoi);
        }
        public static void Arquivar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update usuarios set ativo = 0 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update usuarios set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public void Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from usuarios where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
