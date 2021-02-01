namespace Agenda_Escolar.frames.UserControlProvas
{
    partial class ProvasDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvasDialog));
            this.txtNomeJanela = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtNomeJanela
            // 
            this.txtNomeJanela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeJanela.AutoSize = true;
            this.txtNomeJanela.Location = new System.Drawing.Point(252, 9);
            this.txtNomeJanela.Name = "txtNomeJanela";
            this.txtNomeJanela.Size = new System.Drawing.Size(70, 23);
            this.txtNomeJanela.TabIndex = 0;
            this.txtNomeJanela.Text = "label1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(199, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(329, 32);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data:";
            // 
            // btnFunction
            // 
            this.btnFunction.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFunction.FlatAppearance.BorderSize = 0;
            this.btnFunction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunction.Location = new System.Drawing.Point(208, 261);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(181, 43);
            this.btnFunction.TabIndex = 28;
            this.btnFunction.Text = "Function";
            this.btnFunction.UseVisualStyleBackColor = false;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(543, 290);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(53, 46);
            this.btnSair.TabIndex = 29;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(199, 174);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(329, 32);
            this.txtData.TabIndex = 30;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // ProvasDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 348);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNomeJanela);
            this.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "ProvasDialog";
            this.Text = "ProvasDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNomeJanela;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFunction;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}