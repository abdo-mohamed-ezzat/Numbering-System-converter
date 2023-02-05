namespace numbreing
{
    public class Gray : Decimal
    {
        public char xor_c(char a, char b)
        {
            return (a == b) ? '0' : '1';
        }

        // Helper function to flip the bit
        public char flip(char c)
        {
            return (c == '0') ? '1' : '0';
        }

        // function to convert binary
        // string to gray string
        public string binarytoGray(string binary)
        {
            string gray = "";

            // MSB of gray code is same
            // as binary code
            gray += binary[0];

            // Compute remaining bits, next
            // bit is computed by doing XOR
            // of previous and current in
            // Binary
            for (int i = 1; i < binary.Length; i++)
            {

                // Concatenate XOR of previous
                // bit with current bit
                gray += xor_c(binary[i - 1],
                              binary[i]);
            }

            return gray;
        }

        // function to convert gray code
        // string to binary string
        public string graytoBinary(string gray)
        {

            string binary = "";

            // MSB of binary code is same
            // as gray code
            binary += gray[0];

            // Compute remaining bits
            for (int i = 1; i < gray.Length; i++)
            {

                // If current bit is 0,
                // concatenate previous bit
                if (gray[i] == '0')
                    binary += binary[i - 1];

                // Else, concatenate invert of
                // previous bit
                else
                    binary += flip(binary[i - 1]);
            }

            return binary;
        }

        // Driver program to test above
        // functions

    }
}
