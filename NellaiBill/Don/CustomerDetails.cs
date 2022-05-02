using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace NellaiBill.Don
{
    public partial class CustomerDetails : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xDonorId;
        GlobalClass globalClass = new GlobalClass();
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            LoadGrid("");
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
        public void LoadGrid(string xFilter)
        {
            string xQry = "select * from candidates order by id desc";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 250;
            dataGridView1.Columns[6].Width = 250;
            dataGridView1.Columns[7].Width = 250;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Find your Account SID and Auth Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = Environment.GetEnvironmentVariable("AC10a275c80f723b7d7049c87905633ad2");
            string authToken = Environment.GetEnvironmentVariable("f7b79284af7977e613ccfd095c368de0");

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Hello there!",
                from: new Twilio.Types.PhoneNumber("whatsapp:+919345493911"),
                to: new Twilio.Types.PhoneNumber("whatsapp:+919578795653")
            );
            Console.WriteLine(message.Sid);
        }
    }
}
