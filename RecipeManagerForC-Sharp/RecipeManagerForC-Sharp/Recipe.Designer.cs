namespace RecipeManagerForC_Sharp
{
    partial class Recipe
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblForStyle = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRate = new System.Windows.Forms.ComboBox();
            this.lblForRate = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.lblForCateg = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblForTime = new System.Windows.Forms.Label();
            this.lblIngre = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblForIngr = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnBack.Location = new System.Drawing.Point(9, 471);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBack.Size = new System.Drawing.Size(81, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblForStyle
            // 
            this.lblForStyle.AutoSize = true;
            this.lblForStyle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForStyle.Location = new System.Drawing.Point(19, 20);
            this.lblForStyle.Name = "lblForStyle";
            this.lblForStyle.Size = new System.Drawing.Size(71, 20);
            this.lblForStyle.TabIndex = 2;
            this.lblForStyle.Text = "スタイル :";
            // 
            // txtRecipe
            // 
            this.txtRecipe.BackColor = System.Drawing.Color.FloralWhite;
            this.txtRecipe.Location = new System.Drawing.Point(9, 177);
            this.txtRecipe.Multiline = true;
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(559, 274);
            this.txtRecipe.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRate);
            this.groupBox1.Controls.Add(this.lblForRate);
            this.groupBox1.Controls.Add(this.lblCateg);
            this.groupBox1.Controls.Add(this.lblForCateg);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblForTime);
            this.groupBox1.Controls.Add(this.lblIngre);
            this.groupBox1.Controls.Add(this.lblStyle);
            this.groupBox1.Controls.Add(this.lblForIngr);
            this.groupBox1.Controls.Add(this.lblForStyle);
            this.groupBox1.Location = new System.Drawing.Point(9, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbRate
            // 
            this.cmbRate.BackColor = System.Drawing.Color.FloralWhite;
            this.cmbRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRate.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbRate.FormattingEnabled = true;
            this.cmbRate.Location = new System.Drawing.Point(431, 18);
            this.cmbRate.Name = "cmbRate";
            this.cmbRate.Size = new System.Drawing.Size(119, 26);
            this.cmbRate.TabIndex = 0;
            // 
            // lblForRate
            // 
            this.lblForRate.AutoSize = true;
            this.lblForRate.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForRate.Location = new System.Drawing.Point(354, 20);
            this.lblForRate.Name = "lblForRate";
            this.lblForRate.Size = new System.Drawing.Size(71, 20);
            this.lblForRate.TabIndex = 6;
            this.lblForRate.Text = "レート　 :";
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCateg.Location = new System.Drawing.Point(266, 56);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(67, 20);
            this.lblCateg.TabIndex = 10;
            this.lblCateg.Text = "Category";
            // 
            // lblForCateg
            // 
            this.lblForCateg.AutoSize = true;
            this.lblForCateg.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForCateg.Location = new System.Drawing.Point(189, 56);
            this.lblForCateg.Name = "lblForCateg";
            this.lblForCateg.Size = new System.Drawing.Size(71, 20);
            this.lblForCateg.TabIndex = 9;
            this.lblForCateg.Text = "カテゴリ :";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCommit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCommit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCommit.Location = new System.Drawing.Point(469, 56);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(0);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCommit.Size = new System.Drawing.Size(81, 27);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "献立にする";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTime.Location = new System.Drawing.Point(266, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblForTime
            // 
            this.lblForTime.AutoSize = true;
            this.lblForTime.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForTime.Location = new System.Drawing.Point(189, 20);
            this.lblForTime.Name = "lblForTime";
            this.lblForTime.Size = new System.Drawing.Size(71, 20);
            this.lblForTime.TabIndex = 4;
            this.lblForTime.Text = "所要時間 :";
            // 
            // lblIngre
            // 
            this.lblIngre.AutoSize = true;
            this.lblIngre.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIngre.Location = new System.Drawing.Point(96, 56);
            this.lblIngre.Name = "lblIngre";
            this.lblIngre.Size = new System.Drawing.Size(75, 20);
            this.lblIngre.TabIndex = 8;
            this.lblIngre.Text = "Ingredient";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStyle.Location = new System.Drawing.Point(96, 20);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 20);
            this.lblStyle.TabIndex = 3;
            this.lblStyle.Text = "Style";
            // 
            // lblForIngr
            // 
            this.lblForIngr.AutoSize = true;
            this.lblForIngr.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForIngr.Location = new System.Drawing.Point(19, 56);
            this.lblForIngr.Name = "lblForIngr";
            this.lblForIngr.Size = new System.Drawing.Size(71, 20);
            this.lblForIngr.TabIndex = 7;
            this.lblForIngr.Text = "主材料 　:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(9, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FloralWhite;
            this.lblName.Font = new System.Drawing.Font("HGS行書体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblName.Location = new System.Drawing.Point(6, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(544, 48);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Recipe Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.Location = new System.Drawing.Point(486, 471);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(81, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "編集を保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(576, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Recipe";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "レシピ";
            this.Load += new System.EventHandler(this.Recipe_Load);
            this.Shown += new System.EventHandler(this.Recipe_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblForStyle;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblForRate;
        private System.Windows.Forms.Label lblForCateg;
        private System.Windows.Forms.Label lblForTime;
        private System.Windows.Forms.Label lblForIngr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblIngre;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCommit;


    }
}

