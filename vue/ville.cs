using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vue
{
    public class ville
    {
        List<List<string>> villes = new List<List<string>>();
        List<string> a = new List<string>
    {
        "",
        "Ariana Essoughra",
        "Ariana Ville",
        "Borj Louzir",
        "Charguia 1",
        "Charguia 2",
        "Chotrana",
        "Chotrana 1",
        "Chotrana 2",
        "Chotrana 3",
        "Cit� Ennasr 1",
        "Cit� Ennasr 2",
        "Cite Ennkhillet",
        "Cit� Hedi Nouira",
        "Dar Fadhal",
        "El Menzah 5",
        "El Menzah 6",
        "El Menzah 7",
        "El Menzah 8",
        "Ennasr",
        "Ettadhamen",
        "Ghazela",
        "Jardins El Menzah",
        "Kalaat Landlous",
        "La Soukra",
        "Les jardins El Menzah1",
        "Les jardins El Menzah2",
        "Mnihla",
        "Nouvelle Ariana",
        "Raoued",
        "Riadh Andalous",
        "Sidi Thabet"
    };

         List<string> b = new List<string>()
{
    "Amdoun",
    "Beja Nord",
    "Beja Sud",
    "El ksar",
    "Goubellat",
    "Mejez El Bab",
    "Nefza",
    "Teboursouk",
    "Testour",
    "Thibar"
};


        List<string> c = new List<string>
{
    "",
    "Ben Arous",
    "Borj cedria",
    "Bou Mhel El Bassatine",
    "El Mourouj",
    "El Mourouj 1",
    "El Mourouj 3",
    "El Mourouj 4",
    "El Mourouj 5",
    "El Mourouj 6",
    "Ezzahra",
    "Fouchana",
    "Hammam Chatt",
    "Hammam Lif",
    "Megrine",
    "Mohamadia",
    "Mornag",
    "Nouvelle Medina",
    "Rades",
    "Sidi Rezig"
};
        List<string> d = new List<string>() {
    "Bizerte",
    "Bizerte Nord",
    "Bizerte Sud",
    "El Alia",
    "Ghar El Melh",
    "Ghezala",
    "Jarzouna",
    "Joumine",
    "Mateur",
    "Menzel Bourguiba",
    "Menzel Jemil",
    "Ras Jebel",
    "Sejnane",
    "Tinja",
    "Utique"
};
        List<string> e = new List<string>()
{
    "El Hamma",
    "El Metouia",
    "Gab�s",
    "Gabes Medina",
    "Gabes Ouest",
    "Gabes Sud",
    "Ghannouche",
    "Mareth",
    "Matmata",
    "Menzel Habib",
    "Nouvelle Matmata"
};

        List<string> f = new List<string>()
{
    "",
    "Belkhir",
    "El Guettar",
    "El Ksar",
    "El Mdhilla",
    "Gafsa Nord",
    "Gafsa Sud",
    "Metlaoui",
    "Moulares",
    "Oum El Araies",
    "Redeyef",
    "Sidi Aich",
    "Sned"
};
        List<string> g = new List<string>()
{
    "Ain Draham",
    "Balta Bou Aouene",
    "Bou Salem",
    "Fernana",
    "Ghardimaou",
    "Jendouba",
    "Jendouba Nord",
    "Oued Mliz",
    "Tabarka"
};
        List<string> h = new List<string>()
{
    "Bou Hajla",
    "Chebika",
    "Cherarda",
    "El Ala",
    "Haffouz",
    "Hajeb El Ayoun",
    "Kairouan Nord",
    "Kairouan Sud",
    "Nasrallah",
    "Oueslatia",
    "Sbikha"
};
        List<string> i = new List<string>
{
    "",
    "El Ayoun",
    "Ezzouhour (Kasserine)",
    "Feriana",
    "Foussana",
    "Haidra",
    "Hassi El Frid",
    "Jediliane",
    "Kasserine Nord",
    "Kasserine Sud",
    "Mejel Bel Abbes",
    "Sbeitla",
    "Sbiba",
    "Thala"
};
        List<string> j = new List<string>
{
    "Douz",
    "Douz Nord",
    "Douz Sud",
    "El Faouar",
    "Kébili",
    "Kebili Nord",
    "Kebili Sud",
    "Souk El Ahad"
};
        List<string> k = new List<string>
{
    "Borj El Amri",
    "Denden",
    "Douar Hicher",
    "El Battan",
    "Jedaida",
    "Mannouba",
    "Manouba Ville",
    "Manzel El Habib",
    "Mornaguia",
    "Oued Ellil",
    "Tebourba"
};

        List<string> l = new List<string> {
    "Dahmani",
    "El Ksour",
    "Jerissa",
    "Kalaa El Khasba",
    "Kalaat Sinane",
    "Le Kef Est",
    "Le Kef Ouest",
    "Le Sers",
    "Nebeur",
    "Sakiet Sidi Youssef",
    "Tajerouine",
    "Touiref"
};

        List<string> m = new List<string>(){
    "",
    "Bou Merdes",
    "Chorbane",
    "El Jem",
    "Hbira",
    "Ksour Essaf",
    "La Chebba",
    "Mahdia",
    "Melloulech",
    "Ouled Chamakh",
    "Sidi Alouene",
    "Souassi"
};


        List<string> n = new List<string>
{
    "", // Ajoutez une option vide si nécessaire
    "Ajim",
    "Ben Guerdane",
    "Beni Khedache",
    "Djerba - Houmet Essouk",
    "Djerba - Midoun",
    "Médenine",
    "Medenine Nord",
    "Medenine Sud",
    "Sidi Makhlouf",
    "Zarzis"
};
        List<string> o = new List<string>(){
    "Bekalta",
    "Bembla",
    "Beni Hassen",
    "Jemmal",
    "Ksar Helal",
    "Ksibet El Mediouni",
    "Moknine",
    "Monastir",
    "Ouerdanine",
    "Sahline",
    "Sayada Lamta Bou Hajar",
    "Teboulba",
    "Zeramdine"
};

        List<string> p = new List<string>
{
      "",
    "Beni Khalled",
    "Beni Khiar",
    "Bou Argoub",
    "Dar Chaabane Elfehri",
    "El Haouaria",
    "El Mida",
    "Grombalia",
    "Hammam El Ghezaz",
    "Hammamet",
    "Hammamet Centre",
    "Hammamet Nord",
    "Kelibia",
    "Korba",
    "Menzel Bouzelfa",
    "Menzel Temime",
    "Mrezga",
    "Nabeul",
    "Soliman",
    "Takelsa"
};
        List<string> q = new List<string>()
{
    "",
    "Agareb",
    "Bir Ali Ben Khelifa",
    "El Amra",
    "El Hencha",
    "Esskhira",
    "Ghraiba",
    "Jebeniana",
    "Kerkenah",
    "Mahras",
    "Menzel Chaker",
    "Route De Gab�s",
    "Route de l'a�roport",
    "Route El Afrane",
    "Route El Ain",
    "Route Gremda",
    "Route Maehdia",
    "Route Manzel Chaker",
    "Route MHARZA",
    "Route Saltania",
    "Route Soukra",
    "Route Taniour",
    "Route TUNIS",
    "Sakiet Eddaier",
    "Sakiet Ezzit",
    "Sfax Est",
    "Sfax M�dina",
    "Sfax Sud",
    "Sfax Ville",
    "Thyna"
};
        List<string> r = new List<string> { "Ben Oun", "Bir El Haffey", "Cebbala", "Jilma", "Maknassy", "Menzel Bouzaiene", "Mezzouna", "Ouled Haffouz", "Regueb", "Sidi Bouzid", "Sidi Bouzid Est", "Sidi Bouzid Ouest", "Souk Jedid" };

        List<string> q1 = new List<string>
{
    "",
    "Bargou",
    "Bou Arada",
    "El Aroussa",
    "Gaafour",
    "Kesra",
    "Le Krib",
    "Makthar",
    "Rohia",
    "Sidi Bou Rouis",
    "Siliana",
    "Siliana Nord",
    "Siliana Sud"
};

        List<string> s = new List<string>() { "Akouda", "Bou Ficha", "Chatt mariem", "Enfidha", "Hammam Sousse", "Hergla", "Kalaa El Kebira", "Kalaa Essghira", "Kantaoui", "Khzema", "Kondar", "Msaken", "Sahloul", "Sidi Bou Ali", "Sidi El Heni", "Sousse", "Sousse Jaouhara", "Sousse Riadh", "Sousse Sidi Abdelhamid", "Sousse Ville", "Zaouit Ksibat Thrayett" };
        List<string> t = new List<string>
{
    "",
    "Bir Lahmar",
    "Dhehiba",
    "Ghomrassen",
    "Remada",
    "Smar",
    "Tataouine",
    "Tataouine Nord",
    "Tataouine Sud"
};




        List<string> u = new List<string>() { "Agba", "Ain Zaghouan", "Ain Zaghouan", "Ain Zaghouan Nord", "Ain Zaghouan Sud", "Bab Bhar", "Bab Souika", "Bellevue", "Carthage", "Centre Urbain Nord", "Centre Ville Lafayette", "Cite El Khadra", "Cit� Olympique", "El Hrairia", "El Kabbaria", "El Kram", "El manar 1", "El manar 2", "El Menzah", "El Menzah 1", "El Menzah 4", "El Menzah 9", "El Omrane", "El Omrane Superieur", "El Ouerdia", "Essijoumi", "Ettahrir", "Ezzouhour (Tunis)", "Gammarth", "Jardins de carthage", "Jebel Jelloud", "Khaznadar", "Kheireddine Pacha", "Ksar said", "L'aouina", "La Goulette", "La Marsa", "La Medina", "Lac 1", "Lac 2", "Le Bardo", "Monfleury", "Montplaisir", "Mutuelleville", "Sidi bou said", "Sidi Daoud", "Sidi El Bechir", "Sidi Hassine", "Tunis", "Tunis Belvedere" };

List<string> v = new List<string>()
{
    "Bir Mcherga",
    "El Fahs",
    "Ennadhour",
    "Hammam Zriba",
    "Saouef",
    "Zaghouan"
};

        
    public List<List<string>>getville()
    {
            villes.Add(a);
            villes.Add(b);
            villes.Add(c);
            villes.Add(d);
            villes.Add(e);
            villes.Add(f);
            villes.Add(g);
            villes.Add(h);
            villes.Add(i);
            villes.Add(j);
            villes.Add(k);
            villes.Add(l);
            villes.Add(m);
            villes.Add(n);
            villes.Add(o);
            villes.Add(p);
            villes.Add(q);
            villes.Add(r);
            villes.Add(q1);
            villes.Add(s);
            villes.Add(t);
            villes.Add(u);
            villes.Add(v);
            return villes;
    }
}
}






    
