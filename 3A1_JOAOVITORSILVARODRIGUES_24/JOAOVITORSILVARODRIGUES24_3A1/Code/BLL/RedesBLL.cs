using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JOAOVITORSILVARODRIGUES24_3A1.Code.DTO;
using JOAOVITORSILVARODRIGUES24_3A1.Code.DAL;
using System.Data;

namespace JOAOVITORSILVARODRIGUES24_3A1.Code.BLL
{
    class RedesBLL
    {

        BD conexao = new BD();
        string tabela = "lojasrede";

        public void Inserir(RedesDTO redeDTO) 
        {
            string inserir = $"insert into {tabela} value (null, '{redeDTO.Item}', '{redeDTO.Setor}', '{redeDTO.Valor}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(RedesDTO redeDTO) 
        {
            string alterar = $"update {tabela} set Item = '{redeDTO.Item}', Setor = '{redeDTO.Setor}'," +
               $" where id = '{redeDTO.Numero}'";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(RedesDTO redeDTO) 
        {
            string excluir = $"delete from {tabela} where id = '{redeDTO.Numero}'";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }


    }

}
