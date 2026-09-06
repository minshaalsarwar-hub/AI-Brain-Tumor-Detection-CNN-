namespace MIP.DB;

using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

// Define a static class 'MipDB' to manage data operations.
public static class MipDB
{
    // CRUD Operations for Medical Images
    public static List<MedicalImage> GetMedicalImages()
    {
        using var context = new MipContext();
        return context.MedicalImages.ToList();
    }

    public static MedicalImage? GetMedicalImage(int id)
    {
        using var context = new MipContext();
        return context.MedicalImages.Find(id);
    }

    public static MedicalImage CreateMedicalImage(MedicalImage image)
    {
        using var context = new MipContext();
        context.MedicalImages.Add(image);
        context.SaveChanges();
        return image;
    }

    public static void UpdateMedicalImage(MedicalImage update)
    {
        using var context = new MipContext();
        var image = context.MedicalImages.Find(update.ImageId);
        if (image != null)
        {
            image.ImagePath = update.ImagePath;
            context.SaveChanges();
        }
    }

    public static void RemoveMedicalImage(int id)
    {
        using var context = new MipContext();
        var image = context.MedicalImages.Find(id);
        if (image != null)
        {
            context.MedicalImages.Remove(image);
            context.SaveChanges();
        }
    }

    // CRUD Operations for Predictions
    public static List<Prediction> GetPredictions()
    {
        using var context = new MipContext();
        return context.Predictions.ToList();
    }

    public static Prediction? GetPrediction(int id)
    {
        using var context = new MipContext();
        return context.Predictions.Find(id);
    }

    public static Prediction CreatePrediction(Prediction prediction)
    {
        using var context = new MipContext();
        context.Predictions.Add(prediction);
        context.SaveChanges();
        return prediction;
    }

    public static void UpdatePrediction(Prediction update)
    {
        using var context = new MipContext();
        var prediction = context.Predictions.Find(update.PredictionId);
        if (prediction != null)
        {
            prediction.ConditionDetected = update.ConditionDetected;
            prediction.ConfidenceScore = update.ConfidenceScore;
            context.SaveChanges();
        }
    }

    public static void RemovePrediction(int id)
    {
        using var context = new MipContext();
        var prediction = context.Predictions.Find(id);
        if (prediction != null)
        {
            context.Predictions.Remove(prediction);
            context.SaveChanges();
        }
    }
}
