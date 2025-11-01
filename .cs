namespace CatalogModule
{
    public static class  CatalogModule
    {
        public static IserviceCollection AddCatalogModule(  IServiceColleciton services) {

            var builder = WebApplication.CreateBuilder();km
            //without calling isevice as a native parameter
            CatalogModule.AddCatalogModule(builder.services)
            return services
        }
        
    }
}
