using DependencyInjectionDemp.ExampleConsoleAppWithDI.Concretes;

namespace DependencyInjectionDemp.ExampleConsoleAppWithDI;

public class Program
{
	static void Main(string[] args)
	{
		var notificationService = new NotificationService(new EmailService());
		notificationService.SendNotification(
			to: "berkanserbes3@gmail.com",
			subject: "Dependency Injection",
			body: "Use dependency injection for better applications."
		);
	}
}
