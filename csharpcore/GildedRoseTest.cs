using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName ="Deveria diminuir um aos dias que restam para vender o produto")]
        public void DeveriaDiminuirDataDevenda()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 3, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(2, Items[0].SellIn);
        }

        //Quando a data de venda do item tiver passado, a qualidade (quality) do item diminui duas vezes mais rapido.

        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria diminuir a qualidade duas vezes mais rápido depois que a SellIn estir passado")]
        public void DeveriaDiminuirQualidadeDuasVezesMaisRápidoDepoisQueSellInEstirPassado()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(48, Items[0].Quality);
        }

        //A qualidade (quality) do item não pode ser negativa
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "A Qualidade De Item Não Pode Ser Negativa")]
        public void QualidadeDeItemNaoPodeSerNegativa()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(0, Items[0].Quality);
        }

        //O "Queijo Brie envelhecido" (Aged Brie), aumenta sua qualidade(quality) em 1 unidade a medida que envelhece.
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria aumentar a qualidade do queijo em Um conforme Envelhece")]
        public void DeveriaAumentarQualidadeDoQueijoEmUmConformeEnvelhece()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(50, Items[0].Quality);
        }

        //A qualidade (quality) de um item não pode ser maior que 50.
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria Ser Cinquenta A Qualidade Maxima Do Item")]
        public void DeveriaSerCinquentaQualidadeMaximaDoItem()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(50, Items[0].Quality);
        }

        //O item "Sulfuras" (Sulfuras), por ser um item lendário, não precisa ter uma data de venda (SellIn) 
        //e sua qualidade (quality) não precisa ser diminuida.
        //"Sulfuras" por serem um item lendário vão ter uma qualidade imutavel de 80.
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria Oitenta Para Sempre a Qualidade De Sulfuras")]
        public void DeveriaOitentaParaSempreQualidadeDeSulfuras()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(80, Items[0].Quality);
        }

        //O item "Entrada para os Bastidores" (Backstage Passes), assim como o "Queijo Brie envelhecido", 
        //aumenta sua qualidade (quality) a medida que o dia da venda (SellIn) se aproxima;
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria Aumentar a Qualidade De Backstage Passes conforme envelhece")]
        public void DeveriaAumentarQualidadeDeBackstagePassesConformeEnvelhece()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(50, Items[0].Quality);
        }

        // A qualidade (quality) de (Backstage Passes) aumenta em 2 unidades quando a data de venda (SellIn) é igual ou menor que 10.
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria Aumentar a Qualidade De Backstage Passes Vezes Dois Quando SellIn For Menor Ou Igual A Dez")]
        public void DeveriaAumentarAQualidadeDeBackstagePassesVezesDoisQuandoSellInForMenorOuIgualADez()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 48 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(50, Items[0].Quality);
        }

        // A qualidade (quality) de (Backstage Passes) aumenta em 3 unidades quando a data de venda (SellIn) é igual ou menor que 5.
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria Aumentar a Qualidade De Backstage Passes Vezes Tres Quando SellIn For Menor Ou Igual A Cinco")]
        public void DeveriaAumentarAQualidadeDeBackstagePassesVezesTresQuandoSellInForMenorOuIgualADez()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 47 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(50, Items[0].Quality);
        }

        // A qualidade (quality) do item vai direto à 0 quando a data de venda (SellIn) tiver passado.
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria Aumentar a Qualidade De Backstage Passes Vezes Tres Quando SellIn For Menor Ou Igual A Cinco")]
        public void DeveriaZerarAQualidadeQuandoDataDeSellInTerminar()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 47 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(0, Items[0].Quality);
        }


        //Os itens "Conjurados" (Conjured) diminuem a qualidade (quality) duas vezes mais rápido que os outros itens.
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Deveria Diminuir a Qualidade De Conjured Duas Vezes Mais Rapido")]
        public void DeveriaDiminuirQualidadeDeDonjuredDuasVezesMaisRapido()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 6 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(4, Items[0].Quality);
        }

        //Como os itens "Conjurados" (Conjured) já diminuem a qualidade (quality) duas vezes mais rápido que os outros itens
        //Quando a validade chegar ao fim deverar duplicar mais uma vez a diminuição da qualidade por dia.
        [Trait("GildedRose", "UpdateQuality")]
        [Fact(DisplayName = "Item Conjurado Que Tiver Passado a Data da SellIn Deverar Dobra Mais Uma vez a Diminuicao Da Qualidade")]
        public void ItemConjuradoQueTiverPassadoDataDaSellInDeverarDobraMaisUmaVezADiminuicaoDaQualidade()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 } };
            GildedRose app = new GildedRose(Items);
            //Act
            app.UpdateQuality();
            //Assert
            Assert.Equal(2, Items[0].Quality);
        }

    }
}