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
    public partial class FaturaDetayFrm : Form
    {
        //TicariContext context = new TicariContext();
        public FaturaDetayFrm()
        {
            InitializeComponent();
        }
        public FaturaDetayFrm(int id)
        {
            //InitializeComponent();
            //gridView1.OptionsBehavior.Editable = false;
            //gridControl1.DataSource = (from l in context.FaturaDetay_TB
            //                           where l.FaturaBilgiId==id
            //                           select l).ToList();

        }

        private void FaturaDetayFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            int deger1 = Convert.ToInt32(B);
            FaturaUrunDuzenlemeFrm frm = new FaturaUrunDuzenlemeFrm(deger1);
            frm.ShowDialog();
            
        }
    }
}
