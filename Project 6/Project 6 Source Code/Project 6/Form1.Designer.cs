namespace Project_6
{
    partial class Form1
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
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            middleNameTextBox = new TextBox();
            disciplineNameTextBox = new TextBox();
            disciplineCodeTextBox = new TextBox();
            dataGridView = new DataGridView();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            sortByLastNameButton = new Button();
            sortByDisciplineCodeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(32, 75);
            lastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Фамилия";
            lastNameTextBox.Size = new Size(132, 27);
            lastNameTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(32, 40);
            firstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "Имя";
            firstNameTextBox.Size = new Size(132, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(32, 110);
            middleNameTextBox.Margin = new Padding(3, 4, 3, 4);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.PlaceholderText = "Отчество";
            middleNameTextBox.Size = new Size(132, 27);
            middleNameTextBox.TabIndex = 2;
            // 
            // disciplineNameTextBox
            // 
            disciplineNameTextBox.Location = new Point(271, 75);
            disciplineNameTextBox.Margin = new Padding(3, 4, 3, 4);
            disciplineNameTextBox.Name = "disciplineNameTextBox";
            disciplineNameTextBox.PlaceholderText = "Название дисциплины";
            disciplineNameTextBox.Size = new Size(132, 27);
            disciplineNameTextBox.TabIndex = 3;
            // 
            // disciplineCodeTextBox
            // 
            disciplineCodeTextBox.Location = new Point(271, 40);
            disciplineCodeTextBox.Margin = new Padding(3, 4, 3, 4);
            disciplineCodeTextBox.Name = "disciplineCodeTextBox";
            disciplineCodeTextBox.PlaceholderText = "Код дисциплины";
            disciplineCodeTextBox.Size = new Size(132, 27);
            disciplineCodeTextBox.TabIndex = 4;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(409, 16);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(491, 571);
            dataGridView.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(32, 168);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 31);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(167, 168);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(86, 31);
            editButton.TabIndex = 7;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(302, 168);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(86, 31);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // sortByLastNameButton
            // 
            sortByLastNameButton.Location = new Point(32, 252);
            sortByLastNameButton.Margin = new Padding(3, 4, 3, 4);
            sortByLastNameButton.Name = "sortByLastNameButton";
            sortByLastNameButton.Size = new Size(283, 31);
            sortByLastNameButton.TabIndex = 9;
            sortByLastNameButton.Text = "Отсортировать по Фамилии";
            sortByLastNameButton.UseVisualStyleBackColor = true;
            sortByLastNameButton.Click += SortByLastNameButton_Click;
            // 
            // sortByDisciplineCodeButton
            // 
            sortByDisciplineCodeButton.Location = new Point(32, 326);
            sortByDisciplineCodeButton.Margin = new Padding(3, 4, 3, 4);
            sortByDisciplineCodeButton.Name = "sortByDisciplineCodeButton";
            sortByDisciplineCodeButton.Size = new Size(283, 31);
            sortByDisciplineCodeButton.TabIndex = 10;
            sortByDisciplineCodeButton.Text = "Отсортировать по коду дисциплины";
            sortByDisciplineCodeButton.UseVisualStyleBackColor = true;
            sortByDisciplineCodeButton.Click += SortByDisciplineCodeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(sortByDisciplineCodeButton);
            Controls.Add(sortByLastNameButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView);
            Controls.Add(disciplineCodeTextBox);
            Controls.Add(disciplineNameTextBox);
            Controls.Add(middleNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private TextBox disciplineNameTextBox;
        private TextBox disciplineCodeTextBox;
        private DataGridView dataGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button sortByLastNameButton;
        private Button sortByDisciplineCodeButton;
    }
}
