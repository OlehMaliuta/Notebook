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
    public partial class ElementForm : Form
    {
        ListsStorage listsStorage = new ListsStorage();
        ProgVarStorage progVarStorage = new ProgVarStorage();
        PeopleList reviewList = new PeopleList();
        Element reviewElement = new Element();

        public ElementForm()
        {
            InitializeComponent();
        }

        private void ElementForm_Load(object sender, EventArgs e)
        {
            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            this.reviewList = listsStorage.peopleLists.Single(
                        item => item.listName == progVarStorage.reviewListName);

            if (progVarStorage.elementFormVariant == "change")
            {
                reviewElement = 
                    reviewList.elements.Single(item => item.name == progVarStorage.revievElementName);

                changeElement_button.Text = "Змінити";
            }

            infoFieldType_comboBox.SelectedIndex = 0;
            infoFieldType_comboBox.Text = "ім'я";
            fieldName_label.Text = infoFieldType_comboBox.Text;
            info_textBox.Text = reviewElement.name;
        }

        private void changeElement_button_Click(object sender, EventArgs e)
        {
            if (progVarStorage.elementFormVariant == "create")
            {
                if (reviewList.elements.Find(item => item.name == info_textBox.Text) != null)
                {
                    MessageBox.Show("Елемент із даним ім'ям вже існує в списку.", "Попередження!");
                    return;
                }

                listsStorage.peopleLists.Single(
                    item => item.listName == progVarStorage.reviewListName)
                    .elements.Add(reviewElement);
            }

            this.Close();
            ListForm listForm = new ListForm();
            listForm.Show();
        }

        private void goBack_button_Click(object sender, EventArgs e)
        {
            this.Close();
            ListForm listForm = new ListForm();
            listForm.Show();
        }

        private void info_textBox_TextChanged(object sender, EventArgs e)
        {
            switch (infoFieldType_comboBox.SelectedIndex)
            {
                case 0:
                    reviewElement.name = info_textBox.Text;
                    break;

                case 1:
                    reviewElement.birthday = info_textBox.Text;
                    break;

                case 2:
                    reviewElement.phone = info_textBox.Text;
                    break;

                case 3:
                    reviewElement.personalData = info_textBox.Text;
                    break;

                case 4:
                    reviewElement.restdentialAddress = info_textBox.Text;
                    break;

                case 5:
                    reviewElement.locale = info_textBox.Text;
                    break;

                case 6:
                    reviewElement.firstMeeting = info_textBox.Text;
                    break;

                case 7:
                    reviewElement.familarPeoplePosition = info_textBox.Text;
                    break;

                case 8:
                    reviewElement.goodSides = info_textBox.Text;
                    break;

                case 9:
                    reviewElement.extraInfo = info_textBox.Text;
                    break;
            }
        }

        private void infoFieldType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fieldName_label.Text = infoFieldType_comboBox.Text;

            switch (infoFieldType_comboBox.SelectedIndex)
            {
                case 0:
                    info_textBox.Text = reviewElement.name;
                    break;

                case 1:
                    info_textBox.Text = reviewElement.birthday;
                    break;

                case 2:
                    info_textBox.Text = reviewElement.phone;
                    break;

                case 3:
                    info_textBox.Text = reviewElement.personalData;
                    break;

                case 4:
                    info_textBox.Text = reviewElement.restdentialAddress;
                    break;

                case 5:
                    info_textBox.Text = reviewElement.locale;
                    break;

                case 6:
                    info_textBox.Text = reviewElement.firstMeeting;
                    break;

                case 7:
                    info_textBox.Text = reviewElement.familarPeoplePosition;
                    break;

                case 8:
                    info_textBox.Text = reviewElement.goodSides;
                    break;

                case 9:
                    info_textBox.Text = reviewElement.extraInfo;
                    break;
            }
        }

        private void ElementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
