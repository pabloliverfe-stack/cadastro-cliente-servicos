﻿
namespace FormCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDataEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.tagSolutions = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome: ";
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(106, 46);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(352, 22);
            this.TextNome.TabIndex = 3;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(106, 84);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(352, 22);
            this.textEndereco.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço: ";
            // 
            // textDataEntrada
            // 
            this.textDataEntrada.Location = new System.Drawing.Point(106, 124);
            this.textDataEntrada.Name = "textDataEntrada";
            this.textDataEntrada.Size = new System.Drawing.Size(352, 22);
            this.textDataEntrada.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Entrada: ";
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(37, 244);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.RowHeadersWidth = 51;
            this.dataGridViewCliente.RowTemplate.Height = 24;
            this.dataGridViewCliente.Size = new System.Drawing.Size(735, 190);
            this.dataGridViewCliente.TabIndex = 8;
            this.dataGridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellContentClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(74, 180);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(141, 46);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "&Atualizar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnAtualizar);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(233, 180);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(141, 46);
            this.BtnNovo.TabIndex = 9;
            this.BtnNovo.Text = "&Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnCadNovo);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(403, 180);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 46);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "&Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtncadCancel);
            // 
            // tagSolutions
            // 
            this.tagSolutions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tagSolutions.Cursor = System.Windows.Forms.Cursors.No;
            this.tagSolutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSolutions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tagSolutions.Location = new System.Drawing.Point(484, 440);
            this.tagSolutions.Name = "tagSolutions";
            this.tagSolutions.Size = new System.Drawing.Size(288, 43);
            this.tagSolutions.TabIndex = 10;
            this.tagSolutions.Text = "Oliveira New Solutions";
            this.tagSolutions.UseVisualStyleBackColor = false;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(107, 19);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(82, 22);
            this.textId.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID :";
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletar.Location = new System.Drawing.Point(563, 179);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(141, 46);
            this.BtnDeletar.TabIndex = 13;
            this.BtnDeletar.Text = "&Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = false;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tagSolutions);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.textDataEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDataEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button tagSolutions;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDeletar;
    }
}

