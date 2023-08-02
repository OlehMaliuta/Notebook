using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using Notebook.Classes;
using Word = Microsoft.Office.Interop.Word.Application;

namespace Notebook
{
    public partial class ListForm : Form
    {
        public enum NextAction
        {
            AppIsClosing,
            GoToMainForm,
            Other
        }

        private readonly ListsStorage listsStorage;
        private readonly PeopleList reviewList;
        private NextAction action;
        private int sortMode;
        private bool sortByAsc;

        public ListForm(string reviewListName)
        {
            InitializeComponent();

            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.reviewList = listsStorage.PeopleLists.Single(
                item => item.ListName == reviewListName);

            this.action = NextAction.GoToMainForm;

            this.sortMode = 0;

            this.sortByAsc = true;
        }

        private void ListFormLoad(object sender, EventArgs e)
        {
            // form settings

            elementDataGridView.DefaultCellStyle.WrapMode = 
                DataGridViewTriState.True;

            var pl =
                this.reviewList.Elements.OrderBy(item => item.Name);

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

            this.Text = $"{LanguageManager.Get("general.app-name")} - \"{this.reviewList.ListName}\"";

            addElementButton.Text = LanguageManager.Get("list-form.add-element-option");
            createTxtFileButton.Text = LanguageManager.Get("list-form.save-txt-option");
            createDocxFileButton.Text = LanguageManager.Get("list-form.save-docx-option");

            elementDataGridView.Columns[0].HeaderText = LanguageManager.Get("list-form.column-header-1");
            elementDataGridView.Columns[1].HeaderText = LanguageManager.Get("list-form.column-header-2");
            elementDataGridView.Columns[2].HeaderText = LanguageManager.Get("list-form.column-header-3");
            elementDataGridView.Columns[3].HeaderText = LanguageManager.Get("list-form.column-header-4");
            elementDataGridView.Columns[4].HeaderText = LanguageManager.Get("list-form.column-header-5");
            elementDataGridView.Columns[5].HeaderText = LanguageManager.Get("list-form.column-header-6");

            searchLabel.Text = LanguageManager.Get("list-form.searching-option-title");

            settingsButton.Text = LanguageManager.Get("list-form.settings-option");
            mainMenuButton.Text = LanguageManager.Get("list-form.main-menu-option");
            exitButton.Text = LanguageManager.Get("list-form.exit-option");

            fileMenuSection.Text = LanguageManager.Get("list-form.top-menu-option-file");
            addElementTool.Text = LanguageManager.Get("list-form.add-element-option");
            createTxtTool.Text = LanguageManager.Get("list-form.save-txt-option");
            createDocxTool.Text = LanguageManager.Get("list-form.save-docx-option");
            settingsTool.Text = LanguageManager.Get("list-form.settings-option");
            exitTool.Text = LanguageManager.Get("list-form.exit-option");
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
            this.action = NextAction.Other;
            this.Close();
            ElementForm elementForm = new ElementForm(this.reviewList.ListName, null);
            elementForm.Show();
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            this.action = NextAction.Other;
            this.Close();
            SettingsForm settingsForm = new SettingsForm(this.reviewList.ListName, SettingsForm.PrevForm.ListForm);
            settingsForm.Show();
        }

        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                LanguageManager.Get("general.exit-message"),
                                LanguageManager.Get("general.warning-message-title"),
                                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.action = NextAction.AppIsClosing;
                this.Close();
            }
        }

        private void ElementDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (elementDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "open":
                        {
                            string elementName =
                                elementDataGridView[0, e.RowIndex]
                                    .Value.ToString();

                            this.action = NextAction.Other;
                            this.Close();

                            ElementForm elementForm = new ElementForm(
                                    this.reviewList.ListName,
                                    elementName);

                            elementForm.Show();
                        }
                        break;
                    case "delete":
                        {
                            DialogResult result = MessageBox.Show(
                                LanguageManager.Get("list-form.remove-element-message"),
                                LanguageManager.Get("general.warning-message-title"),
                                MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                this.reviewList.Elements.RemoveAt(
                                    this.reviewList.Elements.FindIndex(
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

                                foreach (Element el in this.reviewList.Elements)
                                {
                                    elementDataGridView.Rows.Add
                                        (
                                        el.Name,
                                        el.Birthday,
                                        el.CreatingDate,
                                        el.UpdatingDate
                                        );
                                }

                                switch (sortMode)
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
                        LanguageManager.Get("list-form.illegal-chars-message"), 
                        LanguageManager.Get("general.warning-message-title"));
                    goto p_a;
                }

                List<Element> people = new List<Element>();

                for (int i = 0; i < elementDataGridView.Rows.Count; i++)
                {
                    people.Add(this.reviewList.Elements.Single(
                        p => p.Name == elementDataGridView[0, i].
                            Value.ToString()));
                }

                string listData = "";
                int count1 = 1;
                int count2 = 0;
                listData = "\"" + this.reviewList.ListName + "\"\n\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    listData += $"\n{count1}. {people[count1 - 1].Name}\n";
                    List<string> fields = new List<string>
                    {
                        LanguageManager.Get("list-form.fields-for-documents-1") +
                        people[count1 - 1].Birthday,
                        LanguageManager.Get("list-form.fields-for-documents-2") +
                        people[count1 - 1].Phone,
                        LanguageManager.Get("list-form.fields-for-documents-3") +
                        people[count1 - 1].PersonalData,
                        LanguageManager.Get("list-form.fields-for-documents-4") +
                        people[count1 - 1].ResidentialAddress,
                        LanguageManager.Get("list-form.fields-for-documents-5") +
                        people[count1 - 1].Locale,
                        LanguageManager.Get("list-form.fields-for-documents-6") +
                        people[count1 - 1].RelativesPosition,
                        LanguageManager.Get("list-form.fields-for-documents-7") +
                        people[count1 - 1].FirstMeeting,
                        LanguageManager.Get("list-form.fields-for-documents-8") +
                        people[count1 - 1].Skills,
                        LanguageManager.Get("list-form.fields-for-documents-9") +
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
                    LanguageManager.Get("list-form.document-created-message"), 
                    LanguageManager.Get("general.normal-message-title"));
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
                        LanguageManager.Get("list-form.illegal-chars-message"),
                        LanguageManager.Get("general.warning-message-title"));
                    goto p_b;
                }

                Word app = new Word();
                Document docx = app.Documents.Add(Visible: false);
                Range r = docx.Range();

                List<Element> people = new List<Element>();

                for (int i = 0; i < elementDataGridView.Rows.Count; i++)
                {
                    people.Add(this.reviewList.Elements.Single(
                        p => p.Name == elementDataGridView[0, i]
                            .Value.ToString()));
                }

                int count1 = 1;
                int count2 = 0;
                r.Text = "\"" + this.reviewList.ListName + "\"\n\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    r.Text += $"\n{count1}. {people[count1 - 1].Name}\n";
                    List<string> fields = new List<string>
                    {
                        LanguageManager.Get("list-form.fields-for-documents-1") +
                        people[count1 - 1].Birthday,
                        LanguageManager.Get("list-form.fields-for-documents-2") +
                        people[count1 - 1].Phone,
                        LanguageManager.Get("list-form.fields-for-documents-3") +
                        people[count1 - 1].PersonalData,
                        LanguageManager.Get("list-form.fields-for-documents-4") +
                        people[count1 - 1].ResidentialAddress,
                        LanguageManager.Get("list-form.fields-for-documents-5") +
                        people[count1 - 1].Locale,
                        LanguageManager.Get("list-form.fields-for-documents-6") +
                        people[count1 - 1].RelativesPosition,
                        LanguageManager.Get("list-form.fields-for-documents-7") +
                        people[count1 - 1].FirstMeeting,
                        LanguageManager.Get("list-form.fields-for-documents-8") +
                        people[count1 - 1].Skills,
                        LanguageManager.Get("list-form.fields-for-documents-9") +
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
                    LanguageManager.Get("list-form.document-created-message"),
                    LanguageManager.Get("general.normal-message-title"));
            }
        }

        private void SearchElementTextBoxTextChanged(object sender, EventArgs e)
        {
            elementDataGridView.Rows.Clear();

            List<Element> pl = new List<Element>();

            pl = this.reviewList.Elements.FindAll(
                        item => item.Name.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));

            foreach (Element el in pl)
            {
                elementDataGridView.Rows.Add(
                    el.Name,
                    el.Birthday,
                    el.CreatingDate,
                    el.UpdatingDate);
            }
        }

        private void ElementDataGridViewColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > 3)
            {
                return;
            }

            if (sortMode == e.ColumnIndex)
            {
                this.sortByAsc = !sortByAsc;
            }
            else
            {
                this.sortByAsc = true;
            }

            this.sortMode = e.ColumnIndex;

            if (this.sortByAsc)
            {
                switch (this.sortMode)
                {
                    case 0:
                        this.reviewList.Elements = this.reviewList.Elements
                            .OrderBy(p => p.Name)
                            .ToList();
                        break;
                    case 1:
                        this.reviewList.Elements = this.reviewList.Elements
                            .OrderBy(p => string.Join(".", p.Birthday.Split('.').Reverse().ToArray()))
                            .ToList();
                        break;
                    case 2:
                        this.reviewList.Elements = this.reviewList.Elements
                            .OrderBy(p => Program.MeasureTimeStr(p.CreatingDate))
                            .ToList();
                        break;
                    case 3:
                        this.reviewList.Elements = this.reviewList.Elements
                            .OrderBy(p => Program.MeasureTimeStr(p.UpdatingDate))
                            .ToList();
                        break;
                }
            }
            else
            {
                switch (this.sortMode)
                {
                    case 0:
                        this.reviewList.Elements = this.reviewList.Elements
                            .OrderByDescending(p => p.Name)
                            .ToList();
                        break;
                    case 1:
                        this.reviewList.Elements = this.reviewList.Elements
                            .OrderByDescending(p => string.Join(".", p.Birthday.Split('.').Reverse().ToArray()))
                            .ToList();
                        break;
                    case 2:
                        this.reviewList.Elements = this.reviewList.Elements
                            .OrderByDescending(p => Program.MeasureTimeStr(p.CreatingDate))
                            .ToList();
                        break;
                    case 3:
                        this.reviewList.Elements = this.reviewList.Elements
                            .OrderByDescending(p => Program.MeasureTimeStr(p.UpdatingDate))
                            .ToList();
                        break;
                }
            }

            elementDataGridView.Rows.Clear();

            List<Element> pl = new List<Element>();

            pl = this.reviewList.Elements.FindAll(
                        item => item.Name.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));

            foreach (Element el in pl)
            {
                elementDataGridView.Rows.Add(
                    el.Name,
                    el.Birthday,
                    el.CreatingDate,
                    el.UpdatingDate);
            }
        }

        private void ListFormFormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            switch (this.action)
            {
                case NextAction.AppIsClosing: 
                    Environment.Exit(0); 
                    break;
                case NextAction.GoToMainForm:
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    break;
            }
        }
    }
}
