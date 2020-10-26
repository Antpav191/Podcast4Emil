using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace POD191028.POD.Logic
{
    public class Podcast : IEntitet
    {
        public string Namn { get; set; }
        public string URL { get; set; }
        public string Uppdatering { get; set; }
        public int antalAvsnitt { get; set; }
        public int ID { get; set; }
        public string nyaAvsnitt { get; set; }
        public Kategori kategori { get; set; }
        public List<PodcastAvsnitt> avsnitt { get; set; }
        

        public Podcast() {
            nyaAvsnitt = "Nej";
        }

        public Podcast(Podcast p)
        {
            this.Namn = p.Namn;
            this.URL = p.URL;
            this.Uppdatering = p.Uppdatering;
            this.antalAvsnitt = p.antalAvsnitt;
            this.ID = p.ID;
            this.nyaAvsnitt = p.nyaAvsnitt;
            this.kategori = p.kategori;
            this.avsnitt = p.avsnitt;
        }

        public Podcast(string Namn, string URL, string Uppdatering, Kategori kategori, int ID) {

            this.Namn = Namn;
            this.URL = URL;
            this.Uppdatering = Uppdatering;
            this.kategori = kategori;
            this.ID = ID;
            nyaAvsnitt = "Nej";

        }

        public void hamtaAvsnitt() {
                
            
            var reader = XmlReader.Create(URL);
            var feed = SyndicationFeed.Load(reader);

            avsnitt = new List<PodcastAvsnitt>();
             
            foreach (var i in feed.Items) {
                foreach (SyndicationElementExtension extension in i.ElementExtensions) {
                    XElement ele = extension.GetObject<XElement>();
              
                    if(extension.OuterName == "subtitle")
                    {
                        PodcastAvsnitt pa = new PodcastAvsnitt(i.Title.Text, i.PublishDate.ToString(), ele.Value);
                        avsnitt.Add(pa);
                        break;
                    }
                }
            }

            if (antalAvsnitt < avsnitt.Count()){
                nyaAvsnitt = "Ja";}
            else {
                nyaAvsnitt = "Nej";}
            antalAvsnitt = avsnitt.Count();
        }

       
    }
}
