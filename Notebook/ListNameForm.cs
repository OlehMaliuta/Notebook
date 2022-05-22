using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Notebook
{
    public partial class ListNameForm : Form
    {
        public ListNameForm()
        {
            InitializeComponent();
        }

        private void giveListName_button_Click(object sender, EventArgs e)
        {
            if (listName_textBox.Text != "")
            {
                Storage storage = JsonConvert.DeserializeObject<Storage>(File.ReadAllText("Info.json"));
                storage.peopleLists.Add(new PeopleList(listName: listName_textBox.Text));

                StreamWriter stream = new StreamWriter("Info.json");
                stream.Write(JsonConvert.SerializeObject(storage));
                stream.Close();

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ви не можете створити список без назви.", "Попередження!");
            }
        }

        private void goBack_button_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
