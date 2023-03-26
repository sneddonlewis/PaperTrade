using MediatR;

namespace PaperTrade.Application.Commands;

public class AccountResetPasswordCommand : IRequest<Unit>
{
    public string Mail { get; set; }
}
