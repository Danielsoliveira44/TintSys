using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Nivel //(Abstração)
    {
        //attributos 
        private int id;
        private string name;
        private string sigla;


        //propriedades (Encapsulamento) getters and setters 
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sigla { get => sigla; set => sigla = value; }

        //Métodos construtores - Int x = new Int();
        public Nivel() { } // vazio

        public Nivel(string _nome, string _sigla)
        {
            Name = _nome;
            Sigla = _sigla;
        }
        public Nivel(int _id, string _name, string _sigla)
        {
            Id = _id; 
            Name = _name;
            Sigla = _sigla;
        }

        //Métodos da Classes (inserir, alterar, consultar, por Id, por)
        public void Inserir() // teste
        {
            // cria uma variável com conexão de banco aberta
            var cmd = Banco.Abrir();
            // define o tipo de instrução MySQL a ser processada pelo serv banco de dados
            cmd.CommandType = CommandType.Text;
            // define a query sql especificada com parametros (@nome...)
            cmd.CommandText = "insert niveis (nome, sigla) value (@nome, @sigla)";
            // cria o parametro e associa ao valor
            cmd.Parameters.Add("@nome",MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("@sigla", Sigla);
            //executa a instrução SQL na conexão
            cmd.ExecuteNonQuery();
            // obtendo o id do nivel recém inserido
            cmd.CommandText = "Select @@identity";
            // recupera o id na Propriedade
            Id = Convert.ToInt32 cmd.ExecuteScalar();
            // fecha a conexão
            Banco.Fechar(cmd);
        }
        public static Nivel ObterPorId(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where id = @id";
            cmd.Parameters.AddWithValue("@id", _id);
            var dr = cmd.ExecuteReader();
            Nivel nivel;
            while(dr.Read())
            {
                nivel = new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            Banco.Fechar(cmd);
            return nivel;
        }
        public static List<Nivel> Listar()
        {
            List<Nivel> lista = new List<Nivel>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

            }

            return lista;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();    
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = @nome, sigla = @sigla where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome",Nome);
            cmd.Parameters.AddWithValue("@sigla", Sigla);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public bool Excluir(int _id)
        {
            bool confirma = false;
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from niveis where id = "+_id;
            if (cmd.ExecuteNonQuery()>-1)
            {
                confirma = true;
            }

            Banco.Fechar(cmd);
            return confirma;
        }

    }
}
