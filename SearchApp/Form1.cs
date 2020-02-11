using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int numberOfRepetitions = 0;
        static StringCollection log = new StringCollection();

        private void SelectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtSelectedFolderPath.Text = fbd.SelectedPath.ToString();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSelectedFolderPath.Text == "")
            {
                MessageBox.Show("Select folder first!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelectFolder();
            }
            numberOfRepetitions = 0;
            txtTextInFile.Text = "";
            lbxFilesList.Items.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(txtSelectedFolderPath.Text);
            TreeView tree = new TreeView();
            ListDirectory(tree, directoryInfo);
            lblNumber.Text = numberOfRepetitions.ToString();
        }

        private void ListDirectory(TreeView treeView, DirectoryInfo directoryInfo)
        {
            treeView.Nodes.Add(WalkDirectoryTree(directoryInfo));
        }

        private TreeNode WalkDirectoryTree(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            try
            {
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    directoryNode.Nodes.Add(WalkDirectoryTree(directory));
                }
                foreach (var file in directoryInfo.GetFiles("*.txt"))
                {
                    if (SearchStringInFile(txtSearchText.Text, file.FullName))
                    {
                        lbxFilesList.Items.Add(file);
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                log.Add(e.Message);
            }

            return directoryNode;
        }
        private bool SearchStringInFile(String searchString, String filePath)
        {
            bool returnState = false;
            string text = System.IO.File.ReadAllText(filePath);
            int i = 0;

            while ((i + searchString.Length) < text.Length)
            {
                int j = 0;
                while (j< searchString.Length && text[i + j] == searchString[j])
                {
                    j ++;
                    if (j >= searchString.Length)
                    {
                        numberOfRepetitions++;
                        returnState = true;
                    }
                }
                i ++;
            }
            return returnState;
        }

        private void lbxFilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo file = (FileInfo)lbxFilesList.SelectedItem;
            txtTextInFile.Text = System.IO.File.ReadAllText(file.FullName);
        }

        private void lbxFilesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FileInfo file = (FileInfo)lbxFilesList.SelectedItem;
            System.Diagnostics.Process.Start(file.FullName);
        }
    }
}
