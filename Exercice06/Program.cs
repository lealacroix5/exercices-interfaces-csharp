Console.WriteLine("Hello, World!");

var facture = new Facture(1);
var rapport = new Rapport("Rapport annuel");

IImprimable imprimable = facture;
IExportable exportable = facture;

imprimable.Imprimer();
exportable.Exporter("facture.pdf");

rapport.Exporter("rapport.pdf");

// RÉPONSES AUX QUESTIONS

// 1. Un seul objet Facture a été créé.

// 2. Oui, imprimable et exportable peuvent
// référencer le même objet Facture.

// 3. Avec imprimable, on peut appeler Imprimer().

// 4. Avec exportable, on peut appeler Exporter().

// 5. Oui, une classe C# peut implémenter
// plusieurs interfaces.