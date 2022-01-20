using System;
using System.Collections.Generic;
using System.Text;

namespace keturunan_chap6
{
    class KerusakanPanah
    {
        /*CONSTRUCTOR*/
        public KerusakanPanah(int rollMulai)
        {
            this.roll = rollMulai;
        }

        /*FIELDS*/
        //public const int LUKA_DASAR = 3;
        //public const int LUKA_BAKAR = 2;
        private const decimal PENGALI_DASAR = 0.35M;
        private const decimal PENGALI_AJIB = 2.5M;
        private const decimal RUSAK_TERBAKAR = 1.25M;

        /*METHODS*/
        public int Roll
        {
            get { return roll; }
            set
            {
                this.roll = value;
                HitungKerusakan();
            }
        }
        //public decimal PengaliAjaib = 1M;
        //public int RusakTerbakar = 0;
        public int Kerusakan { get; private set; }

        private int roll;

        private bool keajaiban;

        public bool Keajaiban {
            get { return this.keajaiban; }
            set
            {
                this.keajaiban = value;
                HitungKerusakan();
            }
        } // END Keajaiban

        private bool nyala;

        public bool Nyala
        {
            get { return this.nyala; }

            set
            {
                this.nyala = value;
                HitungKerusakan();
            }
        }// END Nyala



        public void HitungKerusakan()
        {
            // Kerusakan = (int)(Roll * PengaliAjaib) + LUKA_DASAR + RusakTerbakar;
            decimal kerusakanDasar = Roll * PENGALI_DASAR;
            if (Keajaiban) kerusakanDasar *= PENGALI_AJIB;
            if (Nyala) Kerusakan = (int)Math.Ceiling(kerusakanDasar + RUSAK_TERBAKAR);
            else Kerusakan = (int)Math.Ceiling(kerusakanDasar);
        }//END HitungKerusakan

    }//END Class
}//END ALL
