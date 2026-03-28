using System;
using System.Collections.Generic;
using System.Text;

namespace MOD4_103022400143
{
    internal class KodePaket
    {

        private Dictionary<string, string> tabelPaket = new Dictionary<string, string>(){
            { "Basic", "P201" },
            { "Standard", "P202" },
            { "Premium", "P203" },
            { "Unlimited", "P204" },
            { "Gaming", "P205" },
            { "Streaming", "P206" },
            { "Family", "P207" },
            { "Business", "P208" },
            { "Student", "P209" },
            { "Traveler", "P2010" },

        };

        public string getKodePaket(string namapaket) {
            if (tabelPaket.ContainsKey(namapaket))
            {
                return tabelPaket[namapaket];
            }
            else {
                return "Paket Tidak Ditemukan";
            }
            
        }

    }
}
