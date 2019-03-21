using Microsoft.AspNetCore.Builder;

namespace WebSocketBroadcast.Middlewares
{
    public static class WebsocketClientMiddlewareExtension
    {
        public static IApplicationBuilder UseWebsocketClientMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<WebsocketClientMiddleware>();
        }
    }
}