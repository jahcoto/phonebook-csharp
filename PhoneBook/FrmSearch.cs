using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //-----Verify if the Id it was entered
            if (this.TxtSearchId.Text == "")
            {
                MessageBox.Show("You must enter the ID!!!");
                return;
            }

            string path = "C:\\Users\\jonathan.hernandez\\Documents\\code\\bas\\phonebook-csharp\\PhoneBook\\Data\\";
            string[] directoryList = Directory.GetDirectories(path);
            bool result = false;
            foreach (string directory in directoryList)
            {
                result = directory.Contains("\\" + TxtSearchId.Text + "-");
                if (result == true)
                {
                    string[] files = Directory.GetFiles(directory);
                    string readFile = "";
                    this.TxtId.Text = this.TxtSearchId.Text; 
                    foreach (string file in files)
                    {
                        
                        int index1 = file.IndexOf('_');
                        int index2 = file.IndexOf('_', index1 + 1);
                        string fileName = file.Substring(index2 + 1);                     
                        switch (fileName)
                        {
                            case "FirstName.txt":
                                
                                readFile = System.IO.File.ReadAllText(directory + "\\" + this.TxtSearchId.Text + "_" + fileName, Encoding.UTF8);
                                this.txtFirstName.Text = readFile;
                                break;

                            case "LastName.txt":

                                readFile = System.IO.File.ReadAllText(directory + "\\" + this.TxtSearchId.Text + "_" + fileName, Encoding.UTF8);
                                this.txtLastName.Text = readFile;
                                break;

                            case "Telephone.txt":

                                readFile = System.IO.File.ReadAllText(directory + "\\" + this.TxtSearchId.Text + "_" + fileName, Encoding.UTF8);
                                this.txtTelephone.Text = readFile;
                                break;

                            case "Email.txt":

                                readFile = System.IO.File.ReadAllText(directory + "\\" + this.TxtSearchId.Text + "_" + fileName, Encoding.UTF8);
                                this.txtEmail.Text = readFile;
                                break;

                            case "CellNumber.txt":

                                readFile = System.IO.File.ReadAllText(directory + "\\" + this.TxtSearchId.Text + "_" + fileName, Encoding.UTF8);
                                this.txtCellNumber.Text = readFile;
                                break;

                            case "Address.txt":

                                readFile = System.IO.File.ReadAllText(directory + "\\" + this.TxtSearchId.Text + "_" + fileName, Encoding.UTF8);
                                this.txtAddress.Text = readFile;
                                break;

                            case "Comments.txt":

                                readFile = System.IO.File.ReadAllText(directory + "\\" + this.TxtSearchId.Text + "_" + fileName, Encoding.UTF8);
                                this.txtComment.Text = readFile;
                                break;
                        }
                    }
                    
                    MessageBox.Show("ID founded");
                    return;
                }

            }
            if (result == false)
            {
                MessageBox.Show("ID not found");
            }
        }
    }
}
