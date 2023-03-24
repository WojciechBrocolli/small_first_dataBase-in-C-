namespace WindowsFormsApp1
{
    partial class Dodawacz
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
            this.date_ur = new System.Windows.Forms.DateTimePicker();
            this.howTall = new System.Windows.Forms.NumericUpDown();
            this.Name_Sname = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.howTall)).BeginInit();
            this.SuspendLayout();
            // 
            // date_ur
            // 
            this.date_ur.Location = new System.Drawing.Point(403, 95);
            this.date_ur.Name = "date_ur";
            this.date_ur.Size = new System.Drawing.Size(200, 20);
            this.date_ur.TabIndex = 0;
            this.date_ur.ValueChanged += new System.EventHandler(this.date_ur_ValueChanged);
            // 
            // howTall
            // 
            this.howTall.Location = new System.Drawing.Point(235, 94);
            this.howTall.Name = "howTall";
            this.howTall.Size = new System.Drawing.Size(120, 20);
            this.howTall.TabIndex = 1;
            this.howTall.ValueChanged += new System.EventHandler(this.howTall_ValueChanged);
            // 
            // Name_Sname
            // 
            this.Name_Sname.Location = new System.Drawing.Point(626, 95);
            this.Name_Sname.Name = "Name_Sname";
            this.Name_Sname.Size = new System.Drawing.Size(100, 20);
            this.Name_Sname.TabIndex = 2;
            this.Name_Sname.TextChanged += new System.EventHandler(this.Name_Sname_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(235, 154);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "Dodaj";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Dodawacz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.Name_Sname);
            this.Controls.Add(this.howTall);
            this.Controls.Add(this.date_ur);
            this.Name = "Dodawacz";
            this.Text = "Dodawacz";
            ((System.ComponentModel.ISupportInitialize)(this.howTall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_ur;
        private System.Windows.Forms.NumericUpDown howTall;
        private System.Windows.Forms.TextBox Name_Sname;
        private System.Windows.Forms.Button buttonOK;
    }
}