using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
namespace Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string conf, string config)
        {
            return Task.CompletedTask;
        }
    }
}
