using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_MaliyetHesaplama
{
    public partial class Anasayfa : Form
    {
        public Dictionary<string, Form> dictionary;

        public Anasayfa()
        {
            InitializeComponent();
            dictionary = new Dictionary<string, Form>();
        }
        public void FormsShow(string formName)
        {
            Form form = null;
            if (dictionary.ContainsKey(formName))
            {
                form = this.dictionary[formName];
                form.WindowState = FormWindowState.Normal;
                form.Activate();
            }
            else
            {
                if (formName == "Defter")
                {
                    form = new Defter();
                    form.FormClosed += Form_FormClosed;
                }
                else if (formName == "Kutu")
                {
                    form = new Kutu();
                    form.FormClosed += Form_FormClosed1;
                }
                else if (formName == "Teklif")
                {
                    form = new Teklif();
                    form.FormClosed += Form_FormClosed1;
                }
                else if (formName == "Canta")
                {
                    form = new Canta();
                    form.FormClosed += Form_FormClosed1;
                }
                else if (formName == "Stok")
                {
                    form = new Stok();
                    form.FormClosed += Form_FormClosed1;
                }
               

                dictionary.Add(formName, form);
                form.MdiParent = this;
                form.Show();



            }
        }



        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            dictionary.Remove("Defter");
        }
        private void Form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            dictionary.Remove("Kutu");
        }

        private void Form_FormClosed2(object sender, FormClosedEventArgs e)
        {
            dictionary.Remove("Teklif");
        }

        private void Form_FormClosed3(object sender, FormClosedEventArgs e)
        {
            dictionary.Remove("Canta");
        }
        private void Form_FormClosed4(object sender, FormClosedEventArgs e)
        {
            dictionary.Remove("Stok");
        }
      

        private void DefterMaliyetiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormsShow("Defter");
        }

        private void KutuMaliyetiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormsShow("Kutu");
        }

        private void CantaMaliyetiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormsShow("Canta");
        }

        private void StokToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormsShow("Teklif");
        }

        private void CalışanlarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                FormsShow("Stok");
            
        }

       

       
    }
    


}
    

        
    

