namespace Lab4
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        double maxGrade = 0;
        double minGrade = int.MaxValue;
        double AvgGPA = 0;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom();
        }


        private void button1_Click(object sender, EventArgs e, double g)
        {
            

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            int year = int.Parse(this.textBoxBYear.Text);
            double grade = double.Parse(this.textBoxGPA.Text);

            Person students = new Person(name, year, grade);
            this.classroom.addStudent(students);

            textBox1.Text = this.classroom.ShowStudent();
            textBoxTotal.Text = this.classroom.ShowAllAge().ToString();
            this.classroom.SetGrade();
            this.textBoxGPAmax.Text = this.classroom.ShowMaxGrade().ToString();
            this.textBoxGPAmin.Text = this.classroom.ShowMinGrade().ToString();
            this.textBoxNameGPAmax.Text = this.classroom.ShowMaxGradeName();
            this.textBoxNameGPAmin.Text = this.classroom.ShowMinGradeName();
            AvgGPA = this.classroom.ShowAvgGPA();
            this.textBoxGPAavg.Text = AvgGPA.ToString();
            //this.textBoxGPAavg.Text = this.classroom.AvggradeinClass().ToString("#.##");
            //display total age of class
            //this.textBoxTotal.Text = this.classroom.showsumageClass().ToString(); 
        }
    }
}