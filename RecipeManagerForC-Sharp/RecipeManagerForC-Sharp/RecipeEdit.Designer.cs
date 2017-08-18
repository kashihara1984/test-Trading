namespace RecipeManagerForC_Sharp
{
    partial class RecipeEdit
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
            this.btnRecipeBack = new System.Windows.Forms.Button();
            this.lblForStyle = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCateg = new System.Windows.Forms.TextBox();
            this.txtIngre = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.cmbRate = new System.Windows.Forms.ComboBox();
            this.lblForRate = new System.Windows.Forms.Label();
            this.lblForCateg = new System.Windows.Forms.Label();
            this.lblForTime = new System.Windows.Forms.Label();
            this.lblForIngr = new System.Windows.Forms.Label();
            this.btnSetRecipe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.txtRname = new System.Windows.Forms.TextBox();
            this.lblRnumber = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvEdit = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecipeBack
            // 
            this.btnRecipeBack.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRecipeBack.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnRecipeBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnRecipeBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnRecipeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipeBack.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRecipeBack.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRecipeBack.Location = new System.Drawing.Point(292, 471);
            this.btnRecipeBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecipeBack.Name = "btnRecipeBack";
            this.btnRecipeBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRecipeBack.Size = new System.Drawing.Size(81, 33);
            this.btnRecipeBack.TabIndex = 0;
            this.btnRecipeBack.Text = "戻る";
            this.btnRecipeBack.UseVisualStyleBackColor = false;
            this.btnRecipeBack.Click += new System.EventHandler(this.btnRecipeBack_Click);
            // 
            // lblForStyle
            // 
            this.lblForStyle.AutoSize = true;
            this.lblForStyle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForStyle.Location = new System.Drawing.Point(19, 20);
            this.lblForStyle.Name = "lblForStyle";
            this.lblForStyle.Size = new System.Drawing.Size(71, 20);
            this.lblForStyle.TabIndex = 6;
            this.lblForStyle.Text = "スタイル :";
            // 
            // txtRecipe
            // 
            this.txtRecipe.BackColor = System.Drawing.Color.FloralWhite;
            this.txtRecipe.Location = new System.Drawing.Point(292, 177);
            this.txtRecipe.Multiline = true;
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(559, 274);
            this.txtRecipe.TabIndex = 6;
            this.txtRecipe.TextChanged += new System.EventHandler(this.txtRecipe_TextChanged);
            this.txtRecipe.Enter += new System.EventHandler(this.txtRecipe_Enter);
            this.txtRecipe.Leave += new System.EventHandler(this.txtRecipe_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRegister.ForeColor = System.Drawing.Color.Green;
            this.btnRegister.Location = new System.Drawing.Point(758, 471);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRegister.Size = new System.Drawing.Size(81, 33);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "新規登録";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCateg);
            this.groupBox1.Controls.Add(this.txtIngre);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtStyle);
            this.groupBox1.Controls.Add(this.cmbRate);
            this.groupBox1.Controls.Add(this.lblForRate);
            this.groupBox1.Controls.Add(this.lblForCateg);
            this.groupBox1.Controls.Add(this.lblForTime);
            this.groupBox1.Controls.Add(this.lblForIngr);
            this.groupBox1.Controls.Add(this.lblForStyle);
            this.groupBox1.Controls.Add(this.btnSetRecipe);
            this.groupBox1.Location = new System.Drawing.Point(292, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtCateg
            // 
            this.txtCateg.BackColor = System.Drawing.Color.FloralWhite;
            this.txtCateg.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCateg.Location = new System.Drawing.Point(259, 53);
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.Size = new System.Drawing.Size(97, 27);
            this.txtCateg.TabIndex = 3;
            this.txtCateg.TextChanged += new System.EventHandler(this.txtCateg_TextChanged);
            this.txtCateg.Enter += new System.EventHandler(this.txtCateg_Enter);
            this.txtCateg.Leave += new System.EventHandler(this.txtCateg_Leave);
            // 
            // txtIngre
            // 
            this.txtIngre.BackColor = System.Drawing.Color.FloralWhite;
            this.txtIngre.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtIngre.Location = new System.Drawing.Point(94, 53);
            this.txtIngre.Name = "txtIngre";
            this.txtIngre.Size = new System.Drawing.Size(81, 27);
            this.txtIngre.TabIndex = 2;
            this.txtIngre.TextChanged += new System.EventHandler(this.txtIngre_TextChanged);
            this.txtIngre.Enter += new System.EventHandler(this.txtIngre_Enter);
            this.txtIngre.Leave += new System.EventHandler(this.txtIngre_Leave);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FloralWhite;
            this.txtTime.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTime.Location = new System.Drawing.Point(259, 17);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(97, 27);
            this.txtTime.TabIndex = 1;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            this.txtTime.Leave += new System.EventHandler(this.txtTime_Leave);
            // 
            // txtStyle
            // 
            this.txtStyle.BackColor = System.Drawing.Color.FloralWhite;
            this.txtStyle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtStyle.Location = new System.Drawing.Point(94, 17);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(81, 27);
            this.txtStyle.TabIndex = 0;
            this.txtStyle.TextChanged += new System.EventHandler(this.txtStyle_TextChanged);
            this.txtStyle.Enter += new System.EventHandler(this.txtStyle_Enter);
            this.txtStyle.Leave += new System.EventHandler(this.txtStyle_Leave);
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
            this.cmbRate.TabIndex = 4;
            // 
            // lblForRate
            // 
            this.lblForRate.AutoSize = true;
            this.lblForRate.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForRate.Location = new System.Drawing.Point(364, 20);
            this.lblForRate.Name = "lblForRate";
            this.lblForRate.Size = new System.Drawing.Size(62, 20);
            this.lblForRate.TabIndex = 10;
            this.lblForRate.Text = "レート  :";
            // 
            // lblForCateg
            // 
            this.lblForCateg.AutoSize = true;
            this.lblForCateg.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForCateg.Location = new System.Drawing.Point(183, 56);
            this.lblForCateg.Name = "lblForCateg";
            this.lblForCateg.Size = new System.Drawing.Size(71, 20);
            this.lblForCateg.TabIndex = 9;
            this.lblForCateg.Text = "カテゴリ :";
            // 
            // lblForTime
            // 
            this.lblForTime.AutoSize = true;
            this.lblForTime.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForTime.Location = new System.Drawing.Point(183, 20);
            this.lblForTime.Name = "lblForTime";
            this.lblForTime.Size = new System.Drawing.Size(71, 20);
            this.lblForTime.TabIndex = 7;
            this.lblForTime.Text = "所要時間 :";
            // 
            // lblForIngr
            // 
            this.lblForIngr.AutoSize = true;
            this.lblForIngr.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblForIngr.Location = new System.Drawing.Point(19, 56);
            this.lblForIngr.Name = "lblForIngr";
            this.lblForIngr.Size = new System.Drawing.Size(71, 20);
            this.lblForIngr.TabIndex = 8;
            this.lblForIngr.Text = "主材料 　:";
            // 
            // btnSetRecipe
            // 
            this.btnSetRecipe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSetRecipe.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnSetRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnSetRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnSetRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetRecipe.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSetRecipe.ForeColor = System.Drawing.Color.Green;
            this.btnSetRecipe.Location = new System.Drawing.Point(457, 53);
            this.btnSetRecipe.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetRecipe.Name = "btnSetRecipe";
            this.btnSetRecipe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSetRecipe.Size = new System.Drawing.Size(90, 33);
            this.btnSetRecipe.TabIndex = 5;
            this.btnSetRecipe.Text = "新規作成";
            this.btnSetRecipe.UseVisualStyleBackColor = false;
            this.btnSetRecipe.Click += new System.EventHandler(this.btnSetRecipe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TitlePanel);
            this.groupBox2.Controls.Add(this.lblRnumber);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(292, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FloralWhite;
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TitlePanel.Controls.Add(this.txtRname);
            this.TitlePanel.Location = new System.Drawing.Point(93, 15);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(459, 49);
            this.TitlePanel.TabIndex = 2;
            // 
            // txtRname
            // 
            this.txtRname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRname.BackColor = System.Drawing.Color.FloralWhite;
            this.txtRname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRname.Font = new System.Drawing.Font("HGS行書体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtRname.ForeColor = System.Drawing.Color.DarkRed;
            this.txtRname.Location = new System.Drawing.Point(1, 4);
            this.txtRname.MaxLength = 30;
            this.txtRname.Name = "txtRname";
            this.txtRname.Size = new System.Drawing.Size(455, 37);
            this.txtRname.TabIndex = 1;
            this.txtRname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRname.TextChanged += new System.EventHandler(this.txtRname_TextChanged);
            this.txtRname.Enter += new System.EventHandler(this.txtRname_Enter);
            this.txtRname.Leave += new System.EventHandler(this.txtRname_Leave);
            // 
            // lblRnumber
            // 
            this.lblRnumber.AutoSize = true;
            this.lblRnumber.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRnumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRnumber.Location = new System.Drawing.Point(8, 17);
            this.lblRnumber.Name = "lblRnumber";
            this.lblRnumber.Size = new System.Drawing.Size(0, 48);
            this.lblRnumber.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEdit.ForeColor = System.Drawing.Color.Teal;
            this.btnEdit.Location = new System.Drawing.Point(667, 471);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(81, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "編集を保存";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(576, 471);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(81, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "品目を削除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEdit
            // 
            this.dgvEdit.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEdit.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEdit.Location = new System.Drawing.Point(12, 12);
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.RowTemplate.Height = 21;
            this.dgvEdit.Size = new System.Drawing.Size(274, 492);
            this.dgvEdit.TabIndex = 7;
            this.dgvEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdit_CellClick);
            this.dgvEdit.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdit_CellEnter);
            // 
            // RecipeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(863, 513);
            this.Controls.Add(this.dgvEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnRecipeBack);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipeEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "レシピ";
            this.Load += new System.EventHandler(this.RecipeEdit_Load);
            this.Shown += new System.EventHandler(this.RecipeEdit_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecipeBack;
        private System.Windows.Forms.Label lblForStyle;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRate;
        private System.Windows.Forms.Button btnSetRecipe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblForRate;
        private System.Windows.Forms.Label lblForCateg;
        private System.Windows.Forms.Label lblForTime;
        private System.Windows.Forms.Label lblForIngr;
        internal System.Windows.Forms.TextBox txtCateg;
        internal System.Windows.Forms.TextBox txtIngre;
        internal System.Windows.Forms.TextBox txtTime;
        internal System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.Label lblRnumber;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvEdit;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.TextBox txtRname;


    }
}

