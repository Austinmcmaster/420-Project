using ConsignmentShopLibrary;

namespace ConsignmentShop
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        
        private decimal storeProfit = 0;
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingcartListBox.DataSource = cartBinding;

            shoppingcartListBox.DisplayMember = "Display";
            shoppingcartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorsBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
       



        }

        private void SetupData()
        {

            store.Vendors.Add(new Vendor { FirstName ="Bill", LastName = "MCM"});
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a while",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "Revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter",
                Description = "Wizard Stuff",
                Price = 10.10M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Milk",
                Description = "From a Cow",
                Price = 1.10M,
                Owner = store.Vendors[0]
            });

            store.Name = "Livn Life";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListbox.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);



        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach(Item item in shoppingCartData)
            {
                item.Sold= true;
                item.Owner.PaymentDue += item.Price * (decimal)item.Owner.Comission;
                storeProfit += item.Price * (1 - (decimal)item.Owner.Comission);
            }
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            shoppingCartData.Clear();
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);

            StoreProfitValue.Text = string.Format("${0}", storeProfit);
        }
    }
}