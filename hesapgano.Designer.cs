
namespace öğrenci_transkript
{
    partial class hesapgano
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
            this.listboxGano = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listboxGano
            // 
            this.listboxGano.FormattingEnabled = true;
            this.listboxGano.ItemHeight = 20;
            this.listboxGano.Location = new System.Drawing.Point(98, 52);
            this.listboxGano.Name = "listboxGano";
            this.listboxGano.Size = new System.Drawing.Size(499, 184);
            this.listboxGano.TabIndex = 0;
            // 
            // hesapgano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listboxGano);
            this.Name = "hesapgano";
            this.Text = "hesapgano";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listboxGano;
    }
}