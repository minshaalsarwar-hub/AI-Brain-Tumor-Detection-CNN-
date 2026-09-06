using Microsoft.OpenApi.Models;
using MIP;
using MIP.DB; // Import the database operations.

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Medical Image Prediction API",
        Description = "API for storing and predicting medical images",
        Version = "v1"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Medical Image Prediction API V1");
    });
}

// API Routes

// Medical Image APIs
app.MapGet("/medicalimages/{id}", (int id) => MipDB.GetMedicalImage(id));
app.MapGet("/medicalimages", () => MipDB.GetMedicalImages());
app.MapPost("/medicalimages", (MedicalImage image) => MipDB.CreateMedicalImage(image));
app.MapPut("/medicalimages", (MedicalImage image) => MipDB.UpdateMedicalImage(image));
app.MapDelete("/medicalimages/{id}", (int id) => MipDB.RemoveMedicalImage(id));
// Prediction APIs

app.MapGet("/predictions/{id}", (int id) => MipDB.GetPrediction(id));
app.MapGet("/predictions", () => MipDB.GetPredictions());
app.MapPost("/predictions", (Prediction prediction) => MipDB.CreatePrediction(prediction));
app.MapPut("/predictions", (Prediction prediction) => MipDB.UpdatePrediction(prediction));
app.MapDelete("/predictions/{id}", (int id) => MipDB.RemovePrediction(id));

app.MapGet("/", () => "Welcome to Medical Image Prediction API!");

app.Run();
