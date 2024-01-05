using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NuriTiras1453B
{
    public class Suleyman
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public byte yas;
        public double boy, agirlik;

        public virtual double VcutKitleIndeksi()
        {
            return agirlik / (boy * boy);
        }
    }
    public class Nuri : Suleyman
    {
        public string OkuduguBolum;
        public bool Durum;
        public Nuri()
        {
            Console.WriteLine("Bilişim Teknolojileri öğrencisi her zaman fit bir vücuda sahiptir.");
        }
        public override double VcutKitleIndeksi()
        {
            return 20.85;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Suleyman suleyman= new Suleyman();
            suleyman.isim = "Süleyman";
            suleyman.yas = 74;
            suleyman.boy = 1.80;
            suleyman.agirlik = 80.5;
            Console.WriteLine("Vücut Kitle İndeks Değeri={0}", suleyman.VcutKitleIndeksi());
        }
    }
}
