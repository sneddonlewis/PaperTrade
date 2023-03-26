using MediatR;
using PaperTrade.Dto;

namespace PaperTrade.Application.Commands;

public class AccountGetQuery : IRequest<UserDto>
{
}
