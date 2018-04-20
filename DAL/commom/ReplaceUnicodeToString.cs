using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.commom
{
    public class ReplaceUnicodeToString
    {

        public string ReplaceUniToStr(string str)
        {

            str = str.Replace("%20", " ").Replace("%40", "@").Replace("%60", "`");
            str = str.Replace("%21", "!").Replace("%41", "A").Replace("%61", "a");
            //str = str.Replace("%22",""").Replace("%42", "B").Replace("%62", "b");
            str = str.Replace("%23", "#").Replace("%43", "C").Replace("%63", "c");
            str = str.Replace("%24", "$").Replace("%44", "D").Replace("%64", "d");
            str = str.Replace("%25", "%").Replace("%45", "E").Replace("%65", "e");
            str = str.Replace("%26", "&").Replace("%46", "F").Replace("%66", "f");
            str = str.Replace("%27", "'").Replace("%47", "G").Replace("%67", "g");
            str = str.Replace("%28", "(").Replace("%48", "H").Replace("%68", "h");
            str = str.Replace("%29", ")").Replace("%49", "I").Replace("%69", "i");
            str = str.Replace("%2A", "*").Replace("%4A", "J").Replace("%6A", "j");
            str = str.Replace("%2B", "+").Replace("%4B", "K").Replace("%6B", "k");
            str = str.Replace("%2C", ",").Replace("%4C", "L").Replace("%6C", "l");
            str = str.Replace("%2D", "-").Replace("%4D", "M").Replace("%6D", "m");
            str = str.Replace("%2E", ".").Replace("%4E", "N").Replace("%6E", "n");
            str = str.Replace("%2F", "/").Replace("%4F", "O").Replace("%6F", "o");
            str = str.Replace("%30", "0").Replace("%50", "P").Replace("%70", "p");
            str = str.Replace("%31", "1").Replace("%51", "Q").Replace("%71", "q");
            str = str.Replace("%32", "2").Replace("%52", "R").Replace("%72", "r");
            str = str.Replace("%33", "3").Replace("%53", "S").Replace("%73", "s");
            str = str.Replace("%34", "4").Replace("%54", "T").Replace("%74", "t");
            str = str.Replace("%35", "5").Replace("%55", "U").Replace("%75", "u");
            str = str.Replace("%36", "6").Replace("%56", "V").Replace("%76", "v");
            str = str.Replace("%37", "7").Replace("%57", "W").Replace("%77", "w");
            str = str.Replace("%38", "8").Replace("%58", "X").Replace("%78", "x");
            str = str.Replace("%39", "9").Replace("%59", "Y").Replace("%79", "y");
            str = str.Replace("%3A", ":").Replace("%5A", "Z").Replace("%7A", "z");
            str = str.Replace("%3B", ";").Replace("%5B", "[").Replace("%7B", "{");
            //str = str.Replace("%3C", "<").Replace("%5C", "\").Replace(" % 7C", " | ");
            str = str.Replace("%3D", "=").Replace("%5D", "]").Replace("%7D", "}");
            str = str.Replace("%3E", ">").Replace("%5E", "^").Replace("%7E", "~");
            str = str.Replace("%3F", "?").Replace("%5F", "_").Replace("%7F", " ");

            return str;
        }
    }
}
