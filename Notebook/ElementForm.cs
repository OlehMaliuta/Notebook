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
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private PeopleList reviewList = new PeopleList();
        private Element reviewElement = new Element();
        private Element newElement = new Element();
        private string[] messageText;

        public ElementForm()
        {
            InitializeComponent();
        }

        private void SetWindowLang(Language language, string variant)
        {
            switch (language)
            {
                case Language.Ukranian:
                    if (variant == "create")
                    {
                        this.Text = "Новий елемент";
                        changeElement_button.Text = "створити";
                    }
                    else if (variant == "change")
                    {
                        this.Text = "Перегляд елементу";
                        changeElement_button.Text = "змінити";
                    }

                    day_label.Text = "День:";
                    month_label.Text = "Місяць:";
                    year_label.Text = "Рік:";

                    goBack_button.Text = "назад";

                    fieldType_label.Text = "Поля:";

                    infoFieldType_comboBox.Items.Add("ім'я");
                    infoFieldType_comboBox.Items.Add("дата народження");
                    infoFieldType_comboBox.Items.Add("телефон");
                    infoFieldType_comboBox.Items.Add("анкетні дані");
                    infoFieldType_comboBox.Items.Add("місце проживання");
                    infoFieldType_comboBox.Items.Add("місце роботи/навчання");
                    infoFieldType_comboBox.Items.Add("характер знайомства");
                    infoFieldType_comboBox.Items.Add("посада знайомих");
                    infoFieldType_comboBox.Items.Add("ділові якості");
                    infoFieldType_comboBox.Items.Add("додаткові дані");

                    messageText = new string[]
                    {
                        "Попередження!",
                        "Елемент із даним ім'ям вже існує в списку.",
                        "Елемент повинен мати ім'я.",
                        "Поля для дати народження не можуть мати від'ємні значення."
                    };
                    break;

                case Language.Russian:
                    if (variant == "create")
                    {
                        this.Text = "Новый элемент";
                        changeElement_button.Text = "создать";
                    }
                    else if (variant == "change")
                    {
                        this.Text = "Просмотр элемента";
                        changeElement_button.Text = "изменить";
                    }

                    day_label.Text = "День:";
                    month_label.Text = "Месяц:";
                    year_label.Text = "Год:";

                    goBack_button.Text = "назад";

                    fieldType_label.Text = "Поля:";

                    infoFieldType_comboBox.Items.Add("имя");
                    infoFieldType_comboBox.Items.Add("дата рождения");
                    infoFieldType_comboBox.Items.Add("телефон");
                    infoFieldType_comboBox.Items.Add("анкетные даные");
                    infoFieldType_comboBox.Items.Add("место проживания");
                    infoFieldType_comboBox.Items.Add("место работи/учёбы");
                    infoFieldType_comboBox.Items.Add("характер знакомства");
                    infoFieldType_comboBox.Items.Add("положение знакомых");
                    infoFieldType_comboBox.Items.Add("деловые качества");
                    infoFieldType_comboBox.Items.Add("дополнительные данные");

                    messageText = new string[]
                    {
                        "Предупреждения!",
                        "Элемент с данным именем уже есть в списке.",
                        "У элемента должно быть имя.",
                        "Поля для даты рождения не принимают отрицательных значений."
                    };
                    break;

                case Language.English:
                    if (variant == "create")
                    {
                        this.Text = "New element";
                        changeElement_button.Text = "create";
                    }
                    else if (variant == "change")
                    {
                        this.Text = "Element review";
                        changeElement_button.Text = "change";
                    }

                    day_label.Text = "Day:";
                    month_label.Text = "Month:";
                    year_label.Text = "Year:";

                    goBack_button.Text = "back";

                    fieldType_label.Text = "Field:";

                    infoFieldType_comboBox.Items.Add("name");
                    infoFieldType_comboBox.Items.Add("birth date");
                    infoFieldType_comboBox.Items.Add("phone");
                    infoFieldType_comboBox.Items.Add("personal data");
                    infoFieldType_comboBox.Items.Add("residentional address");
                    infoFieldType_comboBox.Items.Add("locale");
                    infoFieldType_comboBox.Items.Add("first meeting");
                    infoFieldType_comboBox.Items.Add("familar people position");
                    infoFieldType_comboBox.Items.Add("good sides");
                    infoFieldType_comboBox.Items.Add("extra info");

                    messageText = new string[]
                    {
                        "Warning!",
                        "Element with the same name already exists in the list.",
                        "An element must have a name",
                        "Birth date fields do not take negative values."
                    };
                    break;
            }
        }

        private void ElementForm_Load(object sender, EventArgs e)
        {
            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            this.reviewList = listsStorage.peopleLists.Single(
                        item => item.listName == progVarStorage.reviewListName);

            SetWindowLang(progVarStorage.language, progVarStorage.elementFormVariant);

            if (progVarStorage.elementFormVariant == "change")
            {
                reviewElement = reviewList.elements.Single(
                    p => p.name == progVarStorage.revievElementName);

                newElement.CopyElement(reviewElement);
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
                err += "\n" + messageText[1];

            if (newElement.name == "")
                err += "\n" + messageText[2];

            if (
                day_numericUpDown.Value < 0 ||
                month_numericUpDown.Value < 0 ||
                year_numericUpDown.Value < 0)
                err += "\n" + messageText[3];

            if (err != "")
            {
                MessageBox.Show(err, messageText[0]);
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
