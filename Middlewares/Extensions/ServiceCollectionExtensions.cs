namespace Middlewares.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHttpsRedirectionAndHsts(this IServiceCollection services)
        {
            services.AddHttpsRedirection(options =>
            {
                options.RedirectStatusCode = StatusCodes.Status308PermanentRedirect;
                options.HttpsPort = 443; //Production yapılarda orjinal SSL Port numarasıdır.
            });

            services.AddHsts(options =>
            {
                options.MaxAge = TimeSpan.FromDays(365);
                options.IncludeSubDomains = true;
                options.Preload = true;
            });

            return services;
        }
    }
}
