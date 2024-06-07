using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewSupplier : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewSupplier()
        {
            InitializeComponent();
        }
        /*private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("Sup");
            filter.Query += filter_Query;
            filter.Show();
        }
        //filter
        private void filter_Query(object sender, EventArgs e)
        {
            reloadDataGridView(filter.queryString);
        }*/
    }
}
