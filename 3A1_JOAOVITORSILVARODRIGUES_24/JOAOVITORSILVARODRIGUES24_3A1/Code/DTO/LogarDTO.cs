using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOAOVITORSILVARODRIGUES24_3A1.Code.DTO
{
    class LogarDTO
    {

        private int _id;
        private string _usuario;
        private string _senha;

        public int Id { get => _id; set => _id = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
