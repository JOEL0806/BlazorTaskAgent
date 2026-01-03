using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.SemanticKernel;
using BlazorTaskAgent.Agents;
using System;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);

// Add Blazor services
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Configure Microsoft Agent (Semantic Kernel)
builder.Services.AddSingleton(sp =>
{
   var kernelBuilder = Kernel.CreateBuilder();

    kernelBuilder.AddOpenAIChatCompletion(
        modelId: "phi3",
        apiKey: "ollama",
        httpClient: new HttpClient
        {
            BaseAddress = new Uri("http://localhost:11434/v1/")
        }
    );
    return kernelBuilder.Build();
});

// Register our Task Planner Agent
builder.Services.AddScoped<TaskPlannerAgent>();
builder.Services.AddSingleton<BlazorTaskAgent.Data.WeatherForecastService>();
builder.Services.AddScoped<TextSummarizerAgent>();
builder.Services.AddTransient<TextSummarizerAgent>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();