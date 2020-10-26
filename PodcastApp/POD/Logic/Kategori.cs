using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POD191028.POD.Logic
{

    public class Kategori : IEntitet
    {
        public string Namn { get; set; }
        public int ID { get; set; }

        public Kategori() { }

        public Kategori(string Namn, int ID) {
            this.Namn = Namn;
            this.ID = ID;
        }

        public override string ToString()
        {
            return Namn;
        }
    }
}
