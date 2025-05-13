using DependencyInjectionDemo.ExampleConsoleAppWithoutDI.Concretes;

namespace DependencyInjectionDemo.ExampleConsoleAppWithoutDI;

public class Program
{
	static void Main(string[] args)
	{
		var notificationService = new NotificationService();
		notificationService.SendNotification(
			to: "berkanserbes3@gmail.com",
			subject: "Dependency Injection",
			body: "Use dependency injection for better applications."
		);
	}
}
