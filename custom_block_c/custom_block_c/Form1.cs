﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace custom_block_c
{
    public partial class main_f : Form
    {
        public main_f()
        {
            this.Load += main_load;
            InitializeComponent();
            block_tex.AllowDrop = true;
            pi_pb.AllowDrop = true;
            it_pb.AllowDrop = true;
            block_ltex.AllowDrop = true;
        }
        public void done_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(folder_tb.Text) == true)
            {
                MessageBox.Show("保存先のファイルを指定してください", "警告");
                return;
            }
            string fp_folder = folder_tb.Text;//保存先フォルダーパス
            Directory.CreateDirectory($"{fp_folder}/custom_block");//保存フォルダ作成
            string pack_name = pn_tb.Text;//パック名取得
            string fp_beh = $"{fp_folder}/custom_block/{pack_name}_b";//ビヘイビアーファイルパス
            string fp_res = $"{fp_folder}/custom_block/{pack_name}_r";//リソースファイルパス
            Directory.CreateDirectory(fp_beh);//ビヘイビアーフォルダ作成
            Directory.CreateDirectory($"{fp_beh}/loot_tables");//ルートテーブルフォルダ作成
            Directory.CreateDirectory(fp_res);//リソースフォルダ作成
            Directory.CreateDirectory($"{fp_res}/textures");//テクスチャフォルダ作成
            Directory.CreateDirectory($"{fp_res}/texts");//言語フォルダ作成
            string name_space = ns_tb.Text;//名前空間取得
            if (bs_cb.Checked == true)//ブロックファイル生成
            {
                Directory.CreateDirectory($"{fp_beh}/blocks");//ブロックフォルダ作成
                string fp_rtb = $"{fp_res}/textures/blocks";//ブロックテクスチャフォルダパス
                Directory.CreateDirectory(fp_rtb);//ブロックテクスチャフォルダ作成
                string block_name = bn_tb.Text;//ブロック名取得
                string block_id = $"{name_space}:{block_name}";//ブロックID生成
                if(fp_cb.Items.Count < 2)
                {
                    MessageBox.Show("ブロックのテクスチャが指定されていません。", "警告", MessageBoxButtons.OK);
                    return;
                }
                fp_cb.SelectedIndex = 1;//ブロックテクスチャパスにリストを設定
                string fp_t = fp_cb.SelectedItem.ToString();//ブロックテクスチャ元画像パス
                if (bt_cb.Checked == true)
                {
                    tn_tb.Text = $"{block_name}";//元画像をブロック名に改名
                }
                string tex_name = tn_tb.Text;//ブロックテクスチャ画像名取得
                if(string.IsNullOrEmpty(tn_tb.Text) == true)
                {
                    MessageBox.Show("ブロックの画像が指定されていません。", "警告");
                    return;
                }
                string fp_lbt = lbt_fp_tb.Text;//柱ブロックテクスチャ取得
                if (lb_cb.Checked == true)
                {
                    if (bt_cb.Checked == true)
                    {
                        lbt_fn_tb.Text = $"{block_name}_t";//元画像をブロック名に改名b
                    }
                }
                string lbt_name = lbt_fn_tb.Text;//柱ブロックテクスチャ画像名取得
                string block_tl = tl_tb.Text;//ブロックの表示名
                string block_le = le_nud.Text;//明るさ
                string block_dt = dt_nud.Text;//破壊時間
                string block_er = er_nud.Text;//爆発耐性
                string fp_bt = $"{fp_rtb}\\{tex_name}.png";//画像パス
                if(string.IsNullOrEmpty(fp_bt) == true)
                {
                    MessageBox.Show("ブロックのテクスチャを選択してください", "警告", MessageBoxButtons.OK);
                    return;
                }
                if (System.IO.File.Exists(fp_bt) == false)//画像の存在を確認
                {
                    File.Copy($@"{fp_t}", $@"{fp_bt}");//画像が無かったらコピー
                }
                if (lb_cb.Checked == true)
                {
                    if (System.IO.File.Exists(fp_lbt) == false)//柱ブロックの画像の存在を確認
                    {
                        File.Copy($@"{fp_t}", $@"{fp_lbt}");//柱ブロック画像が無かったらコピー
                    }
                }
                //
                //block.json生成
                //
                string fp_b = $"{fp_beh}/blocks/{block_name}.json";
                using (FileStream fs_b = File.Create(fp_b)) ;
                StreamReader sr_od_b = new StreamReader("original_data/block.json");
                string od_b = sr_od_b.ReadToEnd();
                sr_od_b.Close();
                System.Text.StringBuilder sb_b = new System.Text.StringBuilder(od_b);
                sb_b.Replace("block_id", $"{block_id}");
                sb_b.Replace("block_name", $"{block_name}");
                sb_b.Replace("block_tex", $"{tex_name}");
                sb_b.Replace("block_le", $"{block_le}");
                sb_b.Replace("block_dt", $"{block_dt}");
                sb_b.Replace("block_er", $"{block_er}");
                string block_json = sb_b.ToString();
                StreamWriter sw_bj = new StreamWriter(fp_b, true);
                sw_bj.Write(block_json);
                sw_bj.Close();
                //
                //block_loot.json生成
                //
                string fp_l = $"{fp_beh}/loot_tables/{block_name}_loot.json";
                using (FileStream fs_l = File.Create(fp_l)) ;
                StreamReader sr_od_l = new StreamReader("original_data/block_loot.json");
                string od_l = sr_od_l.ReadToEnd();
                sr_od_l.Close();
                System.Text.StringBuilder sb_l = new System.Text.StringBuilder(od_l);
                sb_l.Replace("block_id", $"{block_id}");
                string loot_json = sb_l.ToString();
                StreamWriter sw_lj = new StreamWriter(fp_l, true);
                sw_lj.Write(loot_json);
                sw_lj.Close();
                //
                //terrain_texture.jsonの編集
                //
                string fp_tj = $"{fp_res}/textures/terrain_texture.json";//terrain_texture.jsonパス
                if (System.IO.File.Exists(fp_tj))//terrain_textureの存在を確認
                {
                    StreamReader sr_od_tj = new StreamReader(fp_tj);
                    string od_tj = sr_od_tj.ReadToEnd();
                    sr_od_tj.Close();
                    File.Delete(fp_tj);
                    using (FileStream fs_tj = File.Create(fp_tj)) ;
                    System.Text.StringBuilder sb_tj = new System.Text.StringBuilder(od_tj);
                    string tex_tj = $"\"}},\n    \"{tex_name}\":{{\"textures\":\"textures/blocks/{tex_name}\"}}\n  }}";//追加内容
                    sb_tj.Replace("\"}\n  }", $"{tex_tj}");
                    if (lb_cb.Checked == true)//柱ブロック有効確認
                    {
                        string lb_tj = $"\"}},\n    \"{lbt_name}\":{{\"textures\":\"textures/blocks/{lbt_name}\"}}\n  }}";
                        sb_tj.Replace("\"}\n  }", $"{lb_tj}");
                        string texture_json = sb_tj.ToString();
                        StreamWriter tj_w = new StreamWriter(fp_tj, true);
                        tj_w.Write(texture_json);
                        tj_w.Close();
                    }
                    else//柱ブロック無効
                    {
                        string texture_json = sb_tj.ToString();//
                        StreamWriter tj_w = new StreamWriter(fp_tj, true);//書き込み内容
                        tj_w.Write(texture_json);//書き込み
                        tj_w.Close();//streamwriter閉じる
                    }
                }
                else//terrain_texture.jsonを新規作成
                {
                    using (FileStream fs_tj = File.Create(fp_tj)) ;//
                    StreamReader sr_od_tj = new StreamReader("original_data/terrain_texture.json");
                    string od_tj = sr_od_tj.ReadToEnd();
                    sr_od_tj.Close();
                    System.Text.StringBuilder sb_tj = new System.Text.StringBuilder(od_tj);
                    string tex_tj = $"    \"{tex_name}\": {{\"textures\":\"textures/blocks/{tex_name}\"}}\n  }}";//追加内容
                    sb_tj.Replace("pack_name", $"{pack_name}");
                    sb_tj.Replace("  }", $"{tex_tj}");
                    if (lb_cb.Checked == true)
                    {
                        string lb_tj = $"\"}},\n    \"{lbt_name}\":{{\"textures\":\"textures/blocks/{lbt_name}\"}}\n  }}";
                        sb_tj.Replace("\"}\n  }", $"{lb_tj}");
                        string texture_json = sb_tj.ToString();
                        StreamWriter tj_w = new StreamWriter(fp_tj, true);
                        tj_w.Write(texture_json);
                        tj_w.Close();
                    }
                    else
                    {
                        string texture_json = sb_tj.ToString();
                        StreamWriter tj_w = new StreamWriter(fp_tj, true);
                        tj_w.Write(texture_json);
                        tj_w.Close();
                    }
                }
                //
                //ブロック名ja_JP.lang
                //
                string fp_tl = $"{fp_res}/texts/ja_JP.lang";
                if (System.IO.File.Exists(fp_tl))
                {
                    StreamWriter sw_tl = new StreamWriter(fp_tl, true);
                    sw_tl.Write($"\ntile.{block_id}.name={block_tl}");
                    sw_tl.Close();
                }
                else
                {
                    using (FileStream fs_tl = File.Create(fp_tl)) ;
                    StreamWriter sw_tl = new StreamWriter(fp_tl, true);
                    sw_tl.Write($"tile.{block_id}.name={block_tl}");
                    sw_tl.Close();
                }
            }
            if (is_cb.Checked == true) //アイテム
            {
                //
                //アイテム設定
                //
                Directory.CreateDirectory($"{fp_beh}/items");
                string fp_rti = $"{fp_res}/textures/items";
                Directory.CreateDirectory(fp_rti);
                string item_name = in_tb.Text;
                string item_id = $"{name_space}:{item_name}";
                string item_tex = itn_tb.Text;
                string item_dn = idn_tb.Text;
                string item_mss = mss_nud.Text;
                string fp_it = it_tb.Text;
                string fp_itn = $"{fp_rti}\\{item_tex}.png";
                if (System.IO.File.Exists(fp_itn) == false)
                {
                    File.Copy($@"{fp_it}", $@"{fp_itn}");
                }
                //
                //item.json生成
                //
                string fp_i = $"{fp_beh}/items/{item_name}.json";
                using (FileStream fs_i = File.Create(fp_i)) ;
                StreamReader sr_od_i = new StreamReader("original_data/item.json");
                string od_i = sr_od_i.ReadToEnd();
                sr_od_i.Close();
                System.Text.StringBuilder sb_i = new System.Text.StringBuilder(od_i);
                sb_i.Replace("item_id", $"{item_id}");
                sb_i.Replace("item_tex", $"{item_tex}");
                sb_i.Replace("item_dn", $"{item_dn}");
                sb_i.Replace("item_mss", $"{item_mss}");
                string item_json = sb_i.ToString();
                StreamWriter sw_ij = new StreamWriter(fp_i, true);
                sw_ij.Write(item_json);
                sw_ij.Close();
                //
                //item_texture.json編集
                //
                string fp_itj = $"{fp_res}/textures/item_texture.json";
                if (System.IO.File.Exists(fp_itj))
                {
                    StreamReader sr_od_tj = new StreamReader(fp_itj);
                    string od_itj = sr_od_tj.ReadToEnd();
                    sr_od_tj.Close();
                    File.Delete(fp_itj);
                    using (FileStream fs_tj = File.Create(fp_itj)) ;
                    string tex_tj = $"\"}},\n    \"{item_tex}\":{{\"textures\":\"textures/items/{item_tex}\"}}\n  }}";
                    System.Text.StringBuilder sb_tj = new System.Text.StringBuilder(od_itj);
                    sb_tj.Replace("\"}\n  }", $"{tex_tj}");
                    string item_tex_json = sb_tj.ToString();
                    StreamWriter tj_w = new StreamWriter(fp_itj, true);
                    tj_w.Write(item_tex_json);
                    tj_w.Close();
                }
                else
                {
                    using (FileStream fs_tj = File.Create(fp_itj)) ;
                    StreamReader sr_od_itj = new StreamReader("original_data/terrain_texture.json");
                    string od_tj = sr_od_itj.ReadToEnd();
                    sr_od_itj.Close();
                    string tex_tj = $"    \"{item_tex}\":{{\"textures\":\"textures/items/{item_tex}\"}}\n  }}";
                    System.Text.StringBuilder sb_tj = new System.Text.StringBuilder(od_tj);
                    sb_tj.Replace("pack_name", $"{pack_name}");
                    sb_tj.Replace("  }", $"{tex_tj}");
                    string item_tex_json = sb_tj.ToString();
                    StreamWriter sw_itj = new StreamWriter(fp_itj, true);
                    sw_itj.Write(item_tex_json);
                    sw_itj.Close();
                }
            }
            //
            //manifest
            //
            string pack_desc = pd_tb.Text;//パック説明
            string pack_ver = pv_nud.Text;//パックバージョン
            if (pi_pb.Image == null)
            {
                MessageBox.Show("パックアイコンの画像を指定してください。", "警告", MessageBoxButtons.OK);
                return;
            }
            string fp_mb = $"{fp_beh}/manifest.json";
            using (FileStream fs_mb = File.Create(fp_mb)) ;
            Guid ub_od_1 = Guid.NewGuid();
            string uuid_1_b = ub_od_1.ToString();
            Guid ub_od_2 = Guid.NewGuid();
            string uuid_2_b = ub_od_2.ToString();
            StreamReader sr_od_mb = new StreamReader("original_data/manifest_b.json");
            string od_mb = sr_od_mb.ReadToEnd();
            System.Text.StringBuilder sb_mb = new System.Text.StringBuilder(od_mb);
            sb_mb.Replace("pack_name", $"{pack_name}");
            sb_mb.Replace("pack_desc", $"{pack_desc}");
            sb_mb.Replace("pack_ver", $"{pack_ver}");
            sb_mb.Replace("uuid_1_b", $"{uuid_1_b}");
            sb_mb.Replace("uuid_2_b", $"{uuid_2_b}");
            string manifest_beh = sb_mb.ToString();
            StreamWriter sw_mb = new StreamWriter(fp_mb, true);
            sw_mb.Write(manifest_beh);
            sw_mb.Close();
            string fp_mr = $"{fp_res}/manifest.json";
            using (FileStream fs_mr = File.Create(fp_mr)) ;
            Guid ur_od_1 = Guid.NewGuid();
            string uuid_1_r = ur_od_1.ToString();
            Guid ur_od_2 = Guid.NewGuid();
            string uuid_2_r = ur_od_2.ToString();
            StreamReader sr_od_mr = new StreamReader("original_data/manifest_r.json");
            string od_mr = sr_od_mr.ReadToEnd();
            System.Text.StringBuilder sb_mr = new System.Text.StringBuilder(od_mr);
            sb_mr.Replace("pack_name", $"{pack_name}");
            sb_mr.Replace("pack_desc", $"{pack_desc}");
            sb_mr.Replace("pack_ver", $"{pack_ver}");
            sb_mr.Replace("uuid_1_r", $"{uuid_1_r}");
            sb_mr.Replace("uuid_2_r", $"{uuid_2_r}");
            string manifest_res = sb_mr.ToString();
            StreamWriter sw_mr = new StreamWriter(fp_mr, true);
            sw_mr.Write(manifest_res);
            sw_mr.Close();

            //メッセージ
            MessageBox.Show("ファイルが生成されました", "ファイル生成", MessageBoxButtons.OK);
        }
        private void block_tex_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void block_tex_DragDrop(object sender, DragEventArgs e)
        {
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            block_tex.ImageLocation = fileName;
            block_tex.Image = new Bitmap(fileName);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                string block_op = files[i];
                fp_cb.Items.Insert(1,block_op);
                tn_tb.Text = Path.GetFileNameWithoutExtension(block_op);
            }
        }
        private void pi_pb_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void pi_pb_DragDrop(object sender, DragEventArgs e)
        {
            string pi_fn = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            pi_pb.ImageLocation = pi_fn;
            pi_pb.Image = new Bitmap(pi_fn);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                fp_cb.Items.Insert(0, files[i]);//パックアイコン元データパス
            }

        }
        private void it_pb_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void it_pb_DragDrop(object sender, DragEventArgs e)
        {
            string it_fn = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            it_pb.ImageLocation = it_fn;
            it_pb.Image = new Bitmap(it_fn);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                string fp_it = files[i];
                it_tb.Text = fp_it;
                itn_tb.Text = Path.GetFileNameWithoutExtension(fp_it);
            }
        }
        private void block_ltex_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void block_ltex_DragDrop(object sender, DragEventArgs e)//柱ブロックテクスチャ設定
        {
            string fd_lbt = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            block_ltex.ImageLocation = fd_lbt;
            block_ltex.Image = new Bitmap(fd_lbt);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                string fp_lbt= files[i];
                lbt_fp_tb.Text = fp_lbt;
                lbt_fn_tb.Text = Path.GetFileNameWithoutExtension(fp_lbt);
            }
        }
        private void file_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "保存先のフォルダを指定してください";
            folder.RootFolder = Environment.SpecialFolder.Desktop;
            folder.SelectedPath = @"C:\Windows";
            folder.ShowNewFolderButton = true;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                folder_tb.Text = folder.SelectedPath;
            }
        }

        private void block_tex_click(object sender, EventArgs e)
        {
            OpenFileDialog bt_ofd = new OpenFileDialog();
            bt_ofd.InitialDirectory = @"C:\User\Pictures\";
            bt_ofd.Title = "ブロックのテクスチャを選択してください";
            if(bt_ofd.ShowDialog() == DialogResult.OK)
            {
                string block_op = bt_ofd.FileName;
                block_tex.ImageLocation = block_op;
                pi_pb.Image = new Bitmap(block_op);
                if (fp_cb.Items.Count > 1)
                {
                    fp_cb.Items.Insert(1, block_op);
                    tn_tb.Text = Path.GetFileNameWithoutExtension(block_op);
                }
                else
                {
                    MessageBox.Show("pack_iconを選択してください。", "警告", MessageBoxButtons.OK);
                }
            }
        }

        private void is_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (is_cb.Checked == true)
            {
                ifs_l.Text = "アイテム生成ON";
            }
            else
            {
                ifs_l.Text = "アイテム生成OFF";
            }
        }

        private void bs_cb_CheckedChanged(object sender, EventArgs e)
        {
            if(bs_cb.Checked == true)
            {
                bfs_l.Text = "ブロック生成ON";
            }
            else
            {
                bfs_l.Text = "ブロック生成OFF";
            }
        }

        private void lb_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (lb_cb.Checked == true)
            {
                ltex_l.Visible = true;
                block_ltex.Visible = true;
            }
            else
            {
                ltex_l.Visible = false;
                block_ltex.Visible = false;
            }
        }

        private void pi_pb_Click(object sender, EventArgs e)
        {
            OpenFileDialog pi_ofd = new OpenFileDialog();
            pi_ofd.InitialDirectory = @"C:\User\Pictures\";
            pi_ofd.Title = "パックアイコンの画像を選択してください";
            if (pi_ofd.ShowDialog() == DialogResult.OK)
            {
                string pack_icon_pash = pi_ofd.FileName;//パックアイコン画像ファイルパス
                File.Copy($@"{pack_icon_pash}", @"temp\behavior\pack_icon.png");//ビヘイビアーにコピー
                File.Copy($@"{pack_icon_pash}", @"temp\resource\pack_icon.png");//リソースにコピー
                pi_pb.ImageLocation = pack_icon_pash;//ソフト側に反映
                pi_pb.Image = new Bitmap(pack_icon_pash);//picboxにコピーしたpack_iconを反映
            }
        }
        private void folder_open_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folder_tb.Text))// 保存先のフォルダー見るボタン
            {
                MessageBox.Show("保存先のフォルダーが指定されていません。", "警告", MessageBoxButtons.OK);
                return;
            }
            else
            {
                string sf_fp = folder_tb.Text;
                System.Diagnostics.Process.Start(sf_fp);
            }
        }

        private void main_load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"temp");//tempフォルダ作成
            Directory.CreateDirectory(@"temp\behavior");//behavior.tempファイル作成
            Directory.CreateDirectory(@"temp\resource");//resource.tempファイル作成

        }
    }
}