using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using MemoMates.Classes;
using MemoMates.Classes.DB;
using MemoMates.Classes.DB.Models;
using System.Reflection.Emit;

namespace MemoMates
{
    public partial class ElementForm : Form
    {
        private readonly DbApp DB;
        private readonly PersonList reviewingList;
        private readonly Person reviewingPerson;
        private readonly bool creatingMode;
        private bool xIsPressed;

        public ElementForm(DbApp db, PersonList list, Person person)
        {
            InitializeComponent();

            this.DB = db;
            this.reviewingList = list;
            this.reviewingPerson = person;

            if (this.reviewingPerson != null)
            {
                this.creatingMode = false;
            }
            else
            {
                this.reviewingPerson = new Person();
                this.creatingMode = true;
            }

            this.xIsPressed = true;
        }

        private void ElementFormLoad(object sender, EventArgs e)
        {
            // form settings

            if (!this.creatingMode)
            {
                this.firstNameTextBox.Text = this.reviewingPerson.FirstName;
                this.lastNameTextBox.Text = this.reviewingPerson.LastName;
                this.middleNameTextBox.Text = this.reviewingPerson.MiddleName;
                this.isDateOfBirthAllowedCheckBox.Checked = 
                    this.reviewingPerson.DateOfBirth != null;


                if (this.reviewingPerson.DateOfBirth != null)
                {
                    this.dateOfBirthDateTimePicker.Value = this.reviewingPerson.DateOfBirth 
                        ?? throw new NullReferenceException();
                }
                else
                {
                    this.dateOfBirthDateTimePicker.Enabled = false;
                }

                this.phoneNoTextBox.Text = this.reviewingPerson.PhoneNumber;
                this.emailTextBox.Text = this.reviewingPerson.EmailAddress;
                this.extraInfoTextBox.Text = this.reviewingPerson.ExtraInfo;
            }
            else
            {
                this.isDateOfBirthAllowedCheckBox.Checked = false;
                this.dateOfBirthDateTimePicker.Enabled = false;
            }

            // localization

            this.Text = this.creatingMode
                ? $"{LanguageManager.Get("general.app-name")} - {LanguageManager.Get("element-form.form-name-create")}"
                : $"{LanguageManager.Get("general.app-name")} - {LanguageManager.Get("element-form.form-name-review")}";

            this.editElementButton.Text = this.creatingMode
                ? LanguageManager.Get("element-form.create-element-button")
                : LanguageManager.Get("element-form.edit-element-button");

            this.goBackButton.Text = LanguageManager.Get("element-form.go-back-button");

            this.firstNameLabel.Text = LanguageManager.Get("element-form.first-name-label");
            this.lastNameLabel.Text = LanguageManager.Get("element-form.last-name-label");
            this.middleNameLabel.Text = LanguageManager.Get("element-form.middle-name-label");
            this.dateOfBirthLabel.Text = LanguageManager.Get("element-form.date-of-birth-label");
            this.phoneNoLabel.Text = LanguageManager.Get("element-form.phone-no-label");
            this.emailLabel.Text = LanguageManager.Get("element-form.email-address-label");
            this.extraInfoLabel.Text = LanguageManager.Get("element-form.extra-info-label");
        }

        private void IsDateOfBirthAllowedCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this.dateOfBirthDateTimePicker.Enabled = 
                this.isDateOfBirthAllowedCheckBox.Checked;
        }

        private void ChangeElementButtonClick(object sender, EventArgs e)
        {
            if (
                this.firstNameTextBox.Text.Trim() == "" 
                || this.lastNameTextBox.Text.Trim() == ""
                )
            {
                MessageBox.Show(
                    LanguageManager.Get("element-form.necessary-fields-message"), 
                    LanguageManager.Get("general.warning-message-title"));

                return;
            }

            this.reviewingPerson.FirstName = this.firstNameTextBox.Text.Trim();
            this.reviewingPerson.LastName = this.lastNameTextBox.Text.Trim();
            this.reviewingPerson.MiddleName =
                this.middleNameTextBox.Text.Trim() == "" ? null : this.middleNameTextBox.Text.Trim();
            this.reviewingPerson.PhoneNumber =
                this.phoneNoTextBox.Text.Trim() == "" ? null : this.phoneNoTextBox.Text.Trim();
            this.reviewingPerson.EmailAddress =
                this.emailTextBox.Text.Trim() == "" ? null : this.emailTextBox.Text.Trim();
            this.reviewingPerson.ExtraInfo =
                this.extraInfoTextBox.Text.Trim() == "" ? null : this.extraInfoTextBox.Text.Trim();

            if (this.isDateOfBirthAllowedCheckBox.Checked)
            {
                this.reviewingPerson.DateOfBirth = this.dateOfBirthDateTimePicker.Value;
            }

            if (this.creatingMode)
            {
                this.reviewingPerson.ListId = this.reviewingList.Id;
                this.reviewingPerson.List = this.reviewingList;

                DB.People.Add(this.reviewingPerson);
            }

            DB.SaveChanges();

            this.xIsPressed = false;

            this.Close();
            ListForm listForm = new ListForm(this.DB, this.reviewingList);
            listForm.Show();
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ElementFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.xIsPressed)
            {
                ListForm listForm = new ListForm(this.DB, this.reviewingList);
                listForm.Show();
            }
        }
    }
}
