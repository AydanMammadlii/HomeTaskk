using ClassLibrary;




Product p1 = new("Aydan", 3500M);
if (!File.Exists(@".\Test\test.txt"))
{
    File.Create(@".\Test\test.txt");
}
//File.Delete(@".\Test\test.txt");

StreamWriter streamWriter = new StreamWriter(@".\Test\test.txt");
streamWriter.WriteLine($"Name: {p1.Name}; Price: {p1.Price}");
streamWriter.Close();