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

        private void UpdateDataGridView(DataGridView dgv, ListsStorage ls)
        {
            while (dgv.Rows.Count > 0)
            {
                dgv.Rows.Remove(dgv.Rows[dgv.Rows.Count - 1]);
            }

            for (int i = 0; i < ls.peopleLists.Count; i++)
            {
                dgv.Rows.Add
                    (
                    ls.peopleLists[i].listName,
                    ls.peopleLists[i].creatingDate,
                    ls.peopleLists[i].updatingDate
                    );
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lists_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ListsStorage storage = JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));
            for (int i = 0; i < storage.peopleLists.Count; i++)
            {
                lists_dataGridView.Rows.Add
                    (
                    storage.peopleLists[i].listName,
                    storage.peopleLists[i].creatingDate,
                    storage.peopleLists[i].updatingDate
                    );
            }

            sortingLists_comboBox.Text = "назвою";
        }

        private void nameForList_button_Click(object sender, EventArgs e)
        {
            ProgVarStorage progVarStorage = JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));
            progVarStorage.listNameFormVariant = "create";

            StreamWriter stream = new StreamWriter("ProgVarStorageInfo.json");
            stream.Write(JsonConvert.SerializeObject(progVarStorage));
            stream.Close();

            this.Hide();
            ListNameForm listNameForm = new ListNameForm();
            listNameForm.Show();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            ProgVarStorage progVarStorage = 
                JsonConvert.DeserializeObject<ProgVarStorage>
                    (File.ReadAllText("ProgVarStorageInfo.json"));

            progVarStorage.prevWindow = "mainForm";

            StreamWriter stream = new StreamWriter("ProgVarStorageInfo.json");
            stream.Write(JsonConvert.SerializeObject(progVarStorage));
            stream.Close();

            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lists_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (lists_dataGridView.Columns[e.ColumnIndex].Name)
            {
                case "open":
                    {


                        ListForm listForm = new ListForm();
                        listForm.Show();
                        this.Hide();
                    }
                    break;
                case "rename":
                    {
                        ProgVarStorage progVarStorage =
                            JsonConvert.DeserializeObject<ProgVarStorage>
                            (File.ReadAllText("ProgVarStorageInfo.json"));

                        progVarStorage.listNameFormVariant = "rename";
                        progVarStorage.name =
                            lists_dataGridView[0, e.RowIndex].Value.ToString();

                        StreamWriter stream = new StreamWriter("ProgVarStorageInfo.json");
                        stream.Write(JsonConvert.SerializeObject(progVarStorage));
                        stream.Close();

                        this.Hide();
                        ListNameForm listNameForm = new ListNameForm();
                        listNameForm.Show();
                    }
                    break;
                case "delete":
                    {
                        DialogResult result = MessageBox.Show
                        (
                        "Ви впевнені, що хочите видалити список",
                        "Попередження!",
                        MessageBoxButtons.YesNo
                        );

                        if (result == DialogResult.Yes)
                        {
                            ListsStorage storage = JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));
                            storage.peopleLists.RemoveAt(e.RowIndex);

                            StreamWriter stream = new StreamWriter("ListsStorageInfo.json");
                            stream.Write(JsonConvert.SerializeObject(storage));
                            stream.Close();

                            UpdateDataGridView(lists_dataGridView, storage);
                        }
                    }
                    break;
            }
        }
    }
}
