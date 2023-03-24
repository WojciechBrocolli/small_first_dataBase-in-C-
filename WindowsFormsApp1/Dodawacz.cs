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
    public partial class Dodawacz : Form
    {
        private Person person ;
        public Person Person
        {
            get => person;
        }
        public Dodawacz(Person myperson)
        {
            InitializeComponent();
            person = myperson;
            date_ur.Value = myperson.BrithDate;
            howTall.Value = myperson.Height;
            Name_Sname.Text = myperson.Name;
        }

        public Dodawacz()
        {
            InitializeComponent();
            person = new Person();
            
            //InitializeComponent();
            
        }

        private void howTall_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_ur_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Name_Sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            person.BrithDate = date_ur.Value;
            person.Height = (int)howTall.Value;
            person.Name = Name_Sname.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
