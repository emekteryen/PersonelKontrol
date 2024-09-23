using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPersonel
{
    public class Personel
    {
        public bool DogumTarihDurum = false;
        public bool IseGirTarihDurum = false;
        private string _ad;
        public string Ad
        {
            get { return _ad.ToUpper(); }
            set
            {
                _ad = value;
            }
        }

        private string _soyad;
        public string SoyAd
        {
            get { return _soyad.ToUpper(); }
            set
            {
                _soyad = value;
            }
        }

        private DateTime _iseGirisTarihi;
        public DateTime IseGirisTarihi
        {
            get { return _iseGirisTarihi; }
            set
            {
                if (DateTime.Now > value)
                {
                    _iseGirisTarihi = value;
                    IseGirTarihDurum = true;
                }
                else
                {
                    IseGirTarihDurum = false;
                    System.Windows.Forms.MessageBox.Show("Ise Giris Tarihi Sıkıntılı");
                }
            }
        }

        private DateTime _dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                if (DateTime.Now > value)
                {
                    DogumTarihDurum = true;
                    _dogumTarihi = value;

                }
                else
                {
                    DogumTarihDurum = false;
                    System.Windows.Forms.MessageBox.Show("Dogum tarihi hatalı");
                }
            }
        }

        private string _departman;
        public string Departman
        {
            get { return _departman; }
            set { _departman = value; }

        }

        public override string ToString()
        {
            return this.Ad + " " + this.SoyAd;
        }

    }
}
