using PaperTrade.Dto;
using MediatR;

namespace PaperTrade.Application.Queries;

public class UserGetQuery : IRequest<UserDto>
{
    public string Login { get; set; }
}
