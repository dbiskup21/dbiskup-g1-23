using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;

namespace Evaluation_Manager
{
    public partial class FrmFinalReport : Form
    {
        public FrmFinalReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        

        private void FrmFinalReport_Load_1(object sender, EventArgs e)
        {
            dgvResults.DataSource = GenerateStudentReport();
        }
        private List<StudentReportView> GenerateStudentReport()
        {
            var allStudents = StudentRepository.GetStudents();
            var examReports = new List<StudentReportView>();

            foreach (var student in allStudents)
            {
                var examReport = new StudentReportView(student);
                examReports.Add(examReport);
                
            }

            return examReports;
        }
    }
}
