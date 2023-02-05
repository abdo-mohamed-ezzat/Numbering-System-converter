namespace numbreing
{
    public class Octal : Decimal
    {
        Decimal obj = new Decimal();
        //octal to decimal==> 
        //octal to binary ==>octal >> decimal >> binary
        //octal to hexa ==> octal >> decimal >> hexa

        public string octalToDec(string octalNum)
        {
            return obj.Todecimal(8, octalNum);
        }

        public string octalToBinary(string octalNum)
        {
            return obj.decToBinary(int.Parse(octalToDec(octalNum)));
        }

        public string octalToHexa(string OctalNum)
        {
            return obj.decToHexa(int.Parse(octalToDec(OctalNum)));
        }

    }


}
