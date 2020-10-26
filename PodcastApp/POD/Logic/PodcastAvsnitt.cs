using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POD191028.POD.Logic
{
    public class PodcastAvsnitt
    {

        public string titel { get; set; }
        public string datum { get; set; }
        public string beskrivning { get; set; }

        public PodcastAvsnitt() { }

        public PodcastAvsnitt(string titel, string datum, string beskrivning) {

            this.titel = titel;
            this.datum = datum;
            this.beskrivning = beskrivning;

        }

    }
}
