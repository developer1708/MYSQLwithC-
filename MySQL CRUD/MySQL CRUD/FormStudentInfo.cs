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
    public partial class FormStudentInfo : Form
    {
        FormStudent form;

        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {
                
        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT ID,Name,University,Adres,Telefon FROM student_table", dataGridView1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();

            form.ShowDialog();
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marks form = new Marks();
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT ID,Name,University,Adres,Telefon FROM student_table WHERE Name LIKE'%"+txtSearch.Text +"%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
               form.Clear();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); 
                form.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.university = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.adres = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.telefon = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                //Edit
                return;
            }
            if (e.ColumnIndex == 1)
            {

                //delete
                if (MessageBox.Show("Шумо дар хакикат донишчуро хорич кардани хастед ?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStudent.DeleteStudent(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display(); 
                }
                return;
            }
        }
    }
}
