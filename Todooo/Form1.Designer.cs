namespace Todooo
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			titleTextBox = new TextBox();
			descriptionTextBox = new TextBox();
			addButton = new Button();
			updateButton = new Button();
			deleteButton = new Button();
			listButton = new Button();
			toDoListView = new DataGridView();
			((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = Color.White;
			label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(13, 13);
			label1.Name = "label1";
			label1.Size = new Size(775, 41);
			label1.TabIndex = 0;
			label1.Text = "To Do List";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// label2
			// 
			label2.BackColor = SystemColors.ActiveCaption;
			label2.Location = new Point(13, 54);
			label2.Name = "label2";
			label2.Size = new Size(776, 22);
			label2.TabIndex = 1;
			label2.Text = "Title:";
			// 
			// label3
			// 
			label3.BackColor = SystemColors.ActiveCaption;
			label3.Location = new Point(13, 109);
			label3.Name = "label3";
			label3.Size = new Size(776, 22);
			label3.TabIndex = 2;
			label3.Text = "Description:";
			// 
			// titleTextBox
			// 
			titleTextBox.Location = new Point(13, 79);
			titleTextBox.Name = "titleTextBox";
			titleTextBox.Size = new Size(776, 27);
			titleTextBox.TabIndex = 3;
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.Location = new Point(12, 134);
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.Size = new Size(776, 27);
			descriptionTextBox.TabIndex = 4;
			// 
			// addButton
			// 
			addButton.Location = new Point(12, 179);
			addButton.Name = "addButton";
			addButton.Size = new Size(163, 32);
			addButton.TabIndex = 5;
			addButton.Text = "Add";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// updateButton
			// 
			updateButton.Location = new Point(206, 179);
			updateButton.Name = "updateButton";
			updateButton.Size = new Size(163, 32);
			updateButton.TabIndex = 6;
			updateButton.Text = "Update";
			updateButton.UseVisualStyleBackColor = true;
			updateButton.Click += updateButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.Location = new Point(409, 179);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(163, 32);
			deleteButton.TabIndex = 7;
			deleteButton.Text = "Delete";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// listButton
			// 
			listButton.Location = new Point(608, 179);
			listButton.Name = "listButton";
			listButton.Size = new Size(180, 32);
			listButton.TabIndex = 8;
			listButton.Text = "Save";
			listButton.UseVisualStyleBackColor = true;
			listButton.Click += listButton_Click;
			// 
			// toDoListView
			// 
			toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			toDoListView.BackgroundColor = SystemColors.Control;
			toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			toDoListView.Location = new Point(13, 243);
			toDoListView.Name = "toDoListView";
			toDoListView.RowHeadersWidth = 51;
			toDoListView.Size = new Size(775, 185);
			toDoListView.TabIndex = 9;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(toDoListView);
			Controls.Add(listButton);
			Controls.Add(deleteButton);
			Controls.Add(updateButton);
			Controls.Add(addButton);
			Controls.Add(descriptionTextBox);
			Controls.Add(titleTextBox);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox titleTextBox;
		private TextBox descriptionTextBox;
		private Button addButton;
		private Button updateButton;
		private Button deleteButton;
		private Button listButton;
		private DataGridView toDoListView;
	}
}
