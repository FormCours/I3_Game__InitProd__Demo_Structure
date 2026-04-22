using Demo_Structure.Models;

Stagiaire s1;
s1.Prenom = "Della";
s1.Nom = "Duck";
s1.Email = "della.duck@interface3.be";
s1.DateNaissance = new DateTime(1988, 11, 6);

Stagiaire s2;
s2.Prenom = "Minnie";
s2.Nom = "Mouse";
s2.Email = "minnie.mouse@interface3.be";
s2.DateNaissance = new DateTime(1979, 1, 9);

Console.WriteLine(s1.Prenom + " " + s1.Nom);


SalleDeCours grpGame;
grpGame.Nom = "UnityGameDev 06";
grpGame.Local = "4IT-7";
grpGame.Apprenantes = new List<Stagiaire>();
grpGame.Apprenantes.Add(s1);
grpGame.Apprenantes.Add(s2);
