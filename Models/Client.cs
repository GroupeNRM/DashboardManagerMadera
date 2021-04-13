using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardManagerMadera.Models
{
    [Table("Client")]
    public class Client
    {
        [Key, Column("ID_Client"), Display(Name = "Code client")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("Societe_Client", TypeName = "nvarchar"), Display(Name = "Société"), Required(ErrorMessage = "Champ obligatoire !"), MaxLength(50, ErrorMessage = "Le libellé de votre société ne peut contenir plus de 50 caractères !")]
        public string Company { get; set; }
        
        [Column("Nom_Client", TypeName = "nvarchar"), Display(Name = "Nom"), Required(ErrorMessage = "Champ obligatoire !"), MaxLength(50, ErrorMessage = "Votre nom ne peut contenir plus de 50 caractères !")]
        public string FirstName { get; set; }

        [Column("Prenom_Client", TypeName = "nvarchar"), Display(Name = "Prénom"), Required(ErrorMessage = "Champ obligatoire !"), MaxLength(50, ErrorMessage = "Votre prénom ne peut contenir plus de 50 caractères !")]
        public string LastName { get; set; }

        [Column("Email_Client", TypeName = "nvarchar"), Display(Name = "Email"), Required(ErrorMessage = "Champ obligatoire !"), MaxLength(100, ErrorMessage = "Votre email ne peut contenir plus de 100 caractères !")]
        public string Email { get; set; }

        [Column("Telephone_Client", TypeName = "nvarchar"), Display(Name = "Téléphone"), Required(ErrorMessage = "Champ obligatoire !"), MaxLength(20, ErrorMessage = "Votre téléphone ne peut contenir plus de 20 caractères !")]
        public string Phone { get; set; }

        [Column("Cree_le_Client"), Display(Name = "Crée le"), Required(ErrorMessage = "Champ obligatoire !")]
        public DateTime CreatedAt { get; set; }
    }
}
