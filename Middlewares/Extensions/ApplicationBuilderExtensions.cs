namespace Middlewares.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseXFrameOptions(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                context.Response.Headers["X-Frame-Options"] = "DENY";
                await next();
            });
        }

        public static IApplicationBuilder UseXContentTypeOptions(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                context.Response.Headers["X-Content-Type-Options"] = "nosniff";
                await next();
            });
        }

        public static IApplicationBuilder UseXXSSProtection(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                context.Response.Headers["X-XSS-Protection"] = "1; mode=block";
                await next();
            });
        }

        public static IApplicationBuilder UseContentSecurityPolicy(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                context.Response.Headers["Content-Security-Policy"] = "default-src 'self'; script-src 'self'; style-src 'self';";
                await next();
            });
        }

        public static IApplicationBuilder UseReferrerPolicy(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                context.Response.Headers["Referrer-Policy"] = "no-referrer";
                await next();
            });
        }

        public static IApplicationBuilder UsePermissionPolicy(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                context.Response.Headers["Permission-Policy"] = "geolocation=(), microphone=(), camera=()";
                await next();
            });
        }
    }
}
