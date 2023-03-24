using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
          DataClassesDataContext db_dc = new DataClassesDataContext();
        public Form1()
        {
            
            InitializeComponent();
            RefreshList();

            /*
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(6);
            l.Add(5);
            List<int> l2 = Where(X=>%2==0)
              */
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem !=null)
            {
                if(listBox1.SelectedItem is Person)
                {
                    Person p = listBox1.SelectedItem as Person;
                    db_dc.Persons.DeleteOnSubmit(p);
                    db_dc.SubmitChanges();
                    RefreshList();
                }
            }
        }

        private void RefreshList()
        {
            //throw new NotImplementedException();
            listBox1.Items.Clear();
            foreach (Person p in db_dc.Persons.OrderBy(x => x.Name))
            {
                listBox1.Items.Add(p);
               

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dodawacz dodaj = new Dodawacz();
            if(dodaj.ShowDialog()==DialogResult.OK)
            {
                db_dc.Persons.InsertOnSubmit(dodaj.Person);
                db_dc.SubmitChanges();
                RefreshList();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem is Person)
                {
                    Person p = listBox1.SelectedItem as Person;
                    Dodawacz dodaj = new Dodawacz(p);
                    if (dodaj.ShowDialog() == DialogResult.OK)
                    {
                        db_dc.SubmitChanges();
                        RefreshList();
                    }
                    RefreshList();








                    db_dc.SubmitChanges();
                    RefreshList();
                }
            }

        }
    }
}
/*
CREATE TABLE[dbo].[Persons]
(

   [Id] INT NOT NULL PRIMARY KEY IDENTITY,

   [Name] NVARCHAR(50) NOT NULL,

   [BrithDate] DATE NOT NULL,

   [Height] INT NOT NULL
)
*/