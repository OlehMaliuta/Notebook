using System;
using System.Windows.Forms;
using MemoMates.Tools;
using MemoMates.Classes.DB;
using MemoMates.Classes.DB.Models;
using System.Linq;

namespace MemoMates
{
    public partial class ListNameForm : Form
    {
        private readonly DbApp DB;
        private PersonList reviewingList;

        public ListNameForm(DbApp db, PersonList list)
        {
            InitializeComponent();

            this.DB = db;
            this.reviewingList = list;
        }

        private void ListNameFormLoad(object sender, EventArgs e)
        {
            listNameTextBox.Text = reviewingList == null ? "" : reviewingList.Name;

            // localization

            this.Text = reviewingList == null
                ? $"{StringTool.Get("general.app-name")} - {StringTool.Get("list-name-form.form-name-create")}"
                : $"{StringTool.Get("general.app-name")} - {StringTool.Get("list-name-form.form-name-rename")}";

            listNameWindowLabel.Text = reviewingList == null
                ? StringTool.Get("list-name-form.name-input-option-title-create")
                : StringTool.Get("list-name-form.name-input-option-title-rename");

            giveListNameButton.Text = reviewingList == null
                ? StringTool.Get("list-name-form.create-button")
                : StringTool.Get("list-name-form.rename-button");

            cancelButton.Text = StringTool.Get("list-name-form.cancel-button");
        }

        private void GiveListNameButtonClick(object sender, EventArgs e)
        {
            string input = listNameTextBox.Text;

            if (input == "")
            {
                MessageBox.Show(
                    StringTool.Get("list-name-form.list-must-have-name-message"),
                    StringTool.Get("general.warning-message-title"));
            }
            else if (this.DB.PersonLists.FirstOrDefault(p => p.Name == input) != null)
            {
                MessageBox.Show(
                    StringTool.Get("list-name-form.same-name-message"),
                    StringTool.Get("general.warning-message-title"));
            }
            else
            {
                if (this.reviewingList != null)
                {
                    this.reviewingList.Name = input;
                    this.reviewingList.UpdatedAt = DateTime.Now;
                }
                else
                {
                    this.DB.PersonLists.Add(new PersonList() 
                    {
                        Name = input
                    });
                }

                this.DB.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
