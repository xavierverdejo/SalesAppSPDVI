using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppSPDVI
{
    class LanguageHelper
    {
        public static string[] langNames= new string[] {"en", "fr"};
        
        public static string lan = "en";

        public static Dictionary<string, string> dict = new Dictionary<string,string>(){
            // ENGLISH
            {"en.login.message","Please, log in with your credentials to\nopen de management application."},
            {"en.login.user", "User"},
            {"en.login.password", "Password"},
            {"en.login.login", "Login"},
            {"en.login.english", "English"},
            {"en.login.french", "French"},
            {"en.main.filtering", "Filtering"},
            {"en.main.category", "Category"},
            {"en.main.subcategory", "Subcategory"},
            {"en.main.size", "Size"},
            {"en.main.productline", "Product line"},
            {"en.main.class", "Class"},
            {"en.main.style", "Style"},
            {"en.main.price_between", "Price between"},
            {"en.main.and", "and"},
            {"en.main.only_available", "Only available products"},
            {"en.main.search", "Search"},
            {"en.main.clear_all", "Clear all"},
            {"en.main.products_found", " products found."},
            {"en.main.pages", " pages"},
            {"en.main.previous", "Previous"},
            {"en.main.next", "Next"},
            {"en.main.title", "SPDVI Management Tool"},
            // FRENCH
            {"fr.login.message","Veuillez vous connecter avec vos identifiants\npour ouvrir l'application de gestion."},
            {"fr.login.user", "Utilisateur"},
            {"fr.login.password", "Mot de passe"},
            {"fr.login.login", "S'identifier"},
            {"fr.login.english", "Anglaise"},
            {"fr.login.french", "Française"},
            {"fr.main.filtering", "Filtration"},
            {"fr.main.category", "Catégorie"},
            {"fr.main.subcategory", "Sous-catégorie"},
            {"fr.main.size", "Taille"},
            {"fr.main.productline", "Gamme de produits"},
            {"fr.main.class", "Classe"},
            {"fr.main.style", "Style"},
            {"fr.main.price_between", "Prix entre"},
            {"fr.main.and", "et"},
            {"fr.main.only_available", "Seulement produits disponibles"},
            {"fr.main.search", "Chercher"},
            {"fr.main.clear_all", "Tout effacer"},
            {"fr.main.products_found", " produits trouvés."},
            {"fr.main.pages", " pages"},
            {"fr.main.previous", "Précédente"},
            {"fr.main.next", "Suivant"},
            {"fr.main.title", "SPDVI Outil de gestion"}
        };


    }
}
