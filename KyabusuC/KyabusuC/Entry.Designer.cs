namespace KyabusuC
{
    partial class Entry
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
            this.txtNumber = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.ComboBox();
            this.txtStart = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Uptake = new System.Windows.Forms.Button();
            this.EntrySet = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.FormattingEnabled = true;
            this.txtNumber.Location = new System.Drawing.Point(6, 51);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(121, 27);
            this.txtNumber.TabIndex = 0;
            // 
            // txtHeight
            // 
            this.txtHeight.FormattingEnabled = true;
            this.txtHeight.Location = new System.Drawing.Point(285, 52);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(121, 27);
            this.txtHeight.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.FormattingEnabled = true;
            this.txtWeight.Location = new System.Drawing.Point(6, 122);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(121, 27);
            this.txtWeight.TabIndex = 2;
            // 
            // txtStart
            // 
            this.txtStart.FormattingEnabled = true;
            this.txtStart.Location = new System.Drawing.Point(149, 122);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(121, 27);
            this.txtStart.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(285, 122);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(121, 26);
            this.txtComment.TabIndex = 5;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(297, 337);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(121, 39);
            this.Return.TabIndex = 7;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "名前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "背番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "ポジション";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "先発又は控え";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "体重";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "身長";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 190);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Uptake
            // 
            this.Uptake.Location = new System.Drawing.Point(22, 285);
            this.Uptake.Name = "Uptake";
            this.Uptake.Size = new System.Drawing.Size(117, 39);
            this.Uptake.TabIndex = 16;
            this.Uptake.Text = "取り込み";
            this.Uptake.UseVisualStyleBackColor = true;
            this.Uptake.Click += new System.EventHandler(this.Uptake_Click);
            // 
            // EntrySet
            // 
            this.EntrySet.Location = new System.Drawing.Point(161, 285);
            this.EntrySet.Name = "EntrySet";
            this.EntrySet.Size = new System.Drawing.Size(121, 39);
            this.EntrySet.TabIndex = 17;
            this.EntrySet.Text = "登録確定";
            this.EntrySet.UseVisualStyleBackColor = true;
            this.EntrySet.Click += new System.EventHandler(this.EntrySet_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(20, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(99, 35);
            this.Title.TabIndex = 18;
            this.Title.Text = "label2";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(297, 285);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(121, 39);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "登録中止";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 388);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.EntrySet);
            this.Controls.Add(this.Uptake);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Return);
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登録";
            this.Load += new System.EventHandler(this.Entry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtNumber;
        private System.Windows.Forms.ComboBox txtHeight;
        private System.Windows.Forms.ComboBox txtWeight;
        private System.Windows.Forms.ComboBox txtStart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Uptake;
        private System.Windows.Forms.Button EntrySet;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Cancel;
    }

    internal class BindingContextChanged
    {
    }
}