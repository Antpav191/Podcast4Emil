using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POD191028.POD.Data;

namespace POD191028.POD.Logic
{
    class MasterClass
    {
        KategoriDB kDB = new KategoriDB();
        PodcastDB pDB = new PodcastDB();

        public void skapaKategori(string Namn)
        {
            int id = 0;
            foreach (var item in laddaKategoriLista()) {
                if (item.ID >= id) {
                    id = item.ID + 1;
                }
            }
            Kategori kategori = new Kategori(Namn, id);
            kDB.sparaKategori(kategori);
        }


        public List<Kategori> laddaKategoriLista()
        {
            List<Kategori> kategoriLista = kDB.hamtaKategoriLista();
            return kategoriLista;
        }


        public void laggTillPodcast(string Namn, string URL, string Uppdatering, Kategori kategori)
        {
            int id = 0;
            
            foreach (var item in laddaPodcastLista(false))
            {
                if (item.ID >= id)
                {
                    id = item.ID + 1;
                }
            }

            Podcast podcast = new Podcast(Namn, URL, Uppdatering, kategori, id);
            pDB.sparaPodcast(podcast);
            podcast.hamtaAvsnitt();
        }


        public List<Podcast> laddaPodcastLista(bool hamtaAvsnitt = true)
        {
            
            List<Podcast> podcastLista = pDB.hamtaPodcastLista();
            if (hamtaAvsnitt == true)
            {
                foreach (var podcast in podcastLista)
                {
                    podcast.hamtaAvsnitt();
                    andraPodcast(podcast);
                }
            }
            return podcastLista;
        }

        public Podcast hamtaPodcastAvsnitt(Podcast podcast)
        {
            podcast.hamtaAvsnitt();
            andraPodcast(podcast);
            return podcast;
        }


        public void andraPodcast(Podcast podcast) 
        {
            Podcast kopia = new Podcast(podcast);
            kopia.avsnitt = new List<PodcastAvsnitt>();

            pDB.andraPodcast(kopia);
        }

        public void andraPodcastInfo(Podcast podcast, string namn, string url, string uppdatering, Kategori kategori)
        {
            if (namn != ""){
                podcast.Namn = namn;}

            if (url != ""){
                podcast.URL = url;}

            if (uppdatering != ""){
                podcast.Uppdatering = uppdatering;}

            podcast.kategori = kategori;

            andraPodcast(podcast);
        }


        public void taBortPodcast(Podcast podcast) 
        {
            pDB.taBortPodcast(podcast);
        }


        public List<Podcast> laddaValdKategori(Kategori kategori)
        {
            //Här använder vi LINQ

            return laddaPodcastLista(false).Where(p => p.kategori.ID == kategori.ID).ToList();
        }


        public void taBortKategori(Kategori kategori) 
        {
            bool isOK = true;

            foreach (var podcast in laddaPodcastLista(false))
            {
                if (podcast.kategori.ID == kategori.ID) {
                    isOK = false;
                    break;
                }
            }

            if (isOK == true)
            {
                kDB.taBortKategori(kategori);
            }
            else 
            {
                MessageBox.Show("Du försöker ta bort en kategori som används. Vänligen byt kategori på podcast och försök igen.", "Varning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void andraKategori(Kategori kategori, string nyttNamn) 
        {
            foreach (var podcast in laddaPodcastLista(false))
            {
                if (podcast.kategori.ID == kategori.ID)
                {
                    podcast.kategori.Namn = nyttNamn;
                    andraPodcast(podcast);
                }
            }
            kategori.Namn = nyttNamn;

            kDB.andraKategori(kategori);
        }

    }
}
