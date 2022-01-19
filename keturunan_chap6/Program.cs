using System;

namespace keturunan_chap6
{
    class Program
    {
        static Random acak = new Random();

        static void Main(string[] args)
        {
            KerusakanPanah kerusakan_panah = new KerusakanPanah(LemparDadu(1));
            KerusakanPedang kerusakan_pedang = new KerusakanPedang(LemparDadu(3));

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, " +
                                "3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                Console.Write("\nS for sword, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        kerusakan_pedang.Roll = LemparDadu(3);
                        kerusakan_pedang.Magic = (key == '1' || key == '3');
                        kerusakan_pedang.Flaming = (key == '2' || key == '3');
                        Console.WriteLine(
                           $"\nRolled {kerusakan_pedang.Roll} for {kerusakan_pedang.Damage} HP\n");
                        break;

                    case 'A':
                        kerusakan_panah.Roll = LemparDadu(1);
                        kerusakan_panah.Keajaiban = (key == '1' || key == '3');
                        kerusakan_panah.Nyala = (key == '2' || key == '3');
                        Console.WriteLine(
                           $"\nRolled {kerusakan_panah.Roll} for {kerusakan_panah.Kerusakan} HP\n");
                        break;

                    default:
                        return;
                }
            }


        } //END Main ----------------------------------------------------------------------

        public static int LemparDadu(int banyakLemparan)
        {
            int total = 0;
            for (int i = 0; i < banyakLemparan; i++) total += acak.Next(1, 7);
            return total;

        } //END function LemparDadu----------------------------------------------------------
        
     

    }//end class
}//end namespace
