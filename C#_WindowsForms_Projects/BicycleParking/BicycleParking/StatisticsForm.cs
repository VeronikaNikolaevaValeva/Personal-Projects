﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleParking
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm(string partialZipCode, BicycleParking BP)
        {
            InitializeComponent();
           foreach(Bicycle b in BP.GetAllRetrievedBicyclesByZipcode(partialZipCode))
            {
                lbxBicycles.Items.Add(b.GetInfo());
            }

        }
    }
}
