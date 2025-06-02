using System.Windows.Forms;

namespace goldfish
{
     public class Context : ApplicationContext
     {
        public Context()
        {
            AuthForm auth = new AuthForm();
            auth.FormClosed += SwitchToMain;
            auth.Show();
        }
     
        private void SwitchToMain(object sender, FormClosedEventArgs e)
        {
            if (AuthForm.authSuccessful)
            {
                MainForm main = new MainForm();
                main.FormClosed += (s, args) => ExitThread();
                main.Show();
            }
            else
            {
                ExitThread();
            }
        }
    }
}
