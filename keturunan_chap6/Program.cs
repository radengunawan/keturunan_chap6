using System;

namespace keturunan_chap6
{
    class Program
    {
        static void Main(string[] args)
        {
            KerusakanPanah kerusakan_panah = new KerusakanPanah(LemparDadu(1));
            KerusakanPedang kerusakan_pedang = new KerusakanPedang(LemparDadu(3));


        } //END main ----------------------------------------------------------------------

        public void LemparDadu(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                kped.Roll = ngacak.Next(1, 7) + ngacak.Next(1, 7) + ngacak.Next(1, 7);
                kped.AturNyalaApi(flaming.IsChecked.Value);
                kped.AturKeajaiban(magic.IsChecked.Value);
            }

            DisplayKerusakan();
        } //END function LemparDadu----------------------------------------------------------
        
        //void DisplayKerusakan()
        //{
        //    //damage is variable from Textblock's XAML
        //    //damage.Text = "Rolled " + kped.Roll + " for " + kped.Kerusakan + " HP";
        //    damage.Text = "Rolled " + kped.Roll + " for " + kped.Kerusakan + " HP";
        //}


    }//end class
}//end namespace
