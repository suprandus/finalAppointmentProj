﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Appointment.WindowsForms
{
    public partial class frm_GeneralAdminTransactionsHistory : MetroFramework.Forms.MetroForm
    {
        string staff_name = CurrentUser.user_name;
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        public frm_GeneralAdminTransactionsHistory()
        {
            InitializeComponent();
        }

        private void frm_GeneralAdminTransactionsHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
