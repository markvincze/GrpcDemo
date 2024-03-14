using Grpc.Core.Interceptors;
using Grpc.Core;

namespace GrpcDemo.Web.Interceptors;

public class LoggingInterceptor : Interceptor
{
    private readonly ILogger _logger;

    public LoggingInterceptor(ILogger<LoggingInterceptor> logger)
    {
        _logger = logger;
    }

    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
    {
        _logger.LogInformation("Processing call: {Type} / {Method}", MethodType.Unary, context.Method);

        try
        {
            return await continuation(request, context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error thrown by {context.Method}.");
            throw;
        }
    }
}
