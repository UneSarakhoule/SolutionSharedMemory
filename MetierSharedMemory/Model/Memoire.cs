using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MetierSharedMemory.Model
{
    public class Memoire
    {
        [Key]
        public int IdMemoire { get; set; }


        [MaxLength(300, ErrorMessage = "taille maximale 300"), Required(ErrorMessage = "*")]
        [Display(Name = "Titre du memoire")]
        public string Titre { get; set; }


        [Required(ErrorMessage ="*")]
        public int Annee { get; set; }


        [MaxLength(10, ErrorMessage = "taille maximale 10")]
        [Display(Name = "Status")]
        public string statut { get; set; }


        [MaxLength(80, ErrorMessage = "taille maximale 80"), Required(ErrorMessage = "*")]
        [Display(Name = "Auteur")]
        public string Auteur { get; set; }


        [MaxLength(30, ErrorMessage = "taille maximale 30"), Required(ErrorMessage = "*")]
        [Display(Name = "Fichier")]
        public string FileName { get; set; }


        [MaxLength(10, ErrorMessage = "taille maximale 10"), Required(ErrorMessage = "*")]
        [Display(Name = "Extension")]
        public string Extension { get; set; }


        [DataType(DataType.Date), Required(ErrorMessage = "*")]
        [Display(Name = "Date de Publication")]
        public DateTime? DatePublication { get; set; }

        //public virtual ICollection<Jury> Jury { get; set; } //Un memoire peut avoir plusieurs jurys

    }
}