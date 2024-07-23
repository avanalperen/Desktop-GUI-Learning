namespace E_Contact
{
    partial class E_Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_Contact));
            pictureBoxLogo = new PictureBox();
            labelContactID = new Label();
            textBoxContactID = new TextBox();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxContactNo = new TextBox();
            labelContactNo = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            dataGridViewContactList = new DataGridView();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(534, 29);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(252, 88);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelContactID
            // 
            labelContactID.AutoSize = true;
            labelContactID.BackColor = Color.Transparent;
            labelContactID.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelContactID.Location = new Point(107, 159);
            labelContactID.Margin = new Padding(3, 20, 3, 3);
            labelContactID.Name = "labelContactID";
            labelContactID.Size = new Size(112, 30);
            labelContactID.TabIndex = 1;
            labelContactID.Text = "Contact ID";
            labelContactID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxContactID
            // 
            textBoxContactID.Font = new Font("Segoe UI", 15.75F);
            textBoxContactID.Location = new Point(225, 159);
            textBoxContactID.Margin = new Padding(3, 20, 3, 3);
            textBoxContactID.Name = "textBoxContactID";
            textBoxContactID.ReadOnly = true;
            textBoxContactID.Size = new Size(230, 35);
            textBoxContactID.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 15.75F);
            textBoxFirstName.Location = new Point(225, 217);
            textBoxFirstName.Margin = new Padding(3, 20, 3, 3);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(230, 35);
            textBoxFirstName.TabIndex = 4;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 15.75F);
            labelFirstName.Location = new Point(106, 217);
            labelFirstName.Margin = new Padding(3, 20, 3, 3);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(113, 30);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "First Name";
            labelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 15.75F);
            textBoxLastName.Location = new Point(225, 275);
            textBoxLastName.Margin = new Padding(3, 20, 3, 3);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(230, 35);
            textBoxLastName.TabIndex = 6;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 15.75F);
            labelLastName.Location = new Point(107, 275);
            labelLastName.Margin = new Padding(3, 20, 3, 3);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(112, 30);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name";
            labelLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxContactNo
            // 
            textBoxContactNo.Font = new Font("Segoe UI", 15.75F);
            textBoxContactNo.Location = new Point(225, 333);
            textBoxContactNo.Margin = new Padding(3, 20, 3, 3);
            textBoxContactNo.Name = "textBoxContactNo";
            textBoxContactNo.Size = new Size(230, 35);
            textBoxContactNo.TabIndex = 8;
            // 
            // labelContactNo
            // 
            labelContactNo.AutoSize = true;
            labelContactNo.BackColor = Color.Transparent;
            labelContactNo.Font = new Font("Segoe UI", 15.75F);
            labelContactNo.Location = new Point(100, 333);
            labelContactNo.Margin = new Padding(3, 20, 3, 3);
            labelContactNo.Name = "labelContactNo";
            labelContactNo.Size = new Size(119, 30);
            labelContactNo.TabIndex = 7;
            labelContactNo.Text = "Contact No";
            labelContactNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 15.75F);
            textBoxAddress.Location = new Point(225, 391);
            textBoxAddress.Margin = new Padding(3, 20, 3, 3);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(230, 94);
            textBoxAddress.TabIndex = 10;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Segoe UI", 15.75F);
            labelAddress.Location = new Point(132, 391);
            labelAddress.Margin = new Padding(3, 20, 3, 3);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(87, 30);
            labelAddress.TabIndex = 9;
            labelAddress.Text = "Address";
            labelAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = Color.Transparent;
            labelGender.Font = new Font("Segoe UI", 15.75F);
            labelGender.Location = new Point(136, 508);
            labelGender.Margin = new Padding(3, 20, 3, 3);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(80, 30);
            labelGender.TabIndex = 11;
            labelGender.Text = "Gender";
            labelGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxGender
            // 
            comboBoxGender.Font = new Font("Segoe UI", 15.75F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Man", "Woman" });
            comboBoxGender.Location = new Point(222, 508);
            comboBoxGender.Margin = new Padding(3, 20, 3, 3);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(230, 38);
            comboBoxGender.TabIndex = 12;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkGreen;
            buttonAdd.Font = new Font("Segoe UI", 15.75F);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(296, 569);
            buttonAdd.Margin = new Padding(3, 20, 20, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 50);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.SteelBlue;
            buttonUpdate.Font = new Font("Segoe UI", 15.75F);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(439, 569);
            buttonUpdate.Margin = new Padding(3, 20, 20, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(120, 50);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Font = new Font("Segoe UI", 15.75F);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(582, 569);
            buttonDelete.Margin = new Padding(3, 20, 20, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 50);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Orange;
            buttonClear.Font = new Font("Segoe UI", 15.75F);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(725, 569);
            buttonClear.Margin = new Padding(3, 20, 20, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(120, 50);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // dataGridViewContactList
            // 
            dataGridViewContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContactList.Location = new Point(497, 217);
            dataGridViewContactList.Name = "dataGridViewContactList";
            dataGridViewContactList.Size = new Size(711, 329);
            dataGridViewContactList.TabIndex = 17;
            dataGridViewContactList.RowHeaderMouseClick += dataGridViewContactList_RowHeaderMouseClick;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.Transparent;
            labelSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelSearch.Location = new Point(497, 159);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(75, 30);
            labelSearch.TabIndex = 18;
            labelSearch.Text = "Search";
            labelSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSearch.Location = new Point(578, 159);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(630, 35);
            textBoxSearch.TabIndex = 19;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1220, 29);
            pictureBox1.Margin = new Padding(20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // E_Contact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 654);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(dataGridViewContactList);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxContactNo);
            Controls.Add(labelContactNo);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxContactID);
            Controls.Add(labelContactID);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "E_Contact";
            Text = "E-Contact";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelContactID;
        private TextBox textBoxContactID;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxContactNo;
        private Label labelContactNo;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private Label labelGender;
        private ComboBox comboBoxGender;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
        private DataGridView dataGridViewContactList;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private PictureBox pictureBox1;
    }
}
