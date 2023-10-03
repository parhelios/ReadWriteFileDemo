using ReadWriteFileDemo;

var movieDb = new MovieCollection();

////Path.Combine används för att bygga sökvägar på ett korrekt sätt.
////I Environment kan man hitta alla standard-mappar i en windowsdator. Tex. AppData, Desktop, MyDocuments mm.
//var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Demo.txt");

////File.Exists kan användas för att kontrollera ifall en fil finns på en given sökväg
//if (!File.Exists(path))
//{
//    //StreamWriter används för att öppna en fil och skriva till den.
//    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
//    using StreamWriter sw = new StreamWriter(path);
//    foreach (var movie in movieDb.Movies)
//    {
//        //WriteLine används för att skriva en ny rad.
//        sw.WriteLine(movie);
//    }
//}

//if (File.Exists(path))
//{
//    string? line;
//    //StreamReader används för att öppna en fil och läsa från den.
//    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
//    using StreamReader sr = new StreamReader(path);
//    //ReadLine() läser nästa rad i filen
//    while ((line = sr.ReadLine()) != null)
//    {
//        Console.WriteLine(line);
//    }
//}

//foreach (var movie in movieDb.Movies)
//{
//    if (movie.Genres.Contains(Genres.SciFi))
//    {
//        System.Console.WriteLine(movie.Title);
//    }
//}



#region MyRegion

//Console.WriteLine("--------");

//Console.WriteLine("Vilken genre till du kika på? Skriv nummer.");
//int counter = 0;
//foreach (var genre in Enum.GetValues(typeof(Genres)))
//{
//    Console.WriteLine($"{counter}: {genre}");
//    counter++;
//}

//int.TryParse(Console.ReadLine(), out int output);

//switch (output)
//{
//    case 0:
//        foreach (var movie in movieDb.Movies)
//        {
//            if (movie.Genres.Contains(Genres.SciFi))
//            {
//                System.Console.WriteLine(movie.Title);
//            }
//        }
//        break;
//    case 1:
//        foreach (var movie in movieDb.Movies)
//        {
//            if (movie.Genres.Contains(Genres.Action))
//            {
//                System.Console.WriteLine(movie.Title);
//            }
//        }
//        break;
//    case 2:
//        foreach (var movie in movieDb.Movies)
//        {
//            if (movie.Genres.Contains(Genres.Comedy))
//            {
//                System.Console.WriteLine(movie.Title);
//            }
//        }
//        break;
//    case 3:
//        foreach (var movie in movieDb.Movies)
//        {
//            if (movie.Genres.Contains(Genres.Drama))
//            {
//                System.Console.WriteLine(movie.Title);
//            }
//        }
//        break;
//    case 4:
//        foreach (var movie in movieDb.Movies)
//        {
//            if (movie.Genres.Contains(Genres.Horror))
//            {
//                System.Console.WriteLine(movie.Title);
//            }
//        }
//        break;
//    case 5:
//        foreach (var movie in movieDb.Movies)
//        {
//            if (movie.Genres.Contains(Genres.Thriller))
//            {
//                System.Console.WriteLine(movie.Title);
//            }
//        }
//        break;
//    case 6:
//        foreach (var movie in movieDb.Movies)
//        {
//            if (movie.Genres.Contains(Genres.Fantasy))
//            {
//                System.Console.WriteLine(movie.Title);
//            }
//        }
//        break;
//}

#endregion



//Console.WriteLine("--------");

var appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Demo.txt");


//foreach (var movie in movieDb.Movies)
//{
//    foreach (var genre in Enum.GetValues(typeof(Genres)))
//    {
//        if (movie.Genres.Contains(Genres.SciFi))
//        {
//            string temp = genre.ToString();
//            temp += ".txt";

//            //Console.WriteLine(temp);
//            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), temp);
//            sw2.WriteLine(genre);
//        }
//    }
//}

//for (int i = 0; i < Enum.GetValues(typeof(Genres)).Length; i++)
//{
//    foreach (var movie in movieDb.Movies)
//    {
//        if (movie.Genres.Contains((Genres)i))
//        { 
//            string temp = ((Genres)i).ToString();
//            temp += ".txt";

//            Console.WriteLine(temp);
//            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), temp);
//            using StreamWriter sw2 = new StreamWriter(appDataPath);

//            sw2.WriteLine(((Genres)i));
//        }
//    }

//}

string folderName = @"C:\Users\Tobias\Desktop\TempMapp";
// If directory does not exist, create it
if (!Directory.Exists(folderName))
{
    Directory.CreateDirectory(folderName);
}



foreach (var movie in movieDb.Movies)
{
    for (int i = 0; i < Enum.GetValues(typeof(Genres)).Length; i++)
    {
        if (movie.Genres.Contains((Genres)i))
        {
            appDataPath = Path.Combine(folderName, $"{(Genres)i}.txt");
            using var sw2 = new StreamWriter(appDataPath);

            sw2.WriteLine(((Genres)i));
        }
    }
}

for (int i = 0; i < Enum.GetValues(typeof(Genres)).Length; i++)
{
    appDataPath = Path.Combine(folderName, $"{(Genres)i}.txt");
    using var sr2 = new StreamReader(appDataPath);

    if (File.Exists(appDataPath))
    {
        string line;

        while ((line = sr2.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}


var hereditary = new Movie("Hereditary", 2.1, "A grieving family is haunted by tragic and disturbing occurrences.", new List<Genres>()
    {
        Genres.Horror
    });


var lighthouse = new Movie("The Lighthouse", 1.82, "Two lighthouse keepers try to maintain their sanity while living on a remote and mysterious New England island in the 1890s.", new List<Genres>()
    {
        Genres.Horror,
        Genres.Thriller
    });

var blackCatWhiteCat = new Movie("Black Cat, White Cat", 2.1, "Matko and his son Zare live on the banks of the Danube river and get by through hustling and basically doing anything to make a living. In order to pay off a business debt Matko agrees to marry off Zare to the sister of a local gangster.", new List<Genres>()
    {
        Genres.Comedy
    });

movieDb.Movies.Add(hereditary);
movieDb.Movies.Add(lighthouse);
movieDb.Movies.Add(blackCatWhiteCat);


for (int i = 0; i < Enum.GetValues(typeof(Genres)).Length; i++)
{
    appDataPath = Path.Combine(folderName, $"{(Genres)i}.txt");

    using var sw2 = new StreamWriter(appDataPath);
    foreach (var movie in movieDb.Movies)
    {
        if (movie.Genres.Contains((Genres)i))
        {
            sw2.WriteLine(movie.ToString() + "\n");
        }
    }


}


//foreach (var movie in movieDb.Movies)
//{
//    for (int i = 0; i < Enum.GetValues(typeof(Genres)).Length; i++)
//    {
//        if (movie.Genres.Contains((Genres)i))
//        {
//            appDataPath = Path.Combine(folderName, $"{(Genres)i}.txt");
//            using var sw2 = new StreamWriter(appDataPath);

//            sw2.WriteLine(movie.ToString() + "\n");
//        }
//    }
//}