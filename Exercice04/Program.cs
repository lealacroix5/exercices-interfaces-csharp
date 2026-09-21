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