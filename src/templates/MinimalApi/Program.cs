var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

#if(includeValidation)
services.AddValidators();
#endif
services.AddEndpoints();

var app = builder.Build();

#if(includeValidation)
app.MapEndpoints()
    .AddValidationFilter();
#else
app.MapEndpoints();
#endif

app.Run();