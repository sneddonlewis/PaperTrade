using System.Threading.Tasks;
using PaperTrade.Domain.Entities;

namespace PaperTrade.Domain.Services.Interfaces;

public interface IMailService
{
    Task SendPasswordResetMail(User user);
    Task SendActivationEmail(User user);
    Task SendCreationEmail(User user);
}
