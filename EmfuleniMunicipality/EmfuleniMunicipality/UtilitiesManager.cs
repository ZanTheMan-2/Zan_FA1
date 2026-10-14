using System;

public class UtilitiesManager
{
    public int CalculateUrgencyScore(ServiceRequest request)
    {
        int score = (request.PriorityLevel * 2) + request.SeverityLevel;

        if (request.EstimatedTimeToResolve <= 4)
        {
            score = score + 2;
        }

        return score;
    }

    // build the report for a processed request
    public String GenerateReport(ServiceRequest request)
    {
        return "\n SERVICE REPORT " +
            "\n-- Resident Details --" +
            $"\n{request.resident.GetResidentInfo()}" +
            "\n-- Service Request Details --" +
            $"\n{request.GetServiceRequestInfo()}" +
            $"\nUrgency Score: {CalculateUrgencyScore(request)}";
    }

    // find the request with the highest urgency score
    public String HighestPriority(ServiceRequest[] requests)
    {
        ServiceRequest highestPriorityRequest = null;
        foreach (ServiceRequest request in requests)
        {
            if (highestPriorityRequest == null || CalculateUrgencyScore(request) > CalculateUrgencyScore(highestPriorityRequest))
            {
                highestPriorityRequest = request;
            }
        }
        return highestPriorityRequest != null ? highestPriorityRequest.GetServiceRequestInfo() + $", Urgency Score: {CalculateUrgencyScore(highestPriorityRequest)}" :"No service requests available.";
    }
}