using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_block_c
{
    public partial class main_f : Form
    {
        public main_f()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bi_text_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("../../../出力先");
            Directory.CreateDirectory("../../../出力先/blocks");
            Encoding enc = Encoding.UTF8;
            string name_space = ns_tb.Text;
            string block_name = bn_tb.Text;
            string block_id = $"{name_space}:{block_name}";
            string block_le = le_l.Text;
            string filepash = $"../../../出力先/blocks/{block_name}.json";
            using (FileStream fs_b = File.Create(filepash));
            StreamReader sr_od_b = new StreamReader("original_data/block.json");
            string od_b = sr_od_b.ReadToEnd();
            sr_od_b.Close();
            System.Text.StringBuilder sb_b = new System.Text.StringBuilder(od_b);
            sb_b.Replace("block_id",$"{block_id}");
            sb_b.Replace("block_name", $"{block_name}");
            //sb_b.Replace("block_tex", $"{block_tex}");
            string block_json = sb_b.ToString();
            StreamWriter writer = new StreamWriter(filepash,true,enc);
            writer.WriteLine(block_json);
            writer.Close();
        }

        private void main_f_Load(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}