using System.IO.Compression;

namespace AngularApp1.Server.MiddleWare
{
    public class GzipCompressionMiddleware
    {
        private readonly RequestDelegate _next;
        public GzipCompressionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path == "/api/Compression/CompressedResponse")
            {
                var acceptEncoding = context.Request.Headers["Accept-Encoding"];

                if (acceptEncoding.ToString().Contains("gzip"))
                {
                    context.Response.Headers.Append("Content-Encoding", "gzip");

                    using (var gzipStream = new GZipStream(context.Response.Body, CompressionMode.Compress))
                    {
                        context.Response.Body = gzipStream;

                        await _next(context);

                        await gzipStream.FlushAsync();
                    }
                }
                else
                {
                    await _next(context);
                }
            }
            else
            {
                await _next(context);
            }
        }
    }
}
