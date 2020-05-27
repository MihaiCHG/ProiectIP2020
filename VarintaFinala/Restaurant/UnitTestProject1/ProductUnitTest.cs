/*
 * Fisier creat si implementat de Iorga Beatrice.
 * Contine clasa ProductUnitTest, aceasta clasa contine functiile ce evalueaza afisarea ingredientelor, produselor, listelor de produse si testele realizate.
 */

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;

namespace UnitTest
{
    [TestClass]
    public class ProductUnitTest
    {
        protected Ingredient _ingredient;
        protected Produs _product;
        protected string _name;
        protected TipProdus _tipProdus;
        private IPresenter _presenter;

        // functie ce evalueaza afisarea ingredientelor 
        public bool EvaluateIngredient()
        {
            if (_ingredient.Show() != null)
                return true;
            else return false;
        }

        // functie ce evalueaza afisarea descrierii produselor 
        public bool EvaluateProduct()
        {
            if (_product.descriere() != null)
                return true;
            else return false;
        }


        // functie ce evalueaza afisarea listei produselor 
        public bool EvaluateProductList()
        {
            if (_tipProdus.ShowProducts() != null)
                return true;
            else return false;
        }


        // test pt afisarea ingredientului 1
        [TestMethod]
        public void TestIngredientSos()
        {
            // test pt afisarea ingredinetelor 
            _ingredient = new SosAlb();
            Assert.AreEqual(true, EvaluateIngredient(), "Sos Alb");
        }

        // test pt afisarea ingredientului 2
        [TestMethod]
        public void TestIngredientBacon()
        {
            // test pt afisarea ingredinetelor 
            _ingredient = new Bacon();
            Assert.AreEqual(true, EvaluateIngredient(), "Bacon");
        }

        // test pt afisarea ingredientului 3
        [TestMethod]
        public void TestIngredientCiocolata()
        {
            // test pt afisarea ingredinetelor 
            _ingredient = new Ciocolata();
            Assert.AreEqual(true, EvaluateIngredient(), "Ciocolata");
        }


        //test pt afisarea produselor 4 
        [TestMethod]
        public void TestProdusDesert()
        {
            _product = new Baclava();
            Assert.AreEqual(true, EvaluateProduct(), "Baclava");
        }

        //test pt afisarea produselor 5 
        [TestMethod]
        public void TestProdusSupa()
        {
            _product = new CiorbaRadauteana();
            Assert.AreEqual(true, EvaluateProduct(), "Ciorba Radauteana");
        }

        //test pt afisarea produselor 6 
        [TestMethod]
        public void TestProdusPui()
        {
            _product = new PuiShangai();
            Assert.AreEqual(true, EvaluateProduct(), "Pui Shangai");
        }

        //test pt afisarea produselor 7 
        [TestMethod]
        public void TestProdusGustari()
        {
            _product = new SalataBulgareasca();
            Assert.AreEqual(true, EvaluateProduct(), "Salata Bulgareasca");
        }

        //test pt afisarea produselor 8 
        [TestMethod]
        public void TestProdusPaste()
        {
            _product = new Lasagna();
            Assert.AreEqual(true, EvaluateProduct(), "Lasagna");
        }

        //test pt afisarea produselor 9 
        [TestMethod]
        public void TestProdusPorc()
        {
            _product = new FrigaruiDePorcCuLegume();
            Assert.AreEqual(true, EvaluateProduct(), "Frigarui De Porc Cu Legume");
        }

        //test pt afisarea corecta a produselor 10
        [TestMethod]
        public void TestProdusGresitPaste()
        {
            _product = new SpaghettiCarbonara();
            Assert.AreEqual(false, EvaluateProduct(), "Spagheti Carbonara");
        }

        //test pt afisarea corecta a produselor 11
        [TestMethod]
        public void TestProdusGresitDesert()
        {
            _product = new Tiramisu();
            Assert.AreEqual(false, EvaluateProduct(), "Tiramissssu");
        }


        // test pt afisarea listei de produse 12
        [TestMethod]
        public void TestTipProdusSupe()
        {
            _tipProdus = new TipProdus("Supe/Ciorbe");
            Assert.AreEqual(true, EvaluateProductList(), "Supe....Ciorbe");
        }

        // test pt afisarea listei de produse 13
        [TestMethod]
        public void TestTipProdusDeserturi()
        {
            _tipProdus = new TipProdus("Deserturi");
            Assert.AreEqual(true, EvaluateProductList(), "Deserturi");
        }

        // test pt afisarea listei de produse 14
        [TestMethod]
        public void TestTipProdusPorc()
        {
            _tipProdus = new TipProdus("Preparate Porc");
            Assert.AreEqual(true, EvaluateProductList(), "Preparate Porc");
        }

        // test pt afisarea listei de produse 15
        [TestMethod]
        public void TestTipProdusPui()
        {
            _tipProdus = new TipProdus("Preparate Pui");
            Assert.AreEqual(true, EvaluateProductList(), "Preparate Pui");
        }

        // test pt afisarea descrierii 16
        [TestMethod]
        public void TestDescriereProdusSnitelPorc()
        {
            _product = new SnitelDePorc();
            Assert.AreEqual(true, EvaluateProduct(), "Snitel De Porc");
        }

        // test pt afisarea descrierii - gresit  17
        [TestMethod]
        public void TestDescriereProdusSpaghettiBolognese()
        {
            _product = new SpaghettiBolognese();
            Assert.AreEqual(true, EvaluateProduct(), "Spaghettttti Bolognese");
        }

        // test pt afisarea descrierii 18
        [TestMethod]
        public void TestDescriereProdusTortCiocolata()
        {
            _product = new TortCuCiocolata();
            Assert.AreEqual(true, EvaluateProduct(), "Tort Cu Ciocolata");
        }

        // test pt afisarea descrierii 19
        [TestMethod]
        public void TestDescriereProdusSalataBulgareasca()
        {
            _product = new SalataBulgareasca();
            Assert.AreEqual(true, EvaluateProduct(), "Salata Bulgareasca");
        }

        // test pt afisarea descrierii 20
        [TestMethod]
        public void TestDescriereProdusCiorbaBurta()
        {
            _product = new CiorbaBurta();
            Assert.AreEqual(true, EvaluateProduct(), "Ciorba Burta");
        }

        // test pt afisarea descrierii -  gresit 21 
        [TestMethod]
        public void TestDescriere()
        {
            _product = new CiorbaBurta();
            Assert.AreEqual(false, EvaluateProduct(), "Ciorba Burtaaaaa");
        }

    }
}
