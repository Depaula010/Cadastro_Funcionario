using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cadastro_Funcionario.Paginas
{
    public partial class FrmCadastro : System.Web.UI.Page
    {
        private MeuBanco banco { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            banco = new MeuBanco();
        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                tblfuncionarios fun = new tblfuncionarios()
                {
                    bairro = txtbairro.Text,
                    cidade = txtcidade.Text,
                    cpf = txtcpf.Text,
                    departamento = 1,
                    email = txtemail.Text,
                    endereco = txtendereco.Text,
                    nome = txtnome.Text,
                    rg = txtrg.Text,
                    sobrenome = txtsobrenome.Text,
                    uf = txtuf.Text
                };

                banco.tblfuncionarios.Add(fun);
                banco.SaveChanges();
                txtresp.Text = "Cadastro realizado com sucesso! =)";
            }
            catch (Exception ex)
            {
                txtresp.Text = ex.Message;
                
            }

        }
    }
}