using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CS016TextovySouborCteni
{
    public partial class zobrazeniSouboruForm : Form
    {
        public zobrazeniSouboruForm()
        {
            InitializeComponent();
        }

        private void souborNacteniButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFileDialog.FileName);
                souborObsahTextBox.Text = r.ReadToEnd();
            }
        }

        private void souborNactenPostupneiButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFileDialog.FileName);

                // spustit souborNacteniPostupne(r) v novem vlaknu (thread) z hlavniho vlakna
                var t = Task.Run(() => souborNacteniPostupne(r));    
                       
            }
        }

        private  void souborNacteniPostupne(StreamReader r)
        {
            while (!r.EndOfStream && !nacitaniZastavit)             
            {
                // zmenu textboxu musi provest vlakno, ktere jej vytvorilo (hlavni) 
                // pomoci Invoke je toto vlakno pozadano o provedeni prikazu v bloku
                souborObsahTextBox.Invoke((MethodInvoker)delegate   
                {
                    // provede hlavni vlakno
                    souborObsahTextBox.AppendText(r.ReadLine());        
                });
                Thread.Sleep(10);
            }
            nacitaniZastavit = false;
        }
 
        private bool nacitaniZastavit = false;
        private void nacitaniZastavitButton_Click(object sender, EventArgs e)
        {
            nacitaniZastavit = true;
        }
    }
}
