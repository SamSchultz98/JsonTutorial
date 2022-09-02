using JsonTutorial;
using System.Text.Json;

User noah = new User                                    //Universial Constructor
{           
    id = 1,
    Username = "N.Phence",
    Password = "Password",
    FirstName = "Noah",
    Lastname = "Phence",
    Phone = "411",
    Email = "N.Phence12@Gmail.com",
    IsReviewer = true,
    IsAdmin = false

};

JsonSerializerOptions options = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    WriteIndented = true

};


var json = JsonSerializer.Serialize(noah, options);

User? noahConverted = JsonSerializer.Deserialize<User>(json);       //Deserialize convertes the json into a different type


var v = 1;