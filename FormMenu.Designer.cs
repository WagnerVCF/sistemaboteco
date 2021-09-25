
namespace Boteco
{
    partial class FormMenu
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
            this.lblFuncionário = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalFunc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFuncionário
            // 
            this.lblFuncionário.AutoSize = true;
            this.lblFuncionário.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionário.Location = new System.Drawing.Point(52, 187);
            this.lblFuncionário.Name = "lblFuncionário";
            this.lblFuncionário.Size = new System.Drawing.Size(122, 18);
            this.lblFuncionário.TabIndex = 1;
            this.lblFuncionário.Text = "FUNCIONÁRIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLIENTE";
            // 
            // pbCliente
            // 
            this.pbCliente.Image = global::Boteco.Properties.Resources.cliente;
            this.pbCliente.Location = new System.Drawing.Point(185, 61);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(136, 123);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 2;
            this.pbCliente.TabStop = false;
            this.pbCliente.Click += new System.EventHandler(this.pbCliente_Click);
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Boteco.Properties.Resources.funcionario;
            this.pbFuncionario.Location = new System.Drawing.Point(32, 61);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(126, 123);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 0;
            this.pbFuncionario.TabStop = false;
            this.pbFuncionario.Click += new System.EventHandler(this.pbFuncionario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalFunc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerenciais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "N°Total de funcionarios:";
            // 
            // lblTotalFunc
            // 
            this.lblTotalFunc.AutoSize = true;
            this.lblTotalFunc.Location = new System.Drawing.Point(192, 35);
            this.lblTotalFunc.Name = "lblTotalFunc";
            this.lblTotalFunc.Size = new System.Drawing.Size(0, 18);
            this.lblTotalFunc.TabIndex = 1;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCliente);
            this.Controls.Add(this.lblFuncionário);
            this.Controls.Add(this.pbFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Label lblFuncionário;
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalFunc;
        private System.Windows.Forms.Label label2;
    }
}