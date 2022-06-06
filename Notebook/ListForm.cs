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
    public partial class ListForm : Form
    {
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private PeopleList reviewList = new PeopleList();

        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            elements_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            reviewList = listsStorage.peopleLists.Single(item => item.listName == progVarStorage.reviewListName);

            foreach (var el in reviewList.elements)
            {
                elements_dataGridView.Rows.Add
                    (
                    el.name
                    );
            }
        }

        private void addElement_button_Click(object sender, EventArgs e)
        {
            progVarStorage.elementFormVariant = "create";

            this.Close();
            ElementForm elementForm = new ElementForm();
            elementForm.Show();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            progVarStorage.prevWindow = "listForm";

            this.Close();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void mainMenu_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
