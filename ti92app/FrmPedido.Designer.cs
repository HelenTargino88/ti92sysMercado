namespace ti92app
{
    partial class FrmPedido
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.label3);
            this.grbDados.Controls.Add(this.cmbUsuario);
            this.grbDados.Controls.Add(this.label2);
            this.grbDados.Controls.Add(this.cmbCliente);
            this.grbDados.Controls.Add(this.btnInserir);
            this.grbDados.Location = new System.Drawing.Point(12, 104);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(622, 188);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            this.grbDados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Atendente";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(328, 31);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(74, 34);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(537, 159);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDO Nº";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(510, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 31);
            this.txtId.TabIndex = 2;
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.label9);
            this.grbProduto.Controls.Add(this.textBox7);
            this.grbProduto.Controls.Add(this.label8);
            this.grbProduto.Controls.Add(this.label7);
            this.grbProduto.Controls.Add(this.label6);
            this.grbProduto.Controls.Add(this.label5);
            this.grbProduto.Controls.Add(this.label4);
            this.grbProduto.Controls.Add(this.textBox6);
            this.grbProduto.Controls.Add(this.textBox5);
            this.grbProduto.Controls.Add(this.textBox4);
            this.grbProduto.Controls.Add(this.textBox3);
            this.grbProduto.Controls.Add(this.textBox2);
            this.grbProduto.Controls.Add(this.btnAdicionar);
            this.grbProduto.Location = new System.Drawing.Point(12, 298);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(622, 137);
            this.grbProduto.TabIndex = 3;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "Produtos";
            this.grbProduto.Enter += new System.EventHandler(this.grbProduto_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Desconto";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(548, 52);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(68, 20);
            this.textBox7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Qtd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Und";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(469, 52);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(396, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(69, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(331, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(53, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(537, 105);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSeq,
            this.clnCodigo,
            this.clnDescricao,
            this.clnUnidade,
            this.clnPreco,
            this.clnQtd,
            this.clnDesconto,
            this.clnTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(622, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // clnSeq
            // 
            this.clnSeq.Frozen = true;
            this.clnSeq.HeaderText = "#";
            this.clnSeq.Name = "clnSeq";
            this.clnSeq.ReadOnly = true;
            this.clnSeq.Width = 20;
            // 
            // clnCodigo
            // 
            this.clnCodigo.Frozen = true;
            this.clnCodigo.HeaderText = "Cód";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 70;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 190;
            // 
            // clnUnidade
            // 
            this.clnUnidade.Frozen = true;
            this.clnUnidade.HeaderText = "Unid";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 60;
            // 
            // clnPreco
            // 
            this.clnPreco.Frozen = true;
            this.clnPreco.HeaderText = "Preço R$";
            this.clnPreco.Name = "clnPreco";
            this.clnPreco.ReadOnly = true;
            this.clnPreco.Width = 70;
            // 
            // clnQtd
            // 
            this.clnQtd.Frozen = true;
            this.clnQtd.HeaderText = "Qtd";
            this.clnQtd.Name = "clnQtd";
            this.clnQtd.ReadOnly = true;
            this.clnQtd.Width = 60;
            // 
            // clnDesconto
            // 
            this.clnDesconto.Frozen = true;
            this.clnDesconto.HeaderText = "Desconto";
            this.clnDesconto.Name = "clnDesconto";
            this.clnDesconto.ReadOnly = true;
            this.clnDesconto.Width = 60;
            // 
            // clnTotal
            // 
            this.clnTotal.Frozen = true;
            this.clnTotal.HeaderText = "Total R$";
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            this.clnTotal.Width = 90;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(400, 647);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(108, 24);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "TOTAL R$";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(514, 643);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 31);
            this.textBox1.TabIndex = 6;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(553, 75);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "+ Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(651, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Sts";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 779);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbProduto);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbDados);
            this.Name = "FrmPedido";
            this.Text = "frmPedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
    }
}