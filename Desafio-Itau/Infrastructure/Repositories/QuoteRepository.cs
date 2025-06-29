using DesafioInvestimentosItau.Application.Quote.Quote.Contract.Interfaces;
using DesafioInvestimentosItau.Domain.Entities;
using DesafioInvestimentosItau.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DesafioInvestimentosItau.Infrastructure.Repositories;

public class QuoteRepository: IQuoteRepository
{
    private readonly ApplicationDbContext _context;

    public QuoteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistsAsync(string assetCode, DateTime timestamp)
    {
        return await _context.Quotes
            .AnyAsync(q => q.AssetCode == assetCode && q.Timestamp == timestamp);
    }
    
    public async Task<QuoteEntity> CreateAsync(QuoteEntity quote)
    {
        _context.Quotes.Add(quote);
        await _context.SaveChangesAsync();
        return quote;
    }
    
    public async Task<QuoteEntity?> GetLatestByAssetCodeAsync(string assetCode)
    {
        var latestQuote = await _context.Quotes
            .Where(q => q.AssetCode == assetCode)
            .OrderByDescending(q => q.Timestamp)
            .FirstOrDefaultAsync();


        return latestQuote;
    }
}