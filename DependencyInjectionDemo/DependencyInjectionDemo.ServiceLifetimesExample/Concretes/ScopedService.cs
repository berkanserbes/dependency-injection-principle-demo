using DependencyInjectionDemo.ServiceLifetimesExample.Abstracts;

namespace DependencyInjectionDemo.ServiceLifetimesExample.Concretes;

public class ScopedService : IScopedService
{
	public Guid Id { get; private set; }
	public ScopedService()
	{
		Id = Guid.NewGuid();
	}
}