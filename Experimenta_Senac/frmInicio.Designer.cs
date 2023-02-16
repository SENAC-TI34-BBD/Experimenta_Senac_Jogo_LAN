namespace Experimenta_Senac
{
    partial class frmInicio
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
            this.grbConexao = new System.Windows.Forms.GroupBox();
            this.btnConecta = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.grbHost = new System.Windows.Forms.GroupBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.grbConexao.SuspendLayout();
            this.grbHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConexao
            // 
            this.grbConexao.Controls.Add(this.btnConecta);
            this.grbConexao.Controls.Add(this.txtIP);
            this.grbConexao.Controls.Add(this.lblIP);
            this.grbConexao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConexao.Location = new System.Drawing.Point(12, 12);
            this.grbConexao.Name = "grbConexao";
            this.grbConexao.Size = new System.Drawing.Size(397, 122);
            this.grbConexao.TabIndex = 0;
            this.grbConexao.TabStop = false;
            this.grbConexao.Text = "Conectar-se a um Jogo:";
            // 
            // btnConecta
            // 
            this.btnConecta.Location = new System.Drawing.Point(109, 74);
            this.btnConecta.Name = "btnConecta";
            this.btnConecta.Size = new System.Drawing.Size(202, 30);
            this.btnConecta.TabIndex = 2;
            this.btnConecta.Text = "Conectar-se";
            this.btnConecta.UseVisualStyleBackColor = true;
            this.btnConecta.Click += new System.EventHandler(this.btnConecta_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(136, 36);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(175, 20);
            this.txtIP.TabIndex = 1;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(106, 38);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(24, 16);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP:";
            // 
            // grbHost
            // 
            this.grbHost.Controls.Add(this.btnHost);
            this.grbHost.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHost.Location = new System.Drawing.Point(12, 136);
            this.grbHost.Name = "grbHost";
            this.grbHost.Size = new System.Drawing.Size(397, 122);
            this.grbHost.TabIndex = 3;
            this.grbHost.TabStop = false;
            this.grbHost.Text = "Hospedar um jogo:";
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(57, 44);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(281, 47);
            this.btnHost.TabIndex = 4;
            this.btnHost.Text = "Hospedar um jogo";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click_1);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 270);
            this.Controls.Add(this.grbHost);
            this.Controls.Add(this.grbConexao);
            this.Name = "frmInicio";
            this.Text = "Jogo da Velha - Senac";
            this.grbConexao.ResumeLayout(false);
            this.grbConexao.PerformLayout();
            this.grbHost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConexao;
        private System.Windows.Forms.Button btnConecta;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.GroupBox grbHost;
        private System.Windows.Forms.Button btnHost;
    }
}

