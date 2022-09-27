using System.Text;

Encoding asciiEncoding = Encoding.ASCII;
Encoding utfEncoding = Encoding.UTF8;

string encodedString= "This string is encoded";
byte[] asciiBytes = asciiEncoding.GetBytes(encodedString);
byte[] utfBytes = utfEncoding.GetBytes(encodedString);

for(int i = 0; i < utfBytes.Length; i++)
{
    Console.WriteLine(utfBytes[i]);
}

// decote array of bytes back to a string
string decoded = asciiEncoding.GetString(utfBytes);
Console.WriteLine(decoded);

//encode thisi string

//encodeing: the transformation of a character into a sequence of bytes


// Unsigned: max value in a byte is 255 and minimum of 0
// Signed: max value in a byte is 128 and minimum is -128
// 110010 50 unsigned
// 00110010 50 signed
// 11001101 -50 signed

//Math.Abs(-127) = 127
//Math.Abs(127) = 127