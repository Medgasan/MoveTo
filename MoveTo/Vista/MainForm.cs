using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using MoveTo.Vista;

namespace MoveTo
{
    public partial class MainForm : Form
    {

        Controller Ctrl;

        public MainForm(Controller controller)
        {
            InitializeComponent();
            Ctrl = controller;
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Ctrl.LoadConfig(
                addToContextMenuToolStripMenuItem,
                addFolderToolStripMenuItem,
                crearSoftLinkEnElOrigenToolStripMenuItem);
            Ctrl.InitForm(this, txtOrigen, txtDestino, fBDialog);
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Ha Ocurrido el error: "
                + e.ExceptionObject.GetType().Name +
                ".\nPor favor contacte con su Administrdor del Sistema", "MoveTo");
        }

        private void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Ha Ocurrido el error: "
                + e.Exception.Message +
                ".\nPor favor contacte con su Administrdor del Sistema", "MoveTo");
        }

        private void btnSelectOrigen_Click(object sender, EventArgs e)
        {
            Ctrl.SetFolder(txtOrigen);
        }

        private void btnSelectDestino_Click(object sender, EventArgs e)
        {
            Ctrl.SetDestiny(txtDestino, txtOrigen);
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            Ctrl.MoveTo(txtDestino, txtOrigen);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void txtDestino_Leave(object sender, EventArgs e)
        {
            Ctrl.AddDestinyFolder(txtDestino, txtOrigen);
        }

        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("Help\\index.html");
                Help.ShowHelp(this, "file:./MoveTo.chm", HelpNavigator.TableOfContents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MoveTo");
            }
        }

        private void addToContextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ctrl.SetAddToContext(addToContextMenuToolStripMenuItem.Checked);
        }

        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ctrl.SetAddFolder(addFolderToolStripMenuItem.Checked);
        }

        private void crearSoftLinkEnElOrigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ctrl.SetSoftLink(crearSoftLinkEnElOrigenToolStripMenuItem.Checked);
        }

        private void acuerdoDeLicenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("Help\\eula.html");
                Help.ShowHelp(this, "file:./MoveTo.chm",HelpNavigator.KeywordIndex,"Licencia");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MoveTo");
            }
            //Cluf cluf = new Cluf();
            //cluf.Show();
        }
    }
}
