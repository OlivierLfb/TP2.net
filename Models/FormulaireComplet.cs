using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TPLOCAL1.Models
{
    public class FormulaireComplet
    {
        [Required(ErrorMessage = "Veuillez entrer un nom")]

        public string nom { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un prenom")]
        public string prenom { get; set; }
        [Required(ErrorMessage = "Veuillez selectionner un sexe")]
        public string sexe { get; set; }
        [Required(ErrorMessage = "Veuillez entrer une adresse")]
        public string adresse { get; set; }


        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Code Postal Invalide"), Required]

        public int codePostal { get; set; }
        [Required(ErrorMessage = "Veuillez entrer une ville")]
        public string ville { get; set; }
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Adresse mail Invalide"), Required(ErrorMessage = "Veuillez entrer une adresse mail")]
        public string email { get; set; }

        [Required, DataType(DataType.Date, ErrorMessage = "Veuillez entrer une date valide"), Range(typeof(DateTime), "1/1/1900", "20/7/2022", ErrorMessage = "Entrez une date comprise entre 1/1/1966 et le 20/07/2022")]
        public DateTime debutFormation { get; set; }
        [Required(ErrorMessage = "Veuillez choisir une formation")]
        public string formationSuivie { get; set; }

        public string avisCobol { get; set; }

        public string avisCSharp { get; set; }
    }

    public enum Sexe
    {
        Homme,
        Femme,
        Autre
    }
}