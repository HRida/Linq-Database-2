using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        NorthwindDataContext db = new NorthwindDataContext();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customers = from c in db.Customers select c;
            /* var query1 = from p in db.Products
                         select p; */
            /* var query1 = from p in db.Products
                         select new { p.ProductID, p.ProductName, p.UnitPrice }; */

            /* var query1 = from p in db.Products
                         where p.ProductID == 1
                         select p; */

            /* var query1 = from p in db.Products
                         where p.SupplierID == 5 && p.UnitPrice > 20
                         select p;*/

            /* var query1 = from p in db.Products
                         where p.SupplierID == 5 || p.SupplierID == 6
                         select p; */

           /* var query1 = from p in db.Products
                         orderby p.ProductID //descending
                         select p; */

            /* var query1 = from p in db.Products
                         orderby p.CategoryID,p.UnitPrice //descending
                         select p; */

            /* var query1 = (from p in db.Products
                          select p).Take(10); */

            /* var query1 = (from p in db.Products
                          orderby p.ProductID
                          select p).Take(10); */

            /* var query1 = (from p in db.Products
                          select p.CategoryID).Distinct(); */

            var query1 = from p in db.Products
                         group p by p.CategoryID into g
                         select new {
                             CategoryID = g.Key,
                             NewField = g.Count()
                         }; 

            

            dataGridView1.DataSource = query1.ToList();
        }

    }
}
