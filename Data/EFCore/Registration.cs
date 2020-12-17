using Microsoft.Extensions.DependencyInjection;

namespace CompassSurvey.Data.EFCore
{
    public class Registration
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<EfCoreSurveyQuestionRepository>();
            services.AddScoped<EfCoreSurveyAnswerRepository>();
            services.AddScoped<EfCoreQuestionRepository>();
            services.AddScoped<EfCoreOptionRepository>();
        }
    }
}
