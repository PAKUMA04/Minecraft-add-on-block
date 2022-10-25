namespace custom_block_c
{
    partial class main_f
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
            this.kb_btn = new System.Windows.Forms.Button();
            this.done_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bn_tb
            // 
            this.bn_tb.Location = new System.Drawing.Point(507, 9);
            this.bn_tb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bn_tb.Name = "bn_tb";
            this.bn_tb.Size = new System.Drawing.Size(284, 25);
            this.bn_tb.TabIndex = 1;
            // 
            // bn_t
            // 
            this.bn_t.AutoSize = true;
            this.bn_t.Location = new System.Drawing.Point(413, 20);
            this.bn_t.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bn_t.Name = "bn_t";
            this.bn_t.Size = new System.Drawing.Size(75, 18);
            this.bn_t.TabIndex = 2;
            this.bn_t.Text = "ブロック名";
            this.bn_t.Click += new System.EventHandler(this.label1_Click);
            // 
            // ns_t
            // 
            this.ns_t.AutoSize = true;
            this.ns_t.Location = new System.Drawing.Point(408, 60);
            this.ns_t.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ns_t.Name = "ns_t";
            this.ns_t.Size = new System.Drawing.Size(80, 18);
            this.ns_t.TabIndex = 3;
            this.ns_t.Text = "名前空間";
            this.ns_t.Click += new System.EventHandler(this.bi_text_Click);
            // 
            // ns_tb
            // 
            this.ns_tb.Location = new System.Drawing.Point(507, 50);
            this.ns_tb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ns_tb.Name = "ns_tb";
            this.ns_tb.Size = new System.Drawing.Size(284, 25);
            this.ns_tb.TabIndex = 4;
            // 
            // kb_btn
            // 
            this.kb_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.kb_btn.BackgroundImage = global::custom_block_c.Properties.Resources.kb_btn;
            this.kb_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kb_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kb_btn.Location = new System.Drawing.Point(980, 86);
            this.kb_btn.Name = "kb_btn";
            this.kb_btn.Size = new System.Drawing.Size(128, 128);
            this.kb_btn.TabIndex = 6;
            this.kb_btn.UseVisualStyleBackColor = false;
            // 
            // done_btn
            // 
            this.done_btn.Image = global::custom_block_c.Properties.Resources.comp_button;
            this.done_btn.Location = new System.Drawing.Point(507, 567);
            this.done_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(200, 40);
            this.done_btn.TabIndex = 5;
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.kb_btn);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.ns_tb);
            this.Controls.Add(this.ns_t);
            this.Controls.Add(this.bn_t);
            this.Controls.Add(this.bn_tb);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "main_f";
            this.Text = "MinecraftBE カスタムブロック生成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bn_tb;
        private System.Windows.Forms.Label bn_t;
        private System.Windows.Forms.Label ns_t;
        private System.Windows.Forms.TextBox ns_tb;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Button kb_btn;
    }
}

