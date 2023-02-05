namespace numbreing
{
    public class HexaDecimal : Decimal

    {
        Decimal obj = new Decimal();
        //from hexa to decimal ==> done reimplementation
        //from hexa to octal ==> hexa to deci ==> octal
        //from hexa to binary==> hexa ==> decimal ==> binary

        public string hexaTodec(string hexaNum)
        {
            return obj.Todecimal(16, hexaNum);
        }

        public string hexaToOctal(string hexaNum)
        {
           return obj.decToOctal(double.Parse(hexaTodec(hexaNum))).ToString();
        }

        public string hexaToBinary(string hexaNum)
        {
            return obj.decToBinary(int.Parse(hexaTodec(hexaNum)));
        }
    }
}


