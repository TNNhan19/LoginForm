namespace WIPR
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelStudentID = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelBirthDate = new Label();
            labelGender = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            labelPicture = new Label();
            textBoxStudentID = new TextBox();
            textBoxFName = new TextBox();
            textBoxLName = new TextBox();
            dateTimePickerBDate = new DateTimePicker();
            pictureBoxStudentImage = new PictureBox();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            buttonUploadimage = new Button();
            buttonCancel = new Button();
            buttonAdd = new Button();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).BeginInit();
            SuspendLayout();
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Location = new Point(36, 34);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(82, 20);
            labelStudentID.TabIndex = 0;
            labelStudentID.Text = "Student ID:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(35, 89);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(83, 20);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(36, 135);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(82, 20);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last Name:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(429, 34);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(75, 20);
            labelBirthDate.TabIndex = 3;
            labelBirthDate.Text = "BirthDate:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(429, 86);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(60, 20);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(65, 203);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(53, 20);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Phone:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(53, 271);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(65, 20);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Address:";
            // 
            // labelPicture
            // 
            labelPicture.AutoSize = true;
            labelPicture.Location = new Point(432, 196);
            labelPicture.Name = "labelPicture";
            labelPicture.Size = new Size(57, 20);
            labelPicture.TabIndex = 7;
            labelPicture.Text = "Picture:";
            // 
            // textBoxStudentID
            // 
            textBoxStudentID.Location = new Point(134, 31);
            textBoxStudentID.Name = "textBoxStudentID";
            textBoxStudentID.Size = new Size(249, 27);
            textBoxStudentID.TabIndex = 8;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(134, 86);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(249, 27);
            textBoxFName.TabIndex = 9;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(134, 135);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(249, 27);
            textBoxLName.TabIndex = 10;
            // 
            // dateTimePickerBDate
            // 
            dateTimePickerBDate.Location = new Point(526, 29);
            dateTimePickerBDate.Name = "dateTimePickerBDate";
            dateTimePickerBDate.Size = new Size(250, 27);
            dateTimePickerBDate.TabIndex = 11;
            // 
            // pictureBoxStudentImage
            // 
            pictureBoxStudentImage.Location = new Point(526, 200);
            pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            pictureBoxStudentImage.Size = new Size(202, 139);
            pictureBoxStudentImage.TabIndex = 12;
            pictureBoxStudentImage.TabStop = false;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(526, 84);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 13;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(526, 131);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 14;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // buttonUploadimage
            // 
            buttonUploadimage.Location = new Point(526, 350);
            buttonUploadimage.Name = "buttonUploadimage";
            buttonUploadimage.Size = new Size(202, 29);
            buttonUploadimage.TabIndex = 15;
            buttonUploadimage.Text = "Upload image";
            buttonUploadimage.UseVisualStyleBackColor = true;
            buttonUploadimage.Click += buttonUploadimage_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(65, 350);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(139, 72);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(263, 350);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(139, 72);
            buttonAdd.TabIndex = 17;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(134, 200);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(249, 27);
            textBoxPhone.TabIndex = 18;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(134, 268);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(249, 27);
            textBoxAddress.TabIndex = 19;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhone);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUploadimage);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(pictureBoxStudentImage);
            Controls.Add(dateTimePickerBDate);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFName);
            Controls.Add(textBoxStudentID);
            Controls.Add(labelPicture);
            Controls.Add(labelAddress);
            Controls.Add(labelPhone);
            Controls.Add(labelGender);
            Controls.Add(labelBirthDate);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelStudentID);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            Load += AddStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStudentID;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelBirthDate;
        private Label labelGender;
        private Label labelPhone;
        private Label labelAddress;
        private Label labelPicture;
        private TextBox textBoxStudentID;
        private TextBox textBoxFName;
        private TextBox textBoxLName;
        private DateTimePicker dateTimePickerBDate;
        private PictureBox pictureBoxStudentImage;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Button buttonUploadimage;
        private Button buttonCancel;
        private Button buttonAdd;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
    }
}