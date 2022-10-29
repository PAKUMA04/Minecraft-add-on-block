using System.Windows.Forms;

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
            this.dt_nud = new System.Windows.Forms.NumericUpDown();
            this.dt_l = new System.Windows.Forms.Label();
            this.le_nud = new System.Windows.Forms.NumericUpDown();
            this.le_l = new System.Windows.Forms.Label();
            this.er_nud = new System.Windows.Forms.NumericUpDown();
            this.er_l = new System.Windows.Forms.Label();
            this.f_clb = new System.Windows.Forms.CheckedListBox();
            this.f_l = new System.Windows.Forms.Label();
            this.bt_tb = new System.Windows.Forms.TextBox();
            this.bt_l = new System.Windows.Forms.Label();
            this.tn_tb = new System.Windows.Forms.TextBox();
            this.folder_btn = new System.Windows.Forms.Button();
            this.block_tex = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.folder_tb = new System.Windows.Forms.TextBox();
            this.folder_l = new System.Windows.Forms.Label();
            this.tl_tb = new System.Windows.Forms.TextBox();
            this.tl_l = new System.Windows.Forms.Label();
            this.pi_pb = new System.Windows.Forms.PictureBox();
            this.pn_l = new System.Windows.Forms.Label();
            this.pn_tb = new System.Windows.Forms.TextBox();
            this.pi_tb = new System.Windows.Forms.TextBox();
            this.pi_l = new System.Windows.Forms.Label();
            this.pd_l = new System.Windows.Forms.Label();
            this.pd_tb = new System.Windows.Forms.TextBox();
            this.pv_l = new System.Windows.Forms.Label();
            this.pv_nud = new System.Windows.Forms.NumericUpDown();
            this.mf_l = new System.Windows.Forms.Label();
            this.bs_l = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.le_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_tex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pv_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_tb
            // 
            this.bn_tb.BackColor = System.Drawing.Color.Gray;
            this.bn_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bn_tb.ForeColor = System.Drawing.Color.White;
            this.bn_tb.Location = new System.Drawing.Point(553, 233);
            this.bn_tb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bn_tb.Name = "bn_tb";
            this.bn_tb.Size = new System.Drawing.Size(200, 21);
            this.bn_tb.TabIndex = 1;
            // 
            // bn_l
            // 
            this.bn_l.BackColor = System.Drawing.Color.Transparent;
            this.bn_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bn_l.ForeColor = System.Drawing.Color.White;
            this.bn_l.Location = new System.Drawing.Point(483, 236);
            this.bn_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bn_l.Name = "bn_l";
            this.bn_l.Size = new System.Drawing.Size(60, 20);
            this.bn_l.TabIndex = 2;
            this.bn_l.Text = "ブロック名";
            // 
            // ns_l
            // 
            this.ns_l.AutoSize = true;
            this.ns_l.BackColor = System.Drawing.Color.Transparent;
            this.ns_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ns_l.ForeColor = System.Drawing.Color.White;
            this.ns_l.Location = new System.Drawing.Point(480, 265);
            this.ns_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ns_l.Name = "ns_l";
            this.ns_l.Size = new System.Drawing.Size(63, 14);
            this.ns_l.TabIndex = 3;
            this.ns_l.Text = "名前空間";
            // 
            // ns_tb
            // 
            this.ns_tb.AllowDrop = true;
            this.ns_tb.BackColor = System.Drawing.Color.Gray;
            this.ns_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ns_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ns_tb.ForeColor = System.Drawing.Color.White;
            this.ns_tb.Location = new System.Drawing.Point(553, 262);
            this.ns_tb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ns_tb.Name = "ns_tb";
            this.ns_tb.Size = new System.Drawing.Size(200, 21);
            this.ns_tb.TabIndex = 4;
            // 
            // dt_nud
            // 
            this.dt_nud.BackColor = System.Drawing.Color.Gray;
            this.dt_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dt_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dt_nud.ForeColor = System.Drawing.Color.White;
            this.dt_nud.Location = new System.Drawing.Point(553, 317);
            this.dt_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.dt_nud.Name = "dt_nud";
            this.dt_nud.Size = new System.Drawing.Size(50, 21);
            this.dt_nud.TabIndex = 8;
            // 
            // dt_l
            // 
            this.dt_l.BackColor = System.Drawing.Color.Transparent;
            this.dt_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dt_l.ForeColor = System.Drawing.Color.White;
            this.dt_l.Location = new System.Drawing.Point(482, 319);
            this.dt_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dt_l.Name = "dt_l";
            this.dt_l.Size = new System.Drawing.Size(63, 20);
            this.dt_l.TabIndex = 9;
            this.dt_l.Text = "破壊時間";
            // 
            // le_nud
            // 
            this.le_nud.BackColor = System.Drawing.Color.Gray;
            this.le_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.le_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.le_nud.ForeColor = System.Drawing.Color.White;
            this.le_nud.Location = new System.Drawing.Point(703, 317);
            this.le_nud.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.le_nud.Name = "le_nud";
            this.le_nud.Size = new System.Drawing.Size(50, 21);
            this.le_nud.TabIndex = 10;
            // 
            // le_l
            // 
            this.le_l.BackColor = System.Drawing.Color.Transparent;
            this.le_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.le_l.ForeColor = System.Drawing.Color.White;
            this.le_l.Location = new System.Drawing.Point(645, 319);
            this.le_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.le_l.Name = "le_l";
            this.le_l.Size = new System.Drawing.Size(50, 20);
            this.le_l.TabIndex = 11;
            this.le_l.Text = "明るさ";
            // 
            // er_nud
            // 
            this.er_nud.BackColor = System.Drawing.Color.Gray;
            this.er_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.er_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.er_nud.ForeColor = System.Drawing.Color.White;
            this.er_nud.Location = new System.Drawing.Point(553, 344);
            this.er_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.er_nud.Name = "er_nud";
            this.er_nud.Size = new System.Drawing.Size(50, 21);
            this.er_nud.TabIndex = 12;
            // 
            // er_l
            // 
            this.er_l.BackColor = System.Drawing.Color.Transparent;
            this.er_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.er_l.ForeColor = System.Drawing.Color.White;
            this.er_l.Location = new System.Drawing.Point(480, 346);
            this.er_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.er_l.Name = "er_l";
            this.er_l.Size = new System.Drawing.Size(63, 20);
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
            this.f_clb.Location = new System.Drawing.Point(809, 453);
            this.f_clb.Name = "f_clb";
            this.f_clb.Size = new System.Drawing.Size(166, 52);
            this.f_clb.TabIndex = 16;
            this.f_clb.Visible = false;
            // 
            // f_l
            // 
            this.f_l.BackColor = System.Drawing.Color.Transparent;
            this.f_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.f_l.ForeColor = System.Drawing.Color.White;
            this.f_l.Location = new System.Drawing.Point(820, 430);
            this.f_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.f_l.Name = "f_l";
            this.f_l.Size = new System.Drawing.Size(89, 20);
            this.f_l.TabIndex = 17;
            this.f_l.Text = "表面摩擦";
            this.f_l.Visible = false;
            // 
            // bt_tb
            // 
            this.bt_tb.Location = new System.Drawing.Point(809, 511);
            this.bt_tb.Name = "bt_tb";
            this.bt_tb.Size = new System.Drawing.Size(100, 19);
            this.bt_tb.TabIndex = 19;
            this.bt_tb.UseWaitCursor = true;
            this.bt_tb.Visible = false;
            // 
            // bt_l
            // 
            this.bt_l.AllowDrop = true;
            this.bt_l.AutoSize = true;
            this.bt_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.bt_l.ForeColor = System.Drawing.Color.White;
            this.bt_l.Location = new System.Drawing.Point(480, 371);
            this.bt_l.Name = "bt_l";
            this.bt_l.Size = new System.Drawing.Size(59, 14);
            this.bt_l.TabIndex = 20;
            this.bt_l.Text = "テクスチャ";
            // 
            // tn_tb
            // 
            this.tn_tb.Location = new System.Drawing.Point(809, 530);
            this.tn_tb.Name = "tn_tb";
            this.tn_tb.Size = new System.Drawing.Size(100, 19);
            this.tn_tb.TabIndex = 21;
            this.tn_tb.Visible = false;
            // 
            // folder_btn
            // 
            this.folder_btn.BackColor = System.Drawing.Color.Gray;
            this.folder_btn.BackgroundImage = global::custom_block_c.Properties.Resources.file_btn;
            this.folder_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.folder_btn.Location = new System.Drawing.Point(173, 467);
            this.folder_btn.Name = "folder_btn";
            this.folder_btn.Size = new System.Drawing.Size(32, 32);
            this.folder_btn.TabIndex = 22;
            this.folder_btn.UseVisualStyleBackColor = false;
            this.folder_btn.Click += new System.EventHandler(this.file_btn_Click);
            // 
            // block_tex
            // 
            this.block_tex.BackColor = System.Drawing.Color.Gray;
            this.block_tex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block_tex.Location = new System.Drawing.Point(553, 371);
            this.block_tex.Name = "block_tex";
            this.block_tex.Size = new System.Drawing.Size(80, 80);
            this.block_tex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block_tex.TabIndex = 18;
            this.block_tex.TabStop = false;
            this.block_tex.DragDrop += new System.Windows.Forms.DragEventHandler(this.block_tex_DragDrop);
            this.block_tex.DragEnter += new System.Windows.Forms.DragEventHandler(this.block_tex_DragEnter);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::custom_block_c.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(153, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(600, 200);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // done_btn
            // 
            this.done_btn.BackgroundImage = global::custom_block_c.Properties.Resources.done_btn;
            this.done_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.done_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done_btn.Location = new System.Drawing.Point(350, 500);
            this.done_btn.Margin = new System.Windows.Forms.Padding(0);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(200, 40);
            this.done_btn.TabIndex = 5;
            this.done_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // folder_tb
            // 
            this.folder_tb.BackColor = System.Drawing.Color.Gray;
            this.folder_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.folder_tb.ForeColor = System.Drawing.Color.White;
            this.folder_tb.Location = new System.Drawing.Point(211, 473);
            this.folder_tb.Name = "folder_tb";
            this.folder_tb.Size = new System.Drawing.Size(542, 21);
            this.folder_tb.TabIndex = 23;
            // 
            // folder_l
            // 
            this.folder_l.AutoSize = true;
            this.folder_l.BackColor = System.Drawing.Color.Transparent;
            this.folder_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.folder_l.ForeColor = System.Drawing.Color.White;
            this.folder_l.Location = new System.Drawing.Point(118, 476);
            this.folder_l.Name = "folder_l";
            this.folder_l.Size = new System.Drawing.Size(49, 14);
            this.folder_l.TabIndex = 24;
            this.folder_l.Text = "保存先";
            // 
            // tl_tb
            // 
            this.tl_tb.BackColor = System.Drawing.Color.Gray;
            this.tl_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.tl_tb.ForeColor = System.Drawing.Color.White;
            this.tl_tb.Location = new System.Drawing.Point(553, 290);
            this.tl_tb.Name = "tl_tb";
            this.tl_tb.Size = new System.Drawing.Size(200, 21);
            this.tl_tb.TabIndex = 25;
            // 
            // tl_l
            // 
            this.tl_l.AutoSize = true;
            this.tl_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.tl_l.ForeColor = System.Drawing.Color.White;
            this.tl_l.Location = new System.Drawing.Point(494, 293);
            this.tl_l.Name = "tl_l";
            this.tl_l.Size = new System.Drawing.Size(49, 14);
            this.tl_l.TabIndex = 26;
            this.tl_l.Text = "表示名";
            // 
            // pi_pb
            // 
            this.pi_pb.BackColor = System.Drawing.Color.Gray;
            this.pi_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pi_pb.Location = new System.Drawing.Point(211, 314);
            this.pi_pb.Name = "pi_pb";
            this.pi_pb.Size = new System.Drawing.Size(100, 100);
            this.pi_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_pb.TabIndex = 27;
            this.pi_pb.TabStop = false;
            this.pi_pb.DragDrop += new System.Windows.Forms.DragEventHandler(this.pi_pb_DragDrop);
            this.pi_pb.DragEnter += new System.Windows.Forms.DragEventHandler(this.pi_pb_DragEnter);
            // 
            // pn_l
            // 
            this.pn_l.AutoSize = true;
            this.pn_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pn_l.ForeColor = System.Drawing.Color.White;
            this.pn_l.Location = new System.Drawing.Point(153, 236);
            this.pn_l.Name = "pn_l";
            this.pn_l.Size = new System.Drawing.Size(51, 14);
            this.pn_l.TabIndex = 28;
            this.pn_l.Text = "パック名";
            // 
            // pn_tb
            // 
            this.pn_tb.BackColor = System.Drawing.Color.Gray;
            this.pn_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pn_tb.ForeColor = System.Drawing.Color.White;
            this.pn_tb.Location = new System.Drawing.Point(211, 233);
            this.pn_tb.Name = "pn_tb";
            this.pn_tb.Size = new System.Drawing.Size(200, 21);
            this.pn_tb.TabIndex = 29;
            // 
            // pi_tb
            // 
            this.pi_tb.Location = new System.Drawing.Point(809, 395);
            this.pi_tb.Name = "pi_tb";
            this.pi_tb.Size = new System.Drawing.Size(100, 19);
            this.pi_tb.TabIndex = 30;
            this.pi_tb.Visible = false;
            // 
            // pi_l
            // 
            this.pi_l.AutoSize = true;
            this.pi_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pi_l.ForeColor = System.Drawing.Color.White;
            this.pi_l.Location = new System.Drawing.Point(127, 314);
            this.pi_l.Name = "pi_l";
            this.pi_l.Size = new System.Drawing.Size(78, 14);
            this.pi_l.TabIndex = 31;
            this.pi_l.Text = "パックアイコン";
            // 
            // pd_l
            // 
            this.pd_l.AutoSize = true;
            this.pd_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pd_l.ForeColor = System.Drawing.Color.White;
            this.pd_l.Location = new System.Drawing.Point(140, 263);
            this.pd_l.Name = "pd_l";
            this.pd_l.Size = new System.Drawing.Size(65, 14);
            this.pd_l.TabIndex = 32;
            this.pd_l.Text = "パック説明";
            // 
            // pd_tb
            // 
            this.pd_tb.BackColor = System.Drawing.Color.Gray;
            this.pd_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pd_tb.ForeColor = System.Drawing.Color.White;
            this.pd_tb.Location = new System.Drawing.Point(211, 260);
            this.pd_tb.Name = "pd_tb";
            this.pd_tb.Size = new System.Drawing.Size(200, 21);
            this.pd_tb.TabIndex = 33;
            // 
            // pv_l
            // 
            this.pv_l.AutoSize = true;
            this.pv_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pv_l.ForeColor = System.Drawing.Color.White;
            this.pv_l.Location = new System.Drawing.Point(146, 289);
            this.pv_l.Name = "pv_l";
            this.pv_l.Size = new System.Drawing.Size(59, 14);
            this.pv_l.TabIndex = 34;
            this.pv_l.Text = "バージョン";
            // 
            // pv_nud
            // 
            this.pv_nud.BackColor = System.Drawing.Color.Gray;
            this.pv_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pv_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pv_nud.ForeColor = System.Drawing.Color.White;
            this.pv_nud.Location = new System.Drawing.Point(211, 287);
            this.pv_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.pv_nud.Name = "pv_nud";
            this.pv_nud.Size = new System.Drawing.Size(50, 21);
            this.pv_nud.TabIndex = 35;
            // 
            // mf_l
            // 
            this.mf_l.AutoSize = true;
            this.mf_l.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mf_l.ForeColor = System.Drawing.Color.White;
            this.mf_l.Location = new System.Drawing.Point(152, 202);
            this.mf_l.Name = "mf_l";
            this.mf_l.Size = new System.Drawing.Size(130, 20);
            this.mf_l.TabIndex = 36;
            this.mf_l.Text = "manifest設定";
            // 
            // bs_l
            // 
            this.bs_l.AutoSize = true;
            this.bs_l.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bs_l.ForeColor = System.Drawing.Color.White;
            this.bs_l.Location = new System.Drawing.Point(479, 204);
            this.bs_l.Name = "bs_l";
            this.bs_l.Size = new System.Drawing.Size(110, 20);
            this.bs_l.TabIndex = 37;
            this.bs_l.Text = "ブロック設定";
            // 
            // main_f
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.bs_l);
            this.Controls.Add(this.mf_l);
            this.Controls.Add(this.pv_nud);
            this.Controls.Add(this.pv_l);
            this.Controls.Add(this.pd_tb);
            this.Controls.Add(this.pd_l);
            this.Controls.Add(this.pi_l);
            this.Controls.Add(this.pi_tb);
            this.Controls.Add(this.pn_tb);
            this.Controls.Add(this.pn_l);
            this.Controls.Add(this.pi_pb);
            this.Controls.Add(this.tl_l);
            this.Controls.Add(this.tl_tb);
            this.Controls.Add(this.folder_l);
            this.Controls.Add(this.folder_tb);
            this.Controls.Add(this.folder_btn);
            this.Controls.Add(this.tn_tb);
            this.Controls.Add(this.bt_l);
            this.Controls.Add(this.bt_tb);
            this.Controls.Add(this.block_tex);
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
            this.MaximizeBox = false;
            this.Name = "main_f";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minecraft BE カスタムブロックジェネレーター";
            ((System.ComponentModel.ISupportInitialize)(this.dt_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.le_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_tex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pv_nud)).EndInit();
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
        private System.Windows.Forms.PictureBox block_tex;
        private TextBox bt_tb;
        private Label bt_l;
        private TextBox tn_tb;
        private Button folder_btn;
        private TextBox folder_tb;
        private Label folder_l;
        private TextBox tl_tb;
        private Label tl_l;
        private PictureBox pi_pb;
        private Label pn_l;
        private TextBox pn_tb;
        private TextBox pi_tb;
        private Label pi_l;
        private Label pd_l;
        private TextBox pd_tb;
        private Label pv_l;
        private NumericUpDown pv_nud;
        private Label mf_l;
        private Label bs_l;
    }
}

