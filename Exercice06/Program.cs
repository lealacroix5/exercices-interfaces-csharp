Console.WriteLine("Hello, World!");

var facture = new Facture(1, 250.00m);

IImprimable imprimable = facture;
IExportable exportable = facture;

imprimable.Imprimer();
exportable.Exporter("facture.pdf");

var rapport = new Rapport("rapport annuel");
rapport.Exporter("rapport.pdf");

// RÉPONSES AUX QUESTIONS

// 1. Facture EST UN Document : héritage.

// 2. Facture PEUT ÊTRE imprimée : interface.

// 3. L'héritage décrit principalement
// ce qu'un objet EST.

// Une interface décrit principalement
// ce qu'un objet SAIT FAIRE.