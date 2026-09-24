Console.WriteLine("Hello, World!");

var produit = new Produit("Clavier", 49.90m);
var client = new Client("Alice", "alice@exemple.com");

produit.Afficher();
client.Afficher();

// RÉPONSES AUX QUESTIONS

// 1. Non, Produit n'hérite pas de Client.

// 2. Non, Client n'hérite pas de Produit.

// 3. Les deux classes peuvent afficher leurs
// informations grâce à la méthode Afficher().

// 4. L'interface permet à plusieurs classes
// différentes de partager un même contrat,
// tout en ayant leur propre implémentation.