using LSM.AutoRepair.BL;

namespace LSM.AutoRepair.UI;


//OOP Pillars
// 1. Encapsulation -- Package up related data and methods
// 2. inheritance -- Getting stuff for free
// 3. Polymorphism -- 
//**4. Abstraction -- Don't need to konw "how"



public partial class Form1 : Form
{
    //fields
    public CustomerCollection customers = new CustomerCollection();

    public Form1()
    {
        InitializeComponent();

        customers.LoadTestCustomers();
        RebindCustomers();
    }

    public void btnAddCalc_Click(object sender, EventArgs e)
    {
        Customer customer = new Customer();
        customer.FirstName= txtFirstName.Text;
        customer.LastName= txtLastName.Text;
        customer.PhoneNumber= txtPhoneNumber.Text;

        customers.Add(customer);

        RebindCustomers();
        
    }
    public void RebindCustomers()
    {
        lbxCustomer.DataSource = null; // unbind
        lbxCustomer.DataSource = customers; // bind
    }
    public void lbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        Customer? selectedcustomer = lbxCustomer.SelectedItem as Customer;
        if (selectedcustomer != null) 
        { 
            txtFirstName.Text = selectedcustomer.FirstName;
            txtLastName.Text = selectedcustomer.LastName;
            txtPhoneNumber.Text = selectedcustomer.PhoneNumber;

            RebindVehicles(selectedcustomer.vehicles);
        }
    }

    private void RebindVehicles(List<Vehicle> vehicles)
    {
        lbxVehicles.DataSource = null; // unbind
        lbxVehicles.DataSource = vehicles; // rebind
    }
}
