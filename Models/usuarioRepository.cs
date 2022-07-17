using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;

namespace etapa3.Models
{
    public class usuarioRepository
    {   
        /*ENDEREÇO DE CONEXÃO*/
        private const  string enderecoConexao = "Database=grunge_moments; Datasource=localhost; Username=root;";

    
    /**************************************USUÁRIOS**************************************************/
    
    /*CADASTRAR USUÁRIOS*/
    public void Insert(Usuario user){
                  
    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlInsert = "INSERT INTO usuario (nome, dataNasc, senha, login) VALUES (@nome, @dataNasc, @senha, @login)";

    MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);

    comando.Parameters.AddWithValue("@nome", user.nome);
    comando.Parameters.AddWithValue("@dataNasc", user.dataNasc);
    comando.Parameters.AddWithValue("@senha", user.senha);
    comando.Parameters.AddWithValue("@login", user.login);

    comando.ExecuteNonQuery();

    conexao.Close();
    
    }
  }
}