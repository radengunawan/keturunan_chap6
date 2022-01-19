using System;
using System.Collections.Generic;
using System.Text;

namespace keturunan_chap6
{
    class KerusakanPanah
    {

        /// <summary>
        /// The constructor calculates damage based on default Magic
        /// and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="startingRoll">Starting 3d6 roll</param>
        /// 
        public KerusakanPanah(int rollMulai)
        {
            this.roll = rollMulai;
        }

        //public const int LUKA_DASAR = 3;
        //public const int LUKA_BAKAR = 2;
        private const decimal PENGALI_DASAR = 0.35M;
        private const decimal PENGALI_AJIB = 2.5M;
        private const decimal RUSAK_TERBAKAR = 1.25M;



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
        }

        private bool nyala;

        public bool Nyala
        {
            get { return this.nyala; }

            set
            {
                this.nyala = value;
                HitungKerusakan();
            }
        }



        public void HitungKerusakan()
        {
            // Kerusakan = (int)(Roll * PengaliAjaib) + LUKA_DASAR + RusakTerbakar;
            decimal kerusakanDasar = Roll * PENGALI_DASAR;
            if (Keajaiban) kerusakanDasar *= PENGALI_AJIB;
            if (Nyala) Kerusakan = (int)Math.Ceiling(kerusakanDasar + RUSAK_TERBAKAR);
            else Kerusakan = (int)Math.Ceiling(kerusakanDasar);
        }

        //public void AturKeajaiban(bool Keajaiban)
        //{
        //    if (Keajaiban)
        //    {
        //        PengaliAjaib = 1.75M;
        //    }
        //    else
        //    {
        //        PengaliAjaib = 1M;
        //    }
        //    HitungKerusakan();
        //}// end void

        //public void AturNyalaApi(bool Nyala)
        //{
        //    HitungKerusakan();
        //    if (Nyala)
        //    {
        //        Kerusakan += LUKA_BAKAR;
        //    }
        //}// end void
    }
}
