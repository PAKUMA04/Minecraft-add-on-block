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
            this.bn_l = new System.Windows.Forms.Label();
            this.ns_l = new System.Windows.Forms.Label();
            this.ns_tb = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.dt_nud = new System.Windows.Forms.NumericUpDown();
            this.dt_l = new System.Windows.Forms.Label();
            this.le_nud = new System.Windows.Forms.NumericUpDown();
            this.le_l = new System.Windows.Forms.Label();
            this.er_nud = new System.Windows.Forms.NumericUpDown();
            this.er_l = new System.Windows.Forms.Label();
            this.f_clb = new System.Windows.Forms.CheckedListBox();
            this.f_l = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.le_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_nud)).BeginInit();
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
            // bn_l
            // 
            this.bn_l.BackColor = System.Drawing.Color.Transparent;
            this.bn_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bn_l.ForeColor = System.Drawing.Color.White;
            this.bn_l.Location = new System.Drawing.Point(265, 223);
            this.bn_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bn_l.Name = "bn_l";
            this.bn_l.Size = new System.Drawing.Size(84, 20);
            this.bn_l.TabIndex = 2;
            this.bn_l.Text = "ブロック名";
            this.bn_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // ns_l
            // 
            this.ns_l.AutoSize = true;
            this.ns_l.BackColor = System.Drawing.Color.Transparent;
            this.ns_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ns_l.ForeColor = System.Drawing.Color.White;
            this.ns_l.Location = new System.Drawing.Point(260, 253);
            this.ns_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ns_l.Name = "ns_l";
            this.ns_l.Size = new System.Drawing.Size(89, 20);
            this.ns_l.TabIndex = 3;
            this.ns_l.Text = "名前空間";
            this.ns_l.Click += new System.EventHandler(this.bi_text_Click);
            // 
            // ns_tb
            // 
            this.ns_tb.AllowDrop = true;
            this.ns_tb.BackColor = System.Drawing.Color.Gray;
            this.ns_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ns_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ns_tb.ForeColor = System.Drawing.Color.White;
            this.ns_tb.Location = new System.Drawing.Point(350, 250);
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
            // dt_nud
            // 
            this.dt_nud.BackColor = System.Drawing.Color.Gray;
            this.dt_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dt_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dt_nud.ForeColor = System.Drawing.Color.White;
            this.dt_nud.Location = new System.Drawing.Point(350, 284);
            this.dt_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.dt_nud.Name = "dt_nud";
            this.dt_nud.Size = new System.Drawing.Size(100, 27);
            this.dt_nud.TabIndex = 8;
            // 
            // dt_l
            // 
            this.dt_l.BackColor = System.Drawing.Color.Transparent;
            this.dt_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dt_l.ForeColor = System.Drawing.Color.White;
            this.dt_l.Location = new System.Drawing.Point(260, 286);
            this.dt_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dt_l.Name = "dt_l";
            this.dt_l.Size = new System.Drawing.Size(89, 20);
            this.dt_l.TabIndex = 9;
            this.dt_l.Text = "破壊時間";
            // 
            // le_nud
            // 
            this.le_nud.BackColor = System.Drawing.Color.Gray;
            this.le_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.le_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.le_nud.ForeColor = System.Drawing.Color.White;
            this.le_nud.Location = new System.Drawing.Point(550, 284);
            this.le_nud.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.le_nud.Name = "le_nud";
            this.le_nud.Size = new System.Drawing.Size(100, 27);
            this.le_nud.TabIndex = 10;
            // 
            // le_l
            // 
            this.le_l.BackColor = System.Drawing.Color.Transparent;
            this.le_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.le_l.ForeColor = System.Drawing.Color.White;
            this.le_l.Location = new System.Drawing.Point(458, 286);
            this.le_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.le_l.Name = "le_l";
            this.le_l.Size = new System.Drawing.Size(89, 20);
            this.le_l.TabIndex = 11;
            this.le_l.Text = "発光強さ";
            // 
            // er_nud
            // 
            this.er_nud.BackColor = System.Drawing.Color.Gray;
            this.er_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.er_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.er_nud.ForeColor = System.Drawing.Color.White;
            this.er_nud.Location = new System.Drawing.Point(350, 317);
            this.er_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.er_nud.Name = "er_nud";
            this.er_nud.Size = new System.Drawing.Size(100, 27);
            this.er_nud.TabIndex = 12;
            // 
            // er_l
            // 
            this.er_l.BackColor = System.Drawing.Color.Transparent;
            this.er_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.er_l.ForeColor = System.Drawing.Color.White;
            this.er_l.Location = new System.Drawing.Point(260, 319);
            this.er_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.er_l.Name = "er_l";
            this.er_l.Size = new System.Drawing.Size(89, 20);
            this.er_l.TabIndex = 13;
            this.er_l.Text = "爆発耐性";
            // 
            // f_clb
            // 
            this.f_clb.BackColor = System.Drawing.Color.Gray;
            this.f_clb.CheckOnClick = true;
            this.f_clb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.f_clb.ForeColor = System.Drawing.Color.White;
            this.f_clb.FormattingEnabled = true;
            this.f_clb.Items.AddRange(new object[] {
            "なし(普通)",
            "加速(氷)",
            "減速(ソウルサンド)"});
            this.f_clb.Location = new System.Drawing.Point(350, 350);
            this.f_clb.Name = "f_clb";
            this.f_clb.Size = new System.Drawing.Size(182, 76);
            this.f_clb.TabIndex = 16;
            this.f_clb.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // f_l
            // 
            this.f_l.BackColor = System.Drawing.Color.Transparent;
            this.f_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.f_l.ForeColor = System.Drawing.Color.White;
            this.f_l.Location = new System.Drawing.Point(260, 350);
            this.f_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.f_l.Name = "f_l";
            this.f_l.Size = new System.Drawing.Size(89, 20);
            this.f_l.TabIndex = 17;
            this.f_l.Text = "表面摩擦";
            // 
            // main_f
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.f_l);
            this.Controls.Add(this.f_clb);
            this.Controls.Add(this.er_l);
            this.Controls.Add(this.er_nud);
            this.Controls.Add(this.le_l);
            this.Controls.Add(this.le_nud);
            this.Controls.Add(this.dt_l);
            this.Controls.Add(this.dt_nud);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.ns_tb);
            this.Controls.Add(this.ns_l);
            this.Controls.Add(this.bn_l);
            this.Controls.Add(this.bn_tb);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "main_f";
            this.Text = "Minecraft BE カスタムブロックジェネレーター";
            this.Load += new System.EventHandler(this.main_f_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.le_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bn_tb;
        private System.Windows.Forms.Label bn_l;
        private System.Windows.Forms.Label ns_l;
        private System.Windows.Forms.TextBox ns_tb;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.NumericUpDown dt_nud;
        private System.Windows.Forms.Label dt_l;
        private System.Windows.Forms.NumericUpDown le_nud;
        private System.Windows.Forms.Label le_l;
        private System.Windows.Forms.NumericUpDown er_nud;
        private System.Windows.Forms.Label er_l;
        private System.Windows.Forms.CheckedListBox f_clb;
        private System.Windows.Forms.Label f_l;
    }
}

