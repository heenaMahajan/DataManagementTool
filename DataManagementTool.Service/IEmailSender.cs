using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataManagementTool.Service
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
