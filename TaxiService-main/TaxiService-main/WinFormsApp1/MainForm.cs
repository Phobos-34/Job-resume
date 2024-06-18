using TaxiBusiness.Services;
using TaxiClient.FormCntrls;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private MainFormCntrl _mainFormCntrl;
        public MainForm()
        {
            InitializeComponent();
            _mainFormCntrl = new MainFormCntrl();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string loginText = LoginTextBox.Text;
            string passwordText = PasswordTextBox.Text;

            var res = _mainFormCntrl.Authentication(loginText, passwordText);

            if (res is null)
            {
                DebugLabel.Text = "Nothing!!!";
                return;
            }

            Hide();
            _mainFormCntrl.Authorization(res,this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainService.Upload();
            Application.Exit();
        }
    }
}