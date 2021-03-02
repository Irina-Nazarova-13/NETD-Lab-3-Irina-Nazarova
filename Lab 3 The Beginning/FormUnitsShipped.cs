/*  Program Name: FormUnitsShipped.cs
 *  Author: Irina Nazarova
 *  Date: Feb 24, 2021
 *  Description: This form application will let the user to enter the number of units shipped
 *               fror three employees during the 7 day period. Then the program will calculat e
 *               the average for each employee and the total average.
 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_The_Beginning
{
    public partial class formUnitsShipped : Form
    {
        //Declare two constants to identify the range of entered values
        const int MIN_UNITS = 0;
        const int MAX_UNITS = 5000;

        //Declare two constants to hold number of days and number of employees respectively
        const int NUMBER_OF_DAYS = 7;
        const int NUMBER_OF_EMPLOYEES = 3;

        //Declare an array that will store the number of units shipped for each employee
        int[,] unitsArray = new int[NUMBER_OF_EMPLOYEES, NUMBER_OF_DAYS];

        //Declare a constant VALID to hold an "OK" message
        const string VALID = "OK";
        //Declare a currentEmployee and set its value to 1
        int currentEmployee = 1;
        //Declare a currentDay and set its value to 1
        int currentDay = 1;

        public formUnitsShipped()
        {
            InitializeComponent();

        }
        
        

        /// <summary>
        /// When the "Exit" button is clicked, the form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
        }


        /// <summary>
        /// When the button Calculate is clicked, the text from the textBixInput is displayed
        /// in the textBox for output of a current Employee
        /// Also, when the last value is entered in each category (for 1 employee or for all employees),
        /// the averages are calculated and displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //variable enteredValue will store a raw input from the textBoxInput
            string enteredValue = textBoxInput.Text;
            //declare a variable that will store the entered value that has int data type
            int userInput;
            //If the validation is successfull, the processing continues
            if (ValidateText(enteredValue) == VALID)
            {
                //userInput variable will have a numeric value of the input
                userInput = Int32.Parse(enteredValue);
                //If there were error messages, they are cleared now
                textBoxMessage.Clear();
                //If the first textBox for output is cleared, the entered value goes to the textBoxEmployee1Output
                //This is made (if-else if statements) to identify which textBox will have to take the entered value
                if (textBoxEmployee1Output.Enabled == true)
                {
                    //DisplayInput function is called to display the user's value to the textBoxEmployee1Output
                    DisplayInput(textBoxEmployee1Output, userInput);
                    //currentDay variable is incremented by 1, to identify the new day
                    currentDay += 1;
                    //If 7 values were already entered, the average is displayed
                    if (currentDay == NUMBER_OF_DAYS + 1)
                    {
                        //DisplayAverage function is called to display the average for Employee 1
                        DisplayAverage(textBoxEmployee1Output, textBoxAverageEmployee1);
                        //ChangeFont function is called to put the bold style to the labelEmployee2 and set labelEmployee1 to a Regular Font style
                        ChangeFont(labelEmployee1, labelEmployee2);
                        //The days are reset to the dafault value in order to start fresh with the 2nd employee
                        currentDay = 1;
                        //currentEmployee variable is increased by 1. Now the current employee is Employee 2
                        currentEmployee += 1;
                    }
                    //The labelDay should change to the current day
                    labelDay.Text = "Day " + currentDay.ToString();
                }
                //If the first Employee Output textBox is disabled, all values entered by user will go to the Employee 2 textBox
                else if (textBoxEmployee2Output.Enabled == true)
                {
                    //DisplayInput function is called to display the user's value to the textBoxEmployee2Output
                    DisplayInput(textBoxEmployee2Output, userInput);
                    //currentDay variable is incremented by 1, to identify the new day
                    currentDay += 1;
                    //If 7 values were already entered, the average is displayed
                    if (currentDay == NUMBER_OF_DAYS + 1)
                    {
                        //DisplayAverage function is called to display the average for Employee 2
                        DisplayAverage(textBoxEmployee2Output, textBoxAverageEmployee2);
                        //ChangeFont function is called to put the bold style to the labelEmployee3 and set labelEmployee2 to a Regular Font style
                        ChangeFont(labelEmployee2, labelEmployee3);
                        //The days are reset to the dafault value in order to start fresh with the 3nd employee
                        currentDay = 1;
                        //currentEmployee variable is increased by 1. Now the current employee is Employee 3
                        currentEmployee += 1;
                    }
                    //The labelDay should change to the current day
                    labelDay.Text = "Day " + currentDay.ToString();

                }
                else if (textBoxEmployee3Output.Enabled == true)
                {
                    //DisplayInput function is called to display the user's value to the textBoxEmployee3Output
                    DisplayInput(textBoxEmployee3Output, userInput);
                    //currentDay variable is incremented by 1, to identify the new day
                    currentDay += 1;
                    //The labelDay should change to the current day
                    labelDay.Text = "Day " + currentDay.ToString();
                    //If 7 values were already entered, the average is displayed
                    if (currentDay == NUMBER_OF_DAYS + 1)
                    {
                        //DisplayAverage function is called to display the average for Employee 3
                        DisplayAverage(textBoxEmployee3Output, textBoxAverageEmployee3);
                        //ChangeFont function is called to put the bold style to the labelEmployee1 and set labelEmployee3 to a Regular Font style
                        ChangeFont(labelEmployee3, labelEmployee1);
                        //labelDay will indicate that all data is entered, when the 3rd employee is done
                        labelDay.Text = "Done";
                        //Disable buttonCalculate
                        buttonCalculate.Enabled = false;
                        //Disable the input textbox
                        textBoxInput.Enabled = false;
                        //Set the Focus to the Reset button
                        buttonReset.Focus();
                        //Call the function DisplayTotalAverage to display the average per day
                        DisplayTotalAverage();
                    }

                }
                //After each time the button calculate is pressed and the value is in the output textboxes, the input textbox is cleared
                textBoxInput.Clear();
            }
            //If the value is not entered, the processing does not continue
            else
            {
                //If the values is invalid the error message is displayed explaining why the program failed
                textBoxMessage.Text = ValidateText(enteredValue);
                //The text in the textBoxInput is highlighted for easier modification of the input
                textBoxInput.SelectAll();
            }
        }
        
        /// <summary>
        /// This function will calculate the sum of elements in one row of the unitsArray
        /// This one row contains the data for 1 current employee
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private int SumOFElements(int row)
        {
            //declare the variable sum and set its value to zero
            int sum = 0;
            //Go through the line in the unitsArray (1 line - units in all days for 1 employee)
            for (int i = 0; i < NUMBER_OF_DAYS; i++)
            {
                //Sum the values up, and store the sum in the sum variable
                sum += unitsArray[row, i];
            }
            //return the value of sum
            return sum;
        }

        /// <summary>
        /// This Function Display the average for the current employee and disables the output textbox
        /// </summary>
        /// <param name="textBoxForDisplay"></param>
        /// <param name="labelToChangeStyle1"></param>
        /// <param name="labelToChangeStyle2"></param>
        /// <param name="textBoxAverage"></param>
        private void DisplayAverage(TextBox textBoxOutput, TextBox textBoxAverage)
        {
            //declare the averageValue variable and store the calculated average in it
            float averageValue = ((float)(SumOFElements(currentEmployee - 1)) / NUMBER_OF_DAYS);
            //textBox will display the average for a current employee, the precision is 2 d.p. 
            textBoxAverage.Text = "Average: " + averageValue.ToString("0.00");
            //Since the processing for the current employee is done, disable the output textbox
            textBoxOutput.Enabled = false;
            
        }
        /// <summary>
        /// This function will change the fonts of 2 labels:
        /// The employee that had all the data entered will no longer will have a bold label, the font style is going to be regular
        /// The employee that is the next one is going to have a bold label
        /// </summary>
        /// <param name="labelToChangeStyle1"></param>
        /// <param name="labelToChangeStyle2"></param>
        private void ChangeFont(Label labelToChangeStyle1, Label labelToChangeStyle2)
        {
            //Set the Regular style for the first label
            labelToChangeStyle1.Font = new Font(labelToChangeStyle1.Font, FontStyle.Regular);
            //Set the bold style for the second label
            labelToChangeStyle2.Font = new Font(labelToChangeStyle2.Font, FontStyle.Bold);
        }

        /// <summary>
        /// This function will take the entered value and display it in the output textbox
        /// Also, it will add this value to the appropriate cell in the unitsArray
        /// </summary>
        /// <param name="textBoxOutput"></param>
        /// <param name="value"></param>
        private void DisplayInput(TextBox textBoxOutput, int value)
        {
            //Display the value in the textBoxOutput + go to the next line
            textBoxOutput.Text += value.ToString() + Environment.NewLine;
            //Store this entered value in the appropriate cell in the unitsArray
            unitsArray[currentEmployee - 1, currentDay - 1] = value;
        }

        /// <summary>
        /// This function display the average per day 
        /// It goes through the array, calculates the sum of all the elements and 
        /// divides the sum by the number of days
        /// </summary>
        private void DisplayTotalAverage()
        {
            //declare the sum variable and set its value to 0
            int sum = 0;
            //declare a float variable totalAverage
            float totalAverage;
            //Go through the 2D array
            for (int i = 0; i < NUMBER_OF_EMPLOYEES; i++)
            {
                for (int j = 0; j < NUMBER_OF_DAYS; j++)
                {
                    //Sum up all the values in th earray
                    sum += unitsArray[i, j];
                }
            }
            //totalAverage will now be set to the calculated average for the whole company (3 employees, 21 days)
            totalAverage = (float)sum / (NUMBER_OF_DAYS * NUMBER_OF_EMPLOYEES);
            //Display the value of the totalAverage in the textBoxMessage to 2 d.p.
            textBoxMessage.Text = "Average per Day: " + totalAverage.ToString("0.00");
        }


        /// <summary>
        /// This function will validate the input
        /// If the value is numeric and lies in th eappropriate range, the function will return the "OK" message
        /// If the value is not numeric, the function will return a "The value entered must be Numeric!" message
        /// If the value is numeric and does not belong to the appropriate range, the function will return "The number must be between 0 and 5000" message
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string ValidateText(string value)
        {
            //declare the int variable number
            int number;
            //If the conversion from string to int is successfull, the processing continues
            if (Int32.TryParse(value, out number))
            {
                //If the value lies in the appropriate range, the processing continues
                if (number >= MIN_UNITS && number <= MAX_UNITS)
                {
                    //Return the "OK" message
                    return VALID;
                }
                //If the number does not belong to the appropriate range, th eerror message is returned
                else
                {
                    //Message specifies that the number must be between 0 and 5000 inclusively
                    return "The number must be between 0 and 5000 inclusively";
                }
            }
            //If the conversion failed, the error message is returned
            else
            {
                //The message states that the value entered must be numeeric
                return "The value entered must be Numeric!";
            }

        }
        /// <summary>
        /// When the button Reset is pressed, the form is set to the default (SetDefaults function is called)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            //SetDefaults() function is called
            SetDefaults();
        }

        /// <summary>
        /// This function sets controls to the default state: the textboxes are cleared, 
        /// initial variables are reset, button Enter is in Focus, and textBoxInput is in focus.
        /// Fields that were disabled are enabled.
        /// </summary>
        private void SetDefaults()
        {
            //textBoxMessage is cleared
            textBoxMessage.Clear();
            //textBoxAverageEmployee1 is Cleared
            textBoxAverageEmployee1.Clear();
            //textBoxAverageEmployee2 is Cleared
            textBoxAverageEmployee2.Clear();
            //textBoxAverageEmployee3 is Cleared
            textBoxAverageEmployee3.Clear();
            //textBoxEmployee1Output is Cleared
            textBoxEmployee1Output.Clear();
            //textBoxEmployee2Output is Cleared
            textBoxEmployee2Output.Clear();
            //textBoxEmployee3Output is Cleared
            textBoxEmployee3Output.Clear();
            //textboxInput is Enabled
            textBoxInput.Enabled = true;
            //buttonCalculate is Enabled
            buttonCalculate.Enabled = true;
            //buttonCalculate is in focus
            buttonCalculate.Focus();
            //textBoxEmployee1Output is enabled
            textBoxEmployee1Output.Enabled = true;
            //textBoxEmployee2Output is enabled
            textBoxEmployee2Output.Enabled = true;
            //textBoxEmployee3Output is enabled
            textBoxEmployee3Output.Enabled = true;
            //currentEmployee is set to 1
            currentEmployee = 1;
            //currentDay is set to 1
            currentDay = 1;
            //textBoxInput is in Focus
            textBoxInput.Focus();
            //set labelDay to "Day 1"
            labelDay.Text = "Day 1";
            //Make Employee 1 label bold, unbold label Employee 2, if it is bolded
            ChangeFont(labelEmployee2, labelEmployee1);
            //Unbold label Employee 3, if it is bolded
            ChangeFont(labelEmployee3, labelEmployee1);
        }
    }
}
