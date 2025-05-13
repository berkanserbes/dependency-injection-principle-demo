namespace DependencyInjectionDemp.ExampleConsoleAppWithDI.Concretes;

public class NotificationService
{
	private readonly EmailService _emailService;

	public NotificationService(EmailService emailService)
	{
		_emailService = emailService;
	}

	public void SendNotification(string to, string subject, string body)
	{
		_emailService.SendEmail(to, subject, body);
	}
}
