using System;
using System.Collections.Generic;
using System.Text;


namespace Restaurant
{
    public interface Ingredient
    {
        string Show();
    }

    public class SosAlb : Ingredient
    {
        private string _nume;

        public SosAlb()
        {
            _nume = "Sos alb";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Bacon : Ingredient
    {
        private string _nume;

        public Bacon()
        {
            _nume = "Bacon";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Ou : Ingredient
    {
        private string _nume;

        public Ou()
        {
            _nume = "Ou";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Parmezan : Ingredient
    {
        private string _nume;

        public Parmezan()
        {
            _nume = "Parmezan";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class CarneDeVita : Ingredient
    {
        private string _nume;

        public CarneDeVita()
        {
            _nume = "Carne De Vita";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Ardei : Ingredient
    {
        private string _nume;

        public Ardei()
        {
            _nume = "Ardei";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Rosie : Ingredient
    {
        private string _nume;

        public Rosie()
        {
            _nume = "Rosie";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class FructeDeMare : Ingredient
    {
        private string _nume;
        private string _detalii;

        public FructeDeMare()
        {
            _nume = "Fructe De Mare";
            _detalii = "scoici, fasolare, trufe de mare";
        }
        public string Show()
        {
            return _nume + ": " + _detalii;

        }
    }

    public class Busuioc : Ingredient
    {
        private string _nume;

        public Busuioc()
        {
            _nume = "Busuioc";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Gongorzola : Ingredient
    {
        private string _nume;

        public Gongorzola()
        {
            _nume = "Gongorzola";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Cascaval : Ingredient
    {
        private string _nume;

        public Cascaval()
        {
            _nume = "Cascaval";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Mozzarela : Ingredient
    {
        private string _nume;

        public Mozzarela()
        {
            _nume = "Mozzarela";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class PieptDePui : Ingredient
    {
        private string _nume;

        public PieptDePui()
        {
            _nume = "Piept De Pui";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Crutoane : Ingredient
    {
        private string _nume;

        public Crutoane()
        {
            _nume = "Crutoane";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Dresing : Ingredient
    {
        private string _nume;
        private string _detalii;

        public Dresing()
        {
            _nume = "Dresing de iaurt";
            _detalii = "zeama unei lamai, 1 lingurita zahar, 2 catei de usturoi maruntit, 125 g iaurt grecesc, \n";
            _detalii += "1 lingura ulei de masline, 2 linguri patrunjel maruntit, sare, piper";
        }
        public string Show()
        {
            return _nume + ": " + _detalii;
        }
    }

    public class Cartof : Ingredient
    {
        private string _nume;

        public Cartof()
        {
            _nume = "Cartof";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Castraveti : Ingredient
    {
        private string _nume;

        public Castraveti()
        {
            _nume = "Castraveti";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class ProsciutoCrudo : Ingredient
    {
        private string _nume;

        public ProsciutoCrudo()
        {
            _nume = "Prosciuto Crudo";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Oregano : Ingredient
    {
        private string _nume;

        public Oregano()
        {
            _nume = "Oregano";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class UleiDeMasline : Ingredient
    {
        private string _nume;

        public UleiDeMasline()
        {
            _nume = "Ulei De Masline";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class SuncaPresta : Ingredient
    {
        private string _nume;

        public SuncaPresta()
        {
            _nume = "Sunca Presta";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Branza : Ingredient
    {
        private string _nume;

        public Branza()
        {
            _nume = "Branza";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class SalataVerde : Ingredient
    {
        private string _nume;

        public SalataVerde()
        {
            _nume = "Salata Verde";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Smantana : Ingredient
    {
        private string _nume;
        private string _detalii;

        public Smantana()
        {
            _nume = "Smantana";
            _detalii = "3% grasime";
        }
        public string Show()
        {
            return _nume + ": " + _detalii;
        }
    }
    public class Morcov : Ingredient
    {
        private string _nume;

        public Morcov()
        {
            _nume = "Morcov";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class BurtaVita : Ingredient
    {
        private string _nume;

        public BurtaVita()
        {
            _nume = "Burta Vita";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Otet : Ingredient
    {
        private string _nume;

        public Otet()
        {
            _nume = "Otet";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Usturoi : Ingredient
    {
        private string _nume;

        public Usturoi()
        {
            _nume = "Usturoi";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Bors : Ingredient
    {
        private string _nume;

        public Bors()
        {
            _nume = "Bors";
        }
        public string Show()
        {
            return _nume;
        }

    }
    public class CarnePui : Ingredient
    {
        private string _nume;

        public CarnePui()
        {
            _nume = "Carne Pui";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Gris : Ingredient
    {
        private string _nume;

        public Gris()
        {
            _nume = "Gris";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Telina : Ingredient
    {
        private string _nume;

        public Telina()
        {
            _nume = "Telina";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Ceapa : Ingredient
    {
        private string _nume;

        public Ceapa()
        {
            _nume = "Ceapa";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Fasole : Ingredient
    {
        private string _nume;

        public Fasole()
        {
            _nume = "Fasole";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Patrunej : Ingredient
    {
        private string _nume;

        public Patrunej()
        {
            _nume = "Patrunej";
        }
        public string Show()
        {
            return _nume;
        }
    }
    public class Masline : Ingredient
    {
        private string _nume;

        public Masline()
        {
            _nume = "Masline";
        }
        public string Show()
        {
            return _nume;
        }
    }
    public class Cimbru : Ingredient
    {
        private string _nume;

        public Cimbru()
        {
            _nume = "Cimbru";
        }
        public string Show()
        {
            return _nume;
        }
    }
    public class Sare : Ingredient
    {
        private string _nume;

        public Sare()
        {
            _nume = "Sare";
        }
        public string Show()
        {
            return _nume;
        }
    }
    public class Piper : Ingredient
    {
        private string _nume;

        public Piper()
        {
            _nume = "Piper";
        }
        public string Show()
        {
            return _nume;
        }
    }
    public class FicateiPui : Ingredient
    {
        private string _nume;

        public FicateiPui()
        {
            _nume = "Ficatei de Pui";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Vin : Ingredient
    {
        private string _nume;

        public Vin()
        {
            _nume = "Vin rosu";
        }
        public string Show()
        {
            return _nume;
        }
    }
    public class AripioarePui : Ingredient
    {
        private string _nume;

        public AripioarePui()
        {
            _nume = "Aripioare De Pui";
        }
        public string Show()
        {
            return _nume;
        }
    }
    public class Curry : Ingredient
    {
        private string _nume;

        public Curry()
        {
            _nume = "Curry";
        }
        public string Show()
        {
            return _nume;
        }
    }
    public class ArdeiIuti : Ingredient
    {
        private string _nume;

        public ArdeiIuti()
        {
            _nume = "Ardei Iuti";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Faina : Ingredient
    {
        private string _nume;

        public Faina()
        {
            _nume = "Faina";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Mustar : Ingredient
    {
        private string _nume;

        public Mustar()
        {
            _nume = "Mustar";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class CeafaDePorc : Ingredient
    {
        private string _nume;

        public CeafaDePorc()
        {
            _nume = "Ceafa De Porc";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class SosTzatziki : Ingredient
    {
        private string _nume;

        public SosTzatziki()
        {
            _nume = "Sos Tzatziki";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class CotletDePorc : Ingredient
    {
        private string _nume;

        public CotletDePorc()
        {
            _nume = "Cotlet De Porc";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class CarneDePorc : Ingredient
    {
        private string _nume;

        public CarneDePorc()
        {
            _nume = "Carne De Porc";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Ciuperci : Ingredient
    {
        private string _nume;

        public Ciuperci()
        {
            _nume = "Ciuperci";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class CiolanDePorc : Ingredient
    {
        private string _nume;

        public CiolanDePorc()
        {
            _nume = "Ciolan De Porc";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Varza : Ingredient
    {
        private string _nume;

        public Varza()
        {
            _nume = "Varza";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class BoiaDulce : Ingredient
    {
        private string _nume;

        public BoiaDulce()
        {
            _nume = "Boia Dulce";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Malai : Ingredient
    {
        private string _nume;

        public Malai()
        {
            _nume = "Malai";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Lapte : Ingredient
    {
        private string _nume;

        public Lapte()
        {
            _nume = "Lapte";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class EsentaVanilie : Ingredient
    {
        private string _nume;

        public EsentaVanilie()
        {
            _nume = "Esenta Vanilie";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Gem : Ingredient
    {
        private string _nume;
        private string _detalii;

        public Gem()
        {
            _nume = "Gem";
            _detalii = "Capsuni, zmeura, afine";
        }
        public string Show()
        {
            return _nume + ": " + _detalii;
        }
    }

    public class Finetti : Ingredient
    {
        private string _nume;

        public Finetti()
        {
            _nume = "Finetti";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Banana : Ingredient
    {
        private string _nume;

        public Banana()
        {
            _nume = "Banana";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class InghetataVanilie : Ingredient
    {
        private string _nume;

        public InghetataVanilie()
        {
            _nume = "Inghetata vanilie";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Topping : Ingredient
    {
        private string _nume;

        public Topping()
        {
            _nume = "Topping";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class BranzaDulce : Ingredient
    {
        private string _nume;

        public BranzaDulce()
        {
            _nume = "BranzaDulce";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Dulceata : Ingredient
    {
        private string _nume;
        private string _detalii;

        public Dulceata()
        {
            _nume = "Dulceata";
            _detalii = "Capsuni, zmeura, afine, visine";
        }
        public string Show()
        {
            return _nume + ": " + _detalii;
        }
    }

    public class Zahar : Ingredient
    {
        private string _nume;

        public Zahar()
        {
            _nume = "Zahar";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class InghetataCapsuni : Ingredient
    {
        private string _nume;

        public InghetataCapsuni()
        {
            _nume = "Inghetata Capsuni";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class InghetataCacao : Ingredient
    {
        private string _nume;

        public InghetataCacao()
        {
            _nume = "Inghetata Cacao";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Mascarpone : Ingredient
    {
        private string _nume;

        public Mascarpone()
        {
            _nume = "Mascarpone";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Cafea : Ingredient
    {
        private string _nume;

        public Cafea()
        {
            _nume = "Cafea";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Piscot : Ingredient
    {
        private string _nume;
        private string _detalii;

        public Piscot()
        {
            _nume = "Piscot";
            _detalii = "de sampanie";
        }
        public string Show()
        {
            return _nume + ": " + _detalii;
        }
    }

    public class Cacao : Ingredient
    {
        private string _nume;

        public Cacao()
        {
            _nume = "Cacao";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Nuca : Ingredient
    {
        private string _nume;

        public Nuca()
        {
            _nume = "Nuca";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class FoiPlacinta : Ingredient
    {
        private string _nume;

        public FoiPlacinta()
        {
            _nume = "Foi Placinta";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Unt : Ingredient
    {
        private string _nume;

        public Unt()
        {
            _nume = "Unt";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Lamaie : Ingredient
    {
        private string _nume;

        public Lamaie()
        {
            _nume = "Lamaie";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Fistic : Ingredient
    {
        private string _nume;

        public Fistic()
        {
            _nume = "Fistic";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class CremaDeBranza : Ingredient
    {
        private string _nume;

        public CremaDeBranza()
        {
            _nume = "Crema De Branza";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Biscuiti : Ingredient
    {
        private string _nume;

        public Biscuiti()
        {
            _nume = "Biscuiti";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class FriscaLichida : Ingredient
    {
        private string _nume;

        public FriscaLichida()
        {
            _nume = "Frisca Lichida";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Capsuni : Ingredient
    {
        private string _nume;

        public Capsuni()
        {
            _nume = "Capsuni";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Gelatina : Ingredient
    {
        private string _nume;

        public Gelatina()
        {
            _nume = "Gelatina";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Zmeura : Ingredient
    {
        private string _nume;

        public Zmeura()
        {
            _nume = "Zmeura";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Ulei : Ingredient
    {
        private string _nume;

        public Ulei()
        {
            _nume = "Ulei";
        }
        public string Show()
        {
            return _nume;
        }
    }

    public class Ciocolata : Ingredient
    {
        private string _nume;
        private string _detalii;

        public Ciocolata()
        {
            _nume = "Ciocolata";
            _detalii = "70% cacao";
        }
        public string Show()
        {
            return _nume + ": " + _detalii;

        }
    }

    public class Frisca : Ingredient
    {
        private string _nume;

        public Frisca()
        {
            _nume = "Frisca";
        }
        public string Show()
        {
            return _nume;
        }
    }
}
