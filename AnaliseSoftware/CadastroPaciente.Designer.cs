namespace AnaliseSoftware
{
    partial class CadastroPaciente
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sMasc = new System.Windows.Forms.RadioButton();
            this.sFem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmar.Location = new System.Drawing.Point(350, 134);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 33);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(3, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe os dados Paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(377, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(57, 77);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(377, 20);
            this.txtCpf.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sexo:";
            // 
            // sMasc
            // 
            this.sMasc.AutoSize = true;
            this.sMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.sMasc.ForeColor = System.Drawing.Color.White;
            this.sMasc.Location = new System.Drawing.Point(57, 111);
            this.sMasc.Name = "sMasc";
            this.sMasc.Size = new System.Drawing.Size(96, 20);
            this.sMasc.TabIndex = 8;
            this.sMasc.TabStop = true;
            this.sMasc.Text = "Masculino";
            this.sMasc.UseVisualStyleBackColor = true;
            // 
            // sFem
            // 
            this.sFem.AutoSize = true;
            this.sFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.sFem.ForeColor = System.Drawing.Color.White;
            this.sFem.Location = new System.Drawing.Point(57, 134);
            this.sFem.Name = "sFem";
            this.sFem.Size = new System.Drawing.Size(89, 20);
            this.sFem.TabIndex = 9;
            this.sFem.TabStop = true;
            this.sFem.Text = "Feminino";
            this.sFem.UseVisualStyleBackColor = true;
            // 
            // CadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(467, 179);
            this.Controls.Add(this.sFem);
            this.Controls.Add(this.sMasc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "CadastroPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroPaciente";
            this.Load += new System.EventHandler(this.CadastroPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sMasc;
        private System.Windows.Forms.RadioButton sFem;
    }
}