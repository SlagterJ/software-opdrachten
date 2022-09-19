static string FullName(string forename, string surname)
{
    return $"{forename} {surname}";
}

static int Times(string forename, string surname)
{
    int forenameLength = forename.Length;
    int surnameLength = surname.Length;

    return forenameLength * surnameLength;
}

static bool IsIn(string character, string word)
{
    return word.Contains(character);
}

static List<string> InCommon(string forename, string surname)
{
    List<string> commonLetters = new();

    foreach (char letter in forename)
    {
        if (surname.Contains(letter))
        {
            commonLetters.Add(letter.ToString());
        }
    }

    return commonLetters;
}

static int HowMuchLonger(string forename, string surname)
{
    int forenameLength = forename.Length;
    int surnameLength = surname.Length;

    int howLong = surnameLength - forenameLength;

    if (howLong < 0) return 0;

    return howLong;
}

static string ForenameOf(string name)
{
    string[] splitName = name.Split(" ");
    return splitName.First();
}

static string SurnameOf(string name)
{
    string[] splitName = name.Split("");
    return splitName.Last();
}

static string ReverseName(string input)
{
    char[] inputArray = input.ToCharArray();
    Array.Reverse(inputArray);
    return new string(inputArray);
}

static string ForenameReversed(string name)
{
    string[] splitName = name.Split();
    string forename = splitName.First();

    return ReverseName(forename);
}

static string SurnameReversed(string name)
{
    string[] splitName = name.Split();
    string surname = splitName.Last();

    return ReverseName(surname);
}

static string MangleName(string forename, string surname)
{
    int amountOfLoops = 0;

    if (forename.Length > surname.Length)
    {
        amountOfLoops = forename.Length;
    }
    else
    {
        amountOfLoops = surname.Length;
    }

    char[] forenameArray = forename.ToCharArray();
    Queue<char> forenameQueue = new(forenameArray);
    char[] surnameArray = surname.ToCharArray();
    Queue<char> surnameQueue = new(surnameArray);

    List<char> result = new();

    for (int i = 0; i < amountOfLoops; i++)
    {
        if (forenameQueue.Count > 0)
        {
            result.Add(forenameQueue.Dequeue());
        }
        if (surnameQueue.Count > 0)
        {
            result.Add(surnameQueue.Dequeue());
        }
    }

    return new string(result.ToArray());
}

static string MangleNameForeSur(string name)
{
    string[] splitName = name.Split();
    string forename = splitName.First();
    string surname = splitName.Last();

    return MangleName(forename, surname);
}

static string MangleNameSurFore(string name)
{
    string[] splitName = name.Split();
    string forename = splitName.First();
    string surname = splitName.Last();

    return MangleName(surname, forename);
}

static int WordCount(string text)
{
    string[] words = text.Split(" ");
    return words.Length;
}

static float MeanLength(string text)
{
    int wordCount = WordCount(text);
    string[] words = text.Split(" ");
    List<string> wordList = new(words);
    Queue<string> wordQueue = new(words);
    List<int> letterCounts = new();

    wordList.ForEach((word) =>
    {
        letterCounts.Add(word.Length);
    });

    int letterSum = letterCounts.Sum();

    float result = (float)letterSum / wordCount;

    return result;
}

static bool IsLeapYear(int year)
{
    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                return true;
            }

            return false;
        }

        return true;
    }

    return false;
}

static int AmountOfDaysInFebruary(int year)
{
    if (IsLeapYear(year))
    {
        return 29;
    }

    return 28;
}

static int AmountOfDaysInYear(int year)
{
    if (IsLeapYear(year))
    {
        return 366;
    }

    return 365;
}

Console.WriteLine(FullName("Ada", "Lovelace"));
Console.WriteLine(Times("Ada", "Lovelace"));
Console.WriteLine(IsIn("a", "Ada Lovelace"));
Console.WriteLine(IsIn("r", "Ada Lovelace"));
Console.WriteLine(InCommon("Donald", "Knuth"));
Console.WriteLine(HowMuchLonger("Donald", "Knuth"));
Console.WriteLine(ForenameOf("Alan Kay"));
Console.WriteLine(SurnameOf("Alan Kay"));
Console.WriteLine(ForenameReversed("Edsger W. Dijkstra"));
Console.WriteLine(SurnameReversed("Edsger W. Dijkstra"));
Console.WriteLine(MangleNameForeSur("Edsger W. Dijkstra"));
Console.WriteLine(MangleNameSurFore("Donald Knuth"));
Console.WriteLine(WordCount("The art of programming is the art of organizing complexity."));
Console.WriteLine(MeanLength("If debugging is the process of removing software bugs, then programming must be the process of putting them in."));
Console.WriteLine(IsLeapYear(2019));
Console.WriteLine(IsLeapYear(2020));
Console.WriteLine(AmountOfDaysInFebruary(2019));
Console.WriteLine(AmountOfDaysInFebruary(2020));
Console.WriteLine(AmountOfDaysInYear(2019));
Console.WriteLine(AmountOfDaysInYear(2020));
