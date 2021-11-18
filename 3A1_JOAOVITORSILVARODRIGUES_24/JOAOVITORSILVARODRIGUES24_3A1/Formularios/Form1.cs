using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JOAOVITORSILVARODRIGUES24_3A1.Code.DTO;
using JOAOVITORSILVARODRIGUES24_3A1.Code.BLL;


namespace JOAOVITORSILVARODRIGUES24_3A1
{
    public partial class Form1 : Form
    {

        RedesDTO redeDTO = new RedesDTO();
        RedesBLL redeBLL = new RedesBLL();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            redeDTO.Item = txt_item.Text;
            redeDTO.Setor = txt_setorizacao.Text;
            redeDTO.Valor = float.Parse(txt_valor.Text);

            redeBLL.Inserir(redeDTO);

            MessageBox.Show("Cadastrado!", "LOJAS REDES");

            redeBLL.Listar();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            redeDTO.Numero = int.Parse(txt_numero.Text);
            redeDTO.Item = txt_item.Text;
            redeDTO.Setor = txt_setorizacao.Text;
            redeDTO.Valor = float.Parse(txt_valor.Text);

            redeBLL.Editar(redeDTO);

            MessageBox.Show("Editado!", "LOJAS REDES");

            redeBLL.Listar();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {

            redeDTO.Numero = int.Parse(txt_numero.Text);


            redeBLL.Excluir(redeDTO);

            MessageBox.Show("Excluido!", "LOJAS REDES");

            redeBLL.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_itens.DataSource = redeBLL.Listar();
        }
    }
}
