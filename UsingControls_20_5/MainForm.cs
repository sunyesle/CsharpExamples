using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControls_20_5
{
    public partial class MainForm : Form
    {
        Random random = new Random(37);

        public MainForm()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);
        }

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;

            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, style);
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void tbDummy_Scroll_1(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();   // Modal 창을 띄움
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show(); // Modaless 창을 띄움
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "MessageBox Test", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
        }

        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
                TreeToList(node);
        }

        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(
                new ListViewItem(
                    new string[] { Node.Text,
                    // 경로에 있는 \ 갯수를 세서 depth 알아냄
                    Node.FullPath.Count(f => f == '\\').ToString() }));

            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if(tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.",
                    "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}
