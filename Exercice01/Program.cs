Console.WriteLine("Hello, World!");

var produit = new Produit("Clavier", 49.90m);
produit.Afficher();

// RÉPONSES AUX QUESTIONS

// 1. : IAffichable signifie que Produit implémente
// l'interface IAffichable et respecte son contrat.

// 2. Si Produit ne contient pas Afficher(),
// le programme ne compile pas.

// 3. Une interface est un contrat car elle impose
// aux classes qui l'implémentent certaines méthodes.