/* Fisier creat si implementat de Heghea Mihail-Cristian.
 * Contine clasa Meniu, care va contine produsele disponibile de comandat.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meniu
    {
        private static Meniu _instance = null;
        private List<TipProdus> _productList;
        private CreatorProduct _creator;
        /// <summary>
        /// Constructorul este privat pentru ca implementeaza sablonul de proiectare Singleton.
        /// </summary>
        private Meniu()
        {
            //Se creaza fabrica si se initializeaza lista de tipuri de produse
            _creator = new CreatorProduct();
            _productList = new List<TipProdus>();
            //Se creaza fiecare tip de produse si se adauga produsele in listele cu fiecare tip de produs
            //Gustari reci
            TipProdus gustariReci = new TipProdus("Gustari Reci");
            gustariReci.AddProduct(_creator.CreateProduct(ProductName.PSalataCaesar));
            gustariReci.AddProduct(_creator.CreateProduct(ProductName.PSalataBulgareasca));
            gustariReci.AddProduct(_creator.CreateProduct(ProductName.PSalataGreceasca));
            gustariReci.AddProduct(_creator.CreateProduct(ProductName.PSalatCapresse));
            _productList.Add(gustariReci);

            //Paste
            TipProdus paste = new TipProdus("Paste");
            paste.AddProduct(_creator.CreateProduct(ProductName.PSpaghettiCarbonara));
            paste.AddProduct(_creator.CreateProduct(ProductName.PSpaghettiBolognese));
            paste.AddProduct(_creator.CreateProduct(ProductName.PLinguiniConFrttiDiMare));
            paste.AddProduct(_creator.CreateProduct(ProductName.PPennQuattroFormaggi));
            paste.AddProduct(_creator.CreateProduct(ProductName.PLasagna));
            _productList.Add(paste);

            //Supe/Ciorbe
            TipProdus supe = new TipProdus("Supe/Ciorbe");
            supe.AddProduct(_creator.CreateProduct(ProductName.PCiorbaRadauteana));
            supe.AddProduct(_creator.CreateProduct(ProductName.PCiorbaBurta));
            supe.AddProduct(_creator.CreateProduct(ProductName.PCiorbaPerisoare));
            supe.AddProduct(_creator.CreateProduct(ProductName.PCiorbaDeVacuta));
            supe.AddProduct(_creator.CreateProduct(ProductName.PCiorbaDeFasole));
            _productList.Add(supe);

            //Preparate Pui
            TipProdus preparatePui = new TipProdus("Preparate Pui");
            preparatePui.AddProduct(_creator.CreateProduct(ProductName.PPieptDePuiLaGratar));
            preparatePui.AddProduct(_creator.CreateProduct(ProductName.PPieptDePuiCuSosGrogonzola));
            preparatePui.AddProduct(_creator.CreateProduct(ProductName.PFicateiPasare));
            preparatePui.AddProduct(_creator.CreateProduct(ProductName.PAripioarePicante));
            preparatePui.AddProduct(_creator.CreateProduct(ProductName.PCiulamaDePuiCuBranzaSiMamaliguta));
            preparatePui.AddProduct(_creator.CreateProduct(ProductName.PPuiShanghai));
            preparatePui.AddProduct(_creator.CreateProduct(ProductName.PPiFteluteMoldovenesti));
            preparatePui.AddProduct(_creator.CreateProduct(ProductName.PCordonBleu));
            _productList.Add(preparatePui);

            //Preparate Porc
            TipProdus preparatePorc = new TipProdus("Preparate Porc");
            preparatePorc.AddProduct(_creator.CreateProduct(ProductName.PCeafaLaGratar));
            preparatePorc.AddProduct(_creator.CreateProduct(ProductName.PCotletLaGratar));
            preparatePorc.AddProduct(_creator.CreateProduct(ProductName.PFrigaruiDePorcCuLegume));
            preparatePorc.AddProduct(_creator.CreateProduct(ProductName.PSnitelPorc));
            preparatePorc.AddProduct(_creator.CreateProduct(ProductName.PCiolanDePorcCuVarzaCalita));
            preparatePorc.AddProduct(_creator.CreateProduct(ProductName.PTochituraMoldoveneasca));
            preparatePorc.AddProduct(_creator.CreateProduct(ProductName.PMici));
            preparatePorc.AddProduct(_creator.CreateProduct(ProductName.PFasoleCuCiolan));
            _productList.Add(preparatePorc);

            //Desterturi
            TipProdus deserturi = new TipProdus("Deserturi");
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PClatiteCuGem));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PClatiteCuFinetti));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PClatiteCuInghetataTopingSiFrisca));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PPapanasi));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PInghetataAsortata));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PTiramisu));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PBaclava));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PCheeseCake));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PTortCuFructe));
            deserturi.AddProduct(_creator.CreateProduct(ProductName.PTortCuCiocolata));
            _productList.Add(deserturi);

        }
        /// <summary>
        /// Getter pentru lista de tipuri de produse
        /// </summary>
        public List<TipProdus> ProductList
        {
            get => _productList;
        }
        /// <summary>
        /// Functia care intoarce instanta unica a clasei Meniu, daca a fost instantiata deja se intoarce instanta existenta
        /// Iar daca nu a fost instantiata, se instantiaza si apoi se intoarce instanta.
        /// </summary>
        /// <returns></returns>
        public static Meniu GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Meniu();
            }
            return _instance;
        }
    }
}
