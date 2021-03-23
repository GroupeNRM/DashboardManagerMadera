using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardManagerMadera.Models
{
    [Table("Commercial")]
    public class Commercial
    {
        [Column("ID_Commercial"), Display(Name = "Numéro"), Key]
        public int ID { get; set; }

        [Column("Nom_Commercial", TypeName = "nvarchar"), Display(Name = "Nom"), Required, MinLength(5), MaxLength(50, ErrorMessage ="Votre nom ne peut contenir plus de 50 caractères !")]
        public string FirstName { get; set; }

        [Column("Prenom_Commercial", TypeName = "nvarchar"), Display(Name = "Prénom"), Required, MinLength(5), MaxLength(50, ErrorMessage = "Votre prénom ne peut contenir plus de 50 caractères !")]
        public string LastName { get; set; }
        
        [Column("Email_Commercial", TypeName = "nvarchar"), Display(Name = "Email"), Required, MinLength(5), MaxLength(100, ErrorMessage = "Votre email ne peut contenir plus de 100 caractères !")]
        public string Email { get; set; }
        
        [Column("Telephone_Commercial", TypeName = "nvarchar"), Display(Name = "Téléphone"), Required, MinLength(5), MaxLength(20, ErrorMessage = "Votre téléphone ne peut contenir plus de 20 caractères !")]
        public string Phone { get; set; }

        [Column("Pays_Commercial", TypeName = "nvarchar"), Display(Name = "Pays"), Required, MinLength(5), MaxLength(20, ErrorMessage = "Votre pays ne peut contenir plus de 20 caractères !")]
        public string Country { get; set; }

        [Column("Cree_le_Commercial"), Display(Name = "Crée le"), Required]
        public DateTime CreatedAt { get; set; }
        
        [Column("Modifie_le_Commercial"), Display(Name = "Modifié le")]
        public DateTime UpdatedAt { get; set; }
    }
}
