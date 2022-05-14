using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_CRUD
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public string id, name, university, adres, telefon;


        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            lbltext.Text = "Update Student" ;
            btnSave.Text = "Update" ;
            txtName.Text = name;
            txtUniversity.Text = university;
            txtAdres.Text = adres;
            txtTelefon.Text = telefon;  
        }



        public void Clear()
        {
            txtName.Text = txtUniversity.Text = txtAdres.Text = txtTelefon.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student name is Empty ( > 3).");
                return;
            }
            if (txtUniversity.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student university is Empty ( > 1).");
                return;
            }
            if (txtAdres.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student adres is Empty ( > 1).");
                return;
            }
            if (txtTelefon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student telefon is Empty ( > 1).");
                return;
            }
            if (btnSave.Text == "Save")
            {
                Student std = new Student(txtName.Text.Trim(), txtUniversity.Text.Trim(), txtAdres.Text.Trim(), txtTelefon.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }
            if(btnSave.Text == "Update")
            {
                 Student std = new Student(txtName.Text.Trim(), txtUniversity.Text.Trim(), txtAdres.Text.Trim(), txtTelefon.Text.Trim());
                DbStudent.UpdateStudent(std,id);
            }

            _parent.Display(); 
        }
    }
}
