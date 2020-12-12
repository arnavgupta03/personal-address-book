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

namespace PersonalAddressBook
{
    public partial class FormPABook : Form
    {
        public FormPABook()
        {
            InitializeComponent();
        }

        public struct PersonalInfo
        {
            //intialize name variables
            public string firstName;
            public string lastName;

            //initalize contact info variables
            public long cellNum;
            public string emailAddress;

            //initialize birthday variables
            public int day;
            public int month;
            public int year;
        }

        //initialize global array
        PersonalInfo[] contactArray = new PersonalInfo[100];

        //initialize global index
        int iCurrentIndex = 0;

        //initialize global selected index
        int iSelectedIndex = 0;

        //method to search for person
        public int FindPerson(string FirstName, string LastName)
        {
            //loop to look through array elements
            for (int i = 0; i < iCurrentIndex; i++)
            {
                //conditional to check if first and last names match
                if ((String.Equals(contactArray[i].firstName.ToLower(), FirstName.ToLower())) && (String.Equals(contactArray[i].lastName.ToLower(), LastName.ToLower())))
                {
                    //return index match was found at
                    return i;
                }
            }
            //return invalid index that indicates none was found
            return -1;
        }

        //method to search for cell number
        public int FindNum(long cellNum)
        {
            //loop to look through array elements
            for (int i = 0; i < iCurrentIndex; i++)
            {
                //conditional to check if cell number matches
                if (cellNum == contactArray[i].cellNum)
                {
                    //return index match was found at
                    return i;
                }
            }
            //return invalid index that indicates none was found
            return -1;
        }

        //method to search for email
        public int FindEmail(string emailAddress)
        {
            //loop to look through array elements
            for (int i = 0; i < iCurrentIndex; i++)
            {
                //conditional to check if email matches
                if (String.Equals(emailAddress, contactArray[i].emailAddress))
                {
                    //return index match was found at
                    return i;
                }
            }
            //return invalid index that indicates none was found
            return -1;
        }

        public int SearchAlphabet (char key)
        {
            //set alphabet array
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

            //loop through alphabet
            for (int i = 0; i < alphabet.Length; i++)
            {
                //check for match
                if (alphabet[i].Equals(key))
                {
                    //return index
                    return i;
                }
            }
            //return not in array
            return -1;
        }

        public string Encrypt(string text, string key)
        {
            //initialize output variable
            char[] output = new char[text.Length];
            string strOutput;

            //set alphabet array
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            //loop through char in text
            for (int i = 0; i < text.Length; i++)
            {
                //add encrypted character to output
                output[i] = alphabet[(SearchAlphabet(text.ToLower().ElementAt(i)) + SearchAlphabet(key.ToLower().ElementAt(i % key.Length))) % 36];
            }

            //set string output
            strOutput = new string(output);

            //output
            return strOutput;
        }

