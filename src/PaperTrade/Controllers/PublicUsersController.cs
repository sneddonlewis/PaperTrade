using MediatR;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JHipsterNet.Core.Pagination;
using JHipsterNet.Core.Pagination.Extensions;
using PaperTrade.Domain.Entities;
using PaperTrade.Security;
using PaperTrade.Domain.Services.Interfaces;
using PaperTrade.Dto;
using PaperTrade.Web.Extensions;
using PaperTrade.Web.Filters;
using PaperTrade.Web.Rest.Problems;
using PaperTrade.Web.Rest.Utilities;
using PaperTrade.Crosscutting.Constants;
using PaperTrade.Crosscutting.Exceptions;
using PaperTrade.Infrastructure.Web.Rest.Utilities;
using PaperTrade.Application.Queries;
using PaperTrade.Application.Commands;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PaperTrade.Controllers;


[Route("api/users")]
[ApiController]
public class PublicUsersController : ControllerBase
{
    private readonly ILogger<UsersController> _log;
    private readonly IMediator _mediator;

    public PublicUsersController(ILogger<UsersController> log, IMediator mediator)
    {
        _log = log;
        _mediator = mediator;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAllPublicUsers(IPageable pageable)
    {
        _log.LogDebug("REST request to get a page of Users");
        (var headers, var userDtos) = await _mediator.Send(new UserGetAllPublicUsersQuery { Page = pageable });
        return Ok(userDtos).WithHeaders(headers);
    }

}
