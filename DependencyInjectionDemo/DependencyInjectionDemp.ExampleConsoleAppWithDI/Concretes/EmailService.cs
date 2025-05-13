using DependencyInjectionDemp.ExampleConsoleAppWithDI.Abstracts;

namespace DependencyInjectionDemp.ExampleConsoleAppWithDI.Concretes;

public class EmailService : IEmailService
{
	public void SendEmail(string to, string subject, string body)
	{
		Console.WriteLine($"Email sent to {to} with subject '{subject}' and body '{body}'");
	}
}
