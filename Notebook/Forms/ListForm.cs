using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using Word = Microsoft.Office.Interop.Word.Application;
using Notebook.Classes;

namespace Notebook
{
    public partial class ListForm : Form
    {
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private PeopleList reviewList = new PeopleList();
        private string nextWindow = "";
        private bool isClosing = false;

        public ListForm()
        {
            InitializeComponent();
        }

        private void ListFormLoad(object sender, EventArgs e)
        {
            // form settings

            elementDataGridView.DefaultCellStyle.WrapMode = 
                DataGridViewTriState.True;

            this.listsStorage = 
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

            reviewList = listsStorage.PeopleLists.Single(
                item => item.ListName == progVarStorage.ReviewListName);

            var pl =
                reviewList.Elements.OrderBy(item => item.Name);

            foreach (Element el in pl)
            {
                elementDataGridView.Rows.Add
                    (
                    el.Name,
                    el.Birthday,
                    el.CreatingDate,
                    el.UpdatingDate
                    );
            }

            // localization

            this.Text = $"{Locale.Get("general.app-name")} - \"{reviewList.ListName}\"";

            addElementButton.Text = Locale.Get("list-form.add-element-option");
            createTxtFileButton.Text = Locale.Get("list-form.save-txt-option");
            createDocxFileButton.Text = Locale.Get("list-form.save-docx-option");

            elementDataGridView.Columns[0].HeaderText = Locale.Get("list-form.column-header-1");
            elementDataGridView.Columns[1].HeaderText = Locale.Get("list-form.column-header-2");
            elementDataGridView.Columns[2].HeaderText = Locale.Get("list-form.column-header-3");
            elementDataGridView.Columns[3].HeaderText = Locale.Get("list-form.column-header-4");
            elementDataGridView.Columns[4].HeaderText = Locale.Get("list-form.column-header-5");
            elementDataGridView.Columns[5].HeaderText = Locale.Get("list-form.column-header-6");

            sortLabel.Text = Locale.Get("list-form.sorting-option-title");

            sortingElementsComboBox.Items.Add(Locale.Get("list-form.sort-variant-1"));
            sortingElementsComboBox.Items.Add(Locale.Get("list-form.sort-variant-2"));
            sortingElementsComboBox.Items.Add(Locale.Get("list-form.sort-variant-3"));
            sortingElementsComboBox.Items.Add(Locale.Get("list-form.sort-variant-4"));

            settingsButton.Text = Locale.Get("list-form.settings-option");
            mainMenuButton.Text = Locale.Get("list-form.main-menu-option");
            exitButton.Text = Locale.Get("list-form.exit-option");

            fileMenuSection.Text = Locale.Get("list-form.top-menu-option-file");
            addElementTool.Text = Locale.Get("list-form.add-element-option");
            createTxtTool.Text = Locale.Get("list-form.save-txt-option");
            createDocxTool.Text = Locale.Get("list-form.save-docx-option");
            settingsTool.Text = Locale.Get("list-form.settings-option");
            exitTool.Text = Locale.Get("list-form.exit-option");

            sortingElementsComboBox.SelectedIndex = 0;
        }

        private void AddElementToolClick(object sender, EventArgs e)
        {
            AddElementButtonClick(sender, e);
        }

        private void CreateTxtToolClick(object sender, EventArgs e)
        {
            CreateTxtFileButtonClick(sender, e);
        }

        private void CreateDocxToolClick(object sender, EventArgs e)
        {
            CreateDocxFileButtonClick(sender, e);
        }

        private void SettingsToolClick(object sender, EventArgs e)
        {
            SettingsButtonClick(sender, e);
        }

        private void ExitToolClick(object sender, EventArgs e)
        {
            ExitButtonClick(sender, e);
        }

        private void AddElementButtonClick(object sender, EventArgs e)
        {
            progVarStorage.ElementFormVariant = "create";
            nextWindow = "ElementForm";
            this.Close();
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            progVarStorage.PrevWindow = "listForm";
            nextWindow = "LanguageForm";
            this.Close();
        }

        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            isClosing = true;
            this.Close();
        }

        private void ElementDataGridViewCellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (elementDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "open":
                        {
                            progVarStorage.ElementFormVariant = "change";
                            progVarStorage.ReviewElementName =
                                elementDataGridView[0, e.RowIndex]
                                    .Value.ToString();

                            nextWindow = "ElementForm";
                            this.Close();
                        }
                        break;

                    case "delete":
                        {
                            DialogResult result = MessageBox.Show(
                                Locale.Get("list-form.remove-element-message"),
                                Locale.Get("general.warning-message-title"),
                                MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                reviewList.Elements.RemoveAt(
                                    reviewList.Elements.FindIndex(
                                        item => 
                                            item.Name == 
                                            elementDataGridView[0, e.RowIndex]
                                            .Value.ToString()));

                                while (elementDataGridView.Rows.Count > 0)
                                {
                                    elementDataGridView.Rows.Remove(
                                        elementDataGridView.Rows[
                                            elementDataGridView.
                                               Rows.Count - 1]);
                                }

                                foreach (Element el in reviewList.Elements)
                                {
                                    elementDataGridView.Rows.Add
                                        (
                                        el.Name,
                                        el.Birthday,
                                        el.CreatingDate,
                                        el.UpdatingDate
                                        );
                                }

                                switch (sortingElementsComboBox.SelectedIndex)
                                {
                                    case 0:
                                        elementDataGridView.Sort(
                                            elementDataGridView.Columns[0],
                                            ListSortDirection.Ascending);
                                        break;

                                    case 1:
                                        elementDataGridView.Sort(
                                            elementDataGridView.Columns[1],
                                            ListSortDirection.Ascending);
                                        break;

                                    case 2:
                                        elementDataGridView.Sort(
                                            elementDataGridView.Columns[2],
                                            ListSortDirection.Ascending);
                                        break;

                                    case 3:
                                        elementDataGridView.Sort(
                                            elementDataGridView.Columns[3],
                                            ListSortDirection.Ascending);
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void CreateTxtFileButtonClick(object sender, EventArgs e)
        {
            p_a:

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.InitialDirectory = @"C:\Users\User\Downloads";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName.Contains('.'))
                {
                    MessageBox.Show(
                        Locale.Get("list-form.illegal-chars-message"), 
                        Locale.Get("general.warning-message-title"));
                    goto p_a;
                }

                List<Element> people = new List<Element>();

                for (int i = 0; i < elementDataGridView.Rows.Count; i++)
                {
                    people.Add(reviewList.Elements.Single(
                        p => p.Name == elementDataGridView[0, i].
                            Value.ToString()));
                }

                string listData = "";
                int count1 = 1;
                int count2 = 0;
                listData = "\"" + reviewList.ListName + "\"\n\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    listData += $"\n{count1}. {people[count1 - 1].Name}\n";
                    List<string> fields = new List<string>
                    {
                        Locale.Get("list-form.fields-for-documents-1") +
                        people[count1 - 1].Birthday,
                        Locale.Get("list-form.fields-for-documents-2") +
                        people[count1 - 1].Phone,
                        Locale.Get("list-form.fields-for-documents-3") +
                        people[count1 - 1].PersonalData,
                        Locale.Get("list-form.fields-for-documents-4") +
                        people[count1 - 1].ResidentialAddress,
                        Locale.Get("list-form.fields-for-documents-5") +
                        people[count1 - 1].Locale,
                        Locale.Get("list-form.fields-for-documents-6") +
                        people[count1 - 1].FamilarPeoplePosition,
                        Locale.Get("list-form.fields-for-documents-7") +
                        people[count1 - 1].FirstMeeting,
                        Locale.Get("list-form.fields-for-documents-8") +
                        people[count1 - 1].Skills,
                        Locale.Get("list-form.fields-for-documents-9") +
                        people[count1 - 1].ExtraInfo
                    };

                    while (count2 < fields.Count)
                    {
                        listData += "\n" + fields[count2] + "\n";
                        count2++;
                    }
                    listData += "\n";
                    count1++;
                }

                File.WriteAllText(fileDialog.FileName + ".txt", listData);

                MessageBox.Show(
                    Locale.Get("list-form.document-created-message"), 
                    Locale.Get("general.normal-message-title"));
            }
        }

        private void CreateDocxFileButtonClick(object sender, EventArgs e)
        {
            p_b:

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.InitialDirectory = @"C:\Users\User\Downloads";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName.Contains('.'))
                {
                    MessageBox.Show(
                        Locale.Get("list-form.illegal-chars-message"),
                        Locale.Get("general.warning-message-title"));
                    goto p_b;
                }

                Word app = new Word();
                Document docx = app.Documents.Add(Visible: false);
                Range r = docx.Range();

                List<Element> people = new List<Element>();

                for (int i = 0; i < elementDataGridView.Rows.Count; i++)
                {
                    people.Add(reviewList.Elements.Single(
                        p => p.Name == elementDataGridView[0, i]
                            .Value.ToString()));
                }

                int count1 = 1;
                int count2 = 0;
                r.Text = "\"" + reviewList.ListName + "\"\n\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    r.Text += $"\n{count1}. {people[count1 - 1].Name}\n";
                    List<string> fields = new List<string>
                    {
                        Locale.Get("list-form.fields-for-documents-1") +
                        people[count1 - 1].Birthday,
                        Locale.Get("list-form.fields-for-documents-2") +
                        people[count1 - 1].Phone,
                        Locale.Get("list-form.fields-for-documents-3") +
                        people[count1 - 1].PersonalData,
                        Locale.Get("list-form.fields-for-documents-4") +
                        people[count1 - 1].ResidentialAddress,
                        Locale.Get("list-form.fields-for-documents-5") +
                        people[count1 - 1].Locale,
                        Locale.Get("list-form.fields-for-documents-6") +
                        people[count1 - 1].FamilarPeoplePosition,
                        Locale.Get("list-form.fields-for-documents-7") +
                        people[count1 - 1].FirstMeeting,
                        Locale.Get("list-form.fields-for-documents-8") +
                        people[count1 - 1].Skills,
                        Locale.Get("list-form.fields-for-documents-9") +
                        people[count1 - 1].ExtraInfo
                    };

                    while (count2 < fields.Count)
                    {
                        r.Text += "\n" + fields[count2] + "\n";
                        count2++;
                    }
                    r.Text += "\n";
                    count1++;
                }

