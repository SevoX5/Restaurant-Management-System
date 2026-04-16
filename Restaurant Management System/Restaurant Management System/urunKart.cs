using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class urunKart : UserControl
    {
        public urunKart()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string UrunId { get; set; }
        public string UrunAdi
        {// UrunAdi özelliği, urunadi adlı bir kontrolün Text özelliği ile ilişkilendirilmiştir. Bu sayede, UrunAdi özelliğine bir değer atandığında, urunadi kontrolünün metni de güncellenir ve tam tersi şekilde çalışır.
            get
            {
                return urunadi.Text;
            }
            set 
            {
                urunadi.Text = value;
            }
            
        }
        public string Stok 
        {
            get
            {
                return stok.Text;
            }
            set
            {
                stok.Text = value;
            }

        }
        public string Fiyat
        {
            get
            {
                return fiyat.Text;
            }
            set
            {
                fiyat.Text = value;
            }
        }
        public Image image { 
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }


        public string urunAdedi//adet kısmını buraya yazdım.
        {
            get
            {
                return adet.Text;
            }
            set
            {
                adet.Text = value;
            }
        }


        public string Kategori { get; set; }
       
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler selectKart=null;// selectKart adında bir olay tanımlanır ve başlangıçta null olarak atanır. Bu olay, kartın seçilmesi durumunda tetiklenecektir.

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            selectKart?.Invoke(this, EventArgs.Empty);// ekle_btn adlı bir düğmeye tıklandığında, selectKart olayı tetiklenir. Bu olayın tetiklenmesi için null kontrolü yapılır ve eğer selectKart olayı null değilse, bu olayın dinleyicileri çağrılır. Olayın dinleyicileri, kartın seçilmesi durumunda gerçekleştirilecek işlemleri içerebilir.
        }
    }
}
