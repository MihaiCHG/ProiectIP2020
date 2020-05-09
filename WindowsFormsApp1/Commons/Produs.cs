using System;
using System.Collections.Generic;
using System.Net.Security;

namespace Restaurant
{
    public abstract class Produs
    {
        protected string _nume;
        protected List<Ingredient> _ingrediente;
        protected double _gramaj;
        protected double _pret;

        public double Pret
        {
            get => _pret;
        }

        public string descriere()
        {
            string desc = _nume + "\t";
            for (int i = 0; i < _ingrediente.Count; i++)
            {
                desc += _ingrediente[i] + "\n";
            }
            desc += "Gramaj: " + _gramaj + " Pret: " + _pret;
            return desc;
        }

    }


    public class SpaghettiCarbonara : Produs
    {
        public SpaghettiCarbonara()
        {
            _nume = "Spaghetti Carbonara";
            _gramaj = 350.0;
            _pret = 28.0;
            _ingrediente.Add(new SosAlb());
            _ingrediente.Add(new Bacon());
            _ingrediente.Add(new Ou()); 
            _ingrediente.Add(new Parmezan());
        }
    }

    public class SpaghettiBolognese : Produs
    {
        public SpaghettiBolognese()
        {
            _nume = "Spaghetti Bolognese";
            _gramaj = 350.0;
            _pret = 28.0;
            _ingrediente.Add(new CarneDeVita());
            _ingrediente.Add(new Ardei());
            _ingrediente.Add(new Rosie());
            _ingrediente.Add(new Parmezan());
        }
    }

    public class LinguiniConFrttiDiMare : Produs
    {
        public LinguiniConFrttiDiMare()
        {
            _nume = "Linguini Con Frtti Di Mare";
            _gramaj = 350.0;
            _pret = 41.0;
            _ingrediente.Add(new FructeDeMare());
            _ingrediente.Add(new Rosie());
            _ingrediente.Add(new Busuioc());
        }
    }

    public class PenneQuattroFormaggi : Produs
    {
        public PenneQuattroFormaggi()
        {
            _nume = "Penne Quattro Formaggi";
            _gramaj = 350.0;
            _pret = 30.0;
            _ingrediente.Add(new SosAlb());
            _ingrediente.Add(new Gongorzola());
            _ingrediente.Add(new Cascaval());
            _ingrediente.Add(new Parmezan());
            _ingrediente.Add(new Mozzarela());
        }
    }

    public class Lasagna : Produs
    {
        public Lasagna()
        {
            _nume = "Lasagna";
            _gramaj = 350.0;
            _pret = 29.0;
            _ingrediente.Add(new CarneDeVita());
            _ingrediente.Add(new Mozzarela());
        }
    }
    //Gustari Reci
    public class SalataCaesar : Produs
    {
        public SalataCaesar()
        {
            _nume = "Salata Caesar";
            _gramaj = 250.0;
            _pret = 26.0;
            _ingrediente.Add(new Rosie());
            _ingrediente.Add(new Ardei());
            _ingrediente.Add(new PieptDePui());
            _ingrediente.Add(new Crutoane());
            _ingrediente.Add(new Dresing());
        }
    }

    public class SalataGreceasca : Produs
    {
        public SalataGreceasca()
        {
            _nume = "Salata Caesar";
            _gramaj = 250.0;
            _pret = 25.0;
            _ingrediente.Add(new Castraveti());
            _ingrediente.Add(new Rosie());
            _ingrediente.Add(new Ardei());
            _ingrediente.Add(new Cartof());
            _ingrediente.Add(new Mozzarela());
            _ingrediente.Add(new Dresing());
        }
    }

    public class SalataCapresse : Produs
    {
        public SalataCapresse()
        {
            _nume = "Salata Capresse";
            _gramaj = 250.0;
            _pret = 30.0;
            _ingrediente.Add(new Mozzarela());
            _ingrediente.Add(new Rosie());
            _ingrediente.Add(new ProsciutoCrudo());
            _ingrediente.Add(new Oregano());
            _ingrediente.Add(new UleiDeMasline());
        }
    }

