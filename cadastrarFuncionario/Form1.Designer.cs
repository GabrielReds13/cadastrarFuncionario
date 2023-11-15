namespace CadastrarFuncionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_dataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.btn_limpar = new System.Windows.Forms.PictureBox();
            this.btn_salvar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.cb_estadoCivil = new System.Windows.Forms.ComboBox();
            this.cb_funcao = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_nome.Location = new System.Drawing.Point(54, 143);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(0);
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(366, 28);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.Text = "Nome completo";
            // 
            // txt_dataNascimento
            // 
            this.txt_dataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_dataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_dataNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_dataNascimento.Location = new System.Drawing.Point(54, 203);
            this.txt_dataNascimento.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txt_dataNascimento.Name = "txt_dataNascimento";
            this.txt_dataNascimento.Size = new System.Drawing.Size(366, 19);
            this.txt_dataNascimento.TabIndex = 5;
            this.txt_dataNascimento.Text = "Data de nascimento";
            // 
            // cb_sexo
            // 
            this.cb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Location = new System.Drawing.Point(54, 265);
            this.cb_sexo.Margin = new System.Windows.Forms.Padding(0);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(366, 28);
            this.cb_sexo.TabIndex = 7;
            this.cb_sexo.Text = "Sexo";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = global::CadastrarFuncionario.Properties.Resources.Clear;
            this.btn_limpar.Location = new System.Drawing.Point(242, 647);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(178, 50);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.TabStop = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = global::CadastrarFuncionario.Properties.Resources.Save_Off;
            this.btn_salvar.Location = new System.Drawing.Point(54, 647);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(178, 50);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.TabStop = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(54, 231);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox4.Size = new System.Drawing.Size(366, 2);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(54, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox2.Size = new System.Drawing.Size(366, 2);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadastrarFuncionario.Properties.Resources.User_Photo;
            this.pictureBox1.Location = new System.Drawing.Point(195, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(54, 355);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox6.Size = new System.Drawing.Size(202, 2);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // txt_cpf
            // 
            this.txt_cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_cpf.Location = new System.Drawing.Point(54, 327);
            this.txt_cpf.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(202, 19);
            this.txt_cpf.TabIndex = 10;
            this.txt_cpf.Text = "CPF";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(278, 355);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox7.Size = new System.Drawing.Size(142, 2);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // txt_rg
            // 
            this.txt_rg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_rg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_rg.Location = new System.Drawing.Point(278, 327);
            this.txt_rg.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(142, 19);
            this.txt_rg.TabIndex = 12;
            this.txt_rg.Text = "RG";
            // 
            // cb_estadoCivil
            // 
            this.cb_estadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.cb_estadoCivil.FormattingEnabled = true;
            this.cb_estadoCivil.Location = new System.Drawing.Point(54, 384);
            this.cb_estadoCivil.Margin = new System.Windows.Forms.Padding(0);
            this.cb_estadoCivil.Name = "cb_estadoCivil";
            this.cb_estadoCivil.Size = new System.Drawing.Size(366, 28);
            this.cb_estadoCivil.TabIndex = 14;
            this.cb_estadoCivil.Text = "Estado civil";
            // 
            // cb_funcao
            // 
            this.cb_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_funcao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.cb_funcao.FormattingEnabled = true;
            this.cb_funcao.Location = new System.Drawing.Point(54, 571);
            this.cb_funcao.Margin = new System.Windows.Forms.Padding(0);
            this.cb_funcao.Name = "cb_funcao";
            this.cb_funcao.Size = new System.Drawing.Size(366, 28);
            this.cb_funcao.TabIndex = 15;
            this.cb_funcao.Text = "Função";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_email.Location = new System.Drawing.Point(54, 509);
            this.txt_email.Margin = new System.Windows.Forms.Padding(0);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(366, 28);
            this.txt_email.TabIndex = 17;
            this.txt_email.Text = "Email";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(54, 537);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox8.Size = new System.Drawing.Size(366, 2);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(54, 477);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox9.Size = new System.Drawing.Size(366, 2);
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_telefone.Location = new System.Drawing.Point(54, 449);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(366, 19);
            this.txt_telefone.TabIndex = 18;
            this.txt_telefone.Text = "Telefone";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(451, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(554, 563);
            this.listBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.cb_funcao);
            this.Controls.Add(this.cb_estadoCivil);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_dataNascimento);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.Text = "System - Novo Funcionário";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox txt_dataNascimento;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.PictureBox btn_salvar;
        private System.Windows.Forms.PictureBox btn_limpar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.ComboBox cb_estadoCivil;
        private System.Windows.Forms.ComboBox cb_funcao;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.ListBox listBox1;
    }
}

