var filename = "myfile.txt.gen";

if (File.Exists(filename) == false)
{
    Console.WriteLine("File not present!");
    return;
}

var content = File.ReadAllText(filename);
Console.WriteLine($"File content: {content}");