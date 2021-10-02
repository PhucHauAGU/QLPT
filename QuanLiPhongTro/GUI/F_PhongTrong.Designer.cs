namespace GUI
{
    partial class F_PhongTrong
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
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhongTrong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongTrong
            // 
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTrong.Location = new System.Drawing.Point(8, 81);
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongTrong.Size = new System.Drawing.Size(565, 232);
            this.dgvPhongTrong.TabIndex = 0;
            this.dgvPhongTrong.Click += new System.EventHandler(this.dgvPhongTrong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phòng trống: ";
            // 
            // txtSoPhongTrong
            // 
            this.txtSoPhongTrong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhongTrong.Location = new System.Drawing.Point(204, 36);
            this.txtSoPhongTrong.Name = "txtSoPhongTrong";
            this.txtSoPhongTrong.Size = new System.Drawing.Size(173, 29);
            this.txtSoPhongTrong.TabIndex = 2;
            // 
            // F_PhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(585, 324);
            this.Controls.Add(this.txtSoPhongTrong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhongTrong);
            this.Name = "F_PhongTrong";
            this.Text = "F_PhongTrong";
            this.Load += new System.EventHandler(this.F_PhongTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongTrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhongTrong;
    }
}