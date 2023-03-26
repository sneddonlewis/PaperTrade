using PaperTrade.Domain.Entities;
using MediatR;

namespace PaperTrade.Application.Commands;

public class UserDeleteCommand : IRequest<Unit>
{
    public string Login { get; set; }
}
