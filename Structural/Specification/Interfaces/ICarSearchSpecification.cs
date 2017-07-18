using System.Collections.Generic;
using Specification.Entities;

namespace Specification.Interfaces
{
	internal interface ICarSearchSpecification
	{
		/// <summary>
		/// Searches the specified cars.
		/// </summary>
		/// <param name="cars">The cars.</param>
		/// <returns>The search result.</returns>
		IList<Car> Search(IList<Car> cars);
	}
}
