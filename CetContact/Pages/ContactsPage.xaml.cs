namespace CetContact.Pages;
using CetContact.Model;

public partial class ContactsPage : ContentPage
{
        List<ContactInfo> contactsList= new List<ContactInfo>();
	public ContactsPage()
	{
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
    }
}