# MemoMates

This is a Windows Forms application developed using .NET Framework 4.8. The program utilizes an SQLite database with Entity Framework 6 ORM for storing and editing information about people. Users can create a list to add people nodes, print the content of the list to a text (txt) or Microsoft Word (docx) file, and benefit from localization supporting English, Russian, and Ukrainian languages.

## Features

- Create and manage lists of people with customizable information fields such as:
  - First Name
  - Last Name
  - Middle Name
  - Date of Birth
  - Phone Number
  - Email Address
  - Additional Information

- Export list content to:
  - Text file (.txt)
  - Microsoft Word document (.docx)

- Localization support for three languages:
  - English
  - Russian
  - Ukrainian
 
## Technologies Used

- Framework: .NET Framework 4.8
- Database: SQLite
- ORM: Entity Framework 6
- UI: Windows Forms

## Installation

1. Clone the repository to your local machine: `git clone https://github.com/OlehMaliuta/memo-mates.git`.
2. Open the solution file (PeopleManagementProgram.sln) in Visual Studio.
3. Build the solution to restore dependencies.
4. Run the application.

## Usage

1. Launch the program.
2. Create a new list or load an existing one.
3. Add people to the list by providing their information.
4. Edit or delete existing entries as needed.
5. Export the content of the list to a text or Word document.
6. Utilize localization to switch between supported languages.

## License

[MIT License](LICENSE)
