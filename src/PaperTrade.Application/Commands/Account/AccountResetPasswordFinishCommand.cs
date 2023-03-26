using PaperTrade.Domain.Entities;
using MediatR;
using PaperTrade.Dto.Authentication;

namespace PaperTrade.Application.Commands;

public class AccountResetPasswordFinishCommand : IRequest<User>
{
    public KeyAndPasswordDto KeyAndPasswordDto { get; set; }
}
