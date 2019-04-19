using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadDataGridViewVisitors();
        }

        private void ButtonAddVisitorClick(object sender, EventArgs e)
        {
            FormAddVisitor formAddVisitor = new FormAddVisitor();
            DialogResult result = formAddVisitor.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Visitor visitor = new Visitor();
            using (var context = new VisitorContext())
            {
                if (formAddVisitor.TextBoxName.Text.Length < 1)
                {
                    MessageBox.Show("Вы не ввели имя посетителя");
                    return;
                }
                if (formAddVisitor.TextBoxPassportNumber.Text.Length < 1)
                {
                    MessageBox.Show("Вы не ввели номер удостака");
                    return;
                }
                bool isVisitorNotExists = context.Visitors.ToList().Where(n => n.PassportNumber == formAddVisitor.TextBoxPassportNumber.Text).FirstOrDefault() == null;
                if (!isVisitorNotExists)
                {
                    MessageBox.Show("Этот чел уже заходил");
                    return;
                }
                if (formAddVisitor.RichTextBoxPurposeOfVisit.Text.Length < 1)
                {
                    MessageBox.Show("Вы не ввели цель визита");
                    return;
                }
                visitor.Name = formAddVisitor.TextBoxName.Text;
                visitor.PassportNumber = formAddVisitor.TextBoxPassportNumber.Text;
                visitor.PurposeOfVisit = formAddVisitor.RichTextBoxPurposeOfVisit.Text;
                visitor.DateTimeIn = DateTime.Now;
                
                context.Visitors.Add(visitor);
                context.SaveChanges();
                LoadDataGridViewVisitors();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            using (var context = new VisitorContext())
            {
                var visitor = context.Visitors.ToList()
                        .Where(v => v.PassportNumber == DataGridViewVisitors.SelectedRows[0].Cells["PassportNumber"].Value.ToString())
                        .FirstOrDefault();

                if (DataGridViewVisitors.SelectedRows.Count > 0 && visitor.DateTimeOut == null)
                {
                    visitor.DateTimeOut = DateTime.Now;
                    context.SaveChanges();

                    LoadDataGridViewVisitors();
                }
            }
        }

        private void DataGridViewVisitorsSelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            if (DataGridViewVisitors.SelectedRows.Count > 0)
            {
                using (var context = new VisitorContext())
                {
                    var visitors = context.Visitors.ToList().Where(v => v.PassportNumber == DataGridViewVisitors.SelectedRows[0].Cells["PassportNumber"].Value.ToString()).FirstOrDefault();

                    if (visitors != null)
                        richTextBox1.Text = visitors.PurposeOfVisit;
                }
            }
        }

        private void LoadDataGridViewVisitors()
        {
            DataGridViewVisitors.Rows.Clear();
            DataGridViewVisitors.Columns.Clear();

            DataGridViewVisitors.Columns.Add("Name", "Имя");
            DataGridViewVisitors.Columns.Add("PassportNumber", "Номер удостака");
            DataGridViewVisitors.Columns.Add("TimeIn", "Когда пришел");
            DataGridViewVisitors.Columns.Add("TimeOut", "Когда ушел");

            using (var context = new VisitorContext())
            {
                var visitors = context.Visitors.ToList();

                for (int i = 0; i < visitors.Count(); i++)
                {
                    List<string> data = new List<string>();

                    data.Add(visitors[i].Name);
                    data.Add(visitors[i].PassportNumber);
                    data.Add(visitors[i].DateTimeIn.ToLongDateString() + " " + visitors[i].DateTimeIn.ToShortTimeString());
                    if (visitors[i].DateTimeOut == null)
                        data.Add("Еще в здании");
                    else data.Add(visitors[i].DateTimeOut.Value.ToLongDateString() + " " + visitors[i].DateTimeOut.Value.ToShortTimeString());

                    DataGridViewVisitors.Rows.Add(data.ToArray());
                }
            }
        }

       
    }
}
