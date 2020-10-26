using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using POD191028.POD.Logic;

namespace POD191028.POD.Data
{
    class PodcastDB : EntitetDB
    {

        public override string sokvag()
        {
            return System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Podcasts.xml";
        }


        public void sparaPodcast(Podcast podcast)
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "PodcastLista";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>), root);

            List<Podcast> list = hamtaPodcastLista();
            list.Add(podcast);

            File.Delete(sokvag());

            using (FileStream stream = File.OpenWrite(sokvag()))
            {
                serializer.Serialize(stream, list);
            }
        }

        public List<Podcast> hamtaPodcastLista()
        {
            if (File.Exists(sokvag()))
            {
                XmlRootAttribute root = new XmlRootAttribute();
                root.ElementName = "PodcastLista";

                XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>), root);

                using (FileStream stream = File.OpenRead(sokvag()))
                {
                    List<Podcast> podcasts = (List<Podcast>)serializer.Deserialize(stream);
                    return podcasts;
                }
            }
            else
            {
                return new List<Podcast>();
            }
        }

        public void andraPodcast(Podcast podcast) 
        {

            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "PodcastLista";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>), root);

            List<Podcast> list = hamtaPodcastLista();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ID == podcast.ID)
                {
                    list.RemoveAt(i);
                    list.Insert(i, podcast);
                    break;
                }
            }

            File.Delete(sokvag());

            using (FileStream stream = File.OpenWrite(sokvag()))
            {
                serializer.Serialize(stream, list);
            }


        }

        public void taBortPodcast(Podcast podcast)
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "PodcastLista";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>), root);

            List<Podcast> list = hamtaPodcastLista();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ID == podcast.ID)
                {
                    list.RemoveAt(i);
                    break;
                }
            }

            File.Delete(sokvag());

            if (list.Count() != 0)
            {
                using (FileStream stream = File.OpenWrite(sokvag()  ))
                {
                    serializer.Serialize(stream, list);
                }
            }

        }
    }
}