        public string Decrypt(string text, string key)
        {
            //initialize output variable
            char[] output = new char[text.Length];
            string strOutput;

            //set alphabet array
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            //loop through char in text
            for (int i = 0; i < text.Length; i++)
            {
                //add encrypted character to output
                output[i] = alphabet[(SearchAlphabet(text.ToLower().ElementAt(i)) - SearchAlphabet(key.ToLower().ElementAt(i % key.Length)) + 36) % 36];
            }

            //set string out
            strOutput = new string(output);

            //output
            return strOutput;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check to ensure database is not already full
            if (iCurrentIndex > 99)
            {
                //error message in case database is full
                MessageBox.Show("The database is full. You must delete a current contact to be able to add another.");
            }
            else
            {
                try
                {
                    //initialize variables for input
                    string strFirstName, strLastName, strEmailAddress;
                    long lCellNum;
                    int iDay, iMonth, iYear;

                    //set variables to input
                    strFirstName = txtAddFirstName.Text.Trim();
                    strLastName = txtAddLastName.Text.Trim();
                    strEmailAddress = txtAddEmail.Text.Trim();
                    lCellNum = Convert.ToInt64(txtAddNum.Text.Trim());
                    iDay = dtpAdd.Value.Day;
                    iMonth = dtpAdd.Value.Month;
                    iYear = dtpAdd.Value.Year;

                    //check to ensure strings are not empty
                    if (String.IsNullOrEmpty(strFirstName) || String.IsNullOrEmpty(strLastName) || String.IsNullOrEmpty(strEmailAddress))
                    {
                        //error message in case strings are empty
                        MessageBox.Show("Please ensure that the First Name, Last Name, and Email Address fields are filled.");

                        //exit
                        return;
                    }

                    //check to ensure names only contain letters
                    if (!strFirstName.All(Char.IsLetter) || !strLastName.All(Char.IsLetter))
                    {
                        //error message in case name contains non-alphabetic characters
                        MessageBox.Show("Please ensure that the name only contains alphabetic characters. (no numbers or symbols)");

                        //clear name fields
                        txtAddFirstName.Clear();
                        txtAddLastName.Clear();

                        //exit
                        return;
                    }

                    //check that email is properly formatted
                    if (!strEmailAddress.Contains("@") || !strEmailAddress.Contains("."))
                    {
                        //error message that email is improperly formatted
                        MessageBox.Show("Please ensure that the email is properly formatted with an @ symbol and a dot.");

                        //clear email field
                        txtAddEmail.Clear();

                        //exit
                        return;
                    }

                    //check that cell number is correct
                    if (lCellNum > 9999999999)
                    {
                        //error message in case cell number is incorrect
                        MessageBox.Show("Please ensure that the Cell Number is in the 9-digit format, including area code, with no dashes or parentheses.");

                        //clear cell number field
                        txtAddNum.Clear();

                        //exit
                        return;
                    }

                    //check that birthday is not in the future
                    if (iYear > DateTime.Today.Year || (iYear == DateTime.Today.Year && iMonth > DateTime.Today.Month) || (iYear == DateTime.Today.Year && iMonth == DateTime.Today.Month && iDay > DateTime.Today.Day))
                    {
                        //error message in case birthday is in future
                        MessageBox.Show("Please ensure the birthday is not in the future.");

                        //reset date
                        dtpAdd.ResetText();

                        //exit
                        return;
                    }

                    //check that names have not been previously entered
                    if (FindPerson(strFirstName, strLastName) == -1)
                    {
                        //set names to values in array at index
                        contactArray[iCurrentIndex].firstName = strFirstName;
                        contactArray[iCurrentIndex].lastName = strLastName;

                        //set contact info to values in array at index
                        contactArray[iCurrentIndex].emailAddress = strEmailAddress;
                        contactArray[iCurrentIndex].cellNum = lCellNum;

                        //set birthday to values in array at index
                        contactArray[iCurrentIndex].day = iDay;
                        contactArray[iCurrentIndex].month = iMonth;
                        contactArray[iCurrentIndex].year = iYear;

                        //increment index
                        iCurrentIndex++;

                        //success message
                        MessageBox.Show(strFirstName + " " + strLastName + " has been successfully added to the address book.");

                        //clear textboxes
                        txtAddFirstName.Clear();
                        txtAddLastName.Clear();
                        txtAddEmail.Clear();
                        txtAddNum.Clear();
                        dtpAdd.ResetText();
                    }
                    else
                    {
                        //error message for names
                        MessageBox.Show(strFirstName + " " + strLastName + " has already been entered into the application.");

                        //clear textboxes
                        txtAddFirstName.Clear();
                        txtAddLastName.Clear();
                        txtAddEmail.Clear();
                        txtAddNum.Clear();
                        dtpAdd.ResetText();
                    }
                }
                catch
                {
                    //error message to fix input types
                    MessageBox.Show("Please ensure all textboxes are filled with appropriate values. First name, last name, and email address should be plaintext. The cell phone number should be a positive integer with no dashes or spaces.");

                    //clear textboxes
                    txtAddFirstName.Clear();
                    txtAddLastName.Clear();
                    txtAddEmail.Clear();
                    txtAddNum.Clear();
                    dtpAdd.ResetText();
                }
            }
        }

        private void btnBdaySearch_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize variables
                int iDay, iMonth, iYear, iIndex;

