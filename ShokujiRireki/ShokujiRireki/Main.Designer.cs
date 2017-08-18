namespace ShokujiRireki
{
    partial class Main
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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbToM = new System.Windows.Forms.ComboBox();
            this.cmbToY = new System.Windows.Forms.ComboBox();
            this.cmbFromM = new System.Windows.Forms.ComboBox();
            this.cmbFromY = new System.Windows.Forms.ComboBox();
            this.rdoCal = new System.Windows.Forms.RadioButton();
            this.rdoRank = new System.Windows.Forms.RadioButton();
            this.rdoKikan = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgv_Shokuji = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shokuji)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(440, 99);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 35;
            this.btnShowAll.Text = "全て表示";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(333, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "検索実行";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(512, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 11);
            this.label3.TabIndex = 33;
            this.label3.Text = "月から";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(451, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 11);
            this.label4.TabIndex = 32;
            this.label4.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(346, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 11);
            this.label2.TabIndex = 31;
            this.label2.Text = "月から";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(285, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 11);
            this.label1.TabIndex = 30;
            this.label1.Text = "年";
            // 
            // cmbToM
            // 
            this.cmbToM.FormattingEnabled = true;
            this.cmbToM.Location = new System.Drawing.Point(467, 58);
            this.cmbToM.Name = "cmbToM";
            this.cmbToM.Size = new System.Drawing.Size(42, 20);
            this.cmbToM.TabIndex = 29;
            // 
            // cmbToY
            // 
            this.cmbToY.FormattingEnabled = true;
            this.cmbToY.Location = new System.Drawing.Point(381, 58);
            this.cmbToY.Name = "cmbToY";
            this.cmbToY.Size = new System.Drawing.Size(70, 20);
            this.cmbToY.TabIndex = 28;
            // 
            // cmbFromM
            // 
            this.cmbFromM.FormattingEnabled = true;
            this.cmbFromM.Location = new System.Drawing.Point(300, 59);
            this.cmbFromM.Name = "cmbFromM";
            this.cmbFromM.Size = new System.Drawing.Size(42, 20);
            this.cmbFromM.TabIndex = 27;
            // 
            // cmbFromY
            // 
            this.cmbFromY.FormattingEnabled = true;
            this.cmbFromY.Location = new System.Drawing.Point(214, 59);
            this.cmbFromY.Name = "cmbFromY";
            this.cmbFromY.Size = new System.Drawing.Size(70, 20);
            this.cmbFromY.TabIndex = 26;
            // 
            // rdoCal
            // 
            this.rdoCal.AutoSize = true;
            this.rdoCal.Location = new System.Drawing.Point(48, 106);
            this.rdoCal.Name = "rdoCal";
            this.rdoCal.Size = new System.Drawing.Size(218, 16);
            this.rdoCal.TabIndex = 25;
            this.rdoCal.TabStop = true;
            this.rdoCal.Text = "1日のカロリー摂取量が多い順に表示する";
            this.rdoCal.UseVisualStyleBackColor = true;
            // 
            // rdoRank
            // 
            this.rdoRank.AutoSize = true;
            this.rdoRank.Location = new System.Drawing.Point(48, 84);
            this.rdoRank.Name = "rdoRank";
            this.rdoRank.Size = new System.Drawing.Size(220, 16);
            this.rdoRank.TabIndex = 24;
            this.rdoRank.TabStop = true;
            this.rdoRank.Text = "食べた回数の多いもの上位3つを表示する";
            this.rdoRank.UseVisualStyleBackColor = true;
            // 
            // rdoKikan
            // 
            this.rdoKikan.AutoSize = true;
            this.rdoKikan.Location = new System.Drawing.Point(48, 62);
            this.rdoKikan.Name = "rdoKikan";
            this.rdoKikan.Size = new System.Drawing.Size(151, 16);
            this.rdoKikan.TabIndex = 23;
            this.rdoKikan.TabStop = true;
            this.rdoKikan.Text = "指定した期間で検索を行う";
            this.rdoKikan.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Meiryo UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(27, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 24);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "メイン画面";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(440, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.Location = new System.Drawing.Point(240, 339);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(75, 23);
            this.btnMaster.TabIndex = 20;
            this.btnMaster.Text = "マスタ編集へ";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "新規登録";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv_Shokuji
            // 
            this.dgv_Shokuji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Shokuji.Location = new System.Drawing.Point(12, 136);
            this.dgv_Shokuji.Name = "dgv_Shokuji";
            this.dgv_Shokuji.RowTemplate.Height = 21;
            this.dgv_Shokuji.Size = new System.Drawing.Size(520, 188);
            this.dgv_Shokuji.TabIndex = 18;
            this.dgv_Shokuji.DoubleClick += new System.EventHandler(this.dgv_Shokuji_DoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(568, 375);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbToM);
            this.Controls.Add(this.cmbToY);
            this.Controls.Add(this.cmbFromM);
            this.Controls.Add(this.cmbFromY);
            this.Controls.Add(this.rdoCal);
            this.Controls.Add(this.rdoRank);
            this.Controls.Add(this.rdoKikan);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaster);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv_Shokuji);
            this.Name = "Main";
            this.Text = "メインメニュー画面";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shokuji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbToM;
        private System.Windows.Forms.ComboBox cmbToY;
        private System.Windows.Forms.ComboBox cmbFromM;
        private System.Windows.Forms.ComboBox cmbFromY;
        private System.Windows.Forms.RadioButton rdoCal;
        private System.Windows.Forms.RadioButton rdoRank;
        private System.Windows.Forms.RadioButton rdoKikan;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv_Shokuji;
    }
}