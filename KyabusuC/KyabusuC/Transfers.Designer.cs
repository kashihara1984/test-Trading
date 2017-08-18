namespace KyabusuC
{
    partial class Transfers
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
            this.Return = new System.Windows.Forms.Button();
            this.Uptake = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TransferSet = new System.Windows.Forms.Button();
            this.TransferPlayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(193, 184);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(65, 27);
            this.Return.TabIndex = 0;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Uptake
            // 
            this.Uptake.Location = new System.Drawing.Point(16, 147);
            this.Uptake.Name = "Uptake";
            this.Uptake.Size = new System.Drawing.Size(75, 31);
            this.Uptake.TabIndex = 1;
            this.Uptake.Text = "取り込み";
            this.Uptake.UseVisualStyleBackColor = true;
            this.Uptake.Click += new System.EventHandler(this.Uptake_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(180, 147);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 31);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "移籍取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TransferSet
            // 
            this.TransferSet.Location = new System.Drawing.Point(99, 147);
            this.TransferSet.Name = "TransferSet";
            this.TransferSet.Size = new System.Drawing.Size(75, 31);
            this.TransferSet.TabIndex = 3;
            this.TransferSet.Text = "移籍確定";
            this.TransferSet.UseVisualStyleBackColor = true;
            this.TransferSet.Click += new System.EventHandler(this.TransferSet_Click);
            // 
            // TransferPlayer
            // 
            this.TransferPlayer.FormattingEnabled = true;
            this.TransferPlayer.Location = new System.Drawing.Point(16, 96);
            this.TransferPlayer.Name = "TransferPlayer";
            this.TransferPlayer.Size = new System.Drawing.Size(239, 20);
            this.TransferPlayer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "移籍選手";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(14, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(67, 24);
            this.Title.TabIndex = 7;
            this.Title.Text = "label2";
            // 
            // Transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 217);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransferPlayer);
            this.Controls.Add(this.TransferSet);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Uptake);
            this.Controls.Add(this.Return);
            this.Name = "Transfers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "移籍";
            this.Load += new System.EventHandler(this.Transfers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Uptake;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button TransferSet;
        private System.Windows.Forms.ComboBox TransferPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
    }
}