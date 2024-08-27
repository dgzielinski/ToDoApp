namespace ToDoApp
{
    partial class ToDoApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            ListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(705, 102);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(21, 111);
            label2.Name = "label2";
            label2.Size = new Size(101, 44);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(21, 155);
            label3.Name = "label3";
            label3.Size = new Size(135, 53);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(202, 450);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += button1_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(283, 450);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 4;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(364, 450);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(445, 450);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            ListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListView.BorderStyle = BorderStyle.None;
            ListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListView.Location = new Point(21, 193);
            ListView.Name = "ListView";
            ListView.Size = new Size(696, 251);
            ListView.TabIndex = 7;
            // 
            // ToDoApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 485);
            Controls.Add(ListView);
            Controls.Add(SaveButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ToDoApp";
            Text = "To Do App";
            Load += ToDoApp_Load;
            ((System.ComponentModel.ISupportInitialize)ListView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button SaveButton;
        private DataGridView ListView;
    }
}
