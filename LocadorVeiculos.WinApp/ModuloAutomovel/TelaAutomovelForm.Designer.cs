﻿namespace LocadorAutomoveis.WinApp.ModuloAutomovel
{
    partial class TelaAutomovelForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            txtModelo = new TextBox();
            label2 = new Label();
            btnImagem = new Button();
            label3 = new Label();
            cmbGrupo = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtMarca = new TextBox();
            label6 = new Label();
            txtCor = new TextBox();
            cmbCombustivel = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtAno = new NumericUpDown();
            txtCapacidade = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            txtQuilometragem = new NumericUpDown();
            label11 = new Label();
            txtPlaca = new MaskedTextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            txtFoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)txtAno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCapacidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuilometragem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFoto).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(356, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 45);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(275, 373);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 45);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(159, 129);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(253, 23);
            txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 103);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 5;
            label2.Text = "Grupo de Automóveis:";
            // 
            // btnImagem
            // 
            btnImagem.Location = new Point(304, 40);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(108, 37);
            btnImagem.TabIndex = 1;
            btnImagem.Text = "Inserir Imagem";
            btnImagem.UseVisualStyleBackColor = true;
            btnImagem.Click += btnImagem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 51);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 11;
            label3.Text = "Foto:";
            // 
            // cmbGrupo
            // 
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(159, 100);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(253, 23);
            cmbGrupo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 132);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 13;
            label4.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 161);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 15;
            label5.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(159, 158);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(253, 23);
            txtMarca.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 193);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 16;
            label6.Text = "Cor:";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(159, 190);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(253, 23);
            txtCor.TabIndex = 5;
            // 
            // cmbCombustivel
            // 
            cmbCombustivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombustivel.FormattingEnabled = true;
            cmbCombustivel.Location = new Point(156, 272);
            cmbCombustivel.Name = "cmbCombustivel";
            cmbCombustivel.Size = new Size(253, 23);
            cmbCombustivel.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 280);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 19;
            label7.Text = "Tipo de Combustível:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(121, 217);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 20;
            label8.Text = "Ano:";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(156, 214);
            txtAno.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtAno.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(120, 23);
            txtAno.TabIndex = 6;
            txtAno.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // txtCapacidade
            // 
            txtCapacidade.DecimalPlaces = 2;
            txtCapacidade.Location = new Point(157, 306);
            txtCapacidade.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtCapacidade.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.Size = new Size(120, 23);
            txtCapacidade.TabIndex = 9;
            txtCapacidade.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 308);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 23;
            label9.Text = "Capacidade em Litros:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(118, 246);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 25;
            label10.Text = "Placa:";
            // 
            // txtQuilometragem
            // 
            txtQuilometragem.Location = new Point(156, 335);
            txtQuilometragem.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtQuilometragem.Name = "txtQuilometragem";
            txtQuilometragem.Size = new Size(120, 23);
            txtQuilometragem.TabIndex = 10;
            txtQuilometragem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(56, 337);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 26;
            label11.Text = "Quilometragem:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(157, 243);
            txtPlaca.Mask = "aaa-0000";
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(120, 23);
            txtPlaca.TabIndex = 7;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.InitialDirectory = "C:";
            folderBrowserDialog1.SelectedPath = "C:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "C:";
            // 
            // txtFoto
            // 
            txtFoto.BorderStyle = BorderStyle.FixedSingle;
            txtFoto.Image = Properties.Resources.local_shipping_FILL0_wght400_GRAD0_opsz48;
            txtFoto.Location = new Point(159, 22);
            txtFoto.Name = "txtFoto";
            txtFoto.Size = new Size(138, 72);
            txtFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            txtFoto.TabIndex = 29;
            txtFoto.TabStop = false;
            // 
            // TelaAutomovelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 430);
            Controls.Add(txtFoto);
            Controls.Add(txtPlaca);
            Controls.Add(txtQuilometragem);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtCapacidade);
            Controls.Add(label9);
            Controls.Add(txtAno);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbCombustivel);
            Controls.Add(txtCor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(cmbGrupo);
            Controls.Add(label3);
            Controls.Add(btnImagem);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtModelo);
            Controls.Add(label2);
            Name = "TelaAutomovelForm";
            Text = "Cadastro de Automóveis";
            ((System.ComponentModel.ISupportInitialize)txtAno).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCapacidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuilometragem).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtModelo;
        private Label label2;
        private Label txtImagem;
        private Button btnImagem;
        private Label label3;
        private ComboBox cmbGrupo;
        private Label label4;
        private Label label5;
        private TextBox txtMarca;
        private Label label6;
        private TextBox txtCor;
        private ComboBox cmbCombustivel;
        private Label label7;
        private Label label8;
        private NumericUpDown txtAno;
        private NumericUpDown txtCapacidade;
        private Label label9;
        private Label label10;
        private NumericUpDown txtQuilometragem;
        private Label label11;
        private MaskedTextBox txtPlaca;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private PictureBox txtFoto;
    }
}