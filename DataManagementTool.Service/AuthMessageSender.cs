using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataManagementTool.Service
{
    public class AuthMessageSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.FromResult(0);
        }
    }
}
