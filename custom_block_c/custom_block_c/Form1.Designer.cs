namespace custom_block_c
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.bn_tb = new System.Windows.Forms.TextBox();
            this.bn_t = new System.Windows.Forms.Label();
            this.ns_t = new System.Windows.Forms.Label();
            this.ns_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bn_tb
            // 
            this.bn_tb.Location = new System.Drawing.Point(304, 6);
            this.bn_tb.Name = "bn_tb";
            this.bn_tb.Size = new System.Drawing.Size(172, 19);
            this.bn_tb.TabIndex = 1;
            // 
            // bn_t
            // 
            this.bn_t.AutoSize = true;
            this.bn_t.Location = new System.Drawing.Point(248, 13);
            this.bn_t.Name = "bn_t";
            this.bn_t.Size = new System.Drawing.Size(50, 12);
            this.bn_t.TabIndex = 2;
            this.bn_t.Text = "ブロック名";
            this.bn_t.Click += new System.EventHandler(this.label1_Click);
            // 
            // ns_t
            // 
            this.ns_t.AutoSize = true;
            this.ns_t.Location = new System.Drawing.Point(245, 40);
            this.ns_t.Name = "ns_t";
            this.ns_t.Size = new System.Drawing.Size(53, 12);
            this.ns_t.TabIndex = 3;
            this.ns_t.Text = "名前空間";
            this.ns_t.Click += new System.EventHandler(this.bi_text_Click);
            // 
            // ns_tb
            // 
            this.ns_tb.Location = new System.Drawing.Point(304, 33);
            this.ns_tb.Name = "ns_tb";
            this.ns_tb.Size = new System.Drawing.Size(172, 19);
            this.ns_tb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = global::custom_block_c.Properties.Resources.comp_button;
            this.button1.Location = new System.Drawing.Point(276, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ns_tb);
            this.Controls.Add(this.ns_t);
            this.Controls.Add(this.bn_t);
            this.Controls.Add(this.bn_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bn_tb;
        private System.Windows.Forms.Label bn_t;
        private System.Windows.Forms.Label ns_t;
        private System.Windows.Forms.TextBox ns_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

