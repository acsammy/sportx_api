using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using sportx_api.Enums;

namespace sportx_api.Models
{
  public class Partner
  {
    public Partner()
    {
      Phonelist = new List<PartnerPhones>();
    }
    [KeyAttribute]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public bool Cpf { get; set; }
    public bool Cnpj { get; set; }
    public string SocialNumber { get; set; }
    [Required]
    public PartnerClassification Classification { get; set; }
    public int Cep { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    List<PartnerPhones> Phonelist { get; set; }
  }
}