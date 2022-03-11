using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MOD3_1302200027
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            kodePos table_Kodepos = new kodePos();
            Console.WriteLine("=== GET KODE POS BATUNUNGGAL===");
            table_Kodepos.getKodePos("Batununggal");
            Console.WriteLine("==== GET ALL KODE POS ====");
            table_Kodepos.getAllkodepos();
        }
    }
    class kodePos
    {
        Dictionary<string, string> DIC = new Dictionary<string, string>()
        {
            {"Batununggal", "40266"},
            {"Kujangsari" , "40287"},
            {"Mengger"    , "40267"},
            {"Wates"      , "40256"},
            {"Cijaura"    , "40287"},
            {"Jatisari"   , "40286"},
            {"Margasari"  , "40286"},
            {"Sekejati"   , "40286"},
            {"Kebonwaru"  , "40272"},
            {"Maleer"     , "40274"},
            {"Samoja"     , "40273"} } ;
        
        public void getKodePos(string kel)
        {
            if (DIC.ContainsKey(kel))
            { 
                Console.WriteLine(kel + " : " + DIC[kel]); 
            }
            else
            {
                Console.WriteLine(kel + "Tidak ditemukan");
            }
        }
        public void getAllkodepos()
        {
            foreach (KeyValuePair<string, string> elel in DIC)
            {
                Console.WriteLine("{0} \t\t {1}", elel.Key, elel.Value);
            }
        }
    }
}
