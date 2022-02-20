
namespace PasswordGeneratorCSharp
{
    public partial class PasswordGenForm : Form
    {
        public PasswordGenForm()
        {
            InitializeComponent();
        }

        private void PasswordGenButton_Click(object sender, EventArgs e)
        {
            string password = "";

            while (!isInteger(PasswordLengthBox.Text))
            {
                MessageBox.Show("Entry must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int length = (int)long.Parse(PasswordLengthBox.Text);
            char letter = getLetter();

            for (int i = 0; i < length; i++)
            {
                do
                {
                    letter = getLetter();
                } while (password.Contains(letter));
                password += letter;
            }
            PasswordOutputBox.Text = password;
        }

        private void PasswordLengthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordGenForm_Load(object sender, EventArgs e)
        {
            PasswordLengthBox.Text = "8";
        }

        public static char getLetter()
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);

            return chars[num];
        }

        public static bool isInteger(string input)
        {
            bool isInt = int.TryParse(input, out int result);

            return isInt;
        }

        private void PasswordOutputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}