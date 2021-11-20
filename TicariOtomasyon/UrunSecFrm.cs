using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicariOtomasyon
{
    public partial class UrunSecFrm : Form
    {

        public string donecekDeger1 { get; set; }
        public UrunSecFrm()
        {
            InitializeComponent();
        }

        private void UrunSecFrm_Load(object sender, EventArgs e)
        {
            //gridView1.OptionsBehavior.Editable = false;
            //gridControl1.DataSource = (from l in context.Urun_TB
            //                           select l).ToList();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            this.donecekDeger1 = B;
            this.DialogResult = DialogResult.OK;
            FaturaFrm frm = new FaturaFrm();
            frm.Refresh();
            this.Close();
        }
    }
}
