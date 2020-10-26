using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using POD191028.POD.Logic;

namespace POD191028.POD.Data
{
    class KategoriDB : EntitetDB
    {
        
        public override string sokvag()
        {
            return System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Kategorier.xml"; ;
        }

        public void sparaKategori(Kategori kategori) 
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "KategoriLista";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Kategori>), root);

            List<Kategori> list = hamtaKategoriLista();
            list.Add(kategori);

            using (FileStream stream = File.OpenWrite(sokvag()))
            {
                serializer.Serialize(stream, list);
            }
        }

        public List<Kategori> hamtaKategoriLista()
        {

            if (File.Exists(sokvag()))
            {
                XmlRootAttribute root = new XmlRootAttribute();
                root.ElementName = "KategoriLista";

                XmlSerializer serializer = new XmlSerializer(typeof(List<Kategori>), root);

                using (FileStream stream = File.OpenRead(sokvag()))
                {
                    List<Kategori> kategorier = (List<Kategori>)serializer.Deserialize(stream);
                    return kategorier;
                }
            }
            else {
                return new List<Kategori>();
            }
            
        }

       
        public void andraKategori(Kategori kategori)
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "KategoriLista";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Kategori>), root);

            List<Kategori> list = hamtaKategoriLista();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ID == kategori.ID)
                {
                    list.RemoveAt(i);
                    list.Insert(i, kategori);
                    break;
                }
            }

            File.Delete(sokvag());

            if (list.Count() != 0)
            {
                using (FileStream stream = File.OpenWrite(sokvag()))
                {
                    serializer.Serialize(stream, list);
                }
            }

        }

        public void taBortKategori(Kategori kategori)
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "KategoriLista";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Kategori>), root);

            List<Kategori> list = hamtaKategoriLista();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ID == kategori.ID)
                {
                    list.RemoveAt(i);
                    break;
                }
            }

            File.Delete(sokvag());

            if (list.Count() != 0)
            {
                using (FileStream stream = File.OpenWrite(sokvag()))
                {
                    serializer.Serialize(stream, list);
                }
            }

        }

    }
}
