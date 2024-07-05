namespace QuanLyCafe.VIEW.UC
{
    partial class listware
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox37);
            this.groupBox1.Controls.Add(this.txtfind);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng nhập kho";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(665, 294);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox37.Image = global::QuanLyCafe.Properties.Resources.z5257881339161_b564192411e529e97bbfa1325c65bb7c__1__preview_rev_1;
            this.pictureBox37.Location = new System.Drawing.Point(513, 324);
            this.pictureBox37.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(134, 44);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox37.TabIndex = 22;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.Click += new System.EventHandler(this.pictureBox37_Click);
            // 
            // txtfind
            // 
            this.txtfind.BackColor = System.Drawing.Color.SeaShell;
            this.txtfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfind.Location = new System.Drawing.Point(264, 336);
            this.txtfind.Margin = new System.Windows.Forms.Padding(2);
            this.txtfind.Multiline = true;
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(230, 21);
            this.txtfind.TabIndex = 21;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(189, 336);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(71, 15);
            this.label60.TabIndex = 20;
            this.label60.Text = "Tìm hàng:";
            // 
            // listware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.groupBox1);
            this.Name = "listware";
            this.Size = new System.Drawing.Size(839, 517);
            this.Load += new System.EventHandler(this.listware_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label label60;
    }
}
