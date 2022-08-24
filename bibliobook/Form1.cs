namespace bibliobook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbReader.SelectedIndex = 0;
            lstBooks.SelectedIndex = 0;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnVisibleInfo_Click(object sender, EventArgs e)
        {
            grbInform.Visible = false;
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
            btnVisibleInfo.Enabled = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstInform.Items.Clear();
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstInform.Items.Remove(lstInform.Text);
            lstInform.SelectedIndex = lstInform.Items.Count - 1;
            if (lstInform.Items.Count == 0)
            {
                btnRemove.Enabled = false;
                btnClear.Enabled = false;
            }
        }
        private void btnInform_Click(object sender, EventArgs e)
        {
            grbInform.Visible = true;
            btnRemove.Enabled = true;
            btnClear.Enabled = true;
            btnVisibleInfo.Enabled = true;
            lstInform.Items.Clear();
            lstInform.Items.Add(cmbReader.Text);
            if (rdbStatus1.Checked)
                lstInform.Items.Add(rdbStatus1.Text);
            else if (rdbStatus2.Checked)
                lstInform.Items.Add(rdbStatus2.Text);
            else
                lstInform.Items.Add(rdbStatus3.Text);
            if (chkBook.Checked)
                lstInform.Items.Add("����� �� �����");
            lstInform.Items.Add(lstBooks.Text);
            lstInform.Items.Add("���������� ���� " + txtKol.Text);
            lstInform.SelectedIndex = lstInform.Items.Count - 1;
        }
    }
}   
