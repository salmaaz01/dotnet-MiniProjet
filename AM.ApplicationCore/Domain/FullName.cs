using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class FullName /* Classe type d'entite détenu, type complexe qui regroupe un groupe d'attribut*/
    {
        [MinLength(3, ErrorMessage = "longueur minimal est 3!")]
        [MaxLength(25, ErrorMessage = "longeur max est 25!")]
        [RegularExpression(@"^[a-zA-Z]{3-25}$")  ]
        public string? FirstName { get; set; }

        [MinLength(3, ErrorMessage = "longueur minimal est 3!")]
        [MaxLength(25, ErrorMessage = "longeur max est 25!")]
        public string? LastName { get; set; }

        /* exp: on peut faire une classe qui regroupe des adresses avec des attributs : nom de rues, adresse rue,
         * code postal.. dans une meme classe detenue*/

        /* pour configurer les classes type d'entites detenues on utilise les classes fluent api
         * pour dire que full name est un type d(entite detenu qui appartient a la classe passenger on 
         * cree une classe de configuration passenger et on utilise la requete OWNSONE*/
    }
}
