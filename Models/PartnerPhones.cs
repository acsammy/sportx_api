using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace sportx_api.Models
{
  public class PartnerPhones
  {
    [Key]
    public int Id { get; set; }
    public string Phone { get; set; }
    [ForeignKey("FK_Partner_PartnerPhone")]
    public int IdPartner{ get; set; }

    public Partner Partner { get; set; }
  }
}