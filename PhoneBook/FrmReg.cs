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
    public partial class FrmReg : Form
    {

        public string Path = "C:\\Users\\jonathan.hernandez\\Documents\\code\\bas\\phonebook-csharp\\PhoneBook\\Data\\";

        public FrmReg()
        {
            InitializeComponent();
        }

        private void FrmReg_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelephone_Click(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblCellNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtCellNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            this.BtnNew.Enabled = false;
            this.BtnSave.Enabled = true;                   
            
            //-----------------------------
            this.TxtId.Enabled = true;
            this.txtFirstName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.txtTelephone.Enabled = true;
            this.txtCellNumber.Enabled = true;
            this.txtEmail.Enabled = true;  
            this.txtAddress.Enabled = true;
            this.txtComment.Enabled = true;

            //-----------------------------

            string[] dir = Directory.GetDirectories(Path);

            int index = dir.Length + 1;            

            this.TxtId.Text = index.ToString();
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtTelephone.Text = "";
            this.txtCellNumber.Text = "";
            this.txtEmail.Text = "";
            this.txtAddress.Text = "";
            this.txtComment.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.BtnSave.Enabled = false;
            this.BtnNew.Enabled=true;
            //----------------------
            this.TxtId.Enabled = false;
            this.txtFirstName.Enabled = false;
            this.txtLastName.Enabled = false;
            this.txtTelephone.Enabled = false;
            this.txtCellNumber.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtComment.Enabled = false;
            //----------------------
            
            string filePath = Path + this.TxtId.Text + "-" + this.txtFirstName.Text + "_" + this.txtLastName.Text;
            string fileName = "";

            //-----Verify if the Id it was entered
            if (this.TxtId.Text == "")
            {
                MessageBox.Show("You must enter the ID!!!");
                return;
            }


            //-----Create a folder with id + FirstName + LastName
            if (Directory.Exists(filePath))
            {
                MessageBox.Show("The Contact already exists!!!");
                return;
            }

            Directory.CreateDirectory(filePath);
            //-----FirstName
            fileName = filePath + "\\" + this.TxtId.Text + "_FirstName.txt";
            System.IO.File.WriteAllText(fileName, txtFirstName.Text, Encoding.UTF8);
            //-----lastName
            fileName = filePath + "\\" + this.TxtId.Text + "_LastName.txt";
            System.IO.File.WriteAllText(fileName, txtLastName.Text, Encoding.UTF8);
            //-----Telephone
            fileName = filePath + "\\" + this.TxtId.Text + "_Telephone.txt";
            System.IO.File.WriteAllText(fileName, txtTelephone.Text, Encoding.UTF8);
            //-----Cellphone
            fileName = filePath + "\\" + this.TxtId.Text + "_CellNumber.txt";
            System.IO.File.WriteAllText(fileName, txtCellNumber.Text, Encoding.UTF8);
            //-----Email
            fileName = filePath + "\\" + this.TxtId.Text + "_Email.txt";
            System.IO.File.WriteAllText(fileName, txtEmail.Text, Encoding.UTF8);
            //-----Address
            fileName = filePath + "\\" + this.TxtId.Text + "_Address.txt";
            System.IO.File.WriteAllText(fileName, txtAddress.Text, Encoding.UTF8);
            //-----Comments
            fileName = filePath + "\\" + this.TxtId.Text + "_Comments.txt";
            System.IO.File.WriteAllText(fileName, txtComment.Text, Encoding.UTF8);

            MessageBox.Show("Data saved!!!");
            this.Close();
        }
    }
}
