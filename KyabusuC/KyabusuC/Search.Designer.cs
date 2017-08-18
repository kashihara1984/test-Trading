namespace KyabusuC
{
    partial class Search
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
            this.Player = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.Transfer = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Entrybtn = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.Button();
            this.Height = new System.Windows.Forms.Button();
            this.Starting = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Center = new System.Windows.Forms.RadioButton();
            this.Foward = new System.Windows.Forms.RadioButton();
            this.Guard = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Player.Location = new System.Drawing.Point(12, 72);
            this.Player.Name = "Player";
            this.Player.RowTemplate.Height = 21;
            this.Player.Size = new System.Drawing.Size(524, 245);
            this.Player.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(12, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(107, 37);
            this.Title.TabIndex = 1;
            this.Title.Text = "label1";
            // 
            // Transfer
            // 
            this.Transfer.Location = new System.Drawing.Point(289, 458);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(116, 40);
            this.Transfer.TabIndex = 2;
            this.Transfer.Text = "移籍画面";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(154, 458);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(116, 40);
            this.Update.TabIndex = 3;
            this.Update.Text = "更新画面";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Entrybtn
            // 
            this.Entrybtn.Location = new System.Drawing.Point(18, 458);
            this.Entrybtn.Name = "Entrybtn";
            this.Entrybtn.Size = new System.Drawing.Size(116, 40);
            this.Entrybtn.TabIndex = 4;
            this.Entrybtn.Text = "登録画面";
            this.Entrybtn.UseVisualStyleBackColor = true;
            this.Entrybtn.Click += new System.EventHandler(this.Entrybtn_Click);
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(397, 44);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(127, 46);
            this.Position.TabIndex = 5;
            this.Position.Text = "ポジション別";
            this.Position.UseVisualStyleBackColor = true;
            this.Position.Click += new System.EventHandler(this.Position_Click);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(128, 44);
            this.Height.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(130, 46);
            this.Height.TabIndex = 7;
            this.Height.Text = "身長(2m以上)";
            this.Height.UseVisualStyleBackColor = true;
            this.Height.Click += new System.EventHandler(this.Height_Click);
            // 
            // Starting
            // 
            this.Starting.Location = new System.Drawing.Point(6, 44);
            this.Starting.Name = "Starting";
            this.Starting.Size = new System.Drawing.Size(116, 46);
            this.Starting.TabIndex = 8;
            this.Starting.Text = "先発選手";
            this.Starting.UseVisualStyleBackColor = true;
            this.Starting.Click += new System.EventHandler(this.Starting_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(441, 458);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(95, 40);
            this.Return.TabIndex = 11;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Center);
            this.groupBox1.Controls.Add(this.Foward);
            this.groupBox1.Controls.Add(this.Guard);
            this.groupBox1.Controls.Add(this.Starting);
            this.groupBox1.Controls.Add(this.Height);
            this.groupBox1.Controls.Add(this.Position);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索一覧";
            // 
            // Center
            // 
            this.Center.AutoSize = true;
            this.Center.Location = new System.Drawing.Point(277, 85);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(86, 23);
            this.Center.TabIndex = 12;
            this.Center.TabStop = true;
            this.Center.Text = "センター";
            this.Center.UseVisualStyleBackColor = true;
            // 
            // Foward
            // 
            this.Foward.AutoSize = true;
            this.Foward.Location = new System.Drawing.Point(277, 56);
            this.Foward.Name = "Foward";
            this.Foward.Size = new System.Drawing.Size(97, 23);
            this.Foward.TabIndex = 11;
            this.Foward.TabStop = true;
            this.Foward.Text = "フォワード";
            this.Foward.UseVisualStyleBackColor = true;
            // 
            // Guard
            // 
            this.Guard.AutoSize = true;
            this.Guard.Location = new System.Drawing.Point(277, 27);
            this.Guard.Name = "Guard";
            this.Guard.Size = new System.Drawing.Size(72, 23);
            this.Guard.TabIndex = 10;
            this.Guard.TabStop = true;
            this.Guard.Text = "ガード";
            this.Guard.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Entrybtn);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Player);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "検索";
            this.Load += new System.EventHandler(this.Search_Load);
            this.Shown += new System.EventHandler(this.Search_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Player;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Entrybtn;
        private System.Windows.Forms.Button Position;
        private System.Windows.Forms.Button Height;
        private System.Windows.Forms.Button Starting;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Center;
        private System.Windows.Forms.RadioButton Foward;
        private System.Windows.Forms.RadioButton Guard;
    }
}