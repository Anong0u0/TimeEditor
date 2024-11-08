using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeEditor
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            createTime.Value = DateTime.Now - TimeSpan.FromDays(730) + TimeSpan.FromSeconds(r.Next(10, 45000000));
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string v in s)
                if (File.GetAttributes(v).HasFlag(FileAttributes.Directory))
                {
                    foreach (string v2 in Directory.GetFiles(v))
                        if (!listBox.Items.Contains(v2))
                            listBox.Items.Add(v2);
                }
                else if (!listBox.Items.Contains(v))
                {
                    listBox.Items.Add(v);
                }

            label2.Text = "已匯入檔案:   (Del or 雙擊刪除) (Ctrl多選)";
        }
        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "任何檔案|*.*";
                ofd.Title = "選擇要開啟的檔案";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string v in ofd.FileNames)
                        if(!listBox.Items.Contains(v))
                            listBox.Items.Add(v);
                    label2.Text = "已匯入檔案:   (Del or 雙擊刪除) (Ctrl多選)";
                }
            }
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                if(listBox.Items.Count==0) label2.Text = "未匯入檔案";
            }
        }
        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back ||e.KeyCode == Keys.Decimal))
                return;
            List<object> oli = new List<object>();
            foreach (var o in listBox.SelectedItems)
                oli.Add(o);
            foreach (var s in oli)
                listBox.Items.Remove(s);
            if (listBox.Items.Count == 0) label2.Text = "未匯入檔案";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeTime.Value = DateTime.Now - TimeSpan.FromMinutes((double)numericUpDown1.Value) + TimeSpan.FromSeconds(r.Next(10, (int)numericUpDown1.Value*55));
            accessTime.Value = writeTime.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (createCheck.Checked && accessCheck.Checked & writeCheck.Checked)
            {
                MessageBox.Show("未修改任何日期", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            List<FileInfo> fli = new List<FileInfo>();
            foreach (string s in listBox.SelectedItems)
                fli.Add(new FileInfo(s));
            fli.ForEach((f) =>
            {
                if(createTime.Enabled) f.CreationTime = createTime.Value;
                if (writeTime.Enabled) f.LastWriteTime = writeTime.Value;
                if (accessTime.Enabled) f.LastAccessTime = accessTime.Value;
            });
            MessageBox.Show("已修改:" +
                (createTime.Enabled ? "\n建立日期" : "") +
                (writeTime.Enabled ? "\n修改日期" : "") +
                (accessTime.Enabled ? "\n存取日期" : ""), "提示", MessageBoxButtons.OK);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            save.Enabled = listBox.SelectedItem != null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            createTime.Enabled = !createCheck.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            writeTime.Enabled = !writeCheck.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            accessTime.Enabled = !accessCheck.Checked;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(writeTime.Value<accessTime.Value)
                accessTime.Value = writeTime.Value;
            else
                writeTime.Value = accessTime.Value;
        }

        private void writeTime_ValueChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) accessTime.Value = writeTime.Value;
        }

        private void accessTime_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) writeTime.Value = accessTime.Value;
        }
    }
}
