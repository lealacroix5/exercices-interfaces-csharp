public class LivraisonStandard : ICalculLivraison
{
    public decimal Calculer(decimal montantCommande)
    {
        if (montantCommande < 50m)
        {
            return 5m;
        }

        return 0m;
    }
}