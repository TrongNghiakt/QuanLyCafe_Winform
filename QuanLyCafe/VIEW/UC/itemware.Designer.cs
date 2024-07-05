namespace QuanLyCafe.VIEW.UC
{
    partial class itemware
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
            this.lbid = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbsl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picware = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picware)).BeginInit();
            this.SuspendLayout();
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(69, 60);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(41, 13);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "label1";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(69, 16);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(41, 13);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "label2";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.Location = new System.Drawing.Point(69, 38);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(41, 13);
            this.lbprice.TabIndex = 3;
            this.lbprice.Text = "label3";
            this.lbprice.Click += new System.EventHandler(this.lbprice_Click);
            // 
            // lbsl
            // 
            this.lbsl.AutoSize = true;
            this.lbsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsl.Location = new System.Drawing.Point(69, 82);
            this.lbsl.Name = "lbsl";
            this.lbsl.Size = new System.Drawing.Size(41, 13);
            this.lbsl.TabIndex = 4;
            this.lbsl.Text = "label4";
            this.lbsl.Click += new System.EventHandler(this.lbsl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.lbsl);
            this.groupBox1.Controls.Add(this.picware);
            this.groupBox1.Controls.Add(this.lbprice);
            this.groupBox1.Controls.Add(this.lbid);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Location = new System.Drawing.Point(0, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // picware
            // 
            this.picware.Location = new System.Drawing.Point(6, 16);
            this.picware.Name = "picware";
            this.picware.Size = new System.Drawing.Size(57, 79);
            this.picware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picware.TabIndex = 0;
            this.picware.TabStop = false;
            this.picware.Click += new System.EventHandler(this.picware_Click);
            // 
            // itemware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "itemware";
            this.Size = new System.Drawing.Size(185, 110);
            this.Load += new System.EventHandler(this.itemware_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picware)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picware;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbsl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
