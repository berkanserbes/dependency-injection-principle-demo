using DependencyInjectionDemo.ServiceLifetimesExample.Abstracts;

namespace DependencyInjectionDemo.ServiceLifetimesExample.Concretes;

public class TransientService : ITransientService
{
	public Guid Id { get; private set; }
	public TransientService()
	{
		Id = Guid.NewGuid();
	}
}
