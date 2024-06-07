using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewEmployee : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewEmployee()
        {
            InitializeComponent();
        }
        /*private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("emp");
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
