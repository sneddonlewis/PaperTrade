using MediatR;
using PaperTrade.Dto.Authentication;

namespace PaperTrade.Application.Commands;

public class AccountChangePasswordCommand : IRequest<Unit>
{
    public PasswordChangeDto PasswordChangeDto { get; set; }
}
