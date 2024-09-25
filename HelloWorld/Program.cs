namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //datetime
            DateTime d = DateTime.Now;
            //muuttujat
            int ika;
            int vuosi = d.Year;
            int syntymavuosi = 2007;
            int tavoiteaika = 25;
            int tavoitevuosi;

            string nimi = "Jimi";

            //lasketaan ikä ja tavoite vuosi;
            ika = vuosi - syntymavuosi;
            tavoitevuosi = syntymavuosi + tavoiteaika;

            //tulostetaan konsoliin
            Console.WriteLine($"Nimeni on {nimi}. Ikäni on {ika} ja syntymävuoteni on {syntymavuosi} ja vuonna {tavoitevuosi} täytän {tavoiteaika} vuotta!");

        }
    }
}