namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmReg frmReg= new FrmReg();
            frmReg.MdiParent= this;
            frmReg.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch= new FrmSearch();   
            frmSearch.MdiParent= this;  
            frmSearch.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmAboutUs frmAboutUs = new FrmAboutUs();
            frmAboutUs.MdiParent= this;
            frmAboutUs.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }
    }
}