﻿using System;
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
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private PeopleList reviewList = new PeopleList();
        private Element reviewElement = new Element();
        private Element newElement = new Element();

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
                reviewElement = reviewList.elements.Single(
                    p => p.name == progVarStorage.revievElementName);

                newElement.CopyElement(reviewElement);

                changeElement_button.Text = "Змінити";
            }

            infoFieldType_comboBox.SelectedIndex = 0;
            fieldName_label.Text = infoFieldType_comboBox.Text;
            info_textBox.Text = newElement.name;

            day_numericUpDown.Maximum = int.MaxValue;
            day_numericUpDown.Minimum = int.MinValue;

            month_numericUpDown.Maximum = int.MaxValue;
            month_numericUpDown.Minimum = int.MinValue;

            year_numericUpDown.Maximum = int.MaxValue;
            year_numericUpDown.Minimum = int.MinValue;

            date_panel.Visible = false;
        }

        private void changeElement_button_Click(object sender, EventArgs e)
        {
            string err = "";

            if (reviewList.elements.FindIndex(item => item.name == info_textBox.Text) != -1)
                err += "\nЕлемент із даним ім'ям вже існує в списку.";

            if (newElement.name == "")
                err += "\nЕлемент повинен мати ім'я.";

            if (
                day_numericUpDown.Value < 0 ||
                month_numericUpDown.Value < 0 ||
                year_numericUpDown.Value < 0)
                err += "\nПоля для дати народження не можуть мати від'ємні значення.";

            if (err != "")
            {
                MessageBox.Show(err, "Попередження!");
                return;
            }

            newElement.birthday =
                    $"{day_numericUpDown.Value}.{month_numericUpDown.Value}.{year_numericUpDown.Value}";

            if (progVarStorage.elementFormVariant == "create")
            {
                newElement.creatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                newElement.updatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                reviewList.updatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                reviewList.elements.Add(newElement);
            }
            else if (progVarStorage.elementFormVariant == "change")
            {
                if (newElement != reviewElement)
                {
                    newElement.updatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                    reviewList.updatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                    reviewElement.CopyElement(newElement);
                }
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
                    newElement.name = info_textBox.Text;
                    break;

                case 2:
                    newElement.phone = info_textBox.Text;
                    break;

                case 3:
                    newElement.personalData = info_textBox.Text;
                    break;

                case 4:
                    newElement.restdentialAddress = info_textBox.Text;
                    break;

                case 5:
                    newElement.locale = info_textBox.Text;
                    break;

                case 6:
                    newElement.firstMeeting = info_textBox.Text;
                    break;

                case 7:
                    newElement.familarPeoplePosition = info_textBox.Text;
                    break;

                case 8:
                    newElement.goodSides = info_textBox.Text;
                    break;

                case 9:
                    newElement.extraInfo = info_textBox.Text;
                    break;
            }
        }

        private void infoFieldType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fieldName_label.Text = infoFieldType_comboBox.Text;

            switch (infoFieldType_comboBox.SelectedIndex)
            {
                case 0:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.name;
                    break;

                case 1:
                    info_textBox.Visible = false;
                    date_panel.Visible = true;
                    info_textBox.Text = newElement.birthday;
                    break;

                case 2:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.phone;
                    break;

                case 3:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.personalData;
                    break;

                case 4:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.restdentialAddress;
                    break;

                case 5:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.locale;
                    break;

                case 6:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.firstMeeting;
                    break;

                case 7:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.familarPeoplePosition;
                    break;

                case 8:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.goodSides;
                    break;

                case 9:
                    info_textBox.Visible = true;
                    date_panel.Visible = false;
                    info_textBox.Text = newElement.extraInfo;
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
