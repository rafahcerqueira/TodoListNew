public class TaskModel
{
	public string Title { get; set; }
	public bool IsCompleted { get; set; }

	public void EditTask(string newTitle)
	{
		Title = newTitle;
	}
}
