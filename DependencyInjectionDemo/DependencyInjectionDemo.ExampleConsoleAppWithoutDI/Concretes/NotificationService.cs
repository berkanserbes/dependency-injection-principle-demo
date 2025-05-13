using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.ExampleConsoleAppWithoutDI.Concretes;

public class NotificationService
{
	private readonly EmailService _emailService;

	public NotificationService()
	{
		_emailService = new EmailService();
	}

	public void SendNotification(string to, string subject, string body)
	{
		_emailService.SendEmail(to, subject, body);
	}
}
