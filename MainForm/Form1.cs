using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        InstructorManager ınstructorManager;
        StudentManager studentManager;
        DataGridView dt;
        ComboBox cmbBox;
        public MainForm()
        {
            InitializeComponent();
        }

        private void filterByToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             ınstructorManager = new InstructorManager(new EfInstructorDal());
             studentManager = new StudentManager(new EfStudentDal());
                
            dt = new DataGridView();
            dt.DataSource = studentManager.GetAll();
            dt.Visible = false;
           
        }

        private void displayAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Visible = true;
            
            // dt.DataSource = studentManager.GetAll();
            dt.Dock = DockStyle.Fill;
            dt.ReadOnly = true;
            grpBox.Controls.Add(dt);
         
            
        }

        private void displayAllİnstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dt.Visible = true;
            
            dt.DataSource = ınstructorManager.GetAll();
            dt.Dock = DockStyle.Fill;
            dt.ReadOnly = true;
            grpBox.Controls.Add(dt);
            
          
        }

        private void registerNewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Visible = false;
            ClearItemsFromGroupBox();
            LabelGenerator();
           

  
        }

        private void  LabelGenerator(int id=-1)
        {
            
            Point Lpoint = new Point();
            Lpoint.X = 20;
            Lpoint.Y = 20;

            Point Tpoint = new Point();
            Tpoint.X = Lpoint.X + 100;
            Tpoint.Y = 20;
            if (id == -1)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    grpBox.Controls.AddRange(new Control[] { new Label { Text = $"{dt.Columns[i].HeaderText} :", Location = Lpoint }, new TextBox { Location = Tpoint } });
                    Lpoint.X = 20;
                    Lpoint.Y += 40;

                    Tpoint.X = Lpoint.X + 100;
                    Tpoint.Y += 40;

                }
            }
            else
            {
                List<string> liste; 
                Student selectedStudent = studentManager.Get(2);
                liste = new List<string>(){selectedStudent.ID.ToString(), selectedStudent.FirstName, selectedStudent.LastName,
                    selectedStudent.Tel, selectedStudent.NationaltyId, selectedStudent.GNO.ToString() };
                for (int i = 0; i < dt.Columns.Count-1; i++)
                {
                    Lpoint.X = 100;
                    Lpoint.Y += 40;

                    Tpoint.X = Lpoint.X + 100;
                    Tpoint.Y += 40;
                    grpBox.Controls.AddRange(new Control[] { new Label { Text = $"{dt.Columns[i].HeaderText} :", Location = Lpoint }, new TextBox {Text=liste[i], Location = Tpoint } });


                }
                
            }
            
        }

        private void ClearItemsFromGroupBox()
        {
            foreach (Control item in grpBox.Controls)
            {
                item.Visible = false;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearItemsFromGroupBox();

            cmbBox = new ComboBox();
            
            cmbBox.DataSource = studentManager.GetAll();
            
            cmbBox.DisplayMember = "FirstName";
            cmbBox.ValueMember = "ID";
            
            grpBox.Controls.Add(cmbBox);
            LabelGenerator(cmbBox.SelectedIndex);

        }
        
    }
}
