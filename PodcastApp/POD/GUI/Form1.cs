using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.ServiceModel.Syndication;
using System.Xml;
using POD191028.POD.Logic;


namespace POD
{
    public partial class Form1 : Form
    {
        List<Podcast> podcastLista;
        List<PodcastAvsnitt> podcastAvsnittLista;
        List<System.Timers.Timer> timers;
        MasterClass mk = new MasterClass();
        Validering v = new Validering();

        public Form1()
        {
            InitializeComponent();
            visaKategoriLista();

            visaPodcastLista(false);
            skapaTimer();

            _=hamtaPodcastsAsync();
        }

        private void skapaTimer()
        {
            timers = new List<System.Timers.Timer>();
            foreach(var podcast in podcastLista)
            {
                System.Timers.Timer timer = new System.Timers.Timer();

                timer.Elapsed += new ElapsedEventHandler(Uppdatering);
                
                switch (podcast.Uppdatering)
                {
                    case "5 minuter":
                        timer.Interval = 300000;
                        break;
                    case "10 minuter":
                        timer.Interval = 600000;
                        break;
                    case "15 minuter":
                        timer.Interval = 900000;
                        break;
                    case "30 minuter":
                        timer.Interval = 1800000;
                        break;
                }
                timers.Add(timer);
                timer.Enabled = true;

            }
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            try
            {
                var i = listBoxKategorier.SelectedItem.ToString();

                if (i == null)
                {
                    MessageBox.Show("Vänligen markera den kategori du vill ta bort.");
                }
                else
                {
                    mk.taBortKategori(listBoxKategorier.SelectedItem as Kategori);
                    visaKategoriLista();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vänligen markera den kategori du vill ta bort.");
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Uppdatering(object source, ElapsedEventArgs e) {
            //Uppdateringsintervall
            for(var i = 0; i < timers.Count(); i++)
            {
                if(timers[i] == source)
                {
                    _=hamtaAvsnittAsync(podcastLista[i]);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {

            try
            {
                string namn = txtNamn.Text;
                string url = txtURL.Text;
                string uppdatering = cmbUppdatering.SelectedItem.ToString();
                Kategori kategori = cmbKategori.SelectedItem as Kategori;

                var i = v.validateURL(url);
                var y = v.textTomt(namn);
                var k = cmbKategori.SelectedItem.ToString();

                if (i == false)
                {
                    MessageBox.Show("URL:en är inte korrekt ifylld.");
                }
                else if (y == false)
                {
                    MessageBox.Show("Vänligen fyll i ett namn på podcasten.");
                }
                else if (uppdatering == null)
                {
                    MessageBox.Show("Vänligen välj en uppdateringsfrekvens.");
                }
                else if (kategori == null)
                {
                    MessageBox.Show("Vänligen välj en kategori.");
                }
                else
                {
                    mk.laggTillPodcast(namn, url, uppdatering, kategori);
                    visaPodcastLista(true);
                    skapaTimer();
                    txtNamn.Clear();
                    txtURL.Clear();
                    cmbKategori.SelectedItem = null;
                    cmbUppdatering.SelectedItem = null;
                }




            }
            catch (Exception) { MessageBox.Show("Vänligen fyll i alla fält."); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            var i = v.textTomt(txtNamnKategori.Text);

            if (i == false)
            {
                MessageBox.Show("Vänligen välj ett namn på kategorin.");
            }
            else
            {
                mk.skapaKategori(txtNamnKategori.Text);
                visaKategoriLista();
                txtNamnKategori.Clear();
            }
        }

        private void txtNamnKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void visaKategoriLista()
        {
          
            List<Kategori> kategoriLista = mk.laddaKategoriLista();

            cmbKategori.Items.Clear();
            listBoxKategorier.Items.Clear();

            foreach(var kategori in kategoriLista)
            {
                listBoxKategorier.Items.Add(kategori);
                cmbKategori.Items.Add(kategori);
            }


        }

        public void visaPodcastLista(bool kollaOnline = true) 
        {          
            podcastLista = mk.laddaPodcastLista(kollaOnline);

            dataGridViewPodcast.AutoGenerateColumns = false;

            dataGridViewPodcast.DataSource = podcastLista;
        }

        public void visaPodcastAvsnittLista(Podcast podcast) 
        {
            podcastAvsnittLista = podcast.avsnitt;

            dataGridViewAvsnitt.AutoGenerateColumns = false;

            dataGridViewAvsnitt.DataSource = podcastAvsnittLista;
        }

        public void rensaPodcastAvsnittLista()
        {
            dataGridViewAvsnitt.DataSource = null;
            dataGridViewAvsnitt.Rows.Clear();
        }

        public void visaAvsnittsBeskrivning(PodcastAvsnitt avsnitt) 
        {
            txtBeskrivning.Text = avsnitt.beskrivning;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPodcast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPodcast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            visaPodcastAvsnittLista(podcastLista[dataGridViewPodcast.CurrentCell.RowIndex]);
        }

        private void dataGridViewAvsnitt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            visaAvsnittsBeskrivning(podcastAvsnittLista[dataGridViewAvsnitt.CurrentCell.RowIndex]);
        }

        private void btnAndraPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                var i = v.validateURL(txtURL.Text);
                if(i == false)
                {
                    MessageBox.Show("Vänligen fyll i en giltig URL.");
                }
                else
                {
                    Kategori k;
                    string u;
                    Podcast podcast = podcastLista[dataGridViewPodcast.CurrentCell.RowIndex];

                    if (cmbKategori.SelectedIndex == -1)
                    {
                        k = podcast.kategori;
                    }
                    else
                    {
                        k = cmbKategori.SelectedItem as Kategori;
                    }

                    if (cmbUppdatering.SelectedIndex == -1)
                    {
                        u = podcast.Uppdatering;
                    }
                    else
                    {
                        u = cmbUppdatering.SelectedItem.ToString();
                    }

                    mk.andraPodcastInfo(podcast, txtNamn.Text, txtURL.Text, u, k);
                    txtNamn.Clear();
                    txtURL.Clear();
                    cmbKategori.SelectedItem = null;
                    cmbUppdatering.SelectedItem = null;
                    visaPodcastLista(true);

                    if (cmbUppdatering.SelectedIndex == -1)
                    {
                        // timer uppdaterad, sätter alla timers igen
                        skapaTimer();
                    }
                }
                
            }
            catch (Exception) 
            { MessageBox.Show("Vänligen välj vilken podcast du vill ändra."); 
            }
        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                mk.taBortPodcast(podcastLista[dataGridViewPodcast.CurrentCell.RowIndex]);
                visaPodcastLista(true);
                skapaTimer();
                rensaPodcastAvsnittLista();
            }
            catch (Exception) { MessageBox.Show("Vänligen välj vilken podcast du vill ta bort."); }
        }

        private void btnVisaKategori_Click(object sender, EventArgs e)
        {
            Kategori kategori = listBoxKategorier.SelectedItem as Kategori;

            podcastLista = mk.laddaValdKategori(kategori);

            dataGridViewPodcast.DataSource = podcastLista;
        }

        private void btnVisaAllaKategori_Click(object sender, EventArgs e)
        {
            visaPodcastLista(false);
        }

        private void btnAndraKategori_Click(object sender, EventArgs e)
        {

            var i = v.textTomt(txtNamnKategori.Text);

            if (i == false)
            {
                MessageBox.Show("Vänligen välj ett nytt namn på kategorin.");
            }
            else
            {
                mk.andraKategori(listBoxKategorier.SelectedItem as Kategori, txtNamnKategori.Text);

                visaKategoriLista();
                visaPodcastLista(false);
            }

            txtNamnKategori.Clear();
        }
        

        private async Task hamtaPodcastsAsync() 
        {
            await Task.Delay(1000);
            podcastLista = mk.laddaPodcastLista();
            
            dataGridViewPodcast.AutoGenerateColumns = false;

            dataGridViewPodcast.DataSource = podcastLista;
        }

        private async Task hamtaAvsnittAsync(Podcast podcast)
        {
            await Task.Delay(1000);
            podcast = mk.hamtaPodcastAvsnitt(podcast);
          
            for (int i = 0; i < podcastLista.Count(); i++)
            {
                if(podcastLista[i].ID == podcast.ID)
                {
                    podcastLista[i] = podcast;
                    break;
                }
            }
                
            dataGridViewPodcast.AutoGenerateColumns = false;

            dataGridViewPodcast.DataSource = podcastLista;
        }

        private void dataGridViewAvsnitt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

