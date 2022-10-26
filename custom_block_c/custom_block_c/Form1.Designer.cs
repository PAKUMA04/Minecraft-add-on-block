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
            this.logo = new System.Windows.Forms.PictureBox();
            this.done_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_tb
            // 
            this.bn_tb.BackColor = System.Drawing.Color.Gray;
            this.bn_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bn_tb.ForeColor = System.Drawing.Color.White;
            this.bn_tb.Location = new System.Drawing.Point(350, 217);
            this.bn_tb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bn_tb.Name = "bn_tb";
            this.bn_tb.Size = new System.Drawing.Size(300, 27);
            this.bn_tb.TabIndex = 1;
            // 
            // bn_t
            // 
            this.bn_t.AutoSize = true;
            this.bn_t.BackColor = System.Drawing.Color.Transparent;
            this.bn_t.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bn_t.ForeColor = System.Drawing.Color.White;
            this.bn_t.Location = new System.Drawing.Point(265, 223);
            this.bn_t.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bn_t.Name = "bn_t";
            this.bn_t.Size = new System.Drawing.Size(84, 20);
            this.bn_t.TabIndex = 2;
            this.bn_t.Text = "ブロック名";
            this.bn_t.Click += new System.EventHandler(this.label1_Click);
            // 
            // ns_t
            // 
            this.ns_t.AutoSize = true;
            this.ns_t.BackColor = System.Drawing.Color.Transparent;
            this.ns_t.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ns_t.ForeColor = System.Drawing.Color.White;
            this.ns_t.Location = new System.Drawing.Point(260, 257);
            this.ns_t.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ns_t.Name = "ns_t";
            this.ns_t.Size = new System.Drawing.Size(89, 20);
            this.ns_t.TabIndex = 3;
            this.ns_t.Text = "名前空間";
            this.ns_t.Click += new System.EventHandler(this.bi_text_Click);
            // 
            // ns_tb
            // 
            this.ns_tb.AllowDrop = true;
            this.ns_tb.BackColor = System.Drawing.Color.Gray;
            this.ns_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ns_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ns_tb.ForeColor = System.Drawing.Color.White;
            this.ns_tb.Location = new System.Drawing.Point(350, 255);
            this.ns_tb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ns_tb.Name = "ns_tb";
            this.ns_tb.Size = new System.Drawing.Size(300, 27);
            this.ns_tb.TabIndex = 4;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::custom_block_c.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(150, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(600, 200);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // done_btn
            // 
            this.done_btn.BackgroundImage = global::custom_block_c.Properties.Resources.done_btn;
            this.done_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.done_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done_btn.Location = new System.Drawing.Point(350, 490);
            this.done_btn.Margin = new System.Windows.Forms.Padding(0);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(200, 40);
            this.done_btn.TabIndex = 5;
            this.done_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_f
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.ns_tb);
            this.Controls.Add(this.ns_t);
            this.Controls.Add(this.bn_t);
            this.Controls.Add(this.bn_tb);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "main_f";
            this.Text = "MinecraftBE カスタムブロック生成";
            this.Load += new System.EventHandler(this.main_f_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bn_tb;
        private System.Windows.Forms.Label bn_t;
        private System.Windows.Forms.Label ns_t;
        private System.Windows.Forms.TextBox ns_tb;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button kb_btn;
    }
}

