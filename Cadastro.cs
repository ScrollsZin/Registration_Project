using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Project
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Btn_Nome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Visible = true;
            Lbl_Resultado.Text = Txt_Nome.Text; //Enviar a Informação Para o Resultado
        }

        private void Btn_Sobrenome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Visible = true;
            Lbl_Resultado.Text = Txt_Sobrenome.Text; //Enviar a Informação Para o Resultado
        }

        private void Btn_Idade_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Visible = true;
            Lbl_Resultado.Text = Txt_Idade.Text; //Enviar a Informação Para o Resultado
        }

        private void Btn_Bairro_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Visible = true;
            Lbl_Resultado.Text = Txt_Bairro.Text; //Enviar a Informação Para o Resultado
        }

        private void Btn_Celular_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Visible = true;
            Lbl_Resultado.Text = Txt_Celular.Text; //Enviar a Informação Para o Resultado
        }

        private void Btn_Email_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Visible = true;
            Lbl_Resultado.Text = Txt_Email.Text; //Enviar a Informação Para o Resultado
        }

        private void Btn_DadosCompleto_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Visible = true;
            Lbl_Resultado.Text = Txt_Nome.Text + " " + Txt_Sobrenome.Text + "\n " + Txt_Idade.Text + "\n " + Txt_Bairro.Text + "\n " + Txt_Celular.Text + "\n " + Txt_Email.Text; //Contatenar = Unir Todas as Informações Para o Resultado
        }

        private void Rad_Padrao_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Padrão;  //Setar os Temas
        }

        private void Rad_T1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Tema_1; //Setar os Temas
        }

        private void Rad_T2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Tema_2; //Setar os Temas
        }

        private void Rad_T3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Tema_3; //Setar os Temas
        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {
            //Ativando Todos Os Objetos
            Grp_Backgrounds.Enabled = true;
            Rad_Padrao.Enabled = true;
            Rad_T1.Enabled = true;
            Rad_T2.Enabled = true;
            Rad_T3.Enabled = true;
            Lbl_DadosPessoais.Enabled = true;
            Lbl_Nome.Enabled = true;
            Lbl_Sobrenome.Enabled = true;
            Lbl_Idade.Enabled = true;
            Lbl_Bairro.Enabled = true;
            Lbl_Celular.Enabled = true;
            Lbl_Email.Enabled = true;
            Lbl_Confirmacao.Enabled = true;
            Lbl_Resultado.Enabled = true;
            Txt_Nome.Enabled = true;
            Txt_Sobrenome.Enabled = true;
            Txt_Idade.Enabled = true;
            Txt_Bairro.Enabled = true;
            Txt_Celular.Enabled = true;
            Txt_Email.Enabled = true;
            Btn_Nome.Enabled = true;
            Btn_Sobrenome.Enabled = true;
            Btn_Idade.Enabled = true;
            Btn_Bairro.Enabled = true;
            Btn_Celular.Enabled = true;
            Btn_Email.Enabled = true;
            Btn_DadosCompleto.Enabled = true;
            Btn_Ativar.Enabled = false;
            Btn_Desativar.Enabled = true;
        }

        private void Btn_Desativar_Click(object sender, EventArgs e)
        {
            //Desativando Todos os Objetos
            Grp_Backgrounds.Enabled = false;
            Rad_Padrao.Enabled = false;
            Rad_T1.Enabled = false;
            Rad_T2.Enabled = false;
            Rad_T3.Enabled = false;
            Lbl_DadosPessoais.Enabled = false;
            Lbl_Nome.Enabled = false;
            Lbl_Sobrenome.Enabled = false;
            Lbl_Idade.Enabled = false;
            Lbl_Bairro.Enabled = false;
            Lbl_Celular.Enabled = false;
            Lbl_Email.Enabled = false;
            Lbl_Confirmacao.Enabled = false;
            Lbl_Resultado.Enabled = false;
            Txt_Nome.Enabled = false;
            Txt_Sobrenome.Enabled = false;
            Txt_Idade.Enabled = false;
            Txt_Bairro.Enabled = false;
            Txt_Celular.Enabled = false;
            Txt_Email.Enabled = false;
            Btn_Nome.Enabled = false;
            Btn_Sobrenome.Enabled = false;
            Btn_Idade.Enabled = false;
            Btn_Bairro.Enabled = false;
            Btn_Celular.Enabled = false;
            Btn_Email.Enabled = false;
            Btn_DadosCompleto.Enabled = false;
            Btn_Ativar.Enabled = true;
            Btn_Desativar.Enabled = false;
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            //Limpando Todas as Informações das Caixas de Texto
            Txt_Nome.Clear();
            Txt_Sobrenome.Clear();
            Txt_Idade.Clear();
            Txt_Bairro.Clear();
            Txt_Celular.Clear();
            Txt_Email.Clear();
            Btn_Limpar.Enabled = true;
            Lbl_Resultado.Visible = false
        }
    }
}
