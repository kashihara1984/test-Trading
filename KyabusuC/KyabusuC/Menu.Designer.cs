namespace KyabusuC
{
    partial class Menu
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
            this.CAVS = new System.Windows.Forms.Button();
            this.GSW = new System.Windows.Forms.Button();
            this.BOS = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CAVS
            // 
            this.CAVS.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CAVS.Location = new System.Drawing.Point(65, 69);
            this.CAVS.Name = "CAVS";
            this.CAVS.Size = new System.Drawing.Size(190, 44);
            this.CAVS.TabIndex = 1;
            this.CAVS.Text = "キャバリアーズ";
            this.CAVS.UseVisualStyleBackColor = true;
            this.CAVS.Click += new System.EventHandler(this.CAVS_Click);
            // 
            // GSW
            // 
            this.GSW.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GSW.Location = new System.Drawing.Point(65, 129);
            this.GSW.Name = "GSW";
            this.GSW.Size = new System.Drawing.Size(190, 44);
            this.GSW.TabIndex = 2;
            this.GSW.Text = "ウォリアーズ";
            this.GSW.UseVisualStyleBackColor = true;
            this.GSW.Click += new System.EventHandler(this.GSW_Click);
            // 
            // BOS
            // 
            this.BOS.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BOS.Location = new System.Drawing.Point(65, 194);
            this.BOS.Name = "BOS";
            this.BOS.Size = new System.Drawing.Size(190, 44);
            this.BOS.TabIndex = 3;
            this.BOS.Text = "セルティックス";
            this.BOS.UseVisualStyleBackColor = true;
            this.BOS.Click += new System.EventHandler(this.BOS_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(208, 254);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(86, 39);
            this.Close.TabIndex = 4;
            this.Close.Text = "閉じる";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "メニュー画面";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.BOS);
            this.Controls.Add(this.GSW);
            this.Controls.Add(this.CAVS);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メニュー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CAVS;
        private System.Windows.Forms.Button GSW;
        private System.Windows.Forms.Button BOS;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
    }
}