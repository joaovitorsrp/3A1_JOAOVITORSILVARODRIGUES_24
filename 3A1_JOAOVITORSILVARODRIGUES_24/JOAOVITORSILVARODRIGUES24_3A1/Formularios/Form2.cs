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



namespace JOAOVITORSILVARODRIGUES24_3A1.Formularios
{
    public partial class Form2 : Form
    {

        LogarBLL logarBLL = new LogarBLL();
        LogarDTO logarDTO = new LogarDTO();

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {

            logarDTO.Senha = txt_senha.Text;
            logarDTO.Usuario = txt_nomedeusuario.Text;

            if (logarBLL.RealizarLogin(logarDTO) == true) 
            {
                Form1 form1= new Form1();
                form1.ShowDialog();
            }

        }
    }
}
