// See https://aka.ms/new-console-template for more information
using CeaserCypher.Helper;

Console.WriteLine("Texto a ser encriptado:");
string plainText = Console.ReadLine();

Console.WriteLine("\n");

var encrypted = CriptographyHelper.Encrypt(plainText);
var decrypted = CriptographyHelper.Decrypt(encrypted);

Console.WriteLine("Texto encriptado:");
Console.WriteLine(encrypted);
Console.WriteLine("\n");
Console.WriteLine("Texto decriptado:");
Console.WriteLine(decrypted);