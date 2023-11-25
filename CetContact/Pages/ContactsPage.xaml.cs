namespace CetContact.Pages;
using CetContact.Model;
using System.Collections.ObjectModel;

public partial class ContactsPage : ContentPage
{
    public ObservableCollection<ContactInfo> contactsList { get; set; }
public ContactsPage()
	{
        contactsList = new ObservableCollection<ContactInfo>();
		InitializeComponent();
        contactsList.Add(new ContactInfo()
        {
            Name = "Ufuk",
            Email = "ufuk.adanir@boun.edu.tr",
            Adress = "Hisarustu",
            Phone = 5553332211
        }
        );

        contactsList.Add(new ContactInfo() 
        { 
            Name = "Ceyhan/Adana",
            Email = "ceyhan.kosem@alumni.boun.edu.tr",
            Adress = "Hisarustu",
            Phone = 5554443322 
        }
        );
        ContactList.ItemsSource = contactsList;
	}

    private void AddContactButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    private void EditContactButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));
    }

    private void DeleteContactButton_Clicked(object sender, EventArgs e)
    {
        
        if (sender is Button button && button.BindingContext is ContactInfo contactPerson)
        {
            // Remove the contact when the associated button is clicked
            RemoveContact(contactPerson);
        }
    }
    private void RemoveContact(ContactInfo contactPerson)
    {
        contactsList.Remove(contactPerson);
    }
}