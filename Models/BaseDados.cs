using System.Collections.Generic;
using MySqlConnector;
namespace Vendas.Models
{
public class BaseDados
{
protected const string _strConexao = "Database=VendaProdutos; Datasource=localhost; Username=root;";
public List<Produto> Lista(int id, string ordem)
{
MySqlConnection conexao = new MySqlConnection(_strConexao);
conexao.Open();
string sql = "SELECT * FROM Produto " + (id > 0 ? "WHERE id = @id" : "") + " ORDER BY " + ordem;
MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
if(id > 0)
{
comandoQuery.Parameters.AddWithValue("@id", id);
}
MySqlDataReader reader = comandoQuery.ExecuteReader();
List<Produto> lista = new List<Produto>();
while (reader.Read())
{
Produto item = new Produto();
item.Id = reader.GetInt32("Id");

if(!reader.IsDBNull(reader.GetOrdinal("nome")))
item.Nome = reader.GetString("nome");

if(!reader.IsDBNull(reader.GetOrdinal("descricao")))
 item.Descricao = reader.GetString("descricao");

if(!reader.IsDBNull(reader.GetOrdinal("preco")))
item.Preco = reader.GetDecimal("preco");

if(!reader.IsDBNull(reader.GetOrdinal("categoria")))
 item.Categoria = reader.GetString("categoria");

lista.Add(item);
}
conexao.Close();
return lista;
}
public List<Produto> Lista(string ordem)
{
return Lista(0, ordem);
}
}
}