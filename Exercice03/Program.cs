Console.WriteLine("Hello, World!");

IAffichable element = new Produit("Clavier", 49.90m);
element.Afficher();

element = new Client("Alice", "alice@example.com");
element.Afficher();

// RÉPONSES AUX QUESTIONS

// 1. Le type de la variable element est IAffichable.

// 2. Dans le premier exemple, le type réel
// de l'objet est Produit.

// 3. Dans le deuxième exemple, le type réel
// de l'objet est Client.

// 4. element.Afficher() fonctionne dans les deux cas
// car Produit et Client implémentent IAffichable.

// 5. Non, on ne peut pas écrire element.Prix,
// car Prix n'est pas défini dans IAffichable.