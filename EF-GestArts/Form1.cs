using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_GestArts
{
    public partial class Form1 : Form
    {
        maBaseEntities DB = new maBaseEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grd.DataSource = DB.Articles.ToList();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double pu = 0;
            Article art = new Article();
            art.Libelle = txtLib.Text;
            if (double.TryParse(txtPu.Text, out pu))
            {
                error.SetError(txtPu, "");
                art.PU = pu;
                DB.Articles.Add(art);
                DB.SaveChanges();
                grd.DataSource = null;
                grd.DataSource = DB.Articles.ToList();
            }
            else
            {
                error.SetError(txtPu, "Prix invalide");
            }
         
        }
    }
}
