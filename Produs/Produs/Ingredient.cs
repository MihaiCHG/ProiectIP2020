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
            return _nume+": "+_detalii;

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
            return _nume+": "+_detalii;
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
            _nume = "Salata Verde";
            _detalii = "3% grasime";
        }
        public string Show()
        {
            return _nume+": "+_detalii;
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

}
