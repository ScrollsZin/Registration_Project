
namespace Registration_Project
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.Btn_Ativar = new System.Windows.Forms.Button();
            this.Rad_T3 = new System.Windows.Forms.RadioButton();
            this.Rad_T2 = new System.Windows.Forms.RadioButton();
            this.Rad_T1 = new System.Windows.Forms.RadioButton();
            this.Rad_Padrao = new System.Windows.Forms.RadioButton();
            this.Btn_Desativar = new System.Windows.Forms.Button();
            this.Grp_Backgrounds = new System.Windows.Forms.GroupBox();
            this.Btn_DadosCompleto = new System.Windows.Forms.Button();
            this.Btn_Nome = new System.Windows.Forms.Button();
            this.Btn_Sobrenome = new System.Windows.Forms.Button();
            this.Btn_Idade = new System.Windows.Forms.Button();
            this.Btn_Bairro = new System.Windows.Forms.Button();
            this.Btn_Celular = new System.Windows.Forms.Button();
            this.Btn_Email = new System.Windows.Forms.Button();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Celular = new System.Windows.Forms.TextBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.Txt_Idade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Lbl_Confirmacao = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_Celular = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Idade = new System.Windows.Forms.Label();
            this.Lbl_Sobrenome = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_DadosPessoais = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Grp_Backgrounds.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Ativar
            // 
            this.Btn_Ativar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Ativar.FlatAppearance.BorderSize = 0;
            this.Btn_Ativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ativar.ForeColor = System.Drawing.Color.White;
            this.Btn_Ativar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ativar.Image")));
            this.Btn_Ativar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ativar.Location = new System.Drawing.Point(12, 12);
            this.Btn_Ativar.Name = "Btn_Ativar";
            this.Btn_Ativar.Size = new System.Drawing.Size(75, 67);
            this.Btn_Ativar.TabIndex = 28;
            this.Btn_Ativar.Text = "Ativar";
            this.Btn_Ativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Ativar.UseVisualStyleBackColor = false;
            this.Btn_Ativar.Click += new System.EventHandler(this.Btn_Ativar_Click);
            // 
            // Rad_T3
            // 
            this.Rad_T3.AutoSize = true;
            this.Rad_T3.Enabled = false;
            this.Rad_T3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_T3.Location = new System.Drawing.Point(12, 104);
            this.Rad_T3.Name = "Rad_T3";
            this.Rad_T3.Size = new System.Drawing.Size(61, 17);
            this.Rad_T3.TabIndex = 3;
            this.Rad_T3.TabStop = true;
            this.Rad_T3.Text = "Tema 3";
            this.Rad_T3.UseVisualStyleBackColor = true;
            this.Rad_T3.Click += new System.EventHandler(this.Rad_T3_CheckedChanged);
            // 
            // Rad_T2
            // 
            this.Rad_T2.AutoSize = true;
            this.Rad_T2.Enabled = false;
            this.Rad_T2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_T2.Location = new System.Drawing.Point(12, 77);
            this.Rad_T2.Name = "Rad_T2";
            this.Rad_T2.Size = new System.Drawing.Size(61, 17);
            this.Rad_T2.TabIndex = 2;
            this.Rad_T2.TabStop = true;
            this.Rad_T2.Text = "Tema 2";
            this.Rad_T2.UseVisualStyleBackColor = true;
            this.Rad_T2.Click += new System.EventHandler(this.Rad_T2_CheckedChanged);
            // 
            // Rad_T1
            // 
            this.Rad_T1.AutoSize = true;
            this.Rad_T1.Enabled = false;
            this.Rad_T1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_T1.Location = new System.Drawing.Point(12, 50);
            this.Rad_T1.Name = "Rad_T1";
            this.Rad_T1.Size = new System.Drawing.Size(61, 17);
            this.Rad_T1.TabIndex = 1;
            this.Rad_T1.TabStop = true;
            this.Rad_T1.Text = "Tema 1";
            this.Rad_T1.UseVisualStyleBackColor = true;
            this.Rad_T1.Click += new System.EventHandler(this.Rad_T1_CheckedChanged);
            // 
            // Rad_Padrao
            // 
            this.Rad_Padrao.AutoSize = true;
            this.Rad_Padrao.Enabled = false;
            this.Rad_Padrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Padrao.Location = new System.Drawing.Point(12, 23);
            this.Rad_Padrao.Name = "Rad_Padrao";
            this.Rad_Padrao.Size = new System.Drawing.Size(59, 17);
            this.Rad_Padrao.TabIndex = 0;
            this.Rad_Padrao.TabStop = true;
            this.Rad_Padrao.Text = "Padrão";
            this.Rad_Padrao.UseVisualStyleBackColor = true;
            this.Rad_Padrao.Click += new System.EventHandler(this.Rad_Padrao_CheckedChanged);
            // 
            // Btn_Desativar
            // 
            this.Btn_Desativar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Desativar.Enabled = false;
            this.Btn_Desativar.FlatAppearance.BorderSize = 0;
            this.Btn_Desativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Desativar.ForeColor = System.Drawing.Color.White;
            this.Btn_Desativar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Desativar.Image")));
            this.Btn_Desativar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Desativar.Location = new System.Drawing.Point(108, 12);
            this.Btn_Desativar.Name = "Btn_Desativar";
            this.Btn_Desativar.Size = new System.Drawing.Size(75, 67);
            this.Btn_Desativar.TabIndex = 29;
            this.Btn_Desativar.Text = "Desativar";
            this.Btn_Desativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Desativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Desativar.UseVisualStyleBackColor = false;
            this.Btn_Desativar.Click += new System.EventHandler(this.Btn_Desativar_Click);
            // 
            // Grp_Backgrounds
            // 
            this.Grp_Backgrounds.BackColor = System.Drawing.Color.Transparent;
            this.Grp_Backgrounds.Controls.Add(this.Rad_T3);
            this.Grp_Backgrounds.Controls.Add(this.Rad_T2);
            this.Grp_Backgrounds.Controls.Add(this.Rad_T1);
            this.Grp_Backgrounds.Controls.Add(this.Rad_Padrao);
            this.Grp_Backgrounds.Enabled = false;
            this.Grp_Backgrounds.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Backgrounds.ForeColor = System.Drawing.Color.White;
            this.Grp_Backgrounds.Location = new System.Drawing.Point(12, 117);
            this.Grp_Backgrounds.Name = "Grp_Backgrounds";
            this.Grp_Backgrounds.Size = new System.Drawing.Size(200, 128);
            this.Grp_Backgrounds.TabIndex = 48;
            this.Grp_Backgrounds.TabStop = false;
            this.Grp_Backgrounds.Text = "Backgrounds";
            // 
            // Btn_DadosCompleto
            // 
            this.Btn_DadosCompleto.Enabled = false;
            this.Btn_DadosCompleto.Location = new System.Drawing.Point(921, 251);
            this.Btn_DadosCompleto.Name = "Btn_DadosCompleto";
            this.Btn_DadosCompleto.Size = new System.Drawing.Size(75, 35);
            this.Btn_DadosCompleto.TabIndex = 47;
            this.Btn_DadosCompleto.Text = "Dados Completos";
            this.Btn_DadosCompleto.UseVisualStyleBackColor = true;
            this.Btn_DadosCompleto.Click += new System.EventHandler(this.Btn_DadosCompleto_Click);
            // 
            // Btn_Nome
            // 
            this.Btn_Nome.Enabled = false;
            this.Btn_Nome.Location = new System.Drawing.Point(921, 77);
            this.Btn_Nome.Name = "Btn_Nome";
            this.Btn_Nome.Size = new System.Drawing.Size(75, 23);
            this.Btn_Nome.TabIndex = 46;
            this.Btn_Nome.Text = "Nome";
            this.Btn_Nome.UseVisualStyleBackColor = true;
            this.Btn_Nome.Click += new System.EventHandler(this.Btn_Nome_Click);
            // 
            // Btn_Sobrenome
            // 
            this.Btn_Sobrenome.Enabled = false;
            this.Btn_Sobrenome.Location = new System.Drawing.Point(921, 106);
            this.Btn_Sobrenome.Name = "Btn_Sobrenome";
            this.Btn_Sobrenome.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sobrenome.TabIndex = 45;
            this.Btn_Sobrenome.Text = "Sobrenome";
            this.Btn_Sobrenome.UseVisualStyleBackColor = true;
            this.Btn_Sobrenome.Click += new System.EventHandler(this.Btn_Sobrenome_Click);
            // 
            // Btn_Idade
            // 
            this.Btn_Idade.Enabled = false;
            this.Btn_Idade.Location = new System.Drawing.Point(921, 135);
            this.Btn_Idade.Name = "Btn_Idade";
            this.Btn_Idade.Size = new System.Drawing.Size(75, 23);
            this.Btn_Idade.TabIndex = 44;
            this.Btn_Idade.Text = "Idade";
            this.Btn_Idade.UseVisualStyleBackColor = true;
            this.Btn_Idade.Click += new System.EventHandler(this.Btn_Idade_Click);
            // 
            // Btn_Bairro
            // 
            this.Btn_Bairro.Enabled = false;
            this.Btn_Bairro.Location = new System.Drawing.Point(921, 164);
            this.Btn_Bairro.Name = "Btn_Bairro";
            this.Btn_Bairro.Size = new System.Drawing.Size(75, 23);
            this.Btn_Bairro.TabIndex = 43;
            this.Btn_Bairro.Text = "Bairro";
            this.Btn_Bairro.UseVisualStyleBackColor = true;
            this.Btn_Bairro.Click += new System.EventHandler(this.Btn_Bairro_Click);
            // 
            // Btn_Celular
            // 
            this.Btn_Celular.Enabled = false;
            this.Btn_Celular.Location = new System.Drawing.Point(921, 193);
            this.Btn_Celular.Name = "Btn_Celular";
            this.Btn_Celular.Size = new System.Drawing.Size(75, 23);
            this.Btn_Celular.TabIndex = 42;
            this.Btn_Celular.Text = "Celular";
            this.Btn_Celular.UseVisualStyleBackColor = true;
            this.Btn_Celular.Click += new System.EventHandler(this.Btn_Celular_Click);
            // 
            // Btn_Email
            // 
            this.Btn_Email.Enabled = false;
            this.Btn_Email.Location = new System.Drawing.Point(921, 222);
            this.Btn_Email.Name = "Btn_Email";
            this.Btn_Email.Size = new System.Drawing.Size(75, 23);
            this.Btn_Email.TabIndex = 41;
            this.Btn_Email.Text = "E-mail";
            this.Btn_Email.UseVisualStyleBackColor = true;
            this.Btn_Email.Click += new System.EventHandler(this.Btn_Email_Click);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Enabled = false;
            this.Txt_Email.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(723, 222);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(192, 20);
            this.Txt_Email.TabIndex = 40;
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Enabled = false;
            this.Txt_Celular.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Celular.Location = new System.Drawing.Point(723, 193);
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(98, 20);
            this.Txt_Celular.TabIndex = 39;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Enabled = false;
            this.Txt_Nome.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(723, 77);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(192, 20);
            this.Txt_Nome.TabIndex = 38;
            // 
            // Txt_Sobrenome
            // 
            this.Txt_Sobrenome.Enabled = false;
            this.Txt_Sobrenome.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Sobrenome.Location = new System.Drawing.Point(723, 106);
            this.Txt_Sobrenome.Name = "Txt_Sobrenome";
            this.Txt_Sobrenome.Size = new System.Drawing.Size(192, 20);
            this.Txt_Sobrenome.TabIndex = 37;
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.Enabled = false;
            this.Txt_Idade.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Idade.Location = new System.Drawing.Point(723, 135);
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.Size = new System.Drawing.Size(40, 20);
            this.Txt_Idade.TabIndex = 36;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Enabled = false;
            this.Txt_Bairro.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Bairro.Location = new System.Drawing.Point(723, 164);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(192, 20);
            this.Txt_Bairro.TabIndex = 35;
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Resultado.Enabled = false;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.Color.White;
            this.Lbl_Resultado.Location = new System.Drawing.Point(788, 326);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Resultado.TabIndex = 34;
            this.Lbl_Resultado.Text = "Resultado";
            this.Lbl_Resultado.Visible = false;
            // 
            // Lbl_Confirmacao
            // 
            this.Lbl_Confirmacao.AutoSize = true;
            this.Lbl_Confirmacao.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Confirmacao.Enabled = false;
            this.Lbl_Confirmacao.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Confirmacao.ForeColor = System.Drawing.Color.White;
            this.Lbl_Confirmacao.Location = new System.Drawing.Point(723, 258);
            this.Lbl_Confirmacao.Name = "Lbl_Confirmacao";
            this.Lbl_Confirmacao.Size = new System.Drawing.Size(196, 19);
            this.Lbl_Confirmacao.TabIndex = 33;
            this.Lbl_Confirmacao.Text = "Confirmação de Dados:";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Email.Enabled = false;
            this.Lbl_Email.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.ForeColor = System.Drawing.Color.White;
            this.Lbl_Email.Location = new System.Drawing.Point(651, 224);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(66, 19);
            this.Lbl_Email.TabIndex = 32;
            this.Lbl_Email.Text = "E-mail:";
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.AutoSize = true;
            this.Lbl_Celular.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Celular.Enabled = false;
            this.Lbl_Celular.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Celular.ForeColor = System.Drawing.Color.White;
            this.Lbl_Celular.Location = new System.Drawing.Point(642, 195);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(75, 19);
            this.Lbl_Celular.TabIndex = 30;
            this.Lbl_Celular.Text = "Celular:";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Bairro.Enabled = false;
            this.Lbl_Bairro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bairro.ForeColor = System.Drawing.Color.White;
            this.Lbl_Bairro.Location = new System.Drawing.Point(649, 166);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(68, 19);
            this.Lbl_Bairro.TabIndex = 27;
            this.Lbl_Bairro.Text = "Bairro:";
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.AutoSize = true;
            this.Lbl_Idade.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Idade.Enabled = false;
            this.Lbl_Idade.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idade.ForeColor = System.Drawing.Color.White;
            this.Lbl_Idade.Location = new System.Drawing.Point(659, 134);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(58, 19);
            this.Lbl_Idade.TabIndex = 26;
            this.Lbl_Idade.Text = "Idade:";
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.AutoSize = true;
            this.Lbl_Sobrenome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Sobrenome.Enabled = false;
            this.Lbl_Sobrenome.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sobrenome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(612, 107);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(105, 19);
            this.Lbl_Sobrenome.TabIndex = 25;
            this.Lbl_Sobrenome.Text = "Sobrenome:";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Enabled = false;
            this.Lbl_Nome.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome.Location = new System.Drawing.Point(657, 77);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(60, 19);
            this.Lbl_Nome.TabIndex = 24;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Lbl_DadosPessoais
            // 
            this.Lbl_DadosPessoais.AutoSize = true;
            this.Lbl_DadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_DadosPessoais.Enabled = false;
            this.Lbl_DadosPessoais.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DadosPessoais.ForeColor = System.Drawing.Color.White;
            this.Lbl_DadosPessoais.Location = new System.Drawing.Point(397, 9);
            this.Lbl_DadosPessoais.Name = "Lbl_DadosPessoais";
            this.Lbl_DadosPessoais.Size = new System.Drawing.Size(217, 31);
            this.Lbl_DadosPessoais.TabIndex = 23;
            this.Lbl_DadosPessoais.Text = "Dados Pessoais";
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Limpar.FlatAppearance.BorderSize = 0;
            this.Btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpar.Image")));
            this.Btn_Limpar.Location = new System.Drawing.Point(204, 12);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 67);
            this.Btn_Limpar.TabIndex = 49;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 485);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Ativar);
            this.Controls.Add(this.Btn_Desativar);
            this.Controls.Add(this.Grp_Backgrounds);
            this.Controls.Add(this.Btn_DadosCompleto);
            this.Controls.Add(this.Btn_Nome);
            this.Controls.Add(this.Btn_Sobrenome);
            this.Controls.Add(this.Btn_Idade);
            this.Controls.Add(this.Btn_Bairro);
            this.Controls.Add(this.Btn_Celular);
            this.Controls.Add(this.Btn_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Celular);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Txt_Sobrenome);
            this.Controls.Add(this.Txt_Idade);
            this.Controls.Add(this.Txt_Bairro);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Lbl_Confirmacao);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Lbl_Celular);
            this.Controls.Add(this.Lbl_Bairro);
            this.Controls.Add(this.Lbl_Idade);
            this.Controls.Add(this.Lbl_Sobrenome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_DadosPessoais);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Grp_Backgrounds.ResumeLayout(false);
            this.Grp_Backgrounds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ativar;
        private System.Windows.Forms.RadioButton Rad_T3;
        private System.Windows.Forms.RadioButton Rad_T2;
        private System.Windows.Forms.RadioButton Rad_T1;
        private System.Windows.Forms.RadioButton Rad_Padrao;
        private System.Windows.Forms.Button Btn_Desativar;
        private System.Windows.Forms.GroupBox Grp_Backgrounds;
        private System.Windows.Forms.Button Btn_DadosCompleto;
        private System.Windows.Forms.Button Btn_Nome;
        private System.Windows.Forms.Button Btn_Sobrenome;
        private System.Windows.Forms.Button Btn_Idade;
        private System.Windows.Forms.Button Btn_Bairro;
        private System.Windows.Forms.Button Btn_Celular;
        private System.Windows.Forms.Button Btn_Email;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Celular;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Sobrenome;
        private System.Windows.Forms.TextBox Txt_Idade;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Label Lbl_Confirmacao;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_Celular;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Idade;
        private System.Windows.Forms.Label Lbl_Sobrenome;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_DadosPessoais;
        private System.Windows.Forms.Button Btn_Limpar;
    }
}