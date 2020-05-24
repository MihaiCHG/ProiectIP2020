/*
 * Fisier creat de Heghea Mihail-Cristian.
 * Aceasta enumeratie este folosita pentru a fi primita de actre fabrica ca paramentru.
 * Ea contine toate produsele.
 * */

using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public enum ProductName
    {
        //Paste
        PSpaghettiCarbonara,
        PSpaghettiBolognese,
        PLinguiniConFrttiDiMare,
        PPennQuattroFormaggi,
        PLasagna,
        //Gustari reci
        PSalataCaesar,
        PSalataGreceasca,
        PSalatCapresse,
        PSalataBulgareasca,
        //Supe/Ciorbe
        PCiorbaRadauteana,
        PCiorbaBurta,
        PCiorbaPerisoare,
        PCiorbaDeVacuta,
        PCiorbaDeFasole,
        //Preparate Pui
        PPieptDePuiLaGratar,
        PPieptDePuiCuSosGrogonzola,
        PFicateiPasare,
        PAripioarePicante,
        PCiulamaDePuiCuBranzaSiMamaliguta,
        PPuiShanghai,
        PPiFteluteMoldovenesti,
        PCordonBleu,
        //Preparate Porc
        PCeafaLaGratar,
        PCotletLaGratar,
        PFrigaruiDePorcCuLegume,
        PSnitelPorc,
        PCiolanDePorcCuVarzaCalita,
        PTochituraMoldoveneasca,
        PMici,
        PFasoleCuCiolan,
        //Deserturi
        PClatiteCuGem,
        PClatiteCuFinetti,
        PClatiteCuInghetataTopingSiFrisca,
        PPapanasi,
        PInghetataAsortata,
        PTiramisu,
        PBaclava,
        PCheeseCake,
        PTortCuFructe,
        PTortCuCiocolata
    }
}
