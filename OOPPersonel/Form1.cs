using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPersonel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Ad = txtAd.Text;
            p.SoyAd = txtSoyad.Text;
            p.Departman = cmbDepartman.Text;
            p.IseGirisTarihi = dtpIs.Value;
            p.DogumTarihi = dtpDogum.Value;

            if(p.IseGirTarihDurum==true&&p.DogumTarihDurum==true)
            lstPersonel.Items.Add(p);
            else
                MessageBox.Show("Tarihlerinizde hata var");
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (lstPersonel.SelectedItem != null)
            {
                Personel secilenPErsonel =(Personel)lstPersonel.SelectedItem;

                MessageBox.Show(secilenPErsonel.Departman+" "+secilenPErsonel.IseGirisTarihi);
            }
        }
    }
}
