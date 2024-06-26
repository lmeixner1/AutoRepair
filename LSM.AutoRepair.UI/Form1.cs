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

    private DateTime startTime = DateTime.MinValue;

    public Form1()
    {
        InitializeComponent();

        customers.LoadTestCustomers();
        RebindCustomers();

        tmrTime_Tick(this, EventArgs.Empty);

        startTime = DateTime.Now;
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

    private void btnAddAuto_Click(object sender, EventArgs e)
    {
        try
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Make = txtMake.Text;
            vehicle.Model = txtModel.Text;
            vehicle.Year = int.Parse(txtYear.Text);
        }
        catch (InvalidYearException iye) 
        {
            MessageBox.Show(iye.Message);
        }
        catch (FormatException fe)
        {
            MessageBox.Show(fe.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Something really bad happened");
        }
    }

    private void tmrTime_Tick(object sender, EventArgs e)
    {
        TimeSpan sinceStart = DateTime.Now - startTime;
        staTime.Text = sinceStart.ToString("hh\\:mm\\:ss");
        staTime.Text = DateTime.Now.ToString("hh\\:mm\\:ss");
    }
}
