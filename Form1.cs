using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
        //    try
         //   {
        //        panel.Enabled = true;
        //        txtName.Focus();
        //        this.dataBarangDataSet.TabelBarang.AddTabelBarangRow(this.dataBarangDataSet.NewTabelBarangRow());
        //        tabelBarangBindingSource.MoveLast();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        tabelBarangBindingSource.ResetBindings(false);
        //    }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            tabelBarangBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tabelBarangBindingSource.EndEdit();
                tabelBarangTableAdapter.Update(this.dataBarangDataSet.TabelBarang);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabelBarangBindingSource.ResetBindings(false);
            }
        }

        //Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBarangDataSet.TabelBarang' table. You can move, or remove it, as needed.
            this.tabelBarangTableAdapter.Fill(this.dataBarangDataSet.TabelBarang);
            tabelBarangBindingSource.DataSource = this.dataBarangDataSet.TabelBarang;
        }



        //GridView
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tabelBarangBindingSource.RemoveCurrent();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
