using PaperTrade.Domain.Entities;
using MediatR;
using PaperTrade.Dto;

namespace PaperTrade.Application.Commands;

public class AccountCreateCommand : IRequest<User>
{
    public ManagedUserDto ManagedUserDto { get; set; }
}
