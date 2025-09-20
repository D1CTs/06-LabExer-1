namespace StudentList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            studentInfo student = new studentInfo(int.Parse(sID.Text), slName.Text, sfName.Text);

            IDlist.Items.Add(student.stID);
            lnlist.Items.Add(student.stLN);
            fnlist.Items.Add(student.stFN);

            sID.Clear();
            slName.Clear();
            sfName.Clear();
        }
    }
}
