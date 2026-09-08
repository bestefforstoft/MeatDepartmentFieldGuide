
/*
	Important

	There is one architectural issue here that I want to catch before you build on it.

	sqlite-net-pcl doesn't automatically know that our POCO property MeatRegion.MeatId maps to the table we've created with the exact schema unless we explicitly configure mappings/attributes or use SQLite-net's table creation system.

	Because we're using SQL migrations as the source of truth, I don't want to mix two competing schema-generation systems.

	So for the first implementation, I'd actually change our repository strategy slightly: use Microsoft.Data.Sqlite for the infrastructure layer rather than sqlite-net's ORM behavior.

	That gives us:

	Domain POCOs
		 ↓
	Repositories
		 ↓
	Microsoft.Data.Sqlite
		 ↓
	SQLite

	rather than:

	Domain POCOs
		 ↓
	ORM conventions
		 ↓
	SQLite

	For this particular portfolio project, I think the first approach is better. It demonstrates that you understand SQL rather than hiding the database behind an ORM, while still keeping the database code isolated.

	Therefore, don't paste File 25 yet. We're going to replace that implementation in the next batch.
*/

// 26. Application service foundation
// MeatDepartmentFieldGuide.Application/Interfaces/IMeatCatalogService.cs

using MeatDepartmentFieldGuide.Core.Entities;


namespace MeatDepartmentFieldGuide.Application.Interfaces;


public interface IMeatCatalogService
{
    Task<IReadOnlyList<Meat>> GetMeatsAsync(
        CancellationToken cancellationToken = default);


    Task<IReadOnlyList<MeatRegion>> GetRegionsAsync(
        int meatId,
        CancellationToken cancellationToken = default);


    Task<IReadOnlyList<Primal>> GetPrimalsAsync(
        int regionId,
        CancellationToken cancellationToken = default);


    Task<IReadOnlyList<Subprimal>> GetSubprimalsAsync(
        int primalId,
        CancellationToken cancellationToken = default);


    Task<IReadOnlyList<Cut>> GetCutsAsync(
        int subprimalId,
        CancellationToken cancellationToken = default);
}
