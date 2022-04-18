namespace EF_GestArts
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPu = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(130, 265);
            this.grd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 82;
            this.grd.RowTemplate.Height = 33;
            this.grd.Size = new System.Drawing.Size(1110, 606);
            this.grd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libellé : ";
            // 
            // txtLib
            // 
            this.txtLib.Location = new System.Drawing.Point(312, 55);
            this.txtLib.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLib.Multiline = true;
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(525, 48);
            this.txtLib.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix : ";
            // 
            // txtPu
            // 
            this.txtPu.Location = new System.Drawing.Point(312, 139);
            this.txtPu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPu.Multiline = true;
            this.txtPu.Name = "txtPu";
            this.txtPu.Size = new System.Drawing.Size(525, 44);
            this.txtPu.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(971, 173);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(269, 63);
            this.btn.TabIndex = 3;
            this.btn.Text = "Ajouter";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1337, 1292);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtPu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPu;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ErrorProvider error;
    }
}

