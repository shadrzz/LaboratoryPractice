using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryPractice.Views
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }
        private List<int> GenerateRandomId()
        {
            var random = new Random();
            var list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                var id = random.Next(1, 10);
                list.Add(id);
            }
            return list;
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            long record_id = Convert.ToInt64(String.Join("", this.GenerateRandomId()));
        }
    }
}
