using CaesarEncryption;





string text     = "Hello World!";
string password = "123ABC";
string encryption = "Igopt-Xqupi+";

//-------------------- Encode a string --------------------


encryption = Encrypter.Encode(text, password);

Console.WriteLine("Encoded Text: " + encryption);



//-------------------- Decode a string --------------------


text = Encrypter.Decode(encryption, password);

Console.WriteLine("Decoded Text: " + text);
