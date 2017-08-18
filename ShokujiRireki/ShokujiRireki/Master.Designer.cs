namespace ShokujiRireki
{
    partial class Master
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgv_Food = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label1.Font = new System.Drawing.Font("Meiryo UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(46, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 20);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "食品マスタ編集画面";
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(139, 48);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(84, 19);
            this.txtCal.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(43, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(78, 19);
            this.txtName.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 25);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(283, 277);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(64, 25);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(43, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 25);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgv_Food
            // 
            this.dgv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Food.Location = new System.Drawing.Point(26, 73);
            this.dgv_Food.Name = "dgv_Food";
            this.dgv_Food.RowTemplate.Height = 21;
            this.dgv_Food.Size = new System.Drawing.Size(321, 180);
            this.dgv_Food.TabIndex = 8;
            this.dgv_Food.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Food_CellContentClick);
            this.dgv_Food.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Food_CellValueChanged);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(373, 323);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgv_Food);
            this.Name = "Master";
            this.Text = "マスタ編集";
            this.Load += new System.EventHandler(this.Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCal;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnReturn;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.DataGridView dgv_Food;
    }
}