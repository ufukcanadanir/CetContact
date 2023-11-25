namespace CetContact.Pages;
using CetContact.Model;
using System.Collections.ObjectModel;

public partial class AddContactPage : ContentPage
{
    private ObservableCollection<ContactInfo> _contactList;

    public AddContactPage()
	{
        ContactsPage contactsPage = new ContactsPage();
        _contactList = contactsPage.contactsList;
        InitializeComponent();
	}

    private void GoBackButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;
        string address = AddressEntry.Text;
        string email = EmailEntry.Text;
        long phone = long.Parse(PhoneNumberEntry.Text);
        _contactList.Add(
            new ContactInfo()
            {
                Name = name,
                Adress = address,
                Email = email,
                Phone = phone,
            });
    }
}