using MetierSharedMemory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MetierSharedMemory.Model
{
    public class Jury:Personne
    {
        [MaxLength(20, ErrorMessage = "taille maximale 20"), Required(ErrorMessage = "*")]
        [Display(Name = "Grade membre Jury")]
        public string Grade { get; set; }


        [MaxLength(50, ErrorMessage = "taille maximale 50"), Required(ErrorMessage = "*")]
        [Display(Name = "Specialite membre Jury")]
        public string Specialite { get; set; }

        //public virtual ICollection<Memoire> Memoires { get; set; } //Un jury peut etre dans plusieurs memoires
    }
}
