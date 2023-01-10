var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

#if IncludeValidation
services.AddValidators();
#endif
services.AddEndpoints();

var app = builder.Build();

#if IncludeValidation
app.MapEndpoints()
    .AddValidationFilter();
#else
app.MapEndpoints();
#endif

app.Run();