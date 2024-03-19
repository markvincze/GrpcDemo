builder.Services.AddGrpc(options =>
{
    options.Interceptors.Add<LoggingInterceptor>();
});



builder.Services.AddControllers();

app.MapControllers();
