using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BubbleSort_Algoritması
{
    public partial class Form1 : Form
    {
        
        int k = 0; // Karşılaştırma anında dizinin ilk sıradaki elemanını geçici olarak tutacak.
        int n; // 0 ile 100 arasında oluşturulacak olan sayıyı tutacak.
        int m; // Dizinin uzunluğunu belirleyecek.
        int[] dizi; // Sayıları tutacak olan dizimiz.
       

        Random r = new Random(); // Rastgele değer üretmek için random nesne tanımlamamız.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            m = int.Parse(textBox1.Text); // Dizinin uzunluğunu alıyoruz.
            dizi = new int[m]; // Boyutu atadık. 

            for (int i = 0; i < m; i++) // Diziye rastgele değerler atadık.
            {
                n = r.Next(0,100);
                dizi[i] = n;
            }
            textBox1.Clear(); // Textboxı temizledik.
            MessageBox.Show("Dizi Elemanları Aktarıldı. Bubble Sort Butonuna Tıkla");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int x in dizi) // İlk oluşturulan dizinin karmaşık halini listbox1 e yazdırıyoruz.
                                    // Hangi sıralamadan düzeltildi dizi bunu görebilmek için.
            {
                listBox1.Items.Add(x);
            }

           
            for (int i = dizi.Length-1; i >=0; i--) // Kabarcık algoritmasının uygulandığı yer
            {
                for (int j = 1; j <= dizi.Length-1; j++) // Gerekli açıklamayı konu anlatımında yaptım.
                {
                    if(dizi[j] < dizi[j-1])
                    {
                        k = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = k;
                    }
                }
            } // Kabarcık Algoritması Bitti

            foreach (int y in dizi) // Dizinin yeni hali yani küçükten büyüğe şeklindeki hali listbox4 e yazdırıldı.
            {
                listBox4.Items.Add(y);
            }

            Array.Reverse(dizi); // Küçükten büyüğe sıralı olan diziye reverse uygulayınca yani diziyi ters çevirince büyükten küçüğe sıralanmış olan diziyi elde ettik.

            foreach (int w in dizi) // Büyükten küçüğe halini listbox6 ya yazdırdık.
            {
             listBox6.Items.Add(w);   
            }

        }
    }
}
