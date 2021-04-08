using System;

namespace Play.Catalog.Contracts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string Description);

    public record UpdatedItemCreated(Guid ItemId, string Name, string Description);

    public record CatalogItemDeleted(Guid ItemId);
}