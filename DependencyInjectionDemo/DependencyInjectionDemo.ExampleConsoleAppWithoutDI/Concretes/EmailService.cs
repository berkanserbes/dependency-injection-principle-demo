using DependencyInjectionDemo.ExampleConsoleAppWithoutDI.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.ExampleConsoleAppWithoutDI.Concretes;

public class EmailService : IEmailService
{
	public void SendEmail(string to, string subject, string body)
	{
		Console.WriteLine($"Email sent to {to} with subject '{subject}' and body '{body}'");
	}
}
