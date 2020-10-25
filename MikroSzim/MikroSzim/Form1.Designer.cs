namespace MikroSzim
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
            this.label1 = new System.Windows.Forms.Label();
            this.finalyearbox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pathtb = new System.Windows.Forms.TextBox();
            this.Browsebt = new System.Windows.Forms.Button();
            this.Startbt = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.finalyearbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZÁRÓÉV";
            // 
            // finalyearbox
            // 
            this.finalyearbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finalyearbox.Location = new System.Drawing.Point(119, 11);
            this.finalyearbox.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.finalyearbox.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.finalyearbox.Name = "finalyearbox";
            this.finalyearbox.Size = new System.Drawing.Size(98, 30);
            this.finalyearbox.TabIndex = 1;
            this.finalyearbox.Value = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(274, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NÉPESSÉG FÁJL:";
            // 
            // pathtb
            // 
            this.pathtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathtb.Location = new System.Drawing.Point(474, 10);
            this.pathtb.Name = "pathtb";
            this.pathtb.Size = new System.Drawing.Size(371, 30);
            this.pathtb.TabIndex = 3;
            // 
            // Browsebt
            // 
            this.Browsebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Browsebt.Location = new System.Drawing.Point(901, 9);
            this.Browsebt.Name = "Browsebt";
            this.Browsebt.Size = new System.Drawing.Size(139, 45);
            this.Browsebt.TabIndex = 4;
            this.Browsebt.Text = "BROWSE";
            this.Browsebt.UseVisualStyleBackColor = true;
            this.Browsebt.Click += new System.EventHandler(this.Browsebt_Click);
            // 
            // Startbt
            // 
            this.Startbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Startbt.Location = new System.Drawing.Point(1088, 9);
            this.Startbt.Name = "Startbt";
            this.Startbt.Size = new System.Drawing.Size(139, 45);
            this.Startbt.TabIndex = 5;
            this.Startbt.Text = "START";
            this.Startbt.UseVisualStyleBackColor = true;
            this.Startbt.Click += new System.EventHandler(this.Startbt_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1214, 692);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 764);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Startbt);
            this.Controls.Add(this.Browsebt);
            this.Controls.Add(this.pathtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finalyearbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.finalyearbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown finalyearbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathtb;
        private System.Windows.Forms.Button Browsebt;
        private System.Windows.Forms.Button Startbt;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