    public class SalataBulgareasca : Produs
    {
        public SalataBulgareasca()
        {
            _nume = "Salata Bulgareasca";
            _gramaj = 250.0;
            _pret = 16.0;
            _ingrediente.Add(new Rosie());
            _ingrediente.Add(new Castraveti());
            _ingrediente.Add(new SuncaPresta());
            _ingrediente.Add(new Branza());
            _ingrediente.Add(new Masline());
            _ingrediente.Add(new SalataVerde());
        }
    }
    //Supe/Ciorbe
    public class CiorbaRadauteana : Produs
    {
        public CiorbaRadauteana()
        {
            _nume = "Ciorba Radauteana";
            _gramaj = 300.0;
            _pret = 13.0;
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Smantana());
            _ingrediente.Add(new PieptDePui());
            _ingrediente.Add(new Morcov());
        }
    }

    public class CiorbaBurta : Produs
    {
        public CiorbaBurta()
        {
            _nume = "Ciorba Burta";
            _gramaj = 300.0;
            _pret = 14.0;
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Smantana());
            _ingrediente.Add(new BurtaVita());
            _ingrediente.Add(new Otet());
            _ingrediente.Add(new Usturoi());
        }
    }
    public class CiorbaPerisoare : Produs
    {
        public CiorbaPerisoare()
        {
            _nume = "Ciorba Perisoare";
            _gramaj = 300.0;
            _pret = 11.0;
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Bors());
            _ingrediente.Add(new CarnePui());
            _ingrediente.Add(new Gris());
            _ingrediente.Add(new Telina());
            _ingrediente.Add(new Ceapa());
            _ingrediente.Add(new Morcov());
        }
    }

    public class CiorbaDeVacuta : Produs
    {
        public CiorbaDeVacuta()
        {
            _nume = "Ciorba De Vacuta";
            _gramaj = 300.0;
            _pret = 11.0;
            _ingrediente.Add(new CarneDeVita());
            _ingrediente.Add(new Bors());
            _ingrediente.Add(new Telina());
            _ingrediente.Add(new Morcov());
            _ingrediente.Add(new Ceapa());
            _ingrediente.Add(new Ardei());
        }
    }

    public class CiorbaDeFasole : Produs
    {
        public CiorbaDeFasole()
        {
            _nume = "Ciorba De Fasole";
            _gramaj = 300.0;
            _pret = 7.0;
            _ingrediente.Add(new Fasole());
            _ingrediente.Add(new Bors());
            _ingrediente.Add(new Telina());
            _ingrediente.Add(new Morcov());
            _ingrediente.Add(new Patrunej());
            _ingrediente.Add(new Ceapa());
        }
    }
    //Preparate pui

    public class PietDePuiLaGratar : Produs
    {
        public PietDePuiLaGratar()
        {
            _nume = "Piet De Pui La Gratar";
            _gramaj = 200.0;
            _pret = 13.0;
            _ingrediente.Add(new PieptDePui());
            _ingrediente.Add(new Usturoi());
            _ingrediente.Add(new UleiDeMasline());
            _ingrediente.Add(new Cimbru());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
        }
    }

    public class PietDePuiCuSosGongorzola : Produs
    {
        public PietDePuiCuSosGongorzola()
        {
            _nume = "Piet De Pui Cu Sos Gongorzola";
            _gramaj = 250.0;
            _pret = 21.0;
            _ingrediente.Add(new PieptDePui());
            _ingrediente.Add(new Smantana());
            _ingrediente.Add(new Gongorzola());
            _ingrediente.Add(new Parmezan());
            _ingrediente.Add(new Usturoi());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
        }
    }

    public class FicateiPasare : Produs
    {
        public FicateiPasare()
        {
            _nume = "Ficatei Pasare cu ceapa si sos de rosii";
            _gramaj = 200.0;
            _pret = 30.0;
            _ingrediente.Add(new FicateiPui());
            _ingrediente.Add(new Ceapa());
            _ingrediente.Add(new Morcov());
            _ingrediente.Add(new Rosie());
            _ingrediente.Add(new Usturoi());
            _ingrediente.Add(new Vin());
            _ingrediente.Add(new UleiDeMasline());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
        }
    }

    public class AripioarePicante : Produs
    {
        public AripioarePicante()
        {
            _nume = "Aripioare Picante";
            _gramaj = 100.0;
            _pret = 6.0;
            _ingrediente.Add(new AripioarePui());
            _ingrediente.Add(new Cimbru());
            _ingrediente.Add(new Curry());
            _ingrediente.Add(new Oregano());
            _ingrediente.Add(new ArdeiIuti());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
        }
    }

    public class CiulamaDePuiCuBranzaSiMamaliga : Produs
    {
        public CiulamaDePuiCuBranzaSiMamaliga()
        {
            _nume = "Ciulama De Pui Cu Branza Si Mamaliga";
            _gramaj = 500.0;
            _pret = 18.0;
            _ingrediente.Add(new PieptDePui());
            _ingrediente.Add(new Ceapa());
            _ingrediente.Add(new Usturoi());
            _ingrediente.Add(new Morcov());
            _ingrediente.Add(new Smantana());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
            _ingrediente.Add(new Malai());
        }
    }

    public class PuiShangai : Produs
    {
        public PuiShangai()
        {
            _nume = "Pui Shangai";
            _gramaj = 250.0;
            _pret = 20.0;
            _ingrediente.Add(new PieptDePui());
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Mustar());
            _ingrediente.Add(new Sare());
        }
    }

    public class ChifteluteMoldovenesti : Produs
    {
        public ChifteluteMoldovenesti()
        {
            _nume = "Chiftelute Moldovenesti";
            _gramaj = 250.0;
            _pret = 17.0;
            _ingrediente.Add(new CarneDeVita());
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Ceapa());
            _ingrediente.Add(new Morcov());
            _ingrediente.Add(new Cartof());
        }
    }

    public class CordonBleu : Produs
    {
        public CordonBleu()
        {
            _nume = "Cordon Bleu";
            _gramaj = 250.0;
            _pret = 17.0;
            _ingrediente.Add(new CarnePui());
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Cascaval());
            _ingrediente.Add(new SuncaPresta());
        }
    }

    //Preparate Porc
    public class CeafaLaGratar : Produs
    {
        public CeafaLaGratar()
        {
            _nume = "Ceafa La Gratar";
            _gramaj = 250.0;
            _pret = 14.0;
            _ingrediente.Add(new CeafaDePorc());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
            _ingrediente.Add(new UleiDeMasline());
        }
    }

    public class CotletLaGratar : Produs
    {
        public CotletLaGratar()
        {
            _nume = "Cotlet La Gratar";
            _gramaj = 250.0;
            _pret = 14.0;
            _ingrediente.Add(new CotletDePorc());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
            _ingrediente.Add(new UleiDeMasline());
            _ingrediente.Add(new SosTzatziki());
        }
    }

    public class FrigaruiDePorcCuLegume : Produs
    {
        public FrigaruiDePorcCuLegume()
        {
            _nume = "Frigarui De Porc Cu Legume";
            _gramaj = 300.0;
            _pret = 17.0;
            _ingrediente.Add(new CarneDePorc());
            _ingrediente.Add(new Ardei());
            _ingrediente.Add(new Ciuperci());
            _ingrediente.Add(new Ceapa());
            _ingrediente.Add(new Rosie());
        }
    }

    public class SnitelDePorc : Produs
    {
        public SnitelDePorc()
        {
            _nume = "Snitel De Porc";
            _gramaj = 200.0;
            _pret = 15.0;
            _ingrediente.Add(new CarneDePorc());
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new UleiDeMasline());
            _ingrediente.Add(new Sare());
        }
    }

    public class CiolanDePorcCuVarzaCalita : Produs
    {
        public CiolanDePorcCuVarzaCalita()
        {
            _nume = "Ciolan De Porc Cu Varza Calita";
            _gramaj = 300.0;
            _pret = 19.0;
            _ingrediente.Add(new CiolanDePorc());
            _ingrediente.Add(new Varza());
            _ingrediente.Add(new UleiDeMasline());
            _ingrediente.Add(new Ceapa());
            _ingrediente.Add(new BoiaDulce());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
        }
    }

    public class TochituraMoldoveneascaCuMamaliga : Produs
    {
        public TochituraMoldoveneascaCuMamaliga()
        {
            _nume = "Tochitura Moldoveneasca Cu Mamaliga";
            _gramaj = 250.0;
            _pret = 20.0;
            _ingrediente.Add(new CarneDePorc());
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Branza());
            _ingrediente.Add(new Usturoi());
            _ingrediente.Add(new Malai());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
        }
    }

    public class Mici : Produs
    {
        public Mici()
        {
            _nume = "Mici";
            _gramaj = 80.0;
            _pret = 3.0;
            _ingrediente.Add(new CarneDePorc());
            _ingrediente.Add(new Mustar());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
        }
    }

    public class CiolanDePorcCuFasole : Produs
    {
        public CiolanDePorcCuFasole()
        {
            _nume = "Ciolan De Porc Cu Fasole";
            _gramaj = 300.0;
            _pret = 19.0;
            _ingrediente.Add(new CiolanDePorc());
            _ingrediente.Add(new Fasole());
            _ingrediente.Add(new UleiDeMasline());
            _ingrediente.Add(new Ceapa());
            _ingrediente.Add(new Sare());
            _ingrediente.Add(new Piper());
        }
    }


    //Deserturi
    public class ClatiteCuGem : Produs
    {
        public ClatiteCuGem()
        {
            _nume = "Clatite Cu Gem";
            _gramaj = 200.0;
            _pret = 6.0;
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Lapte());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new Gem());
        }
    }

    public class ClatiteCuFinettiSiBanana : Produs
    {
        public ClatiteCuFinettiSiBanana()
        {
            _nume = "Clatite Cu Finetti Si Banana";
            _gramaj = 200.0;
            _pret = 7.0;
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Lapte());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new Finetti());
            _ingrediente.Add(new Banana());
        }
    }

    public class ClatiteCuInghetataSiFrisca : Produs
    {
        public ClatiteCuInghetataSiFrisca()
        {
            _nume = "Clatite Cu Inghetata Si Frisca";
            _gramaj = 200.0;
            _pret = 8.0;
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Lapte());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new InghetataVanilie());
            _ingrediente.Add(new Frisca());
            _ingrediente.Add(new Topping());
        }
    }

    public class Papanasi : Produs
    {
        public Papanasi()
        {
            _nume = "Papanasi";
            _gramaj = 200.0;
            _pret = 11.0;
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Zahar());
            _ingrediente.Add(new BranzaDulce());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new Smantana());
            _ingrediente.Add(new Dulceata());
        }
    }

    public class InghetataAsortata : Produs
    {
        public InghetataAsortata()
        {
            _nume = "Inghetata Asortata";
            _gramaj = 100.0;
            _pret = 8.0;
            _ingrediente.Add(new InghetataVanilie());
            _ingrediente.Add(new InghetataCacao());
            _ingrediente.Add(new InghetataCapsuni());
            _ingrediente.Add(new Topping());
            _ingrediente.Add(new Frisca());
        }
    }

    public class Tiramisu : Produs
    {
        public Tiramisu()
        {
            _nume = "Tiramisu";
            _gramaj = 100.0;
            _pret = 8.0;
            _ingrediente.Add(new Mascarpone());
            _ingrediente.Add(new Cafea());
            _ingrediente.Add(new Piscot());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new Zahar());
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Cacao());
        }
    }

    public class Baclava : Produs
    {
        public Baclava()
        {
            _nume = "Baclava";
            _gramaj = 200.0;
            _pret = 9.0;
            _ingrediente.Add(new Nuca());
            _ingrediente.Add(new FoiPlacinta());
            _ingrediente.Add(new Unt());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new Zahar());
            _ingrediente.Add(new Lamaie());
            _ingrediente.Add(new Fistic());
        }
    }

    public class CheesecakeCuCapsuni : Produs
    {
        public CheesecakeCuCapsuni()
        {
            _nume = "Cheesecake Cu Capsuni";
            _gramaj = 200.0;
            _pret = 13.0;
            _ingrediente.Add(new Biscuiti());
            _ingrediente.Add(new CremaDeBranza());
            _ingrediente.Add(new Unt());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new Zahar());
            _ingrediente.Add(new FriscaLichida());
            _ingrediente.Add(new Capsuni());
            _ingrediente.Add(new Gelatina());
        }
    }

    public class TortCuFructe : Produs
    {
        public TortCuFructe()
        {
            _nume = "Tort Cu Fructe";
            _gramaj = 100.0;
            _pret = 8.0;
            _ingrediente.Add(new FriscaLichida());
            _ingrediente.Add(new Mascarpone());
            _ingrediente.Add(new Capsuni());
            _ingrediente.Add(new Zmeura());
            _ingrediente.Add(new Zahar());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Ou());
            _ingrediente.Add(new Ulei());
        }
    }

    public class TortCuCiocolata : Produs
    {
        public TortCuCiocolata()
        {
            _nume = "Tort Cu Ciocolata";
            _gramaj = 100.0;
            _pret = 8.0;
            _ingrediente.Add(new FriscaLichida());
            _ingrediente.Add(new Mascarpone());
            _ingrediente.Add(new Cacao());
            _ingrediente.Add(new Ciocolata());
            _ingrediente.Add(new Zahar());
            _ingrediente.Add(new EsentaVanilie());
            _ingrediente.Add(new Faina());
            _ingrediente.Add(new Ou());
        }
    }
}
