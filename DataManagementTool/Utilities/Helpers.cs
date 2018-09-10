using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading.Tasks;


namespace DataManagementTool.Utilities
{
    public static class Helpers
    {
        private static readonly char[] Punctuations = "!@#$%^&*()_-+=[{]};:>|./?".ToCharArray();
    
        public static string PasswordGenerate(int length, int numberOfNonAlphanumericCharacters)
        {
            if (length < 1 || length > 128)
            {
                throw new ArgumentException(nameof(length));
            }

            if (numberOfNonAlphanumericCharacters > length || numberOfNonAlphanumericCharacters < 0)
            {
                throw new ArgumentException(nameof(numberOfNonAlphanumericCharacters));
            }

            using (var rng = RandomNumberGenerator.Create())
            {
                var byteBuffer = new byte[length];

                rng.GetBytes(byteBuffer);

                var count = 0;
                var characterBuffer = new char[length];

                for (var iter = 0; iter < length; iter++)
                {
                    var i = byteBuffer[iter] % 87;

                    if (i < 10)
                    {
                        characterBuffer[iter] = (char)('0' + i);
                    }
                    else if (i < 36)
                    {
                        characterBuffer[iter] = (char)('A' + i - 10);
                    }
                    else if (i < 62)
                    {
                        characterBuffer[iter] = (char)('a' + i - 36);
                    }
                    else
                    {
                        characterBuffer[iter] = Punctuations[i - 62];
                        count++;
                    }
                }

                if (count >= numberOfNonAlphanumericCharacters)
                {
                    return new string(characterBuffer);
                }

                int j;
                var rand = new Random();

                for (j = 0; j < numberOfNonAlphanumericCharacters - count; j++)
                {
                    int k;
                    do
                    {
                        k = rand.Next(0, length);
                    }
                    while (!char.IsLetterOrDigit(characterBuffer[k]));

                    characterBuffer[k] = Punctuations[rand.Next(0, Punctuations.Length)];
                }

                return new string(characterBuffer);
            }
        }
        //public static void SendMail(string email, string userName, string subject, string role, string password, string url)
        //{
        //    var emailMessage = new MimeMessage();
        //    var body = new BodyBuilder();
        //    emailMessage.From.Add(new MailboxAddress("Administrator", "Admin@idsil.com"));
        //    emailMessage.To.Add(new MailboxAddress("", email));
        //    emailMessage.Subject = subject;
        //    var webRoot = _env.WebRootPath;
        //    using (StreamReader SourceReader = System.IO.File.OpenText(System.IO.Path.Combine(webRoot, "HTMLTemplates/User_Template.html")))
        //    {
        //        var emailText = SourceReader.ReadToEnd();
        //        emailText = emailText.Replace("$$UserName$$", userName);
        //        emailText = emailText.Replace("$$UserRole$$", role.ToLower());
        //        emailText = emailText.Replace("$$Email$$", email);
        //        emailText = emailText.Replace("$$Password$$", password);
        //        emailText = emailText.Replace("$$Url$$", url);
        //        body.HtmlBody = emailText;
        //        emailMessage.Body = body.ToMessageBody();
        //    }

        //    using (var client = new SmtpClient())
        //    {
        //        client.LocalDomain = _iconfiguration["SMTPServer"];
        //        client.Connect(_iconfiguration["SMTPServer"], 25, SecureSocketOptions.None);//.ConfigureAwait(false);
        //        client.Send(emailMessage);//.ConfigureAwait(false);
        //        client.Disconnect(true);
        //    }

        //}
    }
}
