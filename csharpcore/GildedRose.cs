using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    DiminuindoQualidadeDoItem(i);
                }
                else
                {
                    AumentandoQualidadeDoItem(i);
                }

                DiminuindoDiasRestantesParaVenda(i);

                TratandoItemVencidos(i);
            }
        }

        private void DiminuindoQualidadeDoItem(int i)
        {
            if (Items[i].Quality > 0)
            {
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].Quality = Items[i].Quality - 1;
                    DiminuindoQualidadeDeConjured(i);
                }
            }
        }

        private void AumentandoQualidadeDoItem(int i)
        {
            if (Items[i].Quality < 50)
            {
                Items[i].Quality = Items[i].Quality + 1;

                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].SellIn < 11)
                    {
                        AdicionandoMaisUmNaAQualidadeDoItem(i);
                    }

                    if (Items[i].SellIn < 6)
                    {
                        AdicionandoMaisUmNaAQualidadeDoItem(i);
                    }
                }
            }
        }

        private void DiminuindoDiasRestantesParaVenda(int i)
        {
            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }
        }

        private void TratandoItemVencidos(int i)
        {
            if (Items[i].SellIn < 0)
            {
                if (Items[i].Name != "Aged Brie")
                {
                    if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        DiminuindoQualidadeDoItem(i);
                    }
                    else
                    {
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                }
                else
                {
                    AdicionandoMaisUmNaAQualidadeDoItem(i);
                }
            }
        }

        private void AdicionandoMaisUmNaAQualidadeDoItem(int i)
        {
            if (Items[i].Quality < 50)
            {
                Items[i].Quality = Items[i].Quality + 1;
            }
        }

        private void DiminuindoQualidadeDeConjured(int i)
        {
            if (Items[i].Name == "Conjured Mana Cake")
            {
                Items[i].Quality = Items[i].Quality - 1;
            }
        }

    }
}
