using DesafioInvestimentosItau.Application.Investment.Investment.Contract.DTOs;
using DesafioInvestimentosItau.Application.Position.Position.Contract.DTOs;
using DesafioInvestimentosItau.Application.Trade.Trade.Contract.DTOs;

namespace DesafioInvestimentosItau.Application.Investment.Investment.Contract.Interfaces;

public interface IInvestmentService
{
    Task<List<TotalInvestedByAssetDto>> GetAllInvestmentsByUserIdAsync(long userId);
    Task<TopInvestmentsResponseDto> GetTopUserStatsAsync(int top);
}