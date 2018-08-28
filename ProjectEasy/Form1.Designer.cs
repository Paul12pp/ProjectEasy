namespace ProjectEasy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnopen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btntxt = new System.Windows.Forms.Button();
            this.btnimg = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtfilas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfilas = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnfully = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(18, 60);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "Open csv";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btntxt
            // 
            this.btntxt.Location = new System.Drawing.Point(81, 205);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(75, 23);
            this.btntxt.TabIndex = 2;
            this.btntxt.Text = "Open text";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // btnimg
            // 
            this.btnimg.Location = new System.Drawing.Point(244, 205);
            this.btnimg.Name = "btnimg";
            this.btnimg.Size = new System.Drawing.Size(75, 23);
            this.btnimg.TabIndex = 3;
            this.btnimg.Text = "Open img";
            this.btnimg.UseVisualStyleBackColor = true;
            this.btnimg.Click += new System.EventHandler(this.btnimg_Click);
            // 
            // txtfilas
            // 
            this.txtfilas.Location = new System.Drawing.Point(168, 63);
            this.txtfilas.Name = "txtfilas";
            this.txtfilas.Size = new System.Drawing.Size(100, 20);
            this.txtfilas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero de filas";
            // 
            // btnfilas
            // 
            this.btnfilas.Location = new System.Drawing.Point(172, 103);
            this.btnfilas.Name = "btnfilas";
            this.btnfilas.Size = new System.Drawing.Size(75, 23);
            this.btnfilas.TabIndex = 6;
            this.btnfilas.Text = "OK";
            this.btnfilas.UseVisualStyleBackColor = true;
            this.btnfilas.Click += new System.EventHandler(this.btnfilas_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(40, 143);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 7;
            this.btnselect.Text = "Open img";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Visible = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1er paso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "2do paso";
            // 
            // btnfully
            // 
            this.btnfully.Location = new System.Drawing.Point(340, 124);
            this.btnfully.Name = "btnfully";
            this.btnfully.Size = new System.Drawing.Size(75, 23);
            this.btnfully.TabIndex = 10;
            this.btnfully.Text = "Fully";
            this.btnfully.UseVisualStyleBackColor = true;
            this.btnfully.Click += new System.EventHandler(this.btnfully_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Con img charged";
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(340, 63);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(75, 23);
            this.btnfolder.TabIndex = 12;
            this.btnfolder.Text = "Open folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 240);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnfully);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnfilas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilas);
            this.Controls.Add(this.btnimg);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.btnopen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.Button btnimg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtfilas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnfilas;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnfully;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfolder;
    }
}

