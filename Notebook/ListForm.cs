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
        public int reviewListIndex = -1;
        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            elements_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ProgVarStorage progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            ListsStorage listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            ProgVarStorage progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>
                    (File.ReadAllText("ProgVarStorageInfo.json"));

            progVarStorage.prevWindow = "listForm";

            StreamWriter stream = new StreamWriter("ProgVarStorageInfo.json");
            stream.Write(JsonConvert.SerializeObject(progVarStorage));
            stream.Close();

            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void mainMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
