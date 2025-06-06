using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioInvestimentosItau.Domain.Entities;

public class AssetEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Code { get; set; } = string.Empty; 
    public string Name { get; set; } = string.Empty;

    public List<TradeEntity> Trades { get; set; } = new();
    public List<QuoteEntity> Quotes { get; set; } = new();
    public List<PositionEntity> Positions { get; set; } = new();
}