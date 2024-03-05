string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] tags = orderStream.Split(',');
// sort the tags array
Array.Sort(tags);
// print the sorted array
foreach (var tag in tags)
{
    // if the tag is not 4 characters long, print ${tag} - error
    if (tag.Length != 4)
    {
        Console.WriteLine($"{tag} - error");
    }
    else
    {
        Console.WriteLine(tag);
    }
}
