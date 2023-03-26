using MediatR;
using PaperTrade.Dto.Authentication;
using System.Security.Principal;

namespace PaperTrade.Application.Commands;

public class UserJwtAuthorizeCommand : IRequest<IPrincipal>
{
    public LoginDto LoginDto { get; set; }
}
