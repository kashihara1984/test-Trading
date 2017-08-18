namespace RecipeManagerForC_Sharp
{
    partial class MainMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnToMaster = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnToList = new System.Windows.Forms.Button();
            this.btnEatout = new System.Windows.Forms.Button();
            this.EatoutLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.Location = new System.Drawing.Point(9, 350);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(81, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnToMaster
            // 
            this.btnToMaster.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnToMaster.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnToMaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnToMaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnToMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToMaster.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnToMaster.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnToMaster.Location = new System.Drawing.Point(418, 350);
            this.btnToMaster.Margin = new System.Windows.Forms.Padding(0);
            this.btnToMaster.Name = "btnToMaster";
            this.btnToMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnToMaster.Size = new System.Drawing.Size(81, 33);
            this.btnToMaster.TabIndex = 3;
            this.btnToMaster.Text = "マスタ編集";
            this.btnToMaster.UseVisualStyleBackColor = false;
            this.btnToMaster.Click += new System.EventHandler(this.btnToMaster_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.Location = new System.Drawing.Point(9, 131);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 21;
            this.dgvMain.Size = new System.Drawing.Size(489, 204);
            this.dgvMain.TabIndex = 5;
            // 
            // btnToList
            // 
            this.btnToList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnToList.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnToList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToList.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnToList.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnToList.Location = new System.Drawing.Point(400, 85);
            this.btnToList.Margin = new System.Windows.Forms.Padding(0);
            this.btnToList.Name = "btnToList";
            this.btnToList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnToList.Size = new System.Drawing.Size(99, 33);
            this.btnToList.TabIndex = 0;
            this.btnToList.Text = "献立を選ぶ";
            this.btnToList.UseVisualStyleBackColor = false;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnEatout
            // 
            this.btnEatout.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEatout.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEatout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnEatout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnEatout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatout.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEatout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEatout.Location = new System.Drawing.Point(312, 350);
            this.btnEatout.Margin = new System.Windows.Forms.Padding(0);
            this.btnEatout.Name = "btnEatout";
            this.btnEatout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEatout.Size = new System.Drawing.Size(81, 33);
            this.btnEatout.TabIndex = 2;
            this.btnEatout.Text = "外食率";
            this.btnEatout.UseVisualStyleBackColor = false;
            this.btnEatout.Click += new System.EventHandler(this.btnEatout_Click);
            // 
            // EatoutLabel
            // 
            this.EatoutLabel.AutoSize = true;
            this.EatoutLabel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EatoutLabel.ForeColor = System.Drawing.Color.Brown;
            this.EatoutLabel.Location = new System.Drawing.Point(27, 91);
            this.EatoutLabel.Name = "EatoutLabel";
            this.EatoutLabel.Size = new System.Drawing.Size(85, 20);
            this.EatoutLabel.TabIndex = 6;
            this.EatoutLabel.Text = "EatoutLabel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "メインメニュー";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(508, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EatoutLabel);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.btnEatout);
            this.Controls.Add(this.btnToMaster);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メインメニュー";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.Click += new System.EventHandler(this.MainMenu_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.Button btnEatout;
        private System.Windows.Forms.Label EatoutLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnToMaster;


    }
}

