using System;
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
            InitializeComponent();
            block_tex.AllowDrop = true;
            pi_pb.AllowDrop = true;
            it_pb.AllowDrop = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fp_folder = folder_tb.Text;
            Directory.CreateDirectory($"{fp_folder}/custom_block");
            string pack_name = pn_tb.Text;
            string fp_beh = $"{fp_folder}/custom_block/{pack_name}_b";
            string fp_res = $"{fp_folder}/custom_block/{pack_name}_r";
            Directory.CreateDirectory(fp_beh);
            Directory.CreateDirectory($"{fp_beh}/blocks");
            Directory.CreateDirectory($"{fp_beh}/loot_tables");
            Directory.CreateDirectory(fp_res);
            Directory.CreateDirectory($"{fp_res}/textures");
            Directory.CreateDirectory($"{fp_res}/texts");
            string fp_rtb = $"{fp_res}/textures/blocks";
            Directory.CreateDirectory(fp_rtb);
            string name_space = ns_tb.Text;
            string block_name = bn_tb.Text;
            string block_id = $"{name_space}:{block_name}";
            string fp_t = bt_tb.Text;
            string tex_name = tn_tb.Text;
            string block_tl = tl_tb.Text;
            string block_le = le_nud.Text;
            string block_dt = dt_nud.Text;
            string block_er = er_nud.Text;
            string fp_bt = $"{fp_rtb}\\{tex_name}.png";
            if (System.IO.File.Exists(fp_bt) == false)
            {
                File.Copy($@"{fp_t}", $@"{fp_bt}");
            }
            //
            //manifest
            //
            string pack_desc = pd_tb.Text;
            string pack_ver = pv_nud.Text;
            string fp_od_pi = pi_tb.Text;
            string fp_pi_b = $"{fp_beh}\\pack_icon.png";
            if (System.IO.File.Exists(fp_pi_b) == false)
            {
                File.Copy($@"{fp_od_pi}", $@"{fp_pi_b}");
            }
            string fp_pi_r = $"{fp_res}\\pack_icon.png";
            if (System.IO.File.Exists(fp_pi_r) == false)
            {
                File.Copy($@"{fp_od_pi}", $@"{fp_pi_r}");
            }
            //
            //ブロックファイル生成
            //
            string fp_b = $"{fp_beh}/blocks/{block_name}.json";
            using (FileStream fs_b = File.Create(fp_b)) ;
            StreamReader sr_od_b = new StreamReader("original_data/block.json");
            string od_b = sr_od_b.ReadToEnd();
            sr_od_b.Close();
            System.Text.StringBuilder sb_b = new System.Text.StringBuilder(od_b);
            sb_b.Replace("block_id",$"{block_id}");
            sb_b.Replace("block_name", $"{block_name}");
            sb_b.Replace("block_tex", $"{tex_name}");
            sb_b.Replace("block_le", $"{block_le}");
            sb_b.Replace("block_dt", $"{block_dt}");
            sb_b.Replace("block_er", $"{block_er}");
            string block_json = sb_b.ToString();
            StreamWriter sw_bj = new StreamWriter(fp_b,true);
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
            string fp_tj = $"{fp_res}/textures/terrain_texture.json";
            if (System.IO.File.Exists(fp_tj))
            {
                StreamReader sr_od_tj = new StreamReader(fp_tj);
                string od_tj = sr_od_tj.ReadToEnd();
                sr_od_tj.Close();
                File.Delete(fp_tj);
                using (FileStream fs_tj = File.Create(fp_tj)) ;
                string tex_tj = $"\"}},\n    \"{tex_name}\":{{\"textures\":\"textures/blocks/{tex_name}\"}}\n  }}";
                System.Text.StringBuilder sb_tj = new System.Text.StringBuilder(od_tj);
                sb_tj.Replace("\"}\n  }", $"{tex_tj}");
                string texture_json = sb_tj.ToString();
                StreamWriter tj_w = new StreamWriter(fp_tj, true);
                tj_w.Write(texture_json);
                tj_w.Close();
            }
            else
            {
                using (FileStream fs_tj = File.Create(fp_tj)) ;
                StreamReader sr_od_tj = new StreamReader("original_data/terrain_texture.json");
                string od_tj = sr_od_tj.ReadToEnd();
                sr_od_tj.Close();
                string tex_tj = $"    \"{tex_name}\":{{\"textures\":\"textures/blocks/{tex_name}\"}}\n  }}";
                System.Text.StringBuilder sb_tj = new System.Text.StringBuilder(od_tj);
                sb_tj.Replace("pack_name", $"{pack_name}");
                sb_tj.Replace("  }", $"{tex_tj}");
                string texture_json = sb_tj.ToString();
                StreamWriter tj_w = new StreamWriter(fp_tj, true);
                tj_w.Write(texture_json);
                tj_w.Close();
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
                    string tex_tj = $"    \"{tex_name}\":{{\"textures\":\"textures/items/{item_tex}\"}}\n  }}";
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
            //manifest生成
            //
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
            sb_mb.Replace("pack_desc",$"{pack_desc}");
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
            MessageBox.Show("ファイルが生成されました","ファイル生成", MessageBoxButtons.OK);
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
                string texpash = files[i];
                bt_tb.Text = texpash;
                tn_tb.Text = Path.GetFileNameWithoutExtension(texpash);
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
                string fp_pi = files[i];
                pi_tb.Text = fp_pi;
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
        private void file_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "保存先のフォルダを指定してください";
            folder.RootFolder = Environment.SpecialFolder.Desktop;
            folder.SelectedPath = @"C:\Windows";
            folder.ShowNewFolderButton = true;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                folder_tb.Text=folder.SelectedPath;
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

        private void lb_btn_Click(object sender, EventArgs e)
        {

        }
    }
}