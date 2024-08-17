using DesignPatterns.Strutural_Patterns.Composite.Model;

namespace DesignPatterns.Strutural_Patterns.Composite;

public class CompositeClient
{
    public void Buy()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            ComponentModel product01 = new ProductLeaf("Caneca", 49.99);
            ComponentModel product02 = new ProductLeaf("Laís", 2.50);
            ComponentModel product03 = new ProductLeaf("Chinelo", 33.50);

            ComponentModel product04 = new ProductLeaf("Estatua da liberdade tamanho real", 3199.99);

            ComponentModel smallBox = new ProductComposite();
            smallBox.Add(product01, product02, product03);

            ComponentModel bigBox = new ProductComposite();
            bigBox.Add(smallBox, product04);

            var totalValue = bigBox.Operation();

            Console.WriteLine($"Valor total: {totalValue}");

            Console.WriteLine("\nCompra finalizada com sucesso! Deseja comprar novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}