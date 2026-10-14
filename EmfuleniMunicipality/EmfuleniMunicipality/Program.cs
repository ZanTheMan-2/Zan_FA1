using System;
using System.Collections.Generic;

namespace EmfuleniMunicipality
{
    public class Program
    {
        // storing
        public static List<Resident> residents = new List<Resident>();
        public static List<ServiceRequest> serviceRequests = new List<ServiceRequest>();
        public static List<ServiceRequest> resolvedRequests = new List<ServiceRequest>();
        public static UtilitiesManager manager = new UtilitiesManager();

        public static void Main()
        {
            //start
            Console.WriteLine("Welcome to the Emfuleni Municipality Management System!" +
                "\nHow many residents would you like to add?");

            try
            {
                // Get the number of residents to add
                int amount = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine($"Enter details for resident {i + 1}:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("ID Number: ");
                    string idNumber = Console.ReadLine();
                    Console.Write("Account Number: ");
                    string accountNumber = Console.ReadLine();
                    Console.Write("Address: ");
                    string address = Console.ReadLine();
                    Console.Write("Contact Number: ");
                    string contactNumber = Console.ReadLine();
                    Console.Write("Monthly Usage: ");
                    int monthlyUsage = Convert.ToInt32(Console.ReadLine());

                    residents.Add(new Resident(name, idNumber, accountNumber, address, contactNumber, monthlyUsage));
                    Console.WriteLine("Resident added successfully!");
                }
                if (residents.Count == 0)
                {
                    Console.WriteLine("No residents captured, so no service requests can be added.");
                    return;
                }

                // Get the number of service requests to add
                Console.WriteLine("How many service requests would you like to add?");
                int requestAmount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < requestAmount; i++)
                {
                    // Get the details for each service request
                    Console.WriteLine("Select a resident for the service request:");
                    for (int j = 0; j < residents.Count; j++)
                    {
                        Console.WriteLine($"{j + 1}. {residents[j].Name}");
                    }
                    int pickedResidentIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine("Service Request Type: ");
                    string typeOfRequest = Console.ReadLine();
                    Console.WriteLine("Priority Level (1-5): ");
                    int priorityLevel = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Severity Level (1-10): ");
                    int severityLevel = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Estimated Time to Resolve (in hours): ");
                    int estimatedTimeToResolve = Convert.ToInt32(Console.ReadLine());

                    serviceRequests.Add(new ServiceRequest(typeOfRequest, priorityLevel, severityLevel, estimatedTimeToResolve, residents[pickedResidentIndex]));
                }

                // show the queue, most urgent first
                SortByUrgency(serviceRequests);
                DisplayQueue(serviceRequests);

                // process requests until none are left
                while (serviceRequests.Count > 0)
                {
                    Console.WriteLine($"\nWhich request would you like to process? (1-{serviceRequests.Count})");
                    int pickedRequest;

                    // check it's a number and that it's in the queue
                    if (!int.TryParse(Console.ReadLine(), out pickedRequest) || pickedRequest < 1 || pickedRequest > serviceRequests.Count)
                    {
                        Console.WriteLine("Invalid choice. Please pick a number from the queue.");
                        continue;
                    }

                    // move the request from pending to resolved
                    ServiceRequest processed = serviceRequests[pickedRequest - 1];
                    serviceRequests.RemoveAt(pickedRequest - 1);
                    resolvedRequests.Add(processed);

                    // show the report for this request
                    Console.WriteLine(manager.GenerateReport(processed));

                    // show what's left
                    if (serviceRequests.Count > 0)
                    {
                        DisplayQueue(serviceRequests);
                    }
                }

                Console.WriteLine("\nAll service requests have been processed.");

                // summary of everything that was resolved
                Console.WriteLine("\n--- Summary of Resolved Requests ---");
                for (int i = 0; i < resolvedRequests.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {resolvedRequests[i].GetServiceRequestInfo()}" +
                        $", Urgency Score: {manager.CalculateUrgencyScore(resolvedRequests[i])}");
                }

                Console.WriteLine("\nHighest Urgency Request:");
                Console.WriteLine(manager.HighestPriority(resolvedRequests.ToArray()));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid information.");
            }
        }

        // sort requests so the highest urgency score is at the top (bubble sort)
        public static void SortByUrgency(List<ServiceRequest> requests)
        {
            for (int i = 0; i < requests.Count - 1; i++)
            {
                for (int j = 0; j < requests.Count - 1 - i; j++)
                {
                    // if the one below is more urgent, swap them
                    if (manager.CalculateUrgencyScore(requests[j]) < manager.CalculateUrgencyScore(requests[j + 1]))
                    {
                        ServiceRequest temp = requests[j];
                        requests[j] = requests[j + 1];
                        requests[j + 1] = temp;
                    }
                }
            }
        }

        // show all pending requests with their urgency score
        public static void DisplayQueue(List<ServiceRequest> requests)
        {
            Console.WriteLine("\n--- Pending Service Requests ---");
            for (int i = 0; i < requests.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {requests[i].GetServiceRequestInfo()}" +
                    $", Urgency Score: {manager.CalculateUrgencyScore(requests[i])}");
            }
        }
    }
}
