
namespace Lab_3_The_Beginning
{
    partial class formUnitsShipped
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelEmployee1 = new System.Windows.Forms.Label();
            this.labelEmployee2 = new System.Windows.Forms.Label();
            this.labelEmployee3 = new System.Windows.Forms.Label();
            this.textBoxEmployee1Output = new System.Windows.Forms.TextBox();
            this.textBoxEmployee2Output = new System.Windows.Forms.TextBox();
            this.textBoxEmployee3Output = new System.Windows.Forms.TextBox();
            this.textBoxAverageEmployee1 = new System.Windows.Forms.TextBox();
            this.textBoxAverageEmployee2 = new System.Windows.Forms.TextBox();
            this.textBoxAverageEmployee3 = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTipForTheForm = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDay.Location = new System.Drawing.Point(40, 32);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(64, 31);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Day 1";
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnits.Location = new System.Drawing.Point(40, 82);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(59, 23);
            this.labelUnits.TabIndex = 0;
            this.labelUnits.Text = "&Units: ";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.Location = new System.Drawing.Point(166, 82);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(111, 30);
            this.textBoxInput.TabIndex = 1;
            this.toolTipForTheForm.SetToolTip(this.textBoxInput, "Enter a number of Units Shipped in a day");
            // 
            // labelEmployee1
            // 
            this.labelEmployee1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployee1.Location = new System.Drawing.Point(82, 143);
            this.labelEmployee1.Name = "labelEmployee1";
            this.labelEmployee1.Size = new System.Drawing.Size(107, 38);
            this.labelEmployee1.TabIndex = 3;
            this.labelEmployee1.Text = "Employee 1";
            this.labelEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee2
            // 
            this.labelEmployee2.Location = new System.Drawing.Point(392, 143);
            this.labelEmployee2.Name = "labelEmployee2";
            this.labelEmployee2.Size = new System.Drawing.Size(118, 38);
            this.labelEmployee2.TabIndex = 4;
            this.labelEmployee2.Text = "Employee 2";
            this.labelEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee3
            // 
            this.labelEmployee3.Location = new System.Drawing.Point(713, 143);
            this.labelEmployee3.Name = "labelEmployee3";
            this.labelEmployee3.Size = new System.Drawing.Size(118, 38);
            this.labelEmployee3.TabIndex = 5;
            this.labelEmployee3.Text = "Employee 3";
            this.labelEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmployee1Output
            // 
            this.textBoxEmployee1Output.Location = new System.Drawing.Point(12, 184);
            this.textBoxEmployee1Output.Multiline = true;
            this.textBoxEmployee1Output.Name = "textBoxEmployee1Output";
            this.textBoxEmployee1Output.ReadOnly = true;
            this.textBoxEmployee1Output.Size = new System.Drawing.Size(265, 204);
            this.textBoxEmployee1Output.TabIndex = 2;
            // 
            // textBoxEmployee2Output
            // 
            this.textBoxEmployee2Output.Location = new System.Drawing.Point(326, 184);
            this.textBoxEmployee2Output.Multiline = true;
            this.textBoxEmployee2Output.Name = "textBoxEmployee2Output";
            this.textBoxEmployee2Output.ReadOnly = true;
            this.textBoxEmployee2Output.Size = new System.Drawing.Size(265, 204);
            this.textBoxEmployee2Output.TabIndex = 3;
            // 
            // textBoxEmployee3Output
            // 
            this.textBoxEmployee3Output.Location = new System.Drawing.Point(640, 184);
            this.textBoxEmployee3Output.Multiline = true;
            this.textBoxEmployee3Output.Name = "textBoxEmployee3Output";
            this.textBoxEmployee3Output.ReadOnly = true;
            this.textBoxEmployee3Output.Size = new System.Drawing.Size(265, 204);
            this.textBoxEmployee3Output.TabIndex = 4;
            // 
            // textBoxAverageEmployee1
            // 
            this.textBoxAverageEmployee1.Location = new System.Drawing.Point(12, 410);
            this.textBoxAverageEmployee1.Name = "textBoxAverageEmployee1";
            this.textBoxAverageEmployee1.ReadOnly = true;
            this.textBoxAverageEmployee1.Size = new System.Drawing.Size(265, 30);
            this.textBoxAverageEmployee1.TabIndex = 5;
            this.textBoxAverageEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAverageEmployee2
            // 
            this.textBoxAverageEmployee2.Location = new System.Drawing.Point(326, 410);
            this.textBoxAverageEmployee2.Name = "textBoxAverageEmployee2";
            this.textBoxAverageEmployee2.ReadOnly = true;
            this.textBoxAverageEmployee2.Size = new System.Drawing.Size(265, 30);
            this.textBoxAverageEmployee2.TabIndex = 6;
            this.textBoxAverageEmployee2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAverageEmployee3
            // 
            this.textBoxAverageEmployee3.Location = new System.Drawing.Point(640, 410);
            this.textBoxAverageEmployee3.Name = "textBoxAverageEmployee3";
            this.textBoxAverageEmployee3.ReadOnly = true;
            this.textBoxAverageEmployee3.Size = new System.Drawing.Size(265, 30);
            this.textBoxAverageEmployee3.TabIndex = 7;
            this.textBoxAverageEmployee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(40, 488);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(841, 30);
            this.textBoxMessage.TabIndex = 8;
            this.textBoxMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(40, 546);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(149, 45);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "&Calculate";
            this.toolTipForTheForm.SetToolTip(this.buttonCalculate, "Press \"Calculate\" button to submit the number enetered in the textbox");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(386, 546);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(149, 45);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "&Reset";
            this.toolTipForTheForm.SetToolTip(this.buttonReset, "Press \"Reset\" button to clear the form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(732, 546);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(149, 45);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "&Exit";
            this.toolTipForTheForm.SetToolTip(this.buttonExit, "Press \"Exit\" button to close the form");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // formUnitsShipped
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(927, 621);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxAverageEmployee3);
            this.Controls.Add(this.textBoxAverageEmployee2);
            this.Controls.Add(this.textBoxAverageEmployee1);
            this.Controls.Add(this.textBoxEmployee3Output);
            this.Controls.Add(this.textBoxEmployee2Output);
            this.Controls.Add(this.textBoxEmployee1Output);
            this.Controls.Add(this.labelEmployee3);
            this.Controls.Add(this.labelEmployee2);
            this.Controls.Add(this.labelEmployee1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelUnits);
            this.Controls.Add(this.labelDay);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "&Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelEmployee1;
        private System.Windows.Forms.Label labelEmployee2;
        private System.Windows.Forms.Label labelEmployee3;
        private System.Windows.Forms.TextBox textBoxEmployee1Output;
        private System.Windows.Forms.TextBox textBoxEmployee2Output;
        private System.Windows.Forms.TextBox textBoxEmployee3Output;
        private System.Windows.Forms.TextBox textBoxAverageEmployee1;
        private System.Windows.Forms.TextBox textBoxAverageEmployee2;
        private System.Windows.Forms.TextBox textBoxAverageEmployee3;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTipForTheForm;
    }
}

