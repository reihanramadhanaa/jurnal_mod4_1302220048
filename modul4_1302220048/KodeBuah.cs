using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220048
{
    internal class KodeBuah
    {
        private string[,] Kodebuah = {
         {"Apel","A00" },
         {"Aprikot","B00" },
         {"Alpukat","C00" },
         {"Pisang","D00" },
         {"Paprika","E00" },
         {"Blacberry","F00"},
         {"Ceri","H00"},
         {"Kelapa","I00"},
         {"Jagung","J00"},
         {"Apel","A00"},
         {"Aprikot","B00"},
         {"Aprikot","B00"},


        };

        public string GetKodeBuah(string buah) 
        {
          for (int i = 0; i < Kodebuah.GetLength(0);i++)
            {
                if (Kodebuah[i,0] == buah) 
                {
                  return Kodebuah[i,1];
                }
            }
            return "Kode Buah Tidak Ditemukan";
        
        }


    }
}
