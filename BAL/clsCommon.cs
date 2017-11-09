using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    class clsCommon
    {
         public string nameformat(string names)
        {
            string[] pl = names.Split(' ');
            for (int i = 0; i < pl.Length; i++)
            {
                pl[i] = pl[i].ToLower();
                string k = pl[i][0].ToString();
                k = k.ToUpper();
                pl[i] = pl[i].Remove(0, 1);
                pl[i] = k + pl[i];
            }
            names = "";
            for (int i = 0; i < pl.Length; i++)
            {
                if (names != "")
                    names = names + " ";
                names = names + pl[i].ToString();
            }
            return names;
        }
    
    }
}
