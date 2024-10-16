using System.Data;

namespace Todooo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		DataTable todoList = new DataTable();
		bool isEditing = false;

		private void Form1_Load(object sender, EventArgs e)
		{
			//create//
			todoList.Columns.Add("title");
			todoList.Columns.Add("description");

			//datagridview//
			toDoListView.DataSource = todoList;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			titleTextBox.Text = "";
			descriptionTextBox.Text = "";
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			isEditing = true;

			titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
			descriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
			}
			catch (Exception ex)
			{

				Console.WriteLine("Error: " + ex);
			}
		}

		private void listButton_Click(object sender, EventArgs e)
		{
			if (isEditing)
			{
				todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"]=titleTextBox.Text;
				todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"]=titleTextBox.Text;
			}
			else
			{
				todoList.Rows.Add(titleTextBox.Text,descriptionTextBox.Text);
			}

			titleTextBox.Text="";
			descriptionTextBox.Text = "";

			isEditing = false; 
		}
	}
}
