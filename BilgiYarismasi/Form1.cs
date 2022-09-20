namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnA_Click(object sender, EventArgs e)
        {
            label5.Text = BtnA.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            if (label4.Text==label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            label5.Text = BtnB.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            label5.Text = BtnD.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            LblSoruno.Text = soruno.ToString();
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi il Ege bölgesinde bulunmaz?";
                BtnA.Text = "Ýzmir";
                BtnB.Text = "Aydýn";
                BtnC.Text = "Manisa";
                BtnD.Text = "Bursa";
                label4.Text = "Bursa";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Son Kuþlar hangi yazara aittir?";
                BtnA.Text = "Sait Faik Abasýyanýk";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Attila Ýlhan";
                BtnD.Text = "Reþat Nuri Güntekin";
                label4.Text = "Sait Faik Abasýyanýk";
            }
            if (soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doðru sayýsý:" + dogru + "\n" + "Yanlýþ sayýsý:" + yanlis);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = BtnC.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}