using System;
using System.Collections.Generic;
using System.Text;

namespace keturunan_chap6
{
    class KerusakanPanah
    {
        //public const int LUKA_DASAR = 3;
        //public const int LUKA_BAKAR = 2;
        private const decimal PENGALI_DASAR = 0.35M;
        private const decimal PENGALI_AJIB = 2.5M;
        private const decimal RUSAK_TERBAKAR = 1.25M;



        public int Roll;
        //public decimal PengaliAjaib = 1M;
        //public int RusakTerbakar = 0;
        public float Kerusakan;

        public void HitungKerusakan()
        {
            // Kerusakan = (int)(Roll * PengaliAjaib) + LUKA_DASAR + RusakTerbakar;
            decimal kerusakanDasar = Roll * PENGALI_DASAR;
            if (Keajaiban) kerusakanDasar *= PENGALI_AJIB;
            if (Nyala) Demej = (int)Math.Ceiling(kerusakanDasar + RUSAK_TERBAKAR);
            else Demej = (int)Math.Ceiling(kerusakanDasar);
        }

        public void AturKeajaiban(bool Keajaiban)
        {
            if (Keajaiban)
            {
                PengaliAjaib = 1.75M;
            }
            else
            {
                PengaliAjaib = 1M;
            }
            HitungKerusakan();
        }

        public void AturNyalaApi(bool Nyala)
        {
            HitungKerusakan();
            if (Nyala)
            {
                Kerusakan += LUKA_BAKAR;
            }
        }
    }
}
