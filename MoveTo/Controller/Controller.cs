using Microsoft.VisualBasic.FileIO;
using MoveTo.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace MoveTo
{
    public class Controller
    {

        string origen = "";

        //bool AddFolder = true;
        //bool SoftLink = true;
        //bool ShellContext = true;

        FolderBrowserDialog fbd;
        //TODO: Implementar Multi idioma

        public Controller(string[] args)
        {
            if (args.Length > 1 && Directory.Exists(args[1]))
            {
                origen = args[1];
            }
        }

        internal void LoadConfig(ToolStripMenuItem addToContextMenuToolStripMenuItem, ToolStripMenuItem addFolderToolStripMenuItem, ToolStripMenuItem crearSoftLinkEnElOrigenToolStripMenuItem)
        {
            Helper.LoadConfig();
            addToContextMenuToolStripMenuItem.Checked = (bool)Helper.config[Helper.CREATECONTEXT];
            addFolderToolStripMenuItem.Checked = (bool)Helper.config[Helper.ADDNAME];
            crearSoftLinkEnElOrigenToolStripMenuItem.Checked = (bool)Helper.config[Helper.SOFTLINK];
        }

        public void InitForm(MainForm mainForm, TextBox txtOrigen, TextBox txtDestino, FolderBrowserDialog fbDialog)
        {
            if (!Helper.IsUserAnAdmin())
            {
                Helper.RunAsAdmin(origen);
                mainForm.Text += " (No Admin Mode)";
                //mainForm.Close();
                System.Environment.Exit(0);
                return;
            }
            fbd = fbDialog;

            if (origen.Length < 1) return;

            txtOrigen.Text = origen;
            SetDestiny(txtDestino, txtOrigen);

            return;
        }

        public void SetFolder(TextBox txt, string titulo = "Carpeta que quieres mover (origen)...")
        {
            fbd.SelectedPath = txt.Text;
            fbd.Description = titulo;
            fbd.ShowDialog();
            txt.Text = fbd.SelectedPath;
        }

        public void SetDestiny(TextBox txtDestiny, TextBox txtOrigin)
        {
            if (txtOrigin.Text.Length < 1)
            {
                MessageBox.Show("Elige origen primero");
                return;
            }
            SetFolder(txtDestiny, "Carpeta destino...");
            AddDestinyFolder(txtDestiny, txtOrigin);
        }

        internal void SetAddToContext(bool @checked)
        {
            Helper.config[Helper.CREATECONTEXT] = @checked;
            if (@checked)
            {
                Helper.AddToContextMenu();
            }
            else
            {
                Helper.DelToContextMenu();
            }
            Helper.SaveConfig();
        }

        public void AddDestinyFolder(TextBox txtDestiny, TextBox txtOrigin)
        {
            if (getFolderName(txtDestiny.Text).Equals(getFolderName(txtOrigin.Text))) return;
            if (Directory.Exists(txtDestiny.Text) && Directory.Exists(txtOrigin.Text))
            {
                txtDestiny.Text += txtDestiny.Text.EndsWith("\\") ? "" : "\\";
                if (!(bool)Helper.config[Helper.ADDNAME]) return;
                txtDestiny.Text += getFolderName(txtOrigin.Text);
            }
        }

        internal void SetSoftLink(bool @checked)
        {
            Helper.config[Helper.SOFTLINK] = @checked;
            Helper.SaveConfig();
        }

        private string getFolderName(string pathFolder)
        {
            string folderName = Path.GetFileName(pathFolder);
            return folderName;
        }

        public void MoveTo(TextBox txtDestino, TextBox txtOrigen)
        {
            if (txtOrigen.Text.Length < 1 || txtDestino.Text.Length < 1)
            {
                MessageBox.Show("Primero selecciona carpetas Origen y Destino");
                return;
            }
            txtDestino.Enabled = false;
            txtOrigen.Enabled = false;
            FileSystem.MoveDirectory(txtOrigen.Text, txtDestino.Text, UIOption.AllDialogs,UICancelOption.DoNothing);

            //TODO: Revisar si esta parte del código funciona bien
            if (Directory.Exists(txtOrigen.Text))
            {
                DialogResult dr = MessageBox.Show("no se ha podido mover todo el directorio \n ¿Deseas deshacer?", "MoveTo...", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    UndoMove(txtDestino.Text, txtOrigen.Text);
                }
                txtDestino.Enabled = true;
                txtOrigen.Enabled = true;
                return;
            }
            if ((bool)Helper.config[Helper.SOFTLINK])
            {
                try
                {
                    Helper.CreateSymbolicLink(txtOrigen.Text, txtDestino.Text, Helper.SymbolicLink.Directory);
                }
                catch (Exception e)
                {
                    DialogResult dr = MessageBox.Show("No se ha podido crear el enlace simbólido \n ¿Deseas deshacer?", "MoveTo...", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        UndoMove(txtDestino.Text, txtOrigen.Text);
                    }
                }
            }
            txtDestino.Enabled = true;
            txtOrigen.Enabled = true;
        }

        public void SetAddFolder(bool @checked)
        {
            Helper.config[Helper.ADDNAME] = @checked;
            Helper.SaveConfig();
        }

        public void UndoMove(string origen, string destino)
        {
            FileSystem.MoveDirectory(destino, origen, UIOption.AllDialogs,UICancelOption.DoNothing);
        }
    }
}
