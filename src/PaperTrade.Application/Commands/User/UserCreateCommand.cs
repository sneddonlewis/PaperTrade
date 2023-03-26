using PaperTrade.Domain.Entities;
using MediatR;
using PaperTrade.Dto;

namespace PaperTrade.Application.Commands;

public class UserCreateCommand : IRequest<User>
{
    public UserDto UserDto { get; set; }
}
