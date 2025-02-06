/*
*Dacey Wieland
*Lab12
*This program uses a constructor and methods of encryption and decryption. It very simply gets the message
*and then encrypts and decrypts it.
*/


using System;
internal class Lab11{
    static void Main(){
        View view = new View();
        Cipher cipher = new Cipher(view.GetKey());
        string message = view.GetMessage();
        string encrypted = cipher.Encrypt(message);
        string decrypted = cipher.Decrypt(encrypted);
        Console.WriteLine("Original message: " + message);
        Console.WriteLine("Encrypted message: " + encrypted);
        Console.WriteLine("Decrypted message: " + decrypted);

    }
}