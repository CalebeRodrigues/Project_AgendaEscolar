namespace Agenda_Escolar.frames.userControl
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.btnAtualizaPerfil = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meu Perfil";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(41, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 378);
            this.panel1.TabIndex = 24;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAlterarSenha.FlatAppearance.BorderSize = 0;
            this.btnAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenha.Location = new System.Drawing.Point(562, 445);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(181, 43);
            this.btnAlterarSenha.TabIndex = 25;
            this.btnAlterarSenha.Text = "Atualizar senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // btnAtualizaPerfil
            // 
            this.btnAtualizaPerfil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAtualizaPerfil.FlatAppearance.BorderSize = 0;
            this.btnAtualizaPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAtualizaPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizaPerfil.Location = new System.Drawing.Point(32, 445);
            this.btnAtualizaPerfil.Name = "btnAtualizaPerfil";
            this.btnAtualizaPerfil.Size = new System.Drawing.Size(181, 43);
            this.btnAtualizaPerfil.TabIndex = 26;
            this.btnAtualizaPerfil.Text = "Atualizar Perfil";
            this.btnAtualizaPerfil.UseVisualStyleBackColor = false;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(297, 445);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(181, 43);
            this.btnVer.TabIndex = 27;
            this.btnVer.Text = "Ver dados";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 510);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnAtualizaPerfil);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Button btnAtualizaPerfil;
        private System.Windows.Forms.Button btnVer;
        public System.Windows.Forms.Panel panel1;
    }
}