using System;
using System.Security.Cryptography.X509Certificates;

public class ServiceRequest
{
	public String typeOfRequest { get; set; }
	public int PriorityLevel { get; set; }
	public int SeverityLevel { get; set; }
	public int EstimatedTimeToResolve { get; set; }
	public Resident resident { get; set; }
    
	public ServiceRequest(String typeOfRequest, int priorityLevel, int severityLevel, int estimatedTimeToResolve, Resident resident)
    {
        this.typeOfRequest = typeOfRequest;
        this.PriorityLevel = priorityLevel;
        this.SeverityLevel = severityLevel;
        this.EstimatedTimeToResolve = estimatedTimeToResolve;
        this.resident = resident;
    }

    public String GetServiceRequestInfo()
    {
        return $"Resident: {resident.Name}" +
            $", Type of Request: {typeOfRequest}" +
            $", Priority Level: {PriorityLevel}" +
            $", Severity Level: {SeverityLevel}" +
            $", Estimated Time to Resolve: {EstimatedTimeToResolve} hours";
    }
}
