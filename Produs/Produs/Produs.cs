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


        public string descriere()
        {
            string desc = _nume + "\t";
            for(int i = 0; i < _ingrediente.Count; i++)
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
}
