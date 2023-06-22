using System;
using System.Linq;
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
        private string nextWindow = "";
        private string[] messageText;

        public ElementForm()
        {
            InitializeComponent();
        }

        private void SetWindowLang(Language language, string variant)
        {
            switch (language)
            {
                case Language.Ukraіnian:
                    if (variant == "create")
                    {
                        this.Text = "Notebook - Новий елемент";
                        changeElementButton.Text = "створити";
                    }
                    else if (variant == "change")
                    {
                        this.Text = "Notebook - Перегляд елементу";
                        changeElementButton.Text = "змінити";
                    }

                    dayLabel.Text = "День:";
                    monthLabel.Text = "Місяць:";
                    yearLabel.Text = "Рік:";

                    goBackButton.Text = "назад";

                    fieldTypeLabel.Text = "Поля:";

                    infoFieldTypeComboBox.Items.Add("ім'я");
                    infoFieldTypeComboBox.Items.Add("дата народження");
                    infoFieldTypeComboBox.Items.Add("телефон");
                    infoFieldTypeComboBox.Items.Add("анкетні дані");
                    infoFieldTypeComboBox.Items.Add("місце проживання");
                    infoFieldTypeComboBox.Items.Add("місце роботи/навчання");
                    infoFieldTypeComboBox.Items.Add("характер знайомства");
                    infoFieldTypeComboBox.Items.Add("посада знайомих");
                    infoFieldTypeComboBox.Items.Add("ділові якості");
                    infoFieldTypeComboBox.Items.Add("додаткові дані");

                    messageText = new string[]
                    {
                        "Попередження!",

                        "Елемент із даним ім'ям вже існує в списку.",

                        "Елемент повинен мати ім'я.",

                        "Поля для дати народження не можуть " +
                        "мати від'ємні значення."
                    };
                    break;

                case Language.Russian:
                    if (variant == "create")
                    {
                        this.Text = "Notebook - Новый элемент";
                        changeElementButton.Text = "создать";
                    }
                    else if (variant == "change")
                    {
                        this.Text = "Notebook - Просмотр элемента";
                        changeElementButton.Text = "изменить";
                    }

                    dayLabel.Text = "День:";
                    monthLabel.Text = "Месяц:";
                    yearLabel.Text = "Год:";

                    goBackButton.Text = "назад";

                    fieldTypeLabel.Text = "Поля:";

                    infoFieldTypeComboBox.Items.Add("имя");
                    infoFieldTypeComboBox.Items.Add("дата рождения");
                    infoFieldTypeComboBox.Items.Add("телефон");
                    infoFieldTypeComboBox.Items.Add("анкетные даные");
                    infoFieldTypeComboBox.Items.Add("место проживания");
                    infoFieldTypeComboBox.Items.Add("место работи/учёбы");
                    infoFieldTypeComboBox.Items.Add("характер знакомства");
                    infoFieldTypeComboBox.Items.Add("положение знакомых");
                    infoFieldTypeComboBox.Items.Add("деловые качества");
                    infoFieldTypeComboBox.Items.Add("дополнительные данные");

                    messageText = new string[]
                    {
                        "Предупреждения!",

                        "Элемент с данным именем уже есть в списке.",

                        "У элемента должно быть имя.",

                        "Поля для даты рождения не принимают " +
                        "отрицательных значений."
                    };
                    break;

                case Language.English:
                    if (variant == "create")
                    {
                        this.Text = "Notebook - New element";
                        changeElementButton.Text = "create";
                    }
                    else if (variant == "change")
                    {
                        this.Text = "Notebook - Element review";
                        changeElementButton.Text = "change";
                    }

                    dayLabel.Text = "Day:";
                    monthLabel.Text = "Month:";
                    yearLabel.Text = "Year:";

                    goBackButton.Text = "back";

                    fieldTypeLabel.Text = "Field:";

                    infoFieldTypeComboBox.Items.Add("name");
                    infoFieldTypeComboBox.Items.Add("birth date");
                    infoFieldTypeComboBox.Items.Add("phone");
                    infoFieldTypeComboBox.Items.Add("personal data");
                    infoFieldTypeComboBox.Items.Add("residentional address");
                    infoFieldTypeComboBox.Items.Add("locale");
                    infoFieldTypeComboBox.Items.Add("first meeting");
                    infoFieldTypeComboBox.Items.Add("familar people position");
                    infoFieldTypeComboBox.Items.Add("good sides");
                    infoFieldTypeComboBox.Items.Add("extra info");

                    messageText = new string[]
                    {
                        "Warning!",

                        "Element with the same name already " +
                        "exists in the list.",

                        "An element must have a name",

                        "Birth date fields do not take negative values."
                    };
                    break;
            }
        }

        private void ElementFormLoad(object sender, EventArgs e)
        {
            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

            this.reviewList = listsStorage.PeopleLists.Single(
                        item => 
                        item.ListName == progVarStorage.ReviewListName);

            SetWindowLang(
                progVarStorage.AppLanguage,
                progVarStorage.ElementFormVariant);

            if (progVarStorage.ElementFormVariant == "change")
            {
                reviewElement = reviewList.Elements.Single(
                    p => p.Name == progVarStorage.ReviewElementName);

                newElement.CopyElement(reviewElement);
            }

            infoFieldTypeComboBox.SelectedIndex = 0;
            fieldNameLabel.Text = infoFieldTypeComboBox.Text;
            infoTextBox.Text = newElement.Name;

            dayNumericUpDown.Maximum = int.MaxValue;
            dayNumericUpDown.Minimum = int.MinValue;

            monthNumericUpDown.Maximum = int.MaxValue;
            monthNumericUpDown.Minimum = int.MinValue;

            yearNumericUpDown.Maximum = int.MaxValue;
            yearNumericUpDown.Minimum = int.MinValue;

            datePanel.Visible = false;
        }

        private void ChangeElementButtonClick(object sender, EventArgs e)
        {
            string err = "";

            if (
                progVarStorage.ElementFormVariant == "create" &&
                reviewList.Elements.FindIndex(
                    item => item.Name == infoTextBox.Text) != -1
                )
                err += "\n" + messageText[1];

            if (newElement.Name == "")
                err += "\n" + messageText[2];

            if (
                dayNumericUpDown.Value < 0 ||
                monthNumericUpDown.Value < 0 ||
                yearNumericUpDown.Value < 0)
                err += "\n" + messageText[3];

            if (err != "")
            {
                MessageBox.Show(err, messageText[0]);
                return;
            }

            string day, month, year;

            if (dayNumericUpDown.Value == 0)
                day = "-";
            else
                day = dayNumericUpDown.Value.ToString();

            if (monthNumericUpDown.Value == 0)
                month = "-";
            else
                month = monthNumericUpDown.Value.ToString();

            if (yearNumericUpDown.Value == 0)
                year = "-";
            else
                year = yearNumericUpDown.Value.ToString();

            newElement.Birthday =
                    $"{day}.{month}.{year}";

            if (progVarStorage.ElementFormVariant == "create")
            {
                newElement.CreatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                newElement.UpdatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                reviewList.UpdatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                reviewList.Elements.Add(newElement);
            }
            else if (progVarStorage.ElementFormVariant == "change")
            {
                if (newElement != reviewElement)
                {
                    newElement.UpdatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                    reviewList.UpdatingDate =
                    DateTime.Now.ToShortDateString() +
                    "\n" + DateTime.Now.ToLongTimeString();

                    reviewElement.CopyElement(newElement);
                }
            }

            nextWindow = "ListForm";
            this.Close();
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            nextWindow = "ListForm";
            this.Close();
        }

        private void InfoTextBoxTextChanged(object sender, EventArgs e)
        {
            switch (infoFieldTypeComboBox.SelectedIndex)
            {
                case 0:
                    newElement.Name = infoTextBox.Text;
                    break;

                case 2:
                    newElement.Phone = infoTextBox.Text;
                    break;

                case 3:
                    newElement.PersonalData = infoTextBox.Text;
                    break;

                case 4:
                    newElement.ResidentialAddress = infoTextBox.Text;
                    break;

                case 5:
                    newElement.Locale = infoTextBox.Text;
                    break;

                case 6:
                    newElement.FirstMeeting = infoTextBox.Text;
                    break;

                case 7:
                    newElement.FamilarPeoplePosition = infoTextBox.Text;
                    break;

                case 8:
                    newElement.Skills = infoTextBox.Text;
                    break;

                case 9:
                    newElement.ExtraInfo = infoTextBox.Text;
                    break;
            }
        }

        private void InfoFieldTypeComboBoxSelectedIndexChanged(
            object sender, EventArgs e)
        {
            fieldNameLabel.Text = infoFieldTypeComboBox.Text;

            switch (infoFieldTypeComboBox.SelectedIndex)
            {
                case 0:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.Name;
                    break;

                case 1:
                    infoTextBox.Visible = false;
                    datePanel.Visible = true;
                    string[] nums = newElement.Birthday.Split('.');
                    
                    if (nums[0] == "-")
                        dayNumericUpDown.Value = 0;
                    else
                        dayNumericUpDown.Value = Convert.ToDecimal(nums[0]);

                    if (nums[1] == "-")
                        monthNumericUpDown.Value = 0;
                    else
                        monthNumericUpDown.Value = Convert.ToDecimal(nums[1]);

                    if (nums[2] == "-")
                        yearNumericUpDown.Value = 0;
                    else
                        yearNumericUpDown.Value = Convert.ToDecimal(nums[2]);
                    break;

                case 2:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.Phone;
                    break;

                case 3:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.PersonalData;
                    break;

                case 4:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.ResidentialAddress;
                    break;

                case 5:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.Locale;
                    break;

                case 6:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.FirstMeeting;
                    break;

                case 7:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.FamilarPeoplePosition;
                    break;

                case 8:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.Skills;
                    break;

                case 9:
                    infoTextBox.Visible = true;
                    datePanel.Visible = false;
                    infoTextBox.Text = newElement.ExtraInfo;
                    break;
            }
        }

        private void ElementFormFormClosing(
            object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));

            switch (nextWindow)
            {
                case "ListForm":
                    ListForm listForm1 = new ListForm();
                    listForm1.Show();
                    break;

                case "":
                    ListForm listForm2 = new ListForm();
                    listForm2.Show();
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
