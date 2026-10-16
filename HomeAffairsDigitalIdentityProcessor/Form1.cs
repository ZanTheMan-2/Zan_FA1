using System.Globalization;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public List<CitizenProfile> citizenProfiles = new List<CitizenProfile>();
        private bool isIdValid;

        public Form1()
        {
            InitializeComponent();
            cmbCitizenship.SelectedIndex = 0;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            isIdValid = false;
            lblValidationResult.Text = "";
        }

        private void btnValidateID_Click(object sender, EventArgs e)
        {
            CitizenProfile profile = new CitizenProfile(txtName.Text.Trim(), txtID.Text.Trim(), cmbCitizenship.Text);
            lblValidationResult.Text = profile.ValidateID();
            isIdValid = profile.IsIDValid;
        }

        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isIdValid)
            {
                MessageBox.Show("Please validate a correct ID first.", "ID Not Validated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CitizenProfile profile = new CitizenProfile(txtName.Text.Trim(), txtID.Text.Trim(), cmbCitizenship.Text);
            string validationResult = profile.ValidateID();
            citizenProfiles.Add(profile);

            // a whole lot of printing
            txtSummary.Text =
                " DIGITAL CITIZEN SUMMARY " + Environment.NewLine +
                $"Name: {profile.FullName}" + Environment.NewLine +
                $"ID Number: {profile.IDNumber}" + Environment.NewLine +
                $"Age: {profile.Age}" + Environment.NewLine +
                $"Citizenship: {profile.CitizenshipStatus}" + Environment.NewLine +
                $"Validation: {validationResult}" + Environment.NewLine +
                "Processed at: Home Affairs Digital Desk" + Environment.NewLine +
                $"Timestamp: {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture)}";
        }
    }
}