                //check which textbox(es) have been filled
                if (!String.IsNullOrEmpty(txtBdayFirstName.Text) && !String.IsNullOrEmpty(txtBdayLastName.Text) && String.IsNullOrEmpty(txtBdayEmail.Text) && String.IsNullOrEmpty(txtBdayCellNum.Text)) //find person based on name
                {
                    //initialize variables for input
                    string strFirstName, strLastName;

                    //set variables to input
                    strFirstName = txtBdayFirstName.Text.Trim();
                    strLastName = txtBdayLastName.Text.Trim();

                    //set index to corresponding value based on person location in array
                    iIndex = FindPerson(strFirstName, strLastName);
                }
                else if (String.IsNullOrEmpty(txtBdayFirstName.Text) && String.IsNullOrEmpty(txtBdayLastName.Text) && !String.IsNullOrEmpty(txtBdayEmail.Text) && String.IsNullOrEmpty(txtBdayCellNum.Text)) //find person based on email address
                {
                    //initialize variables for input
                    string strEmailAddress;

                    //set variable to input
                    strEmailAddress = txtBdayEmail.Text.Trim();

                    //set index to corresponding value based on person location in array
                    iIndex = FindEmail(strEmailAddress);
                }
                else if (String.IsNullOrEmpty(txtBdayFirstName.Text) && String.IsNullOrEmpty(txtBdayLastName.Text) && String.IsNullOrEmpty(txtBdayEmail.Text) && !String.IsNullOrEmpty(txtBdayCellNum.Text)) //find person based on cell number
                {
                    //initialize variables for input
                    long lCellNum;

                    //set variable to input
                    lCellNum = Convert.ToInt64(txtBdayCellNum.Text.Trim());

                    //set index to corresponding value based on person location in array
                    iIndex = FindNum(lCellNum);
                }
                else
                {
                    //error message in case of incorrect input
                    MessageBox.Show("To search a birthday, either enter a valid full name (first and last name), an email address, or a cell number. You may not enter multiple.");

                    //hide output
                    lblBday.Visible = false;
                    dtpBday.Visible = false;

                    //exit program
                    return;
                }

                if (iIndex == -1)
                {
                    //ensure label is invisible
                    lblBday.Visible = false;

                    //ensure date-time picker is invisible
                    dtpBday.Visible = false;

                    //error message that person does not exist
                    MessageBox.Show("This person does not exist in the application based on the information provided.");
                }
                else
                {
                    //set variables to value based on searched person
                    iDay = contactArray[iIndex].day;
                    iMonth = contactArray[iIndex].month;
                    iYear = contactArray[iIndex].year;

                    //ensure label is visible
                    lblBday.Visible = true;

                    //ensure date-time picker is visible
                    dtpBday.Visible = true;

                    //output birthday to date-time picker
                    dtpBday.Value = new DateTime(iYear, iMonth, iDay);
                }
            }
            catch
            {
                //error message to fix input
                MessageBox.Show("Please ensure all textboxes are filled appropriately.");

                //hide output
                lblBday.Visible = false;
                dtpBday.Visible = false;
            }
        }

        private void btnContactSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize variables
                int iIndex;
                string strFirstName, strLastName, strEmailAddress;
                long lCellNum;


                //set variables to input
                strFirstName = txtContactFirstName.Text.Trim();
                strLastName = txtContactLastName.Text.Trim();

                //ensure textboxes have been filled
                if (!String.IsNullOrEmpty(strFirstName) && !String.IsNullOrEmpty(strLastName))
                { 
                    //set index to corresponding value based on person location in array
                    iIndex = FindPerson(strFirstName, strLastName);
                }
                else
                {
                    //error message in case of empty textboxes
                    MessageBox.Show("Please ensure that textboxes have the name of the person you are searching for.");

                    //exit
                    return;
                }

                //check if person exists
                if (iIndex == -1)
                {
                    //ensure labels are invisible
                    lblContactCellNum.Visible = false;
                    lblContactEmail.Visible = false;

                    //ensure textboxes are invisible
                    txtContactCellNum.Visible = false;
                    txtContactEmail.Visible = false;

                    //error message that person does not exist
                    MessageBox.Show("This person does not exist in the application.");
                }
                else
                {
                    //set variables to value based on searched person
                    lCellNum = contactArray[iIndex].cellNum;
                    strEmailAddress = contactArray[iIndex].emailAddress;

                    //ensure labels are visible
                    lblContactCellNum.Visible = true;
                    lblContactEmail.Visible = true;

                    //ensure textboxes are visible
                    txtContactCellNum.Visible = true;
                    txtContactEmail.Visible = true;

                    //output birthday to date-time picker
                    txtContactEmail.Text = strEmailAddress;
                    txtContactCellNum.Text = lCellNum.ToString();
                }
            }
            catch
            {
                //error message to fix input
                MessageBox.Show("Please ensure all textboxes (first and last name) are filled appropriately.");

                //change visibility
                lblContactCellNum.Visible = false;
                txtContactCellNum.Visible = false;
                lblContactEmail.Visible = false;
                txtContactEmail.Visible = false;
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize message variable
                string strMessage;

                //clear any potential existing names in list box
                lbToday.Items.Clear();

                //loop through all existing names and check for birthday
                for (int i = 0; i < iCurrentIndex; i++)
                {
                    //check if day and month match with today
                    if ((contactArray[i].day == DateTime.Today.Day) && (contactArray[i].month == DateTime.Today.Month))
                    {
                        if (contactArray[i].year != DateTime.Today.Year)
                        {
                            //create message with name and age
                            strMessage = contactArray[i].firstName + " " + contactArray[i].lastName + " turns " + (DateTime.Today.Year - contactArray[i].year).ToString() + " years old today!";
                        } else
                        {
                            //create born message
                            strMessage = contactArray[i].firstName + " " + contactArray[i].lastName + " was born today!";
                        }
                        
                        //add to listbox
                        lbToday.Items.Add(strMessage);
                    }
                }
            }
            catch
            {
                //error message
                MessageBox.Show("Something went wrong. Try again.");

                //clear list box
                lbToday.Items.Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize variables
                string strFirstName, strLastName;

                //set variables to input
                strFirstName = txtEditFirstName.Text.Trim();
                strLastName = txtEditLastName.Text.Trim();

                if (!String.IsNullOrEmpty(strFirstName) && !String.IsNullOrEmpty(strLastName))
                {
                    //find index of person
                    iSelectedIndex = FindPerson(strFirstName, strLastName);
                } else
                {
                    //error message
                    MessageBox.Show("Please ensure that the names entered are not empty.");

                    //exit
                    return;
                }

                //check that person exists in database
                if (iSelectedIndex != -1)
                {
                    //make labels, textboxes, date-time picker, and buttons visible
                    lblEditBirthday.Visible = true;
                    lblEditCellNum.Visible = true;
                    lblEditEmail.Visible = true;
                    txtEditCellNum.Visible = true;
                    txtEditEmail.Visible = true;
                    dtpEditBirthday.Visible = true;
                    btnSave.Visible = true;
                    btnCancel.Visible = true;

                    //make name textboxes and edit/delete buttons unchangeable
                    txtEditFirstName.ReadOnly = true;
                    txtEditLastName.ReadOnly = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;

                    //output values from array
                    txtEditEmail.Text = contactArray[iSelectedIndex].emailAddress;
                    txtEditCellNum.Text = contactArray[iSelectedIndex].cellNum.ToString();
                    dtpEditBirthday.Value = new DateTime(contactArray[iSelectedIndex].year, contactArray[iSelectedIndex].month, contactArray[iSelectedIndex].day);

                    //change tabs to be unusable
                    tabAdd.Enabled = false;
                    tabBirthday.Enabled = false;
                    tabContact.Enabled = false;
                    tabToday.Enabled = false;
                }
                else
                {
                    //error message
                    MessageBox.Show("This person does not exist in the database and can therefore not be edited. Please check spelling.");

                    //exit
                    return;
                }
            }
            catch
            {
                //error message for input
                MessageBox.Show("Please input appropriate first and last names.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //clear text entered
                txtEditCellNum.Clear();
                txtEditEmail.Clear();
                dtpEditBirthday.ResetText();

                //stop showing editable items
                lblEditEmail.Visible = false;
                lblEditCellNum.Visible = false;
                lblEditBirthday.Visible = false;
                txtEditEmail.Visible = false;
                txtEditCellNum.Visible = false;
                dtpEditBirthday.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;

                //set edit-search area to be usable
                txtEditFirstName.ReadOnly = false;
                txtEditLastName.ReadOnly = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //make tabs usable
                tabAdd.Enabled = true;
                tabBirthday.Enabled = true;
                tabContact.Enabled = true;
                tabToday.Enabled = true;
            }
            catch
            {
                //error message
                MessageBox.Show("Seems like something went wrong. Please try again.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize variables
                string strEmailAddress;
                long lCellNum;
                int iYear, iMonth, iDay;

                //set variables to input
                strEmailAddress = txtEditEmail.Text;
                lCellNum = Convert.ToInt64(txtEditCellNum.Text);
                iYear = dtpEditBirthday.Value.Year;
                iMonth = dtpEditBirthday.Value.Month;
                iDay = dtpEditBirthday.Value.Day;

                //check to ensure strings are not empty
                if (String.IsNullOrEmpty(strEmailAddress))
                {
                    //error message in case strings are empty
                    MessageBox.Show("Please ensure that the Email Address field is filled.");

                    //exit
                    return;
                }

                //check that email is properly formatted
                if (!strEmailAddress.Contains("@") || !strEmailAddress.Contains("."))
                {
                    //error message that email is improperly formatted
                    MessageBox.Show("Please ensure that the email is properly formatted with an @ symbol and a dot.");

                    //exit
                    return;
                }

                //check that cell number is correct
                if (lCellNum > 9999999999)
                {
                    //error message in case cell number is incorrect
                    MessageBox.Show("Please ensure that the Cell Number is in the 9-digit format, including area code, with no dashes or parentheses.");

                    //exit
                    return;
                }

                //check that birthday is not in the future
                if (iYear > DateTime.Today.Year || (iYear == DateTime.Today.Year && iMonth > DateTime.Today.Month) || (iYear == DateTime.Today.Year && iMonth == DateTime.Today.Month && iDay > DateTime.Today.Day))
                {
                    //error message in case birthday is in future
                    MessageBox.Show("Please ensure the birthday is not in the future.");

                    //exit
                    return;
                }

                //send input to array
                contactArray[iSelectedIndex].emailAddress = txtEditEmail.Text;
                contactArray[iSelectedIndex].cellNum = Convert.ToInt64(txtEditCellNum.Text);
                contactArray[iSelectedIndex].day = dtpEditBirthday.Value.Day;
                contactArray[iSelectedIndex].month = dtpEditBirthday.Value.Month;
                contactArray[iSelectedIndex].year = dtpEditBirthday.Value.Year;
                
                //set edit menu to invisible
                lblEditEmail.Visible = false;
                lblEditCellNum.Visible = false;
                lblEditBirthday.Visible = false;
                txtEditEmail.Visible = false;
                txtEditCellNum.Visible = false;
                dtpEditBirthday.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;

                //set edit-search area to be usable
                txtEditFirstName.ReadOnly = false;
                txtEditLastName.ReadOnly = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                //make tabs usable
                tabAdd.Enabled = true;
                tabBirthday.Enabled = true;
                tabContact.Enabled = true;
                tabToday.Enabled = true;

                //clear saved input
                txtEditFirstName.Clear();
                txtEditLastName.Clear();
                txtEditCellNum.Clear();
                txtEditEmail.Clear();
                dtpEditBirthday.ResetText();
            }
            catch
            {
                //error message
                MessageBox.Show("Please check the inputted values. The email must include an @ and a dot. The cell number must be 9 digits long and can only consist of numbers.");
            }
        }

        private void saveToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize save file dialog
                SaveFileDialog sfd = new SaveFileDialog();

                //set filter
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|(*.*)";
                sfd.FileName = "contact-data.txt";

                //check that location has been set (no cancel)
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //create text-writer for output
                    TextWriter tw = new StreamWriter(sfd.FileName);

                    //ask if password is wanted
                    DialogResult dialogResult = MessageBox.Show("The data will be encrypted.", "Do you want to secure your data with a password?", MessageBoxButtons.YesNo);

                    //check if password is wanted
                    if (dialogResult == DialogResult.Yes)
                    {
                        //initialize password
                        string strPassword;
                        bool secure;

                        //create password form
                        passwd pw = new passwd
                        {
                            labelText = "Please input a password to secure \r\n your data. The password can only \r\n include alphanumeric characters \r\n (no symbols)."
                        };

                        //load and get result from password form
                        DialogResult dialogCheck = pw.ShowDialog();

                        //check in case of cancellation
                        if (dialogCheck == DialogResult.Cancel)
                        {
                            //exit
                            return;
                        }

                        //get input from password form
                        strPassword = pw.input.ToLower();

                        //ensure that password is alphanumeric
                        if (!strPassword.All(Char.IsLetterOrDigit))
                        {
                            //error message
                            MessageBox.Show("The password can only have letters and numbers.");

                            //close text writer
                            tw.Close();

                            //return
                            return;
                        }

                        //set secure status
                        secure = true;

                        //save info to file
                        tw.Write(secure.ToString() + ",");
                        tw.WriteLine(strPassword);

                        for (int i = 0; i < iCurrentIndex; i++)
                        {
                            //write name to file
                            tw.Write(Encrypt(contactArray[i].firstName, strPassword) + ",");
                            tw.Write(Encrypt(contactArray[i].lastName, strPassword) + ",");

                            //write contact info to file
                            tw.Write(contactArray[i].emailAddress + ",");
                            tw.Write(Encrypt(contactArray[i].cellNum.ToString(), strPassword) + ",");

                            //write date to file
                            tw.Write(Encrypt(contactArray[i].day.ToString(), strPassword) + ",");
                            tw.Write(Encrypt(contactArray[i].month.ToString(), strPassword) + ",");
                            tw.WriteLine(Encrypt(contactArray[i].year.ToString(), strPassword));
                        }
                    }
                    else
                    {
                        //initialize secure check
                        bool secure;

                        //set secure status
                        secure = false;

                        //save info to file
                        tw.WriteLine(secure.ToString());

                        for (int i = 0; i < iCurrentIndex; i++)
                        {
                            //write name to file
                            tw.Write(contactArray[i].firstName + ",");
                            tw.Write(contactArray[i].lastName + ",");

                            //write contact info to file
                            tw.Write(contactArray[i].emailAddress + ",");
                            tw.Write(contactArray[i].cellNum.ToString() + ",");

                            //write date to file
                            tw.Write(contactArray[i].day.ToString() + ",");
                            tw.Write(contactArray[i].month.ToString() + ",");
                            tw.WriteLine(contactArray[i].year.ToString());
                        }
                    }

                    //success message
                    MessageBox.Show("Successfully saved!");

                    //close text writer
                    tw.Close();
                }
            }
            catch
            {
                //error message
                MessageBox.Show("There was an issue when saving the file. Please try again.");
            }
        }

        private void openFromTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize open file dialog
                OpenFileDialog ofd = new OpenFileDialog();

                //create input variables
                string strRawInput;
                string[] splitInput;

                //change file dialog filter
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|(*.*)";

                //check that file has been opened (no cancel)
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //create text reader
                    TextReader tr = new StreamReader(ofd.FileName);

                    //initialize secure variable
                    bool secure;
                    string[] strHeader;

                    //check if data is secured
                    strHeader = tr.ReadLine().Split(',');
                    secure = Convert.ToBoolean(strHeader[0]);

                    if (secure)
                    {
                        //initialize input and password
                        string strInput, strPassword;

                        //create password form
                        passwd pw = new passwd
                        {
                            labelText = "What is the password for this data?"
                        };

                        //load and get result from password form
                        DialogResult dialogResult = pw.ShowDialog();

                        //check in case of cancellation
                        if (dialogResult == DialogResult.Cancel)
                        {
                            //cancel message
                            MessageBox.Show("The file was not loaded.");

                            //exit
                            return;
                        }

                        //get input from password form
                        strInput = pw.input.ToLower();

                        //set actual password
                        strPassword = strHeader[1];

                        //check that passwords match
                        if (!String.Equals(strInput, strPassword))
                        {
                            //incorrect message
                            MessageBox.Show("The password was incorrect.");

                            //close reader
                            tr.Close();

                            //exit
                            return;
                        }

                        //reset current array position
                        iCurrentIndex = 0;

                        //check that next line exists
                        while ((strRawInput = tr.ReadLine()) != null)
                        {
                            //split line by commas
                            splitInput = strRawInput.Split(',');

                            //send name to array
                            contactArray[iCurrentIndex].firstName = Decrypt(splitInput[0], strPassword);
                            contactArray[iCurrentIndex].lastName = Decrypt(splitInput[1], strPassword);

                            //send contact info to array
                            contactArray[iCurrentIndex].emailAddress = splitInput[2];
                            contactArray[iCurrentIndex].cellNum = Convert.ToInt64(Decrypt(splitInput[3], strPassword));

                            //set birthday to array
                            contactArray[iCurrentIndex].day = Convert.ToInt32(Decrypt(splitInput[4], strPassword));
                            contactArray[iCurrentIndex].month = Convert.ToInt32(Decrypt(splitInput[5], strPassword));
                            contactArray[iCurrentIndex].year = Convert.ToInt32(Decrypt(splitInput[6], strPassword));

                            //increment current index
                            iCurrentIndex++;
                        }
                    }
                    else
                    {
                        //reset current array position
                        iCurrentIndex = 0;

                        //check that next line exists
                        while ((strRawInput = tr.ReadLine()) != null)
                        {
                            //split line by commas
                            splitInput = strRawInput.Split(',');

                            //send name to array
                            contactArray[iCurrentIndex].firstName = splitInput[0];
                            contactArray[iCurrentIndex].lastName = splitInput[1];

                            //send contact info to array
                            contactArray[iCurrentIndex].emailAddress = splitInput[2];
                            contactArray[iCurrentIndex].cellNum = Convert.ToInt64(splitInput[3]);

                            //set birthday to array
                            contactArray[iCurrentIndex].day = Convert.ToInt32(splitInput[4]);
                            contactArray[iCurrentIndex].month = Convert.ToInt32(splitInput[5]);
                            contactArray[iCurrentIndex].year = Convert.ToInt32(splitInput[6]);

                            //increment current index
                            iCurrentIndex++;
                        }
                    }

                    //success message
                    MessageBox.Show("Successfully loaded!");

                    //close text reader
                    tr.Close();
                }
            }
            catch
            {
                //error message
                MessageBox.Show("There was an issue when opening the file. Please try again.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize variables
                string strFirstName, strLastName;
                int iIndex;

                //set variables to input
                strFirstName = txtEditFirstName.Text.Trim();
                strLastName = txtEditLastName.Text.Trim();

                if (!String.IsNullOrEmpty(strFirstName) && !String.IsNullOrEmpty(strLastName))
                {
                    //find index of person
                    iIndex = FindPerson(strFirstName, strLastName);
                }
                else
                {
                    //error message
                    MessageBox.Show("Please ensure that the names entered are not empty.");

                    //exit
                    return;
                }

                //check that person exists in database
                if (iIndex != -1)
                {
                    //confirm deletion
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + strFirstName + " " + strLastName + "?", "Contact Deletion", MessageBoxButtons.YesNo);

                    //check dialog result
                    if (dialogResult == DialogResult.Yes)
                    {                     
                        //loop through all elements from deleted item to end of items in array
                        for (int i = iIndex; i < iCurrentIndex; i++)
                        {
                            //change next entry to previous entry for names
                            contactArray[i].firstName = contactArray[i + 1].firstName;
                            contactArray[i].lastName = contactArray[i + 1].lastName;

                            //change next entry to previous entry for contact info
                            contactArray[i].emailAddress = contactArray[i + 1].emailAddress;
                            contactArray[i].cellNum = contactArray[i + 1].cellNum;

                            //change next entry to previous entry for birthday
                            contactArray[i].year = contactArray[i + 1].year;
                            contactArray[i].month = contactArray[i + 1].month;
                            contactArray[i].day = contactArray[i + 1].day;
                        }

                        //decrement current index
                        iCurrentIndex--;
                    }
                    else
                    {
                        //message
                        MessageBox.Show(strFirstName + " " + strLastName + " was not deleted from the Address Book.");
                    }
                }
                else
                {
                    //error message
                    MessageBox.Show("This person does not exist in the database and can therefore not be deleted. Please check spelling.");
                }
            }
            catch
            {
                //error message for input
                MessageBox.Show("Please input appropriate first and last names.");
            }
        }

        private void saveToBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize save file dialog
                SaveFileDialog sfd = new SaveFileDialog();

                //set filter
                sfd.Filter = "Address Book Files (*.ab)|*.ab|All Files (*.*)|(*.*)";
                sfd.FileName = "contact-data.ab";

                //check that location has been set (no cancel)
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //create filestream
                    FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

                    //create binary-writer for output
                    BinaryWriter bw = new BinaryWriter(fs);

                    //ask if password is wanted
                    DialogResult dialogResult = MessageBox.Show("The data will be encrypted.", "Do you want to secure your data with a password?", MessageBoxButtons.YesNo);

                    //check if password is wanted
                    if (dialogResult == DialogResult.Yes)
                    {
                        //initialize password
                        string strPassword;
                        bool secure;

                        //create password form
                        passwd pw = new passwd
                        {
                            labelText = "Please input a password to secure \r\n your data. The password can only \r\n include alphanumeric characters \r\n (no symbols)."
                        };

                        //load and get result from password form
                        DialogResult dialogCheck = pw.ShowDialog();

                        //check in case of cancellation
                        if (dialogCheck == DialogResult.Cancel)
                        {
                            //exit
                            return;
                        }

                        //get input from password form
                        strPassword = pw.input.ToLower();

                        //ensure that password is alphanumeric
                        if (!strPassword.All(Char.IsLetterOrDigit))
                        {
                            //error message
                            MessageBox.Show("The password can only have letters and numbers.");

                            //flush binary writer
                            bw.Flush();

                            //close binary writer
                            bw.Close();

                            //return
                            return;
                        }

                        //set secure status
                        secure = true;

                        //save info to file
                        bw.Write(secure);
                        bw.Write(strPassword);

                        for (int i = 0; i < iCurrentIndex; i++)
                        {
                            //write name to file
                            bw.Write(Encrypt(contactArray[i].firstName, strPassword));
                            bw.Write(Encrypt(contactArray[i].lastName, strPassword));

                            //write contact info to file
                            bw.Write(contactArray[i].emailAddress);
                            bw.Write(contactArray[i].cellNum);

                            //write date to file
                            bw.Write(contactArray[i].day);
                            bw.Write(contactArray[i].month);
                            bw.Write(contactArray[i].year);
                        }
                    }
                    else
                    {
                        //initialize secure check
                        bool secure;

                        //set secure status
                        secure = false;

                        //save info to file
                        bw.Write(secure);

                        for (int i = 0; i < iCurrentIndex; i++)
                        {
                            //write name to file
                            bw.Write(contactArray[i].firstName);
                            bw.Write(contactArray[i].lastName);

                            //write contact info to file
                            bw.Write(contactArray[i].emailAddress);
                            bw.Write(contactArray[i].cellNum);

                            //write date to file
                            bw.Write(contactArray[i].day);
                            bw.Write(contactArray[i].month);
                            bw.Write(contactArray[i].year);
                        }
                    }

                    //success message
                    MessageBox.Show("Successfully saved!");

                    //flush binary writer
                    bw.Flush();

                    //close binary writer
                    bw.Close();
                }
            }
            catch
            {
                //error message
                MessageBox.Show("There was an issue when saving the file. Please try again.");
            }
        }

        private void openFromBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize open file dialog
                OpenFileDialog ofd = new OpenFileDialog();

                //change file dialog filter
                ofd.Filter = "Address Book Files (*ab)|*.ab|All Files (*.*)|(*.*)";

                //check that file has been opened (no cancel)
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //initialize variables
                    long length;
                    bool secure;

                    //create filestream
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

                    //create text reader
                    BinaryReader br = new BinaryReader(fs);

                    //check if data is secured
                    secure = br.ReadBoolean();

                    if (secure)
                    {
                        //initialize input and password
                        string strInput, strPassword;

                        //create password form
                        passwd pw = new passwd
                        {
                            labelText = "What is the password for this data?"
                        };

                        //load and get result from password form
                        DialogResult dialogResult = pw.ShowDialog();

                        //check in case of cancellation
                        if (dialogResult == DialogResult.Cancel)
                        {
                            //cancel message
                            MessageBox.Show("The file was not loaded.");

                            //exit
                            return;
                        }

                        //get input from password form
                        strInput = pw.input.ToLower();

                        //set actual password
                        strPassword = br.ReadString().ToLower();

                        //check that passwords match
                        if (!String.Equals(strInput, strPassword))
                        {
                            //incorrect message
                            MessageBox.Show("The password was incorrect.");

                            //close reader
                            br.Close();

                            //exit
                            return;
                        }

                        //reset current array position
                        iCurrentIndex = 0;

                        //set length
                        length = br.BaseStream.Length;

                        //check that next line exists
                        while (fs.Position < length)
                        {

                            //send name to array
                            contactArray[iCurrentIndex].firstName = Decrypt(br.ReadString(), strPassword);
                            contactArray[iCurrentIndex].lastName = Decrypt(br.ReadString(), strPassword);

                            //send contact info to array
                            contactArray[iCurrentIndex].emailAddress = br.ReadString();
                            contactArray[iCurrentIndex].cellNum = br.ReadInt64();

                            //set birthday to array
                            contactArray[iCurrentIndex].day = br.ReadInt32();
                            contactArray[iCurrentIndex].month = br.ReadInt32();
                            contactArray[iCurrentIndex].year = br.ReadInt32();

                            //increment current index
                            iCurrentIndex++;
                        }
                    }
                    else
                    {
                        //reset current array position
                        iCurrentIndex = 0;

                        //set length
                        length = br.BaseStream.Length;

                        //check that next line exists
                        while (fs.Position < length)
                        {

                            //send name to array
                            contactArray[iCurrentIndex].firstName = br.ReadString();
                            contactArray[iCurrentIndex].lastName = br.ReadString();

                            //send contact info to array
                            contactArray[iCurrentIndex].emailAddress = br.ReadString();
                            contactArray[iCurrentIndex].cellNum = br.ReadInt64();

                            //set birthday to array
                            contactArray[iCurrentIndex].day = br.ReadInt32();
                            contactArray[iCurrentIndex].month = br.ReadInt32();
                            contactArray[iCurrentIndex].year = br.ReadInt32();

                            //increment current index
                            iCurrentIndex++;
                        }
                    }

                    //success message
                    MessageBox.Show("Successfully loaded!");

                    //close text reader
                    br.Close();
                }
            }
            catch
            {
                //error message
                MessageBox.Show("There was an issue when opening the file. Please try again.");
            }
        }
    }
}
