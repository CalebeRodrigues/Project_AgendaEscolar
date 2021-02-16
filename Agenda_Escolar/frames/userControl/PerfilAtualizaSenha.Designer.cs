namespace Agenda_Escolar.frames.userControl
{
    partial class PerfilAtualizaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilAtualizaSenha));
            this.label3 = new System.Windows.Forms.Label();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.txtNova = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Alterar Senha";
            // 
            // txtAtual
            // 
            this.txtAtual.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtual.ForeColor = System.Drawing.Color.Silver;
            this.txtAtual.Location = new System.Drawing.Point(162, 93);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.Size = new System.Drawing.Size(358, 30);
            this.txtAtual.TabIndex = 42;
            this.txtAtual.Text = "Digite sua senha atual";
            this.txtAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAtual.Enter += new System.EventHandler(this.txtAtual_Enter);
            // 
            // txtNova
            // 
            this.txtNova.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNova.ForeColor = System.Drawing.Color.Silver;
            this.txtNova.Location = new System.Drawing.Point(162, 167);
            this.txtNova.Name = "txtNova";
            this.txtNova.Size = new System.Drawing.Size(358, 30);
            this.txtNova.TabIndex = 43;
            this.txtNova.Text = "Digite sua nova senha";
            this.txtNova.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNova.Enter += new System.EventHandler(this.txtNova_Enter);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(145, 227);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(155, 43);
            this.btnVer.TabIndex = 45;
            this.btnVer.Text = "Cancelar";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAlterarSenha.FlatAppearance.BorderSize = 0;
            this.btnAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenha.Location = new System.Drawing.Point(390, 227);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(155, 43);
            this.btnAlterarSenha.TabIndex = 45;
            this.btnAlterarSenha.Text = "Atualizar";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nova";
            // 
            // PerfilAtualizaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAtual);
            this.Controls.Add(this.txtNova);
            this.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "PerfilAtualizaSenha";
            this.Text = "PerfilAtualizaSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVer;
        public System.Windows.Forms.TextBox txtAtual;
        public System.Windows.Forms.TextBox txtNova;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}