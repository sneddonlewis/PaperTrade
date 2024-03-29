using MediatR;
using PaperTrade.Dto;
using System.Security.Claims;

namespace PaperTrade.Application.Commands;

public class AccountSaveCommand : IRequest<Unit>
{
    public ClaimsPrincipal User { get; set; }
    public UserDto UserDto { get; set; }
}
