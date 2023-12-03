namespace interdisciplinar2
{
    partial class HistoricScreen
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
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbHistorico = new System.Windows.Forms.ComboBox();
            this.tituloSelecionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(283, 60);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(451, 268);
            this.dgvHistorico.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 583);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.pictureBox1.Image = global::interdisciplinar2.Properties.Resources.Marca_do_bruno_com_alterações_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 183);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cbHistorico
            // 
            this.cbHistorico.Font = new System.Drawing.Font("Cascadia Code", 12.75F);
            this.cbHistorico.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbHistorico.FormattingEnabled = true;
            this.cbHistorico.Items.AddRange(new object[] {
            "Horários da ultima semana",
            "Horários do ultimo mês",
            "Horários de hoje"});
            this.cbHistorico.Location = new System.Drawing.Point(423, 373);
            this.cbHistorico.Name = "cbHistorico";
            this.cbHistorico.Size = new System.Drawing.Size(244, 30);
            this.cbHistorico.TabIndex = 4;
            this.cbHistorico.SelectedIndexChanged += new System.EventHandler(this.cbHistorico_SelectedIndexChanged);
            // 
            // tituloSelecionado
            // 
            this.tituloSelecionado.AutoSize = true;
            this.tituloSelecionado.Font = new System.Drawing.Font("Cascadia Code", 12.75F);
            this.tituloSelecionado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloSelecionado.Location = new System.Drawing.Point(506, 24);
            this.tituloSelecionado.Name = "tituloSelecionado";
            this.tituloSelecionado.Size = new System.Drawing.Size(0, 22);
            this.tituloSelecionado.TabIndex = 5;
            // 
            // HistoricScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.tituloSelecionado);
            this.Controls.Add(this.cbHistorico);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvHistorico);
            this.Name = "HistoricScreen";
            this.Text = "d";
            this.Load += new System.EventHandler(this.HistoricScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbHistorico;
        private System.Windows.Forms.Label tituloSelecionado;
    }
}