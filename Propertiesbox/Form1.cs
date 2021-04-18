using System;
using System.Data;
using System.Windows.Forms;

namespace Propertiesbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                comboBox1.Items.Add(((Control)item).Name);
            }
            comboBox1.Hide();
            propertyGrid1.Hide();
            propertyGrid1.SelectedObject = dataGridView1.Rows;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "İd";
            dataGridView1.Columns[1].Name = "Adı";
            dataGridView1.Columns[2].Name = "Numarası";
            dataGridView1.Rows.Add("1", "Ebubekir Bastama", "055547855475555452545");
            dataGridView1.Rows.Add("1", "Fentinar esdidar", "0555478554755551455452545");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selamlar Nasılsınız...","EBS");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize eminmisiniz", "EBS", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                MessageBox.Show("İlgili Mesaj Silindi","EBS");
            }
        }
        bool dgr = true;
        private void kontrolleriAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgr == true)
            {
                propertyGrid1.Show();
                comboBox1.Show();
                dgr = false;
            }
            else
            {
                propertyGrid1.Hide();
                comboBox1.Hide();
                dgr = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (comboBox1.Text == ((Control)item).Name)
                {
                    propertyGrid1.SelectedObject = item;
                }
            }
        }
    }
}
