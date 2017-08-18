namespace KyabusuC
{
    partial class Update
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
            this.NCut = new System.Windows.Forms.Button();
            this.Cut = new System.Windows.Forms.Button();
            this.UpdateScreenDB = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.Uptake = new System.Windows.Forms.Button();
            this.SetUpdate = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateScreenDB)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(407, 288);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 40);
            this.Return.TabIndex = 0;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // NCut
            // 
            this.NCut.Location = new System.Drawing.Point(407, 22);
            this.NCut.Name = "NCut";
            this.NCut.Size = new System.Drawing.Size(75, 36);
            this.NCut.TabIndex = 2;
            this.NCut.Text = "編集不可";
            this.NCut.UseVisualStyleBackColor = true;
            this.NCut.Click += new System.EventHandler(this.NCut_Click);
            // 
            // Cut
            // 
            this.Cut.Location = new System.Drawing.Point(308, 22);
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(75, 36);
            this.Cut.TabIndex = 3;
            this.Cut.Text = "編集可";
            this.Cut.UseVisualStyleBackColor = true;
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // UpdateScreenDB
            // 
            this.UpdateScreenDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateScreenDB.Location = new System.Drawing.Point(16, 64);
            this.UpdateScreenDB.Name = "UpdateScreenDB";
            this.UpdateScreenDB.RowTemplate.Height = 21;
            this.UpdateScreenDB.Size = new System.Drawing.Size(466, 208);
            this.UpdateScreenDB.TabIndex = 4;
            this.UpdateScreenDB.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateScreenDB_CellValueChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(14, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(92, 33);
            this.Title.TabIndex = 5;
            this.Title.Text = "label1";
            // 
            // Uptake
            // 
            this.Uptake.Location = new System.Drawing.Point(16, 288);
            this.Uptake.Name = "Uptake";
            this.Uptake.Size = new System.Drawing.Size(88, 40);
            this.Uptake.TabIndex = 6;
            this.Uptake.Text = "取り込み";
            this.Uptake.UseVisualStyleBackColor = true;
            this.Uptake.Visible = false;
            this.Uptake.Click += new System.EventHandler(this.Uptake_Click);
            // 
            // SetUpdate
            // 
            this.SetUpdate.Location = new System.Drawing.Point(123, 288);
            this.SetUpdate.Name = "SetUpdate";
            this.SetUpdate.Size = new System.Drawing.Size(88, 40);
            this.SetUpdate.TabIndex = 7;
            this.SetUpdate.Text = "更新確定";
            this.SetUpdate.UseVisualStyleBackColor = true;
            this.SetUpdate.Click += new System.EventHandler(this.SetUpdate_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(231, 288);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 40);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "更新取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 349);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SetUpdate);
            this.Controls.Add(this.Uptake);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.UpdateScreenDB);
            this.Controls.Add(this.Cut);
            this.Controls.Add(this.NCut);
            this.Controls.Add(this.Return);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateScreenDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button NCut;
        private System.Windows.Forms.Button Cut;
        private System.Windows.Forms.DataGridView UpdateScreenDB;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Uptake;
        private System.Windows.Forms.Button SetUpdate;
        private System.Windows.Forms.Button Cancel;
    }
}