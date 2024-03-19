builder.Services.AddGrpc(options =>
{
    options.Interceptors.Add<LoggingInterceptor>();
});



builder.Services.AddControllers();

app.MapControllers();



builder.WebHost.ConfigureKestrel(kestrel =>
{
    kestrel.ListenAnyIP(5000, listenOptions => listenOptions.Protocols = HttpProtocols.Http1);
    kestrel.ListenAnyIP(5001, listenOptions => listenOptions.Protocols = HttpProtocols.Http2);
});

