using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.AI; // Required for IChatClient and OllamaChatClient
using BlazorTaskAgent.Agents;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// --- FIXED AI SECTION ---

// 1. Create the Chat Client (Ollama)
// We connect to your local Ollama instance (default port 11434)
IChatClient ollamaClient = new OllamaChatClient(
    new Uri("http://localhost:11434/"), 
    "phi3" // Make sure you have 'ollama pull phi3' or change this to your model
);

// 2. Register the ChatClient so agents can use it
builder.Services.AddSingleton(ollamaClient);

// 3. Register your Agent
builder.Services.AddScoped<TaskPlannerAgent>();
builder.Services.AddScoped<TextSummarizerAgent>();

// -------------------------

// Register other services
builder.Services.AddSingleton<BlazorTaskAgent.Data.WeatherForecastService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();