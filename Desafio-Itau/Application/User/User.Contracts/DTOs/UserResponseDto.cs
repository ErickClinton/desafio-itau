namespace DesafioInvestimentosItau.Application.User.User.Client.DTOs;

public class UserResponseDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public decimal BrokerageFee{ get; set; }
}