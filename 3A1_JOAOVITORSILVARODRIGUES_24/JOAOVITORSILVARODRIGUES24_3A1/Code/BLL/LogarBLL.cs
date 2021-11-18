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
    class LogarBLL
    {

        BD conexao = new BD();
        string tabela = "contas";

        public bool RealizarLogin(LogarDTO logarDTO)
        {
            string sql = $"select * from {tabela} where nome = '{logarDTO.Usuario}' and senha = '{logarDTO.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

    }
}
