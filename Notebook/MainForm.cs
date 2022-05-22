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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Storage storage = JsonConvert.DeserializeObject<Storage>(File.ReadAllText("Info.json"));
            for (int i = 0; i < storage.peopleLists.Count; i++)
            {
                lists_dataGridView.Rows.Add
                    (
                    storage.peopleLists[i].listName,
                    storage.peopleLists[i].creatingDate,
                    storage.peopleLists[i].updatingDate
                    );
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
            this.Hide();
        }

        private void addList_button_Click(object sender, EventArgs e)
        {
            ListNameForm listNameForm = new ListNameForm();
            listNameForm.Show();
            this.Hide();
        }
    }
}
