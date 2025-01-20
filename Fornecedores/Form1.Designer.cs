namespace Fornecedores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtEndereco = new TextBox();
            btbCadastrar = new Button();
            btnPesquisar = new Button();
            label5 = new Label();
            lblId = new Label();
            lblLimpar = new Button();
            lblAtualizar = new Button();
            lblDeletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label1.Location = new Point(70, 103);
            label1.Name = "label1";
            label1.Size = new Size(57, 40);
            label1.TabIndex = 0;
            label1.Text = "Nome\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label2.Location = new Point(70, 150);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Email\r";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label3.Location = new Point(70, 198);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label4.Location = new Point(70, 246);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Endereço";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial Narrow", 10.8F);
            txtNome.Location = new Point(163, 103);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(569, 28);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Narrow", 10.8F);
            txtEmail.Location = new Point(163, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(569, 28);
            txtEmail.TabIndex = 5;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Arial Narrow", 10.8F);
            txtCPF.Location = new Point(163, 198);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(569, 28);
            txtCPF.TabIndex = 6;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial Narrow", 10.8F);
            txtEndereco.Location = new Point(163, 246);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(569, 28);
            txtEndereco.TabIndex = 7;
            // 
            // btbCadastrar
            // 
            btbCadastrar.BackColor = SystemColors.Control;
            btbCadastrar.Cursor = Cursors.Hand;
            btbCadastrar.FlatStyle = FlatStyle.Flat;
            btbCadastrar.Font = new Font("Arial", 10.8F);
            btbCadastrar.Location = new Point(163, 349);
            btbCadastrar.Name = "btbCadastrar";
            btbCadastrar.Size = new Size(133, 35);
            btbCadastrar.TabIndex = 8;
            btbCadastrar.Text = "Cadastrar";
            btbCadastrar.UseVisualStyleBackColor = false;
            btbCadastrar.Click += btbCadastrar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.Control;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 10.8F);
            btnPesquisar.Location = new Point(314, 349);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(122, 35);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label5.Location = new Point(65, 20);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 10;
            label5.Text = "Funcionário ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(179, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 11;
            // 
            // lblLimpar
            // 
            lblLimpar.BackColor = SystemColors.Control;
            lblLimpar.Cursor = Cursors.Hand;
            lblLimpar.FlatStyle = FlatStyle.Flat;
            lblLimpar.Font = new Font("Arial", 10.8F);
            lblLimpar.Location = new Point(613, 20);
            lblLimpar.Name = "lblLimpar";
            lblLimpar.Size = new Size(119, 35);
            lblLimpar.TabIndex = 12;
            lblLimpar.Text = "Limpar";
            lblLimpar.UseVisualStyleBackColor = false;
            lblLimpar.Click += lblLimpar_Click;
            // 
            // lblAtualizar
            // 
            lblAtualizar.BackColor = SystemColors.Control;
            lblAtualizar.Cursor = Cursors.Hand;
            lblAtualizar.FlatStyle = FlatStyle.Flat;
            lblAtualizar.Font = new Font("Arial", 10.8F);
            lblAtualizar.Location = new Point(456, 349);
            lblAtualizar.Name = "lblAtualizar";
            lblAtualizar.Size = new Size(122, 35);
            lblAtualizar.TabIndex = 13;
            lblAtualizar.Text = "Atualizar";
            lblAtualizar.UseVisualStyleBackColor = false;
            lblAtualizar.Click += lblAtualizar_Click;
            // 
            // lblDeletar
            // 
            lblDeletar.BackColor = SystemColors.Control;
            lblDeletar.Cursor = Cursors.Hand;
            lblDeletar.FlatStyle = FlatStyle.Flat;
            lblDeletar.Font = new Font("Arial", 10.8F);
            lblDeletar.Location = new Point(597, 349);
            lblDeletar.Name = "lblDeletar";
            lblDeletar.Size = new Size(122, 35);
            lblDeletar.TabIndex = 14;
            lblDeletar.Text = "Deletar";
            lblDeletar.UseVisualStyleBackColor = false;
            lblDeletar.Click += lblDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDeletar);
            Controls.Add(lblAtualizar);
            Controls.Add(lblLimpar);
            Controls.Add(lblId);
            Controls.Add(label5);
            Controls.Add(btnPesquisar);
            Controls.Add(btbCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Funcionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtEndereco;
        private Button btbCadastrar;
        private Button btnPesquisar;
        private Label label5;
        private Label lblId;
        private Button lblLimpar;
        private Button lblAtualizar;
        private Button lblDeletar;
    }
}
