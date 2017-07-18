using Specification.Entities;
using System.Collections.Generic;

namespace Specification.Interfaces
{
	internal interface ICarRepository
	{
		/// <summary>
		/// Searches the specified car search specification.
		/// </summary>
		/// <param name="carSearchSpecification">The car search specification.</param>
		/// <returns>The result.</returns>
		IList<Car> Search(ICarSearchSpecification carSearchSpecification);
	}
}
