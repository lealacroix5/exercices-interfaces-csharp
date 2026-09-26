Console.WriteLine("Hello, World!");

static void AfficherTotal(
    decimal montantCommande,
    ICalculLivraison calculLivraison)
{
    decimal fraisLivraison = calculLivraison.Calculer(montantCommande);
    decimal total = montantCommande + fraisLivraison;

    Console.WriteLine($"Montant de la commande : {montantCommande:F2} €");
    Console.WriteLine($"Frais de livraison : {fraisLivraison:F2} €");
    Console.WriteLine($"Total : {total:F2} €");
    Console.WriteLine();
}

AfficherTotal(
    40m,
    new LivraisonStandard());

AfficherTotal(
    40m,
    new LivraisonExpress());

AfficherTotal(
    40m,
    new RetraitMagasin());

AfficherTotal(
    40m,
    new LivraisonInternationale());

Console.WriteLine("Commande de 100 € :");

AfficherTotal(
    100m,
    new LivraisonStandard());

AfficherTotal(
    100m,
    new LivraisonExpress());

AfficherTotal(
    100m,
    new RetraitMagasin());

AfficherTotal(
    100m,
    new LivraisonInternationale());