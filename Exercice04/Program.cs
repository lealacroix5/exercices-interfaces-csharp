Console.WriteLine("Hello, World!");

static void AfficherElement(IAffichable element)
{
    element.Afficher();
}

var produit = new Produit("Clavier", 49.90m);
var client = new Client("Alice", "alice@exemple.com");
var commande = new Commande(1, 99.90m);

AfficherElement(produit);
AfficherElement(client);
AfficherElement(commande);

// RÉPONSES AUX QUESTIONS

// 1. Non, il n'a pas été nécessaire de modifier
// AfficherElement() pour ajouter Commande.

// 2. La méthode accepte différentes classes
// car elles implémentent toutes IAffichable.

// 3. Une méthode qui accepte uniquement Produit
// ne pourrait pas recevoir un Client ou une Commande.
// Elle serait donc moins réutilisable.