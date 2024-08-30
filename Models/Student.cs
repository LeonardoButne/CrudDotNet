using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeoTest.Models;

public class Student{

    [Key]
    [DisplayName("ID")]

    public int Id {get; set;}

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength (80, ErrorMessage = "O nome deve conter ate 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter pelo menos 5 caracteres")]
    [DisplayName("Nome completo")]
    public string Name {get; set;} = string.Empty;
    
    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail invalido")]
    [DisplayName("Email")]
    public string Email {get; set;} = string.Empty;

    public List <Premium> Premiums {get; set; } = new();
} 