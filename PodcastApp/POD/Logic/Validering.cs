using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace POD191028.POD.Logic
{
    class Validering
    {

        bool funkar = true;

        public bool validateURL(string url)
        {
            funkar = true;
            try
            {
                XmlReader reader = XmlReader.Create(url);
                Rss20FeedFormatter formatter = new Rss20FeedFormatter();
                formatter.ReadFrom(reader);
                reader.Close();
            }
            catch
            {
                funkar = false;
            }
            return funkar;

        }

        public bool textTomt(string text)
        {

            if (string.IsNullOrEmpty(text))
            {
                funkar = false;
            }
            else
            {
                funkar = true;
            }
            return funkar;
        }


    }
}
