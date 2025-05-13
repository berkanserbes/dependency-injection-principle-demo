using DependencyInjectionDemo.ServiceLifetimesExample.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemo.ServiceLifetimesExample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceLifetimesController : ControllerBase
{
	private readonly ITransientService _transientService1;
	private readonly ITransientService _transientService2;
	private readonly IScopedService _scopedService1;
	private readonly IScopedService _scopedService2;
	private readonly ISingletonService _singletonService1;
	private readonly ISingletonService _singletonService2;

	public ServiceLifetimesController(ITransientService transientService1, ITransientService transientService2, IScopedService scopedService1, IScopedService scopedService2, ISingletonService singletonService1, ISingletonService singletonService2)
	{
		_transientService1 = transientService1;
		_transientService2 = transientService2;
		_scopedService1 = scopedService1;
		_scopedService2 = scopedService2;
		_singletonService1 = singletonService1;
		_singletonService2 = singletonService2;
	}

	[HttpGet]
	public IActionResult Get()
	{
		return Ok(new
		{
			TransientService1Id = _transientService1.Id,
			TransientService2Id = _transientService2.Id,
			ScopedService1Id = _scopedService1.Id,
			ScopedService2Id = _scopedService2.Id,
			SingletonService1Id = _singletonService1.Id,
			SingletonService2Id = _singletonService2.Id
		});
	}

}
