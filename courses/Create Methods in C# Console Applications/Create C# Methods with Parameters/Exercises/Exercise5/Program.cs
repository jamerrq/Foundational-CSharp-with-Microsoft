string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

// display internal email addresses
void DisplayInternalEmailAddresses(string name, string surname)
{
    // The username format is the first two characters of the employee first name, followed by their last name. For example, an employee named "Robert Bavin" would have the username "robavin". The domain for internal employees is "contoso.com".
    Console.WriteLine($"{name[..2].ToLower()}{surname.ToLower()}@contoso.com");
}

// display external email addresses
void DisplayExternalEmailAddresses(string name, string surname)
{
    // The username format is the first two characters of the employee first name, followed by their last name. For example, an employee named "Vinnie Ashton" would have the username "vinashton". The domain for external employees is "hayworth.com".
    Console.WriteLine($"{name[..2].ToLower()}{surname.ToLower()}@{externalDomain}");
}

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayInternalEmailAddresses(corporate[i, 0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayExternalEmailAddresses(external[i, 0], external[i, 1]);
}
