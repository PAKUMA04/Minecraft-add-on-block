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
            this.pi_l = new System.Windows.Forms.Label();
            this.pd_l = new System.Windows.Forms.Label();
            this.pd_tb = new System.Windows.Forms.TextBox();
            this.pv_l = new System.Windows.Forms.Label();
            this.pv_nud = new System.Windows.Forms.NumericUpDown();
            this.ms_l = new System.Windows.Forms.Label();
            this.bs_l = new System.Windows.Forms.Label();
            this.is_l = new System.Windows.Forms.Label();
            this.in_tb = new System.Windows.Forms.TextBox();
            this.in_l = new System.Windows.Forms.Label();
            this.it_pb = new System.Windows.Forms.PictureBox();
            this.it_l = new System.Windows.Forms.Label();
            this.it_tb = new System.Windows.Forms.TextBox();
            this.itn_tb = new System.Windows.Forms.TextBox();
            this.is_cb = new System.Windows.Forms.CheckBox();
            this.idn_tb = new System.Windows.Forms.TextBox();
            this.idn_l = new System.Windows.Forms.Label();
            this.ifs_l = new System.Windows.Forms.Label();
            this.mss_l = new System.Windows.Forms.Label();
            this.mss_nud = new System.Windows.Forms.NumericUpDown();
            this.lb_cb = new System.Windows.Forms.CheckBox();
            this.bs_cb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bfs_l = new System.Windows.Forms.Label();
            this.bt_cb = new System.Windows.Forms.CheckBox();
            this.block_ltex = new System.Windows.Forms.PictureBox();
            this.ltex_l = new System.Windows.Forms.Label();
            this.lbt_fp_tb = new System.Windows.Forms.TextBox();
            this.lbt_fn_tb = new System.Windows.Forms.TextBox();
            this.block_lb = new System.Windows.Forms.ListBox();
            this.fp_cb = new System.Windows.Forms.ComboBox();
            this.folder_open_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.le_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_tex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pv_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.it_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mss_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_ltex)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_tb
            // 
            this.bn_tb.BackColor = System.Drawing.Color.Gray;
            this.bn_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bn_tb.ForeColor = System.Drawing.Color.White;
            this.bn_tb.Location = new System.Drawing.Point(387, 231);
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
            this.bn_l.Location = new System.Drawing.Point(320, 230);
            this.bn_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bn_l.Name = "bn_l";
            this.bn_l.Size = new System.Drawing.Size(60, 20);
            this.bn_l.TabIndex = 2;
            this.bn_l.Text = "ブロック名";
            this.bn_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ns_l
            // 
            this.ns_l.AutoSize = true;
            this.ns_l.BackColor = System.Drawing.Color.Transparent;
            this.ns_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ns_l.ForeColor = System.Drawing.Color.White;
            this.ns_l.Location = new System.Drawing.Point(314, 262);
            this.ns_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ns_l.Name = "ns_l";
            this.ns_l.Size = new System.Drawing.Size(63, 14);
            this.ns_l.TabIndex = 3;
            this.ns_l.Text = "名前空間";
            this.ns_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ns_tb
            // 
            this.ns_tb.AllowDrop = true;
            this.ns_tb.BackColor = System.Drawing.Color.Gray;
            this.ns_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ns_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ns_tb.ForeColor = System.Drawing.Color.White;
            this.ns_tb.Location = new System.Drawing.Point(387, 260);
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
            this.dt_nud.Location = new System.Drawing.Point(387, 315);
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
            this.dt_l.Location = new System.Drawing.Point(317, 315);
            this.dt_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dt_l.Name = "dt_l";
            this.dt_l.Size = new System.Drawing.Size(63, 20);
            this.dt_l.TabIndex = 9;
            this.dt_l.Text = "破壊時間";
            this.dt_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // le_nud
            // 
            this.le_nud.BackColor = System.Drawing.Color.Gray;
            this.le_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.le_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.le_nud.ForeColor = System.Drawing.Color.White;
            this.le_nud.Location = new System.Drawing.Point(537, 315);
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
            this.le_l.Location = new System.Drawing.Point(479, 317);
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
            this.er_nud.Location = new System.Drawing.Point(387, 342);
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
            this.er_l.Location = new System.Drawing.Point(315, 342);
            this.er_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.er_l.Name = "er_l";
            this.er_l.Size = new System.Drawing.Size(63, 20);
            this.er_l.TabIndex = 13;
            this.er_l.Text = "爆発耐性";
            this.er_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.f_clb.Location = new System.Drawing.Point(12, 12);
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
            this.f_l.Location = new System.Drawing.Point(9, 67);
            this.f_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.f_l.Name = "f_l";
            this.f_l.Size = new System.Drawing.Size(89, 20);
            this.f_l.TabIndex = 17;
            this.f_l.Text = "表面摩擦";
            this.f_l.Visible = false;
            // 
            // bt_tb
            // 
            this.bt_tb.Location = new System.Drawing.Point(1072, 37);
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
            this.bt_l.Location = new System.Drawing.Point(318, 373);
            this.bt_l.Name = "bt_l";
            this.bt_l.Size = new System.Drawing.Size(59, 28);
            this.bt_l.TabIndex = 20;
            this.bt_l.Text = "ブロック\r\nテクスチャ";
            this.bt_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tn_tb
            // 
            this.tn_tb.Location = new System.Drawing.Point(1072, 62);
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
            this.folder_btn.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.folder_btn.Location = new System.Drawing.Point(262, 466);
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
            this.block_tex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.block_tex.Location = new System.Drawing.Point(387, 369);
            this.block_tex.Name = "block_tex";
            this.block_tex.Size = new System.Drawing.Size(80, 80);
            this.block_tex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block_tex.TabIndex = 18;
            this.block_tex.TabStop = false;
            this.block_tex.Click += new System.EventHandler(this.block_tex_click);
            this.block_tex.DragDrop += new System.Windows.Forms.DragEventHandler(this.block_tex_DragDrop);
            this.block_tex.DragEnter += new System.Windows.Forms.DragEventHandler(this.block_tex_DragEnter);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::custom_block_c.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(300, 0);
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
            this.done_btn.Location = new System.Drawing.Point(500, 500);
            this.done_btn.Margin = new System.Windows.Forms.Padding(0);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(200, 40);
            this.done_btn.TabIndex = 5;
            this.done_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // folder_tb
            // 
            this.folder_tb.BackColor = System.Drawing.Color.Gray;
            this.folder_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.folder_tb.ForeColor = System.Drawing.Color.White;
            this.folder_tb.Location = new System.Drawing.Point(300, 473);
            this.folder_tb.Name = "folder_tb";
            this.folder_tb.Size = new System.Drawing.Size(600, 21);
            this.folder_tb.TabIndex = 23;
            // 
            // folder_l
            // 
            this.folder_l.AutoSize = true;
            this.folder_l.BackColor = System.Drawing.Color.Transparent;
            this.folder_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.folder_l.ForeColor = System.Drawing.Color.White;
            this.folder_l.Location = new System.Drawing.Point(212, 475);
            this.folder_l.Name = "folder_l";
            this.folder_l.Size = new System.Drawing.Size(49, 14);
            this.folder_l.TabIndex = 24;
            this.folder_l.Text = "保存先";
            this.folder_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tl_tb
            // 
            this.tl_tb.BackColor = System.Drawing.Color.Gray;
            this.tl_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.tl_tb.ForeColor = System.Drawing.Color.White;
            this.tl_tb.Location = new System.Drawing.Point(387, 288);
            this.tl_tb.Name = "tl_tb";
            this.tl_tb.Size = new System.Drawing.Size(200, 21);
            this.tl_tb.TabIndex = 25;
            // 
            // tl_l
            // 
            this.tl_l.AutoSize = true;
            this.tl_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.tl_l.ForeColor = System.Drawing.Color.White;
            this.tl_l.Location = new System.Drawing.Point(329, 289);
            this.tl_l.Name = "tl_l";
            this.tl_l.Size = new System.Drawing.Size(49, 14);
            this.tl_l.TabIndex = 26;
            this.tl_l.Text = "表示名";
            this.tl_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pi_pb
            // 
            this.pi_pb.BackColor = System.Drawing.Color.Gray;
            this.pi_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pi_pb.Location = new System.Drawing.Point(98, 316);
            this.pi_pb.Name = "pi_pb";
            this.pi_pb.Size = new System.Drawing.Size(100, 100);
            this.pi_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_pb.TabIndex = 27;
            this.pi_pb.TabStop = false;
            this.pi_pb.Click += new System.EventHandler(this.pi_pb_Click);
            this.pi_pb.DragDrop += new System.Windows.Forms.DragEventHandler(this.pi_pb_DragDrop);
            this.pi_pb.DragEnter += new System.Windows.Forms.DragEventHandler(this.pi_pb_DragEnter);
            // 
            // pn_l
            // 
            this.pn_l.AutoSize = true;
            this.pn_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pn_l.ForeColor = System.Drawing.Color.White;
            this.pn_l.Location = new System.Drawing.Point(40, 238);
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
            this.pn_tb.Location = new System.Drawing.Point(98, 235);
            this.pn_tb.Name = "pn_tb";
            this.pn_tb.Size = new System.Drawing.Size(200, 21);
            this.pn_tb.TabIndex = 29;
            // 
            // pi_l
            // 
            this.pi_l.AutoSize = true;
            this.pi_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pi_l.ForeColor = System.Drawing.Color.White;
            this.pi_l.Location = new System.Drawing.Point(14, 316);
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
            this.pd_l.Location = new System.Drawing.Point(27, 265);
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
            this.pd_tb.Location = new System.Drawing.Point(98, 262);
            this.pd_tb.Name = "pd_tb";
            this.pd_tb.Size = new System.Drawing.Size(200, 21);
            this.pd_tb.TabIndex = 33;
            // 
            // pv_l
            // 
            this.pv_l.AutoSize = true;
            this.pv_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.pv_l.ForeColor = System.Drawing.Color.White;
            this.pv_l.Location = new System.Drawing.Point(33, 291);
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
            this.pv_nud.Location = new System.Drawing.Point(98, 289);
            this.pv_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.pv_nud.Name = "pv_nud";
            this.pv_nud.Size = new System.Drawing.Size(50, 21);
            this.pv_nud.TabIndex = 35;
            this.pv_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ms_l
            // 
            this.ms_l.AutoSize = true;
            this.ms_l.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ms_l.ForeColor = System.Drawing.Color.White;
            this.ms_l.Location = new System.Drawing.Point(94, 207);
            this.ms_l.Name = "ms_l";
            this.ms_l.Size = new System.Drawing.Size(130, 20);
            this.ms_l.TabIndex = 36;
            this.ms_l.Text = "manifest設定";
            // 
            // bs_l
            // 
            this.bs_l.AutoSize = true;
            this.bs_l.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bs_l.ForeColor = System.Drawing.Color.White;
            this.bs_l.Location = new System.Drawing.Point(383, 207);
            this.bs_l.Name = "bs_l";
            this.bs_l.Size = new System.Drawing.Size(110, 20);
            this.bs_l.TabIndex = 37;
            this.bs_l.Text = "ブロック設定";
            this.bs_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // is_l
            // 
            this.is_l.AutoSize = true;
            this.is_l.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.is_l.ForeColor = System.Drawing.Color.White;
            this.is_l.Location = new System.Drawing.Point(904, 216);
            this.is_l.Name = "is_l";
            this.is_l.Size = new System.Drawing.Size(115, 20);
            this.is_l.TabIndex = 38;
            this.is_l.Text = "アイテム設定";
            this.is_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // in_tb
            // 
            this.in_tb.BackColor = System.Drawing.Color.Gray;
            this.in_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_tb.ForeColor = System.Drawing.Color.White;
            this.in_tb.Location = new System.Drawing.Point(908, 238);
            this.in_tb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.in_tb.Name = "in_tb";
            this.in_tb.Size = new System.Drawing.Size(200, 21);
            this.in_tb.TabIndex = 39;
            // 
            // in_l
            // 
            this.in_l.AutoSize = true;
            this.in_l.BackColor = System.Drawing.Color.Transparent;
            this.in_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_l.ForeColor = System.Drawing.Color.White;
            this.in_l.Location = new System.Drawing.Point(834, 239);
            this.in_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.in_l.Name = "in_l";
            this.in_l.Size = new System.Drawing.Size(64, 14);
            this.in_l.TabIndex = 40;
            this.in_l.Text = "アイテム名";
            this.in_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // it_pb
            // 
            this.it_pb.BackColor = System.Drawing.Color.Gray;
            this.it_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.it_pb.Location = new System.Drawing.Point(908, 266);
            this.it_pb.Name = "it_pb";
            this.it_pb.Size = new System.Drawing.Size(80, 80);
            this.it_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.it_pb.TabIndex = 41;
            this.it_pb.TabStop = false;
            this.it_pb.DragDrop += new System.Windows.Forms.DragEventHandler(this.it_pb_DragDrop);
            this.it_pb.DragEnter += new System.Windows.Forms.DragEventHandler(this.it_pb_DragEnter);
            // 
            // it_l
            // 
            this.it_l.AllowDrop = true;
            this.it_l.AutoSize = true;
            this.it_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.it_l.ForeColor = System.Drawing.Color.White;
            this.it_l.Location = new System.Drawing.Point(839, 266);
            this.it_l.Name = "it_l";
            this.it_l.Size = new System.Drawing.Size(59, 28);
            this.it_l.TabIndex = 42;
            this.it_l.Text = "アイテム\r\nテクスチャ";
            this.it_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // it_tb
            // 
            this.it_tb.Location = new System.Drawing.Point(1072, 87);
            this.it_tb.Name = "it_tb";
            this.it_tb.Size = new System.Drawing.Size(100, 19);
            this.it_tb.TabIndex = 43;
            this.it_tb.Visible = false;
            // 
            // itn_tb
            // 
            this.itn_tb.Location = new System.Drawing.Point(1072, 112);
            this.itn_tb.Name = "itn_tb";
            this.itn_tb.Size = new System.Drawing.Size(100, 19);
            this.itn_tb.TabIndex = 44;
            this.itn_tb.Visible = false;
            // 
            // is_cb
            // 
            this.is_cb.AutoSize = true;
            this.is_cb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.is_cb.ForeColor = System.Drawing.Color.White;
            this.is_cb.Location = new System.Drawing.Point(1025, 218);
            this.is_cb.Name = "is_cb";
            this.is_cb.Size = new System.Drawing.Size(15, 14);
            this.is_cb.TabIndex = 45;
            this.is_cb.UseVisualStyleBackColor = true;
            this.is_cb.CheckedChanged += new System.EventHandler(this.is_cb_CheckedChanged);
            // 
            // idn_tb
            // 
            this.idn_tb.BackColor = System.Drawing.Color.Gray;
            this.idn_tb.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idn_tb.ForeColor = System.Drawing.Color.White;
            this.idn_tb.Location = new System.Drawing.Point(908, 353);
            this.idn_tb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.idn_tb.Name = "idn_tb";
            this.idn_tb.Size = new System.Drawing.Size(200, 21);
            this.idn_tb.TabIndex = 46;
            // 
            // idn_l
            // 
            this.idn_l.AutoSize = true;
            this.idn_l.BackColor = System.Drawing.Color.Transparent;
            this.idn_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idn_l.ForeColor = System.Drawing.Color.White;
            this.idn_l.Location = new System.Drawing.Point(849, 354);
            this.idn_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.idn_l.Name = "idn_l";
            this.idn_l.Size = new System.Drawing.Size(49, 14);
            this.idn_l.TabIndex = 47;
            this.idn_l.Text = "表示名";
            this.idn_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ifs_l
            // 
            this.ifs_l.AutoSize = true;
            this.ifs_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ifs_l.ForeColor = System.Drawing.Color.White;
            this.ifs_l.Location = new System.Drawing.Point(703, 515);
            this.ifs_l.Name = "ifs_l";
            this.ifs_l.Size = new System.Drawing.Size(104, 14);
            this.ifs_l.TabIndex = 48;
            this.ifs_l.Text = "アイテム生成OFF";
            // 
            // mss_l
            // 
            this.mss_l.AutoSize = true;
            this.mss_l.BackColor = System.Drawing.Color.Transparent;
            this.mss_l.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mss_l.ForeColor = System.Drawing.Color.White;
            this.mss_l.Location = new System.Drawing.Point(1001, 267);
            this.mss_l.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mss_l.Name = "mss_l";
            this.mss_l.Size = new System.Drawing.Size(49, 14);
            this.mss_l.TabIndex = 49;
            this.mss_l.Text = "所持数";
            this.mss_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mss_nud
            // 
            this.mss_nud.BackColor = System.Drawing.Color.Gray;
            this.mss_nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mss_nud.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mss_nud.ForeColor = System.Drawing.Color.White;
            this.mss_nud.Location = new System.Drawing.Point(1058, 266);
            this.mss_nud.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.mss_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mss_nud.Name = "mss_nud";
            this.mss_nud.Size = new System.Drawing.Size(50, 21);
            this.mss_nud.TabIndex = 50;
            this.mss_nud.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // lb_cb
            // 
            this.lb_cb.Appearance = System.Windows.Forms.Appearance.Button;
            this.lb_cb.Image = global::custom_block_c.Properties.Resources.file_btn;
            this.lb_cb.Location = new System.Drawing.Point(600, 231);
            this.lb_cb.Name = "lb_cb";
            this.lb_cb.Size = new System.Drawing.Size(60, 60);
            this.lb_cb.TabIndex = 52;
            this.lb_cb.UseVisualStyleBackColor = true;
            this.lb_cb.CheckedChanged += new System.EventHandler(this.lb_cb_CheckedChanged);
            // 
            // bs_cb
            // 
            this.bs_cb.AutoSize = true;
            this.bs_cb.Checked = true;
            this.bs_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bs_cb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.bs_cb.ForeColor = System.Drawing.Color.White;
            this.bs_cb.Location = new System.Drawing.Point(499, 207);
            this.bs_cb.Name = "bs_cb";
            this.bs_cb.Size = new System.Drawing.Size(15, 14);
            this.bs_cb.TabIndex = 53;
            this.bs_cb.UseVisualStyleBackColor = true;
            this.bs_cb.CheckedChanged += new System.EventHandler(this.bs_cb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 14);
            this.label1.TabIndex = 54;
            this.label1.Text = "名前空間はブロックとアイテムで共通です";
            // 
            // bfs_l
            // 
            this.bfs_l.AutoSize = true;
            this.bfs_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.bfs_l.ForeColor = System.Drawing.Color.White;
            this.bfs_l.Location = new System.Drawing.Point(703, 501);
            this.bfs_l.Name = "bfs_l";
            this.bfs_l.Size = new System.Drawing.Size(93, 14);
            this.bfs_l.TabIndex = 55;
            this.bfs_l.Text = "ブロック生成ON";
            // 
            // bt_cb
            // 
            this.bt_cb.AutoSize = true;
            this.bt_cb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cb.Checked = true;
            this.bt_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bt_cb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.bt_cb.ForeColor = System.Drawing.Color.White;
            this.bt_cb.Location = new System.Drawing.Point(363, 404);
            this.bt_cb.Name = "bt_cb";
            this.bt_cb.Size = new System.Drawing.Size(15, 14);
            this.bt_cb.TabIndex = 56;
            this.bt_cb.UseVisualStyleBackColor = true;
            // 
            // block_ltex
            // 
            this.block_ltex.BackColor = System.Drawing.Color.Gray;
            this.block_ltex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block_ltex.Location = new System.Drawing.Point(514, 369);
            this.block_ltex.Name = "block_ltex";
            this.block_ltex.Size = new System.Drawing.Size(80, 80);
            this.block_ltex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block_ltex.TabIndex = 57;
            this.block_ltex.TabStop = false;
            this.block_ltex.Visible = false;
            this.block_ltex.DragDrop += new System.Windows.Forms.DragEventHandler(this.block_ltex_DragDrop);
            this.block_ltex.DragEnter += new System.Windows.Forms.DragEventHandler(this.block_ltex_DragEnter);
            // 
            // ltex_l
            // 
            this.ltex_l.AllowDrop = true;
            this.ltex_l.AutoSize = true;
            this.ltex_l.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ltex_l.ForeColor = System.Drawing.Color.White;
            this.ltex_l.Location = new System.Drawing.Point(473, 373);
            this.ltex_l.Name = "ltex_l";
            this.ltex_l.Size = new System.Drawing.Size(35, 28);
            this.ltex_l.TabIndex = 58;
            this.ltex_l.Text = "上面\r\n底面";
            this.ltex_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ltex_l.Visible = false;
            // 
            // lbt_fp_tb
            // 
            this.lbt_fp_tb.Location = new System.Drawing.Point(1072, 137);
            this.lbt_fp_tb.Name = "lbt_fp_tb";
            this.lbt_fp_tb.Size = new System.Drawing.Size(100, 19);
            this.lbt_fp_tb.TabIndex = 59;
            this.lbt_fp_tb.Visible = false;
            // 
            // lbt_fn_tb
            // 
            this.lbt_fn_tb.Location = new System.Drawing.Point(1072, 162);
            this.lbt_fn_tb.Name = "lbt_fn_tb";
            this.lbt_fn_tb.Size = new System.Drawing.Size(100, 19);
            this.lbt_fn_tb.TabIndex = 60;
            this.lbt_fn_tb.Visible = false;
            // 
            // block_lb
            // 
            this.block_lb.BackColor = System.Drawing.Color.Gray;
            this.block_lb.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.block_lb.ForeColor = System.Drawing.Color.White;
            this.block_lb.FormattingEnabled = true;
            this.block_lb.HorizontalScrollbar = true;
            this.block_lb.Location = new System.Drawing.Point(666, 231);
            this.block_lb.Name = "block_lb";
            this.block_lb.ScrollAlwaysVisible = true;
            this.block_lb.Size = new System.Drawing.Size(141, 147);
            this.block_lb.TabIndex = 61;
            // 
            // fp_cb
            // 
            this.fp_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fp_cb.FormattingEnabled = true;
            this.fp_cb.Location = new System.Drawing.Point(12, 12);
            this.fp_cb.Name = "fp_cb";
            this.fp_cb.Size = new System.Drawing.Size(121, 20);
            this.fp_cb.TabIndex = 63;
            // 
            // folder_open_btn
            // 
            this.folder_open_btn.Location = new System.Drawing.Point(455, 504);
            this.folder_open_btn.Name = "folder_open_btn";
            this.folder_open_btn.Size = new System.Drawing.Size(32, 32);
            this.folder_open_btn.TabIndex = 64;
            this.folder_open_btn.Text = "button1";
            this.folder_open_btn.UseVisualStyleBackColor = true;
            this.folder_open_btn.Click += new System.EventHandler(this.folder_open_btn_Click);
            // 
            // main_f
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.folder_open_btn);
            this.Controls.Add(this.fp_cb);
            this.Controls.Add(this.block_lb);
            this.Controls.Add(this.lbt_fn_tb);
            this.Controls.Add(this.lbt_fp_tb);
            this.Controls.Add(this.ltex_l);
            this.Controls.Add(this.block_ltex);
            this.Controls.Add(this.bt_cb);
            this.Controls.Add(this.bfs_l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bs_cb);
            this.Controls.Add(this.lb_cb);
            this.Controls.Add(this.mss_nud);
            this.Controls.Add(this.mss_l);
            this.Controls.Add(this.ifs_l);
            this.Controls.Add(this.idn_l);
            this.Controls.Add(this.idn_tb);
            this.Controls.Add(this.is_cb);
            this.Controls.Add(this.itn_tb);
            this.Controls.Add(this.it_tb);
            this.Controls.Add(this.it_l);
            this.Controls.Add(this.it_pb);
            this.Controls.Add(this.in_l);
            this.Controls.Add(this.in_tb);
            this.Controls.Add(this.is_l);
            this.Controls.Add(this.bs_l);
            this.Controls.Add(this.ms_l);
            this.Controls.Add(this.pv_nud);
            this.Controls.Add(this.pv_l);
            this.Controls.Add(this.pd_tb);
            this.Controls.Add(this.pd_l);
            this.Controls.Add(this.pi_l);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dt_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.le_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_tex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pv_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.it_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mss_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_ltex)).EndInit();
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
        private Label pi_l;
        private Label pd_l;
        private TextBox pd_tb;
        private Label pv_l;
        private NumericUpDown pv_nud;
        private Label ms_l;
        private Label bs_l;
        private Label is_l;
        private TextBox in_tb;
        private Label in_l;
        private PictureBox it_pb;
        private Label it_l;
        private TextBox it_tb;
        private TextBox itn_tb;
        private CheckBox is_cb;
        private TextBox idn_tb;
        private Label idn_l;
        private Label ifs_l;
        private Label mss_l;
        private NumericUpDown mss_nud;
        private CheckBox lb_cb;
        private CheckBox bs_cb;
        private Label label1;
        private Label bfs_l;
        private CheckBox bt_cb;
        private PictureBox block_ltex;
        private Label ltex_l;
        private TextBox lbt_fp_tb;
        private TextBox lbt_fn_tb;
        private ListBox block_lb;
        private ComboBox fp_cb;
        private Button folder_open_btn;
    }
}

