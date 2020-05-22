using Restaurant;
using System;
using System.Collections.Generic;
using System.Text;
using Produs;

namespace Restaurant
{
    public class CreatorProduct
    {
        public Produs CreateProduct(ProductName type) 
        {
            switch (type)
            {
                //paste
                case ProductName.PSpaghettiCarbonara:
                    return new SpaghettiCarbonara();

                case ProductName.PSpaghettiBolognese:
                    return new SpaghettiBolognese();

                case ProductName.PLinguiniConFrttiDiMare:
                    return new LinguiniConFrttiDiMare();

                case ProductName.PPennQuattroFormaggi:
                    return new PenneQuattroFormaggi();

                case ProductName.PLasagna:
                    return new Lasagna();

                //Gustari reci
                case ProductName.PSalataCaesar:
                    return new SalataCaesar();

                case ProductName.PSalataGreceasca:
                    return new SalataGreceasca();

                case ProductName.PSalatCapresse:
                    return new SalataCapresse();

                case ProductName.PSalataBulgareasca:
                    return new SalataBulgareasca();

                    //supe/ciorbe
                case ProductName.PCiorbaRadauteana:
                    return new CiorbaRadauteana();

                case ProductName.PCiorbaBurta:
                    return new CiorbaBurta();

                case ProductName.PCiorbaPerisoare:
                    return new CiorbaPerisoare();

                case ProductName.PCiorbaDeVacuta:
                    return new CiorbaDeVacuta();

                case ProductName.PCiorbaDeFasole:
                    return new CiorbaDeFasole();
                    
                    //Preparate pui
                case ProductName.PPieptDePuiCuSosGrogonzola:
                    return new PietDePuiCuSosGongorzola();

                case ProductName.PPieptDePuiLaGratar:
                    return new PietDePuiLaGratar();

                case ProductName.PFicateiPasare:
                    return new FicateiPasare();

                case ProductName.PAripioarePicante:
                    return new AripioarePicante();

                case ProductName.PCiulamaDePuiCuBranzaSiMamaliguta:
                    return new CiulamaDePuiCuBranzaSiMamaliga();

                case ProductName.PPuiShanghai:
                    return new PuiShangai();

                case ProductName.PPiFteluteMoldovenesti:
                    return new ChifteluteMoldovenesti();

                case ProductName.PCordonBleu:
                    return new CordonBleu();

                    //Preparate porc
                case ProductName.PCeafaLaGratar:
                    return new CeafaLaGratar();

                case ProductName.PCotletLaGratar:
                    return new CotletLaGratar();

                case ProductName.PFrigaruiDePorcCuLegume:
                    return new FrigaruiDePorcCuLegume();

                case ProductName.PSnitelPorc:
                    return new SnitelDePorc();
                
                case ProductName.PCiolanDePorcCuVarzaCalita:
                    return new CiolanDePorcCuVarzaCalita();

                case ProductName.PTochituraMoldoveneasca:
                    return new TochituraMoldoveneascaCuMamaliga();

                case ProductName.PMici:
                    return new Mici();

                case ProductName.PFasoleCuCiolan:
                    return new CiolanDePorcCuFasole();

                    //deserturi
                case ProductName.PClatiteCuGem:
                    return new ClatiteCuGem();

                case ProductName.PClatiteCuFinetti:
                    return new ClatiteCuFinettiSiBanana();

                case ProductName.PClatiteCuInghetataTopingSiFrisca:
                    return new ClatiteCuInghetataSiFrisca();

                case ProductName.PPapanasi:
                    return new Papanasi();

                case ProductName.PInghetataAsortata:
                    return new InghetataAsortata();

                case ProductName.PTiramisu:
                    return new Tiramisu();

                case ProductName.PBaclava:
                    return new Baclava();

                case ProductName.PCheeseCake:
                    return new CheesecakeCuCapsuni();

                case ProductName.PTortCuFructe:
                    return new TortCuFructe();

                case ProductName.PTortCuCiocolata:
                    return new TortCuCiocolata();

            }
            return null; ;
        }
    }
}
