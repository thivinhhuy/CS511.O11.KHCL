using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Doan.RJUserControl;

namespace Doan.Vietbai
{
    public partial class ThemAnh : UserControl
    {
        
        public ThemAnh()
        {
            InitializeComponent();
            rjButton2.Visible = false;
            listView1.Visible = false;
        }

        private void Tat_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            panel.Controls.Remove(this);

        }
        private List<string> Listfile = new List<string>();
        private void rjButton1_Click(object sender, EventArgs e)
        {
            listView1.Visible=true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.mp4)|*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.mp4";
            openFileDialog.Multiselect = true;
            
            rjButton1.Visible = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                foreach (string filePath in openFileDialog.FileNames)
                {


                    string fileExtension = Path.GetExtension(filePath).ToLower();
                    if (fileExtension == ".mp4")
                    {
                        string fileName = Path.GetFileName(filePath);
                        Program.FileThemAnh.video = 0;
                        Listfile.Add(filePath);
                        ListViewItem item = new ListViewItem(fileName);
                        item.Tag = filePath;
                        listView1.Items.Add(item);
                    }
                    else 
                    {
                        string fileName = Path.GetFileName(filePath);

                        // Thêm tên tệp vào ListView
                        ListViewItem item = new ListViewItem(fileName);
                        item.Tag = filePath;

                        // Thêm ảnh vào ImageList
                        Image image = Image.FromFile(filePath);
                        imageList1.Images.Add(image);

                        // Thiết lập chỉ số hình ảnh cho ListViewItem
                        item.ImageIndex = imageList1.Images.Count - 1;
                        Listfile.Add(filePath);
                        listView1.Items.Add(item);
                    }
                }

                Program.FileThemAnh.Fileanh = Listfile;
            }
            rjButton2.Visible=true;

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.Multiselect = true;

            rjButton1.Visible = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);

                    // Thêm tên tệp vào ListView
                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = filePath;

                    // Thêm ảnh vào ImageList
                    Image image = Image.FromFile(filePath);
                    imageList1.Images.Add(image);

                    // Thiết lập chỉ số hình ảnh cho ListViewItem
                    item.ImageIndex = imageList1.Images.Count - 1;

                    listView1.Items.Add(item);
                }
            }
        }

        private void ThemAnh_Load(object sender, EventArgs e)
        {

        }
    }
}
