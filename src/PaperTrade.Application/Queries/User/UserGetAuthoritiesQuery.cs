using MediatR;
using System.Collections.Generic;

namespace PaperTrade.Application.Queries;

public class UserGetAuthoritiesQuery : IRequest<IEnumerable<string>>
{
}
