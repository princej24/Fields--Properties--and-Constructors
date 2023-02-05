using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fields__Properties__and_Constructors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            Movie shrek2 = new Movie();
            shrek2.movieName = "shrek2";
            shrek2.year = 2004;
            shrek2.Director = "Andrew Adamson";
            shrek2.Rating = 7.3/10;

            Movie Reservoir_Dogs= new Movie();
            Reservoir_Dogs.movieName = "Reservoir_Dogs";
            Reservoir_Dogs.year = 1992;
            Reservoir_Dogs.Director = "Quentin Tarantino";
            Reservoir_Dogs.Rating = 8.3/10;


            Movie Get_Out = new Movie();
            Get_Out.movieName = "Get_Out";
            Get_Out.year = 2017;
            Get_Out.Director = "jordan peele";
            Get_Out.Rating =7.7/10; 

            MessageBox.Show(shrek2.movieName + " " + shrek2.Rating + " "+ shrek2.year.ToString());
            // MessageBox.Show(shrek2.year.ToString());
            MessageBox.Show(Reservoir_Dogs.movieName + " " + Reservoir_Dogs.Rating + " " + Reservoir_Dogs.year.ToString());
            MessageBox.Show(Get_Out.movieName + " " + Get_Out.Rating + " " + Get_Out.year.ToString());
            
           
            Student student = new Student("prince","muturi",100,100);
            Student student2 = new Student("jeff", "mwangi", 100, 100);

            //student.FirstName = "Prince";
            //student.LastName = "Muturi";
            //student.CSIGrade = 100;
            //student.GenEd = 100;
            students.Add(student);
            students.Add(student2);

            // MessageBox.Show(student2());

            Instroctor breshna = new Instroctor("breshna", "naim", "1234567");
            MessageBox.Show(breshna.LastName);
             
        }
       public string formattedStudent(Student student)
        {
           string StudentInformation= student.FirstName + "" + student.LastName + "" + student.CSIGrade + "" + student.GenEdGrade;

           return StudentInformation;
        }
    }
}
