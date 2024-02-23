namespace EVS.Api.Extensions
{
    public static class WebApplicationExtension
    {
        public static void AddSwagger(this WebApplication webApp)
        {
            if (webApp.Environment.IsDevelopment())
            {
                webApp.UseSwagger();
                webApp.UseSwaggerUI(options =>
                {
                    options.DocumentTitle = "\"En voiture Simone !\" API";
                });
            }
        }
    }
}
