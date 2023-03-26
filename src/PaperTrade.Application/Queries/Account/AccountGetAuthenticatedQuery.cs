using PaperTrade.Domain.Entities;
using MediatR;
using PaperTrade.Dto;
using System.Security.Claims;

namespace PaperTrade.Application.Commands;

public class AccountGetAuthenticatedQuery : IRequest<string>
{
    public ClaimsPrincipal User { get; set; }
}
