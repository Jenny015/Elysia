using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewLateDeliveryAlarm : UserControl
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewLateDeliveryAlarm()
        {
            InitializeComponent();
            dgvLateDelivery.AllowUserToAddRows = false;
            dgvLateDelivery.ReadOnly = true;
            if (StaticVariable.dept == "SD")
            {
                reloadDataGridView(@"SELECT o.orderID, o.orderStatus,
                   5 * (DATEDIFF(CURDATE(), o.orderDate) DIV 7) +
                   MID('0123444401233334012222340111123400001234000123440',
                       7 * WEEKDAY(CURDATE()) + WEEKDAY(o.orderDate) + 1, 1) AS DaysAfterOrderDate
                    FROM `order` o
                    WHERE o.orderStatus = 'Assembled'
                    AND (
                        (o.orderID LIKE 'R%' AND (5 * (DATEDIFF(CURDATE(), o.orderDate) DIV 7) +
                        MID('0123444401233334012222340111123400001234000123440',
                            7 * WEEKDAY(CURDATE()) + WEEKDAY(o.orderDate) + 1, 1)) > 5)
                        OR
                        (o.fromOrder IS NULL AND (5 * (DATEDIFF(CURDATE(), o.orderDate) DIV 7) +
                        MID('0123444401233334012222340111123400001234000123440',
                            7 * WEEKDAY(CURDATE()) + WEEKDAY(o.orderDate) + 1, 1)) > 2)
                    );");
            }
            else
            {
                reloadDataGridView(@"SELECT o.orderID, op.partID, op.orderQty,
                   5 * (DATEDIFF(CURDATE(), o.orderDate) DIV 7) +
                   MID('0123444401233334012222340111123400001234000123440',
                       7 * WEEKDAY(CURDATE()) + WEEKDAY(o.orderDate) + 1, 1) AS DaysAfterOrderDate
                    FROM `order` o
                    JOIN `orderpart` op ON o.orderID = op.orderID
                    WHERE o.orderStatus = 'Processing'
                    AND (
                        (o.orderID LIKE 'R%' AND (5 * (DATEDIFF(CURDATE(), o.orderDate) DIV 7) +
                        MID('0123444401233334012222340111123400001234000123440',
                            7 * WEEKDAY(CURDATE()) + WEEKDAY(o.orderDate) + 1, 1)) > 5)
                        OR
                        (o.fromOrder IS NULL AND (5 * (DATEDIFF(CURDATE(), o.orderDate) DIV 7) +
                        MID('0123444401233334012222340111123400001234000123440',
                            7 * WEEKDAY(CURDATE()) + WEEKDAY(o.orderDate) + 1, 1)) > 2)
                    );");
            }
        }
        private void reloadDataGridView(String query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvLateDelivery.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