                docx.SaveAs(fileDialog.FileName + ".docx");
                docx.Close();
                app.Quit();

                MessageBox.Show(
                    Locale.Get("list-form.document-created-message"),
                    Locale.Get("general.normal-message-title"));
            }
        }

        private void SortingElementsComboBoxSelectedIndexChanged(
            object sender, EventArgs e)
        {
            switch (sortingElementsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        elementDataGridView.Sort(
                            elementDataGridView.Columns[0],
                            ListSortDirection.Ascending);
                    }
                    break;

                case 1:
                    {
                        elementDataGridView.Sort(
                            elementDataGridView.Columns[1],
                            ListSortDirection.Ascending);
                    }
                    break;

                case 2:
                    {
                        elementDataGridView.Sort(
                            elementDataGridView.Columns[2],
                            ListSortDirection.Ascending);
                    }
                    break;

                case 3:
                    {
                        elementDataGridView.Sort(
                            elementDataGridView.Columns[3],
                            ListSortDirection.Ascending);
                    }
                    break;
            }
        }

        private void SearchElementTextBoxTextChanged(
            object sender, EventArgs e)
        {
            List<Element> pl = new List<Element>();

            IOrderedEnumerable<Element> persons = default;

            switch (sortingElementsComboBox.SelectedIndex)
            {
                case 0:
                    persons = reviewList.Elements.OrderBy(p => p.Name);
                    break;

                case 1:
                    persons = reviewList.Elements.OrderBy(p => p.Birthday);
                    break;

                case 2:
                    persons = reviewList.Elements.OrderBy(
                        p => p.CreatingDate);
                    break;

                case 3:
                    persons = reviewList.Elements.OrderBy(
                        p => p.UpdatingDate);
                    break;
            }

            foreach (Element el in persons)
            {
                pl.Add(el);
            }

            while (elementDataGridView.Rows.Count > 0)
            {
                elementDataGridView.Rows.Remove(
                    elementDataGridView.Rows[
                        elementDataGridView.Rows.Count - 1]);
            }

            List<Element> spl = new List<Element>();

            spl = pl.FindAll(
                        item => item.Name.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));

            foreach (Element el in spl)
            {
                elementDataGridView.Rows.Add
                    (
                    el.Name,
                    el.Birthday,
                    el.CreatingDate,
                    el.UpdatingDate
                    );
            }
        }

        private void ListFormFormClosing(
            object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));

            if (isClosing)
                Environment.Exit(0);

            switch (nextWindow)
            {
                case "ElementForm":
                    ElementForm elementForm = new ElementForm();
                    elementForm.Show();
                    break;

                case "LanguageForm":
                    LanguageForm languageForm = new LanguageForm();
                    languageForm.Show();
                    break;

                case "":
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    break;

                default:
                    MainForm defForm = new MainForm();
                    defForm.Show();
                    MessageBox.Show("ERROR");
                    break;
            }
        }
    }
}
