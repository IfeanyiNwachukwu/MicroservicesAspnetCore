using Catalogue.API.Entitities;
using MongoDB.Driver;

namespace Catalogue.API.Data
{
    public interface ICatalogueContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
