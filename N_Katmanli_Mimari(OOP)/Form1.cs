using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
using System.Data.SqlClient;

namespace N_Katmanli_Mimari_OOP_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {

            try
            {
                EntityPersonel ent = new EntityPersonel();
                {
                    ent.Ad = txtAD.Text;
                    ent.Soyad = txtSOYAD.Text;
                    ent.Sehir = txtSEHIR.Text;
                    ent.Maas = short.Parse(txtMAAS.Text);
                    ent.Gorev = txtGOREV.Text;
                    LogicPersonel.LLPersonelEkle(ent);
                    MessageBox.Show("Yeni personel eklendi.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz girdiğinizden emin olunuz");
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e) // All debuging is complated.
        {

            try
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = Convert.ToInt32(txtID.Text);
                LogicPersonel.LLPersonelSil(ent.Id);
                MessageBox.Show("Personel silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silmek istediğiniz personeli seçiniz ya da id numarasını giriniz.");
            }

            
        }

        private void btnGuncelle_Click(object sender, EventArgs e) // All debuging is complated.
        {

            try
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = Convert.ToInt32(txtID.Text);
                ent.Ad = txtAD.Text;
                ent.Soyad = txtSOYAD.Text;
                ent.Sehir = txtSEHIR.Text;
                ent.Gorev = txtGOREV.Text;
                ent.Maas = short.Parse(txtMAAS.Text);
                LogicPersonel.LLPersonelGuncelle(ent);
                MessageBox.Show("Personel güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncellemek istediğiniz personeli seçiniz ya da id numarasını giriniz.");
            }

           
        }
    }
}
