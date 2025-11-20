// Models/ProductDetails.cs
public class ProductDetails
{
    public string SerialFPA { get; set; } = string.Empty;
    public string? SerialGEA { get; set; }
    public string? SerialHAIER { get; set; }
    public string Part { get; set; } = string.Empty;
    public string? PartIssue { get; set; }
    public DateTime? SerialIssueDate { get; set; }
    public string? VAI_FoamCode { get; set; }
}
public class TrackingInfo
{
    public int Workcell { get; set; }
    public int Task { get; set; }
    public string? StoreLocation { get; set; }
    public string? Status { get; set; }
    public string? Grade { get; set; }
    public DateTime? LastMaint { get; set; }
    public string? LastMaintLogon { get; set; }
    public int Zone { get; set; }
    public string? Store { get; set; }
    public string? UpdateReference { get; set; }
    public string? OrderNumber { get; set; }
    public string? RejectReason { get; set; }
}
public class TestingInfo
{
    public int Task { get; set; }
    public int Run { get; set; }
    public DateTime? DateTested { get; set; }
    public string? TestPart { get; set; }
    public string? Description { get; set; }
    public string? TaskReference { get; set; }
    public string? TestResult { get; set; }
    public string? TestFault { get; set; }
    public string? TestStatus { get; set; }
    public string? TaskStatus { get; set; }
}



public class PackingError
{
    public string? ReturnCode { get; set; }
    public string? DescriptionCode { get; set; }
    public string? Computer { get; set; }
    public DateTime? DateTested { get; set; }
    public string? Status { get; set; }
}

public class ReworkRecord
{
    public string? Serial { get; set; }
    public string? Part { get; set; }
    public DateTime? DateRecorded { get; set; }
    public string? AreaRecorded { get; set; }
    public string? RwkRepairCode { get; set; }
    public string? RwkRepairCodeDesc { get; set; }
    public string? RepairArea { get; set; }
    public string? RwkFaultCode { get; set; }
    public string? RwkFaultCodeDesc { get; set; }
    public string? Mold { get; set; }
}
public class ProductAggregateDto
{
    public ProductDetails ProductDetails { get; set; } = new ProductDetails();
    public IEnumerable<TrackingInfo> Tracking { get; set; } = Array.Empty<TrackingInfo>();
    public IEnumerable<TestingInfo> Testing { get; set; } = Array.Empty<TestingInfo>();
    public IEnumerable<PackingError> PackingErrors { get; set; } = Array.Empty<PackingError>();
    public IEnumerable<ReworkRecord> ReworkRecords { get; set; } = Array.Empty<ReworkRecord>();
}
