using DependencyInjectionDemo.ServiceLifetimesExample.Abstracts;

namespace DependencyInjectionDemo.ServiceLifetimesExample.Concretes;

public class SingletonService : ISingletonService
{
	public Guid Id { get; private set; }
	public SingletonService()
	{
		Id = Guid.NewGuid();
	}
}
