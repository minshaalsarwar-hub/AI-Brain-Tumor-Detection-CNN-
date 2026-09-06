using System;
using System.Collections.Generic;

namespace MIP;

public partial class MedicalImage
{
    public int ImageId { get; set; }

    public string ImageType { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public DateTime UploadDate { get; set; }

    public string ImageFormat { get; set; } = null!;

    public int ImageSize { get; set; }

    public string Description { get; set; } = null!;

    public string PatientName { get; set; } = null!;

    public DateTime PatientDob { get; set; }

    public string PatientGender { get; set; } = null!;

    public string PatientContactInfo { get; set; } = null!;

    public string PatientAddress { get; set; } = null!;

    public virtual ICollection<Prediction> Predictions { get; set; } = new List<Prediction>();
}
