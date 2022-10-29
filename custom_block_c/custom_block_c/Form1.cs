using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fp_folder = folder_tb.Text;
            Directory.CreateDirectory($"{fp_folder}/custom_block");
            string fp_beh = $"{fp_folder}/custom_block/behavior";
            string fp_res = $"{fp_folder}/custom_block/resource";
            Directory.CreateDirectory(fp_beh);
            Directory.CreateDirectory($"{fp_beh}/blocks");
            Directory.CreateDirectory($"{fp_beh}/loot_tables");
            Directory.CreateDirectory(fp_res);
            Directory.CreateDirectory($"{fp_res}/textures");
            Directory.CreateDirectory($"{fp_res}/texts");
            string fp_tex = $"{fp_res}/textures/blocks";
            Directory.CreateDirectory(fp_tex);
            string name_space = ns_tb.Text;
            string block_name = bn_tb.Text;
            string block_id = $"{name_space}:{block_name}";
            string fp_t = bt_tb.Text;
            string tex_name = tn_tb.Text;
            string block_tl = tl_tb.Text;
            string block_le = le_nud.Text;
            string block_dt = dt_nud.Text;
            string block_er = er_nud.Text;
            string fp_bt = $"{fp_tex}\\{tex_name}.png";
            if (System.IO.File.Exists(fp_bt))
            {
                Message message = new Message();
            }
            else
            {
                File.Copy($@"{fp_t}", $@"{fp_bt}");
            }
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
            StreamWriter bj_w = new StreamWriter(fp_b,true);
            bj_w.Write(block_json);
            bj_w.Close();
            string fp_l = $"{fp_beh}/loot_tables/{block_name}_loot.json";
            using (FileStream fs_l = File.Create(fp_l)) ;
            StreamReader sr_od_l = new StreamReader("original_data/block_loot.json");
            string od_l = sr_od_l.ReadToEnd();
            sr_od_l.Close();
            System.Text.StringBuilder sb_l = new System.Text.StringBuilder(od_l);
            sb_l.Replace("block_id", $"{block_id}");
            string loot_json = sb_l.ToString();
            StreamWriter lj_w = new StreamWriter(fp_l, true);
            lj_w.Write(loot_json);
            lj_w.Close();
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
                sb_tj.Replace("name_space", $"{name_space}");
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
                sb_tj.Replace("name_space", $"{name_space}");
                sb_tj.Replace("  }", $"{tex_tj}");
                string texture_json = sb_tj.ToString();
                StreamWriter tj_w = new StreamWriter(fp_tj, true);
                tj_w.Write(texture_json);
                tj_w.Close();
            }
            string fp_tl = $"{fp_res}/texts/ja_JP.lang";
            if (System.IO.File.Exists(fp_tl))
            {
                StreamWriter tl_w = new StreamWriter(fp_tl, true);
                tl_w.Write($"\ntile.{block_id}.name = {block_tl}");
                tl_w.Close();
            }
            else
            {
                using (FileStream fs_tl = File.Create(fp_tl)) ;
                StreamWriter tl_w = new StreamWriter(fp_tl, true);
                tl_w.Write($"tile.{block_id}.name = {block_tl}");
                tl_w.Close();
            }
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
            // １、２どちらでもよい
            block_tex.ImageLocation = fileName;//１
            block_tex.Image = new Bitmap(fileName);//２
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                string texpash = files[i];
                bt_tb.Text = texpash;
                tn_tb.Text = Path.GetFileNameWithoutExtension(texpash);
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
    }
}