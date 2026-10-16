namespace HomeAffairsDigitalIdentityProcessor
{

    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; private set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge();
        }
        //true once ValidateID() has passed all checks
        public bool IsIDValid { get; private set; }

        //check if real id
        public string ValidateID()
        {
            IsIDValid = false;

            if (IDNumber.Length != 13)
            {
                return "Invalid ID. ID must contain exactly 13 digits.";
            }

            if (!IDNumber.All(char.IsDigit))
            {
                return "Invalid ID. ID must contain only numbers.";
            }

            if (Age < 0)
            {
                return "Invalid ID. Date of birth in the ID is not valid.";
            }

            IsIDValid = true;
            return $"Valid ID. Citizen is {Age} years old.";
        }

        private int CalculateAge()
        {
            if (IDNumber.Length < 6 || !IDNumber.Substring(0, 6).All(char.IsDigit))
            {
                return -1;
            }

            if (!TryGetBirthDate(IDNumber, out DateTime birthDate))
            {
                return -1;
            }

            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        //gets day when born
        private static bool TryGetBirthDate(string idNumber, out DateTime birthDate)
        {
            birthDate = DateTime.MinValue;

            int year = int.Parse(idNumber.Substring(0, 2));
            int month = int.Parse(idNumber.Substring(2, 2));
            int day = int.Parse(idNumber.Substring(4, 2));

            int currentYear = DateTime.Today.Year % 100;
            int century = year <= currentYear ? 2000 : 1900;
            year += century;

            if (month < 1 || month > 12 || day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                return false;
            }

            birthDate = new DateTime(year, month, day);

            return birthDate <= DateTime.Today;
        }
    }
}
