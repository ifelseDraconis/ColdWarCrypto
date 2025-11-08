using Microsoft.VisualBasic;
using System.Threading.Tasks;

/* the goal of this program is to create a simple GUI application that prompts the user to enter a secret code.
// the code can be found by pressing the help menu item in the file menu.
// this then opens the help menu, and you can use the upper case letters
// in order to get the secret code that will unlock the main menu
// I use dynamic labels, form text, and picture boxes to create a simple GUI application
// this is to imitate a cold war theme where the person is a soviet spy
// trying to gain access to secret information
*/

namespace ColdWarCrypto
{

    public partial class frmHome : Form
    {
        private const string sovietRule = "Welcome Comrade!";
        private const string secretCode = "RADD";
        private bool isCodeCorrect = false;
        public frmHome()
        {
            InitializeComponent();
        }

        // this simply handles closing the program when it is clicked or hit by using alt+x
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this closes the entire program when you select it to close it
            Application.Exit();
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }

        private void btnGoCommand_ClickAsync(object sender, EventArgs e)
        {
            if ((txtCommandBox.Text == secretCode) && (isCodeCorrect == false))
            {
                // correct code entered
                // this changes the visibility of the giff to visible and changes the prompt on the label
                // it also changes the text on the form
                // lets the form know that the code has been entered correctly
                frmHome.ActiveForm.Text = sovietRule;
                picGiff.Visible = true;
                isCodeCorrect = true;
            }
            // if the code is incorrect and has not been entered correctly yet
            // this tells you it is incorrect
            else if ((txtCommandBox.Text != secretCode) && (isCodeCorrect == false))
            {
                // incorrect code entered
                // this clears the entry box and prompts the user to try again after a 5 second delay
                // autofill has gotten so much better, haven't they?
                txtCommandBox.Clear();
                picGiff.Visible = false;
                lblPrompt.Text = "That is not the correct code. Try Again.";
                this.Refresh();
                Thread.Sleep(5000);
                lblPrompt.Text = "Enter the secret code to continue:";
            }

            // otherwise the code has been entered correctly
            // and it starts to check for commands instead
            if (isCodeCorrect == true)
            {
                // if the code has been correctly input, read for other codes
                if (txtCommandBox.Text == "Burn")
                {
                    txtCommandBox.Clear();
                    txtCommandBox.Visible = false;
                    btnGoCommand.Visible = false;
                    lblPrompt.Text = "Self Destruct Initiated. Terminating in 2 seconds...";
                    frmHome.ActiveForm.Text = "Goodbye Comrade.";
                    this.Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                }

                if (txtCommandBox.Text == "Report")
                {
                    // provide the secret report by using the CentralIntelligenceAgency class
                    // simulate sending and receiving encrypted data
                    CentralIntelligenceAgency cia = new CentralIntelligenceAgency();
                    string secretMessage = cia.GetSecretMessage();
                    string encryptedData = cia.sendEncryptedData(secretMessage);
                    string decryptedMessage = cia.receiveEncryptedData(encryptedData);
                    MessageBox.Show($"Decrypted Message from CIA: {decryptedMessage}", "Secret Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCommandBox.Clear();
                }
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // when the form first loads, the giff is not visible
            picGiff.Visible = false;
        }
    }
}
