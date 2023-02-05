namespace numbreing
{
    public class Binary : Decimal
    {
        Decimal obj = new Decimal();
        //binary to decimal 
        //binary to octal ==> binary >> decimal >> octal
        //binary to hexa ==> binary >> decimal >> hexa


        public string binaryToDec(string binaryNum)
        {
            return obj.Todecimal(2, binaryNum);
        }

        public string binaryToOctal(string binaryNum)
        {
            return obj.decToOctal(double.Parse(binaryToDec(binaryNum)));
        }
        public string binaryToHexa(string binaryNum)
        {
            return obj.decToHexa(int.Parse(binaryToDec(binaryNum)));
        }


    }

}
