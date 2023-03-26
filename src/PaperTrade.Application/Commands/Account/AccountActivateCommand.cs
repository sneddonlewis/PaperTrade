using PaperTrade.Domain.Entities;
using MediatR;

namespace PaperTrade.Application.Commands;

public class AccountActivateCommand : IRequest<User>
{
    public string Key { get; set; }
}
