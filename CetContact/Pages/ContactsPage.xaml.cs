namespace CetContact.Pages;
using CetContact.Model;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
        List<ContactInfo> contacts= new List<ContactInfo>();
        // contacts.Add(new ContactInfo("Ufuk","Hisarustu", "ufuk.adanir@boun.edu.tr",5553332211));

        contacts.Add(new ContactInfo()
        {
            Name = "Ufuk",
            Email = "ufuk.adanir@boun.edu.tr",
            Adress = "Hisarustu",
            Phone = 5553332211
        }
        );
        ContactList.ItemsSource = contacts;

        contacts.Add(new ContactInfo() 
        { 
            Name = "Busra",
            Email = "busra.kosem@boun.edu.tr",
            Adress = "Hisarustu",
            Phone = 5554443322 
        }
        );
        ContactList.ItemsSource = contacts;
	}

    private void AddContactButton_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    private void EditContactButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));
    }
}