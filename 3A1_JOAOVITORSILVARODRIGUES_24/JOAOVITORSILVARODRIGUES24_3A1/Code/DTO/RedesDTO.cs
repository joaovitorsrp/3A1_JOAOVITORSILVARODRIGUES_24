using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOAOVITORSILVARODRIGUES24_3A1.Code.DTO
{
    class RedesDTO
    {
        private int _numero;
        private string _item;
        private string _setor;
        private float _valor;

        public int Numero { get => _numero; set => _numero = value; }
        public string Item { get => _item; set => _item = value; }
        public string Setor { get => _setor; set => _setor = value; }
        public float Valor { get => _valor; set => _valor = value; }
    }
}
