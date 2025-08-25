namespace Simulador_da_balança
{
    partial class simulador_balanca
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
            this.components = new System.ComponentModel.Container();
            this.lblRecepcao = new System.Windows.Forms.Label();
            this.lblSimulacao = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.txtRecepcaoDados = new System.Windows.Forms.TextBox();
            this.txtSimulacaoPeso = new System.Windows.Forms.TextBox();
            this.txtEnvioDados = new System.Windows.Forms.TextBox();
            this.btnPeca = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pVisor = new System.Windows.Forms.Panel();
            this.lblDinamico = new System.Windows.Forms.Label();
            this.btnPesoMais = new System.Windows.Forms.Button();
            this.btnPesoMenos = new System.Windows.Forms.Button();
            this.lblPeca = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pVisor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecepcao
            // 
            this.lblRecepcao.AutoSize = true;
            this.lblRecepcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblRecepcao.Location = new System.Drawing.Point(9, 64);
            this.lblRecepcao.Name = "lblRecepcao";
            this.lblRecepcao.Size = new System.Drawing.Size(123, 15);
            this.lblRecepcao.TabIndex = 0;
            this.lblRecepcao.Text = "Recepção dos dados";
            // 
            // lblSimulacao
            // 
            this.lblSimulacao.AutoSize = true;
            this.lblSimulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSimulacao.Location = new System.Drawing.Point(9, 125);
            this.lblSimulacao.Name = "lblSimulacao";
            this.lblSimulacao.Size = new System.Drawing.Size(113, 15);
            this.lblSimulacao.TabIndex = 1;
            this.lblSimulacao.Text = "Simulação de peso";
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEnvio.Location = new System.Drawing.Point(268, 83);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(91, 15);
            this.lblEnvio.TabIndex = 2;
            this.lblEnvio.Text = "Envio de dados";
            // 
            // txtRecepcaoDados
            // 
            this.txtRecepcaoDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecepcaoDados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRecepcaoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRecepcaoDados.Location = new System.Drawing.Point(268, 100);
            this.txtRecepcaoDados.Multiline = true;
            this.txtRecepcaoDados.Name = "txtRecepcaoDados";
            this.txtRecepcaoDados.ReadOnly = true;
            this.txtRecepcaoDados.Size = new System.Drawing.Size(88, 20);
            this.txtRecepcaoDados.TabIndex = 3;
            this.txtRecepcaoDados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSimulacaoPeso
            // 
            this.txtSimulacaoPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSimulacaoPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.txtSimulacaoPeso.Location = new System.Drawing.Point(6, 143);
            this.txtSimulacaoPeso.Multiline = true;
            this.txtSimulacaoPeso.Name = "txtSimulacaoPeso";
            this.txtSimulacaoPeso.Size = new System.Drawing.Size(147, 38);
            this.txtSimulacaoPeso.TabIndex = 4;
            this.txtSimulacaoPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnvioDados
            // 
            this.txtEnvioDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnvioDados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEnvioDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEnvioDados.Location = new System.Drawing.Point(6, 82);
            this.txtEnvioDados.Multiline = true;
            this.txtEnvioDados.Name = "txtEnvioDados";
            this.txtEnvioDados.ReadOnly = true;
            this.txtEnvioDados.Size = new System.Drawing.Size(256, 38);
            this.txtEnvioDados.TabIndex = 5;
            this.txtEnvioDados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPeca
            // 
            this.btnPeca.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPeca.FlatAppearance.BorderSize = 0;
            this.btnPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPeca.ForeColor = System.Drawing.Color.White;
            this.btnPeca.Location = new System.Drawing.Point(159, 143);
            this.btnPeca.Name = "btnPeca";
            this.btnPeca.Size = new System.Drawing.Size(197, 38);
            this.btnPeca.TabIndex = 6;
            this.btnPeca.Text = "Colocar peça na balança";
            this.btnPeca.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCom);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(6, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 65);
            this.panel1.TabIndex = 7;
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.BackColor = System.Drawing.Color.Transparent;
            this.lblCom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCom.Location = new System.Drawing.Point(3, 47);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(116, 13);
            this.lblCom.TabIndex = 15;
            this.lblCom.Text = "Porta serial não aberta.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(6, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(65, 10);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(28, 472);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 10);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(313, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(291, 481);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(65, 10);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(85, 364);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 44);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(6, 256);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(171, 109);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.pVisor);
            this.panel8.Controls.Add(this.btnPesoMais);
            this.panel8.Controls.Add(this.btnPesoMenos);
            this.panel8.Location = new System.Drawing.Point(7, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(156, 91);
            this.panel8.TabIndex = 10;
            // 
            // pVisor
            // 
            this.pVisor.BackColor = System.Drawing.Color.AliceBlue;
            this.pVisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pVisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pVisor.Controls.Add(this.lblDinamico);
            this.pVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pVisor.Location = new System.Drawing.Point(5, 7);
            this.pVisor.Name = "pVisor";
            this.pVisor.Size = new System.Drawing.Size(144, 47);
            this.pVisor.TabIndex = 13;
            // 
            // lblDinamico
            // 
            this.lblDinamico.AutoSize = true;
            this.lblDinamico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDinamico.Location = new System.Drawing.Point(12, 10);
            this.lblDinamico.Name = "lblDinamico";
            this.lblDinamico.Size = new System.Drawing.Size(65, 24);
            this.lblDinamico.TabIndex = 0;
            this.lblDinamico.Text = "00.000";
            this.lblDinamico.TextChanged += new System.EventHandler(this.TxtSimulacaoPeso_TextChanged);
            // 
            // btnPesoMais
            // 
            this.btnPesoMais.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPesoMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnPesoMais.ForeColor = System.Drawing.Color.Black;
            this.btnPesoMais.Location = new System.Drawing.Point(82, 61);
            this.btnPesoMais.Name = "btnPesoMais";
            this.btnPesoMais.Size = new System.Drawing.Size(25, 23);
            this.btnPesoMais.TabIndex = 1;
            this.btnPesoMais.Text = ">";
            this.btnPesoMais.UseVisualStyleBackColor = false;
            this.btnPesoMais.Click += new System.EventHandler(this.BtnPesoMais_Click);
            // 
            // btnPesoMenos
            // 
            this.btnPesoMenos.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPesoMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnPesoMenos.ForeColor = System.Drawing.Color.Black;
            this.btnPesoMenos.Location = new System.Drawing.Point(51, 61);
            this.btnPesoMenos.Name = "btnPesoMenos";
            this.btnPesoMenos.Size = new System.Drawing.Size(25, 23);
            this.btnPesoMenos.TabIndex = 0;
            this.btnPesoMenos.Text = "<";
            this.btnPesoMenos.UseVisualStyleBackColor = false;
            this.btnPesoMenos.Click += new System.EventHandler(this.BtnPesoMenos_Click);
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPeca.Location = new System.Drawing.Point(207, 366);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.lblPeca.Size = new System.Drawing.Size(108, 42);
            this.lblPeca.TabIndex = 12;
            this.lblPeca.Text = "PEÇA";
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "github.com/th-guasti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "v1.0 | 2025";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(1, 22);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(360, 22);
            this.txtTitulo.TabIndex = 15;
            this.txtTitulo.Text = "Simulador balança toledo (protocolo P06)";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simulador_balanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 531);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblEnvio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecepcaoDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeca);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPeca);
            this.Controls.Add(this.txtEnvioDados);
            this.Controls.Add(this.txtSimulacaoPeso);
            this.Controls.Add(this.lblSimulacao);
            this.Controls.Add(this.lblRecepcao);
            this.Name = "simulador_balanca";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pVisor.ResumeLayout(false);
            this.pVisor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecepcao;
        private System.Windows.Forms.Label lblSimulacao;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.TextBox txtRecepcaoDados;
        private System.Windows.Forms.TextBox txtSimulacaoPeso;
        private System.Windows.Forms.TextBox txtEnvioDados;
        private System.Windows.Forms.Button btnPeca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPesoMenos;
        private System.Windows.Forms.Label lblDinamico;
        private System.Windows.Forms.Button btnPesoMais;
        private System.Windows.Forms.Label lblPeca;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pVisor;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}

