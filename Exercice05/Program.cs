Console.WriteLine("Hello, World!");

var produit = new Produit("Clavier", 49.90m);
var client = new Client("Alice", "alice@example.com");
var commande = new Commande(1, 99.90m);

List<IAffichable> elements = new();

elements.Add(produit);
elements.Add(client);
elements.Add(commande);

foreach (var element in elements)
{
    element.Afficher();
}

// RÉPONSES AUX QUESTIONS

// 1. La collection peut contenir ces trois types
// car ils implémentent tous IAffichable.

// 2. Leur point commun est la méthode Afficher().

// 3. Le compilateur sait qu'il peut appeler
// la méthode Afficher() sur chaque élément.

// 4. Non, le programme n'a pas besoin de connaître
// le type exact des objets pour appeler Afficher().