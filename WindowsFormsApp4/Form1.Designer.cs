namespace WindowsFormsApp4
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tbxSHL = new System.Windows.Forms.TextBox();
            this.tbxHA = new System.Windows.Forms.TextBox();
            this.btnSHL = new System.Windows.Forms.Button();
            this.btnHA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSchema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLiga3 = new System.Windows.Forms.Button();
            this.tbxLiga3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLiga4 = new System.Windows.Forms.Button();
            this.tbxLiga4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generera schemafil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // tbxSHL
            // 
            this.tbxSHL.Location = new System.Drawing.Point(50, 15);
            this.tbxSHL.Name = "tbxSHL";
            this.tbxSHL.Size = new System.Drawing.Size(100, 20);
            this.tbxSHL.TabIndex = 1;
            // 
            // tbxHA
            // 
            this.tbxHA.Location = new System.Drawing.Point(50, 41);
            this.tbxHA.Name = "tbxHA";
            this.tbxHA.Size = new System.Drawing.Size(100, 20);
            this.tbxHA.TabIndex = 1;
            // 
            // btnSHL
            // 
            this.btnSHL.Location = new System.Drawing.Point(157, 13);
            this.btnSHL.Name = "btnSHL";
            this.btnSHL.Size = new System.Drawing.Size(86, 23);
            this.btnSHL.TabIndex = 2;
            this.btnSHL.Text = "Öppna JSON";
            this.btnSHL.UseVisualStyleBackColor = true;
            this.btnSHL.Click += new System.EventHandler(this.BtnSHL_Click);
            // 
            // btnHA
            // 
            this.btnHA.Location = new System.Drawing.Point(157, 39);
            this.btnHA.Name = "btnHA";
            this.btnHA.Size = new System.Drawing.Size(86, 23);
            this.btnHA.TabIndex = 2;
            this.btnHA.Text = "Öppna JSON";
            this.btnHA.UseVisualStyleBackColor = true;
            this.btnHA.Click += new System.EventHandler(this.BtnHA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SHL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HA:";
            // 
            // tbxSchema
            // 
            this.tbxSchema.Location = new System.Drawing.Point(50, 81);
            this.tbxSchema.Multiline = true;
            this.tbxSchema.Name = "tbxSchema";
            this.tbxSchema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSchema.Size = new System.Drawing.Size(639, 209);
            this.tbxSchema.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SDHL:";
            // 
            // btnLiga3
            // 
            this.btnLiga3.Location = new System.Drawing.Point(405, 13);
            this.btnLiga3.Name = "btnLiga3";
            this.btnLiga3.Size = new System.Drawing.Size(86, 23);
            this.btnLiga3.TabIndex = 6;
            this.btnLiga3.Text = "Öppna JSON";
            this.btnLiga3.UseVisualStyleBackColor = true;
            this.btnLiga3.Click += new System.EventHandler(this.BtnLiga3_Click);
            // 
            // tbxLiga3
            // 
            this.tbxLiga3.Location = new System.Drawing.Point(298, 15);
            this.tbxLiga3.Name = "tbxLiga3";
            this.tbxLiga3.Size = new System.Drawing.Size(100, 20);
            this.tbxLiga3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liga 4:";
            // 
            // btnLiga4
            // 
            this.btnLiga4.Location = new System.Drawing.Point(405, 39);
            this.btnLiga4.Name = "btnLiga4";
            this.btnLiga4.Size = new System.Drawing.Size(86, 23);
            this.btnLiga4.TabIndex = 9;
            this.btnLiga4.Text = "Öppna JSON";
            this.btnLiga4.UseVisualStyleBackColor = true;
            this.btnLiga4.Click += new System.EventHandler(this.BtnLiga4_Click);
            // 
            // tbxLiga4
            // 
            this.tbxLiga4.Location = new System.Drawing.Point(298, 41);
            this.tbxLiga4.Name = "tbxLiga4";
            this.tbxLiga4.Size = new System.Drawing.Size(100, 20);
            this.tbxLiga4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 302);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLiga4);
            this.Controls.Add(this.tbxLiga4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLiga3);
            this.Controls.Add(this.tbxLiga3);
            this.Controls.Add(this.tbxSchema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHA);
            this.Controls.Add(this.btnSHL);
            this.Controls.Add(this.tbxHA);
            this.Controls.Add(this.tbxSHL);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox tbxSHL;
        private System.Windows.Forms.TextBox tbxHA;
        private System.Windows.Forms.Button btnSHL;
        private System.Windows.Forms.Button btnHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxSchema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLiga3;
        private System.Windows.Forms.TextBox tbxLiga3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLiga4;
        private System.Windows.Forms.TextBox tbxLiga4;
    }
}

