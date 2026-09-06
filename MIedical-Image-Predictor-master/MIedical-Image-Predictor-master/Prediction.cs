using System;
using System.Collections.Generic;

namespace MIP;

public partial class Prediction
{
    public int PredictionId { get; set; }

    public int ImageId { get; set; }

    public string ConditionDetected { get; set; } = null!;

    public float ConfidenceScore { get; set; }

    public string SegmentationData { get; set; } = null!;

    public string DetectionLocation { get; set; } = null!;

    public DateTime PredictionDate { get; set; }

    public string Remarks { get; set; } = null!;

    public virtual MedicalImage Image { get; set; } = null!;
}
