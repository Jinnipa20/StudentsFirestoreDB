using StudentFirestore.Services;
using StudentFirestore.ViewModels;

namespace StudentFirestore;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}