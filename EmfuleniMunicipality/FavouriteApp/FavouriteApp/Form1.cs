namespace FavouriteApp
{
    public partial class Form1 : Form
    {
        public String item;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            item = InputBox.Text;

            if (item == null)
            {
                MessageBox.Show("Please enter an item to add.");
                return;
            }
            for (int i = 0; i < ListTextBox.Items.Count; i++)
            {
                if (ListTextBox.Items[i].ToString() == item)
                {
                    MessageBox.Show("Item already exists in the list.");
                    return;
                }
            }
            ListTextBox.Items.Add(item);
            InfoLabel.Text = $"{item} has been added to the list. {DateTime.Now}";
        }

        private void ListTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (item != null)
                {
                    ListTextBox.Items.Remove(item);
                    InfoLabel.Text = $"{item} has been removed from the list. {DateTime.Now}";
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
                
            }
        }
    }
}
