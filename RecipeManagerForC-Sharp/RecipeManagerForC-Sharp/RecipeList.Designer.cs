namespace RecipeManagerForC_Sharp
{
    partial class RecipeList
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.cmbRate = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.cmbIngre = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(9, 423);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBack.Size = new System.Drawing.Size(81, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Location = new System.Drawing.Point(267, 73);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.Size = new System.Drawing.Size(483, 380);
            this.dgvList.TabIndex = 7;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(149, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "レ　シ　ピ　一　覧";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFind.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFind.Location = new System.Drawing.Point(169, 271);
            this.btnFind.Margin = new System.Windows.Forms.Padding(0);
            this.btnFind.Name = "btnFind";
            this.btnFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnFind.Size = new System.Drawing.Size(85, 33);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "探す";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.cmbRate);
            this.GroupBox2.Controls.Add(this.cmbTime);
            this.GroupBox2.Controls.Add(this.cmbCateg);
            this.GroupBox2.Controls.Add(this.btnClear);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.cmbIngre);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.cmbStyle);
            this.GroupBox2.Controls.Add(this.label2);
            this.GroupBox2.Controls.Add(this.label3);
            this.GroupBox2.Location = new System.Drawing.Point(9, 73);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(252, 170);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label5.Location = new System.Drawing.Point(130, 62);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 20);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "カテゴリ";
            // 
            // cmbRate
            // 
            this.cmbRate.BackColor = System.Drawing.Color.Linen;
            this.cmbRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRate.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbRate.FormattingEnabled = true;
            this.cmbRate.Location = new System.Drawing.Point(6, 132);
            this.cmbRate.Name = "cmbRate";
            this.cmbRate.Size = new System.Drawing.Size(111, 21);
            this.cmbRate.TabIndex = 4;
            this.cmbRate.SelectionChangeCommitted += new System.EventHandler(this.cmbRate_SelectionChangeCommitted);
            // 
            // cmbTime
            // 
            this.cmbTime.BackColor = System.Drawing.Color.Linen;
            this.cmbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTime.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(6, 85);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(111, 21);
            this.cmbTime.TabIndex = 2;
            this.cmbTime.SelectionChangeCommitted += new System.EventHandler(this.cmbTime_SelectionChangeCommitted);
            // 
            // cmbCateg
            // 
            this.cmbCateg.BackColor = System.Drawing.Color.Linen;
            this.cmbCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCateg.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Location = new System.Drawing.Point(134, 85);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(111, 21);
            this.cmbCateg.TabIndex = 3;
            this.cmbCateg.SelectionChangeCommitted += new System.EventHandler(this.cmbCateg_SelectionChangeCommitted);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Location = new System.Drawing.Point(157, 122);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(88, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label7.Location = new System.Drawing.Point(6, 109);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(48, 20);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "レート";
            // 
            // cmbIngre
            // 
            this.cmbIngre.BackColor = System.Drawing.Color.Linen;
            this.cmbIngre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIngre.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbIngre.FormattingEnabled = true;
            this.cmbIngre.Location = new System.Drawing.Point(134, 36);
            this.cmbIngre.Name = "cmbIngre";
            this.cmbIngre.Size = new System.Drawing.Size(111, 21);
            this.cmbIngre.TabIndex = 1;
            this.cmbIngre.SelectionChangeCommitted += new System.EventHandler(this.cmbIngre_SelectionChangeCommitted);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label4.Location = new System.Drawing.Point(2, 62);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(61, 20);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "所要時間";
            // 
            // cmbStyle
            // 
            this.cmbStyle.BackColor = System.Drawing.Color.Linen;
            this.cmbStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStyle.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(6, 36);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(111, 21);
            this.cmbStyle.TabIndex = 0;
            this.cmbStyle.SelectionChangeCommitted += new System.EventHandler(this.cmbStyle_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "スタイル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(130, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "主材料";
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.SeaShell;
            this.txtPreview.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPreview.Location = new System.Drawing.Point(9, 346);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(241, 68);
            this.txtPreview.TabIndex = 4;
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.Color.SeaShell;
            this.txtKeyword.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKeyword.Location = new System.Drawing.Point(9, 279);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(154, 25);
            this.txtKeyword.TabIndex = 2;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label8.Location = new System.Drawing.Point(8, 255);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(87, 20);
            this.Label8.TabIndex = 6;
            this.Label8.Text = "レシピ内検索";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label6.Location = new System.Drawing.Point(8, 322);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(126, 20);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "レシピ　プレビュー";
            // 
            // RecipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(762, 465);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipeList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "レシピ一覧";
            this.Load += new System.EventHandler(this.RecipeList_Load);
            this.Shown += new System.EventHandler(this.RecipeList_Shown);
            this.Click += new System.EventHandler(this.RecipeList_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cmbRate;
        internal System.Windows.Forms.ComboBox cmbTime;
        internal System.Windows.Forms.ComboBox cmbCateg;
        private System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cmbIngre;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cmbStyle;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtPreview;
        internal System.Windows.Forms.TextBox txtKeyword;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;


    }
}

