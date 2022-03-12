namespace TransportationHub_VeronikaValeva_AssesmentWeek5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer RideTimer;
            this.tbcTransportationHub = new System.Windows.Forms.TabControl();
            this.tbpVehicle = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.lblChooseVehicle = new System.Windows.Forms.Label();
            this.cbbChoseVehicle = new System.Windows.Forms.ComboBox();
            this.btnEditVehicleSpec = new System.Windows.Forms.Button();
            this.gbViewVehicles = new System.Windows.Forms.GroupBox();
            this.btnUnavailableVehicles = new System.Windows.Forms.Button();
            this.btnAllVehicles = new System.Windows.Forms.Button();
            this.btnAvalableVehicles = new System.Windows.Forms.Button();
            this.lbxVehicles = new System.Windows.Forms.ListBox();
            this.gbAddVehicle = new System.Windows.Forms.GroupBox();
            this.btnLoadVehicle = new System.Windows.Forms.Button();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.lblAmThree = new System.Windows.Forms.Label();
            this.txbVolume = new System.Windows.Forms.TextBox();
            this.lblAmTwo = new System.Windows.Forms.Label();
            this.cbbAmountPassengers = new System.Windows.Forms.ComboBox();
            this.lblAmOne = new System.Windows.Forms.Label();
            this.btnAddvehicle = new System.Windows.Forms.Button();
            this.txbBrandAndModel = new System.Windows.Forms.TextBox();
            this.txbLicensePlate = new System.Windows.Forms.TextBox();
            this.txbGasUsagePerKm = new System.Windows.Forms.TextBox();
            this.cbbTypeOfVehicle = new System.Windows.Forms.ComboBox();
            this.lblGasUsage = new System.Windows.Forms.Label();
            this.lblBrandAndModel = new System.Windows.Forms.Label();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.lblTypeOfVehicle = new System.Windows.Forms.Label();
            this.tbpRide = new System.Windows.Forms.TabPage();
            this.gbCompletedRides = new System.Windows.Forms.GroupBox();
            this.rtxbCompletedRides = new System.Windows.Forms.RichTextBox();
            this.btnCompletedRides = new System.Windows.Forms.Button();
            this.gbCurrentRides = new System.Windows.Forms.GroupBox();
            this.rtxbCurrentRides = new System.Windows.Forms.RichTextBox();
            this.btnCurrentRides = new System.Windows.Forms.Button();
            this.gbReserveARide = new System.Windows.Forms.GroupBox();
            this.btnSaveRide = new System.Windows.Forms.Button();
            this.btnLoadRide = new System.Windows.Forms.Button();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.cbbAmountOfPersons = new System.Windows.Forms.ComboBox();
            this.btnStartTheRide = new System.Windows.Forms.Button();
            this.txbAmountOfKm = new System.Windows.Forms.TextBox();
            this.txbStartingPrice = new System.Windows.Forms.TextBox();
            this.txbAmountTwo = new System.Windows.Forms.TextBox();
            this.txbAmountOne = new System.Windows.Forms.TextBox();
            this.cbbTypeOfTransportation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmountTwo = new System.Windows.Forms.Label();
            this.lblAmountOne = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            RideTimer = new System.Windows.Forms.Timer(this.components);
            this.tbcTransportationHub.SuspendLayout();
            this.tbpVehicle.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbViewVehicles.SuspendLayout();
            this.gbAddVehicle.SuspendLayout();
            this.tbpRide.SuspendLayout();
            this.gbCompletedRides.SuspendLayout();
            this.gbCurrentRides.SuspendLayout();
            this.gbReserveARide.SuspendLayout();
            this.SuspendLayout();
            // 
            // RideTimer
            // 
            RideTimer.Enabled = true;
            RideTimer.Interval = 2000;
            RideTimer.Tick += new System.EventHandler(this.RideTimer_Tick);
            // 
            // tbcTransportationHub
            // 
            this.tbcTransportationHub.Controls.Add(this.tbpVehicle);
            this.tbcTransportationHub.Controls.Add(this.tbpRide);
            this.tbcTransportationHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcTransportationHub.Location = new System.Drawing.Point(12, 12);
            this.tbcTransportationHub.Name = "tbcTransportationHub";
            this.tbcTransportationHub.SelectedIndex = 0;
            this.tbcTransportationHub.Size = new System.Drawing.Size(1144, 619);
            this.tbcTransportationHub.TabIndex = 0;
            // 
            // tbpVehicle
            // 
            this.tbpVehicle.Controls.Add(this.groupBox4);
            this.tbpVehicle.Controls.Add(this.gbViewVehicles);
            this.tbpVehicle.Controls.Add(this.gbAddVehicle);
            this.tbpVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpVehicle.Location = new System.Drawing.Point(4, 34);
            this.tbpVehicle.Name = "tbpVehicle";
            this.tbpVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVehicle.Size = new System.Drawing.Size(1136, 581);
            this.tbpVehicle.TabIndex = 0;
            this.tbpVehicle.Text = "Vehicle";
            this.tbpVehicle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteVehicle);
            this.groupBox4.Controls.Add(this.lblChooseVehicle);
            this.groupBox4.Controls.Add(this.cbbChoseVehicle);
            this.groupBox4.Controls.Add(this.btnEditVehicleSpec);
            this.groupBox4.Location = new System.Drawing.Point(605, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(507, 173);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit vehicle specifications";
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(193, 126);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(308, 36);
            this.btnDeleteVehicle.TabIndex = 7;
            this.btnDeleteVehicle.Text = "Delete vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // lblChooseVehicle
            // 
            this.lblChooseVehicle.AutoSize = true;
            this.lblChooseVehicle.Location = new System.Drawing.Point(22, 37);
            this.lblChooseVehicle.Name = "lblChooseVehicle";
            this.lblChooseVehicle.Size = new System.Drawing.Size(147, 25);
            this.lblChooseVehicle.TabIndex = 6;
            this.lblChooseVehicle.Text = "Choose vehicle";
            // 
            // cbbChoseVehicle
            // 
            this.cbbChoseVehicle.FormattingEnabled = true;
            this.cbbChoseVehicle.Location = new System.Drawing.Point(193, 34);
            this.cbbChoseVehicle.Name = "cbbChoseVehicle";
            this.cbbChoseVehicle.Size = new System.Drawing.Size(308, 33);
            this.cbbChoseVehicle.TabIndex = 5;
            this.cbbChoseVehicle.SelectedIndexChanged += new System.EventHandler(this.cbbChoseVehicle_SelectedIndexChanged);
            this.cbbChoseVehicle.Click += new System.EventHandler(this.cbbChoseVehicle_Click);
            // 
            // btnEditVehicleSpec
            // 
            this.btnEditVehicleSpec.Location = new System.Drawing.Point(193, 84);
            this.btnEditVehicleSpec.Name = "btnEditVehicleSpec";
            this.btnEditVehicleSpec.Size = new System.Drawing.Size(308, 36);
            this.btnEditVehicleSpec.TabIndex = 4;
            this.btnEditVehicleSpec.Text = "Edit vehicle specifications";
            this.btnEditVehicleSpec.UseVisualStyleBackColor = true;
            this.btnEditVehicleSpec.Click += new System.EventHandler(this.btnEditVehicleSpec_Click);
            // 
            // gbViewVehicles
            // 
            this.gbViewVehicles.Controls.Add(this.btnUnavailableVehicles);
            this.gbViewVehicles.Controls.Add(this.btnAllVehicles);
            this.gbViewVehicles.Controls.Add(this.btnAvalableVehicles);
            this.gbViewVehicles.Controls.Add(this.lbxVehicles);
            this.gbViewVehicles.Location = new System.Drawing.Point(605, 6);
            this.gbViewVehicles.Name = "gbViewVehicles";
            this.gbViewVehicles.Size = new System.Drawing.Size(507, 376);
            this.gbViewVehicles.TabIndex = 1;
            this.gbViewVehicles.TabStop = false;
            this.gbViewVehicles.Text = "View vehicles";
            // 
            // btnUnavailableVehicles
            // 
            this.btnUnavailableVehicles.Location = new System.Drawing.Point(322, 264);
            this.btnUnavailableVehicles.Name = "btnUnavailableVehicles";
            this.btnUnavailableVehicles.Size = new System.Drawing.Size(165, 94);
            this.btnUnavailableVehicles.TabIndex = 3;
            this.btnUnavailableVehicles.Text = "Show unavailbale vehicles";
            this.btnUnavailableVehicles.UseVisualStyleBackColor = true;
            this.btnUnavailableVehicles.Click += new System.EventHandler(this.btnUnavailableVehicles_Click);
            // 
            // btnAllVehicles
            // 
            this.btnAllVehicles.Location = new System.Drawing.Point(20, 264);
            this.btnAllVehicles.Name = "btnAllVehicles";
            this.btnAllVehicles.Size = new System.Drawing.Size(135, 94);
            this.btnAllVehicles.TabIndex = 1;
            this.btnAllVehicles.Text = "Show all vehicles";
            this.btnAllVehicles.UseVisualStyleBackColor = true;
            this.btnAllVehicles.Click += new System.EventHandler(this.btnAllVehicles_Click);
            // 
            // btnAvalableVehicles
            // 
            this.btnAvalableVehicles.Location = new System.Drawing.Point(161, 264);
            this.btnAvalableVehicles.Name = "btnAvalableVehicles";
            this.btnAvalableVehicles.Size = new System.Drawing.Size(155, 94);
            this.btnAvalableVehicles.TabIndex = 2;
            this.btnAvalableVehicles.Text = "Show available vehicles";
            this.btnAvalableVehicles.UseVisualStyleBackColor = true;
            this.btnAvalableVehicles.Click += new System.EventHandler(this.btnAvalableVehicles_Click);
            // 
            // lbxVehicles
            // 
            this.lbxVehicles.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbxVehicles.FormattingEnabled = true;
            this.lbxVehicles.ItemHeight = 25;
            this.lbxVehicles.Location = new System.Drawing.Point(20, 29);
            this.lbxVehicles.Name = "lbxVehicles";
            this.lbxVehicles.ScrollAlwaysVisible = true;
            this.lbxVehicles.Size = new System.Drawing.Size(467, 229);
            this.lbxVehicles.TabIndex = 0;
            // 
            // gbAddVehicle
            // 
            this.gbAddVehicle.Controls.Add(this.btnLoadVehicle);
            this.gbAddVehicle.Controls.Add(this.btnSaveVehicle);
            this.gbAddVehicle.Controls.Add(this.txbWeight);
            this.gbAddVehicle.Controls.Add(this.lblAmThree);
            this.gbAddVehicle.Controls.Add(this.txbVolume);
            this.gbAddVehicle.Controls.Add(this.lblAmTwo);
            this.gbAddVehicle.Controls.Add(this.cbbAmountPassengers);
            this.gbAddVehicle.Controls.Add(this.lblAmOne);
            this.gbAddVehicle.Controls.Add(this.btnAddvehicle);
            this.gbAddVehicle.Controls.Add(this.txbBrandAndModel);
            this.gbAddVehicle.Controls.Add(this.txbLicensePlate);
            this.gbAddVehicle.Controls.Add(this.txbGasUsagePerKm);
            this.gbAddVehicle.Controls.Add(this.cbbTypeOfVehicle);
            this.gbAddVehicle.Controls.Add(this.lblGasUsage);
            this.gbAddVehicle.Controls.Add(this.lblBrandAndModel);
            this.gbAddVehicle.Controls.Add(this.lblLicensePlate);
            this.gbAddVehicle.Controls.Add(this.lblTypeOfVehicle);
            this.gbAddVehicle.Location = new System.Drawing.Point(22, 6);
            this.gbAddVehicle.Name = "gbAddVehicle";
            this.gbAddVehicle.Size = new System.Drawing.Size(561, 555);
            this.gbAddVehicle.TabIndex = 0;
            this.gbAddVehicle.TabStop = false;
            this.gbAddVehicle.Text = "Add vehicle";
            // 
            // btnLoadVehicle
            // 
            this.btnLoadVehicle.Location = new System.Drawing.Point(282, 486);
            this.btnLoadVehicle.Name = "btnLoadVehicle";
            this.btnLoadVehicle.Size = new System.Drawing.Size(239, 45);
            this.btnLoadVehicle.TabIndex = 20;
            this.btnLoadVehicle.Text = "Load from text file";
            this.btnLoadVehicle.UseVisualStyleBackColor = true;
            this.btnLoadVehicle.Click += new System.EventHandler(this.btnLoadVehicle_Click);
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(23, 486);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(240, 45);
            this.btnSaveVehicle.TabIndex = 19;
            this.btnSaveVehicle.Text = "Save to text file";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(258, 211);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(278, 30);
            this.txbWeight.TabIndex = 16;
            // 
            // lblAmThree
            // 
            this.lblAmThree.AutoSize = true;
            this.lblAmThree.Location = new System.Drawing.Point(18, 211);
            this.lblAmThree.Name = "lblAmThree";
            this.lblAmThree.Size = new System.Drawing.Size(64, 25);
            this.lblAmThree.TabIndex = 15;
            this.lblAmThree.Text = "label7";
            // 
            // txbVolume
            // 
            this.txbVolume.Location = new System.Drawing.Point(258, 155);
            this.txbVolume.Name = "txbVolume";
            this.txbVolume.Size = new System.Drawing.Size(278, 30);
            this.txbVolume.TabIndex = 14;
            // 
            // lblAmTwo
            // 
            this.lblAmTwo.AutoSize = true;
            this.lblAmTwo.Location = new System.Drawing.Point(18, 155);
            this.lblAmTwo.Name = "lblAmTwo";
            this.lblAmTwo.Size = new System.Drawing.Size(64, 25);
            this.lblAmTwo.TabIndex = 13;
            this.lblAmTwo.Text = "label6";
            // 
            // cbbAmountPassengers
            // 
            this.cbbAmountPassengers.FormattingEnabled = true;
            this.cbbAmountPassengers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbAmountPassengers.Location = new System.Drawing.Point(327, 100);
            this.cbbAmountPassengers.Name = "cbbAmountPassengers";
            this.cbbAmountPassengers.Size = new System.Drawing.Size(209, 33);
            this.cbbAmountPassengers.TabIndex = 12;
            // 
            // lblAmOne
            // 
            this.lblAmOne.AutoSize = true;
            this.lblAmOne.Location = new System.Drawing.Point(18, 100);
            this.lblAmOne.Name = "lblAmOne";
            this.lblAmOne.Size = new System.Drawing.Size(64, 25);
            this.lblAmOne.TabIndex = 11;
            this.lblAmOne.Text = "label5";
            // 
            // btnAddvehicle
            // 
            this.btnAddvehicle.Location = new System.Drawing.Point(258, 419);
            this.btnAddvehicle.Name = "btnAddvehicle";
            this.btnAddvehicle.Size = new System.Drawing.Size(278, 36);
            this.btnAddvehicle.TabIndex = 10;
            this.btnAddvehicle.Text = "Add vehicle";
            this.btnAddvehicle.UseVisualStyleBackColor = true;
            this.btnAddvehicle.Click += new System.EventHandler(this.btnAddvehicle_Click);
            // 
            // txbBrandAndModel
            // 
            this.txbBrandAndModel.Location = new System.Drawing.Point(258, 266);
            this.txbBrandAndModel.Name = "txbBrandAndModel";
            this.txbBrandAndModel.Size = new System.Drawing.Size(278, 30);
            this.txbBrandAndModel.TabIndex = 8;
            // 
            // txbLicensePlate
            // 
            this.txbLicensePlate.Location = new System.Drawing.Point(258, 324);
            this.txbLicensePlate.Name = "txbLicensePlate";
            this.txbLicensePlate.Size = new System.Drawing.Size(278, 30);
            this.txbLicensePlate.TabIndex = 7;
            // 
            // txbGasUsagePerKm
            // 
            this.txbGasUsagePerKm.Location = new System.Drawing.Point(258, 375);
            this.txbGasUsagePerKm.Name = "txbGasUsagePerKm";
            this.txbGasUsagePerKm.Size = new System.Drawing.Size(278, 30);
            this.txbGasUsagePerKm.TabIndex = 6;
            // 
            // cbbTypeOfVehicle
            // 
            this.cbbTypeOfVehicle.FormattingEnabled = true;
            this.cbbTypeOfVehicle.Items.AddRange(new object[] {
            "Car",
            "Van",
            "Truck"});
            this.cbbTypeOfVehicle.Location = new System.Drawing.Point(258, 43);
            this.cbbTypeOfVehicle.Name = "cbbTypeOfVehicle";
            this.cbbTypeOfVehicle.Size = new System.Drawing.Size(278, 33);
            this.cbbTypeOfVehicle.TabIndex = 5;
            this.cbbTypeOfVehicle.SelectedIndexChanged += new System.EventHandler(this.cbbTypeOfVehicle_SelectedIndexChanged);
            // 
            // lblGasUsage
            // 
            this.lblGasUsage.AutoSize = true;
            this.lblGasUsage.Location = new System.Drawing.Point(18, 378);
            this.lblGasUsage.Name = "lblGasUsage";
            this.lblGasUsage.Size = new System.Drawing.Size(177, 25);
            this.lblGasUsage.TabIndex = 3;
            this.lblGasUsage.Text = "Gas usage per km:";
            // 
            // lblBrandAndModel
            // 
            this.lblBrandAndModel.AutoSize = true;
            this.lblBrandAndModel.Location = new System.Drawing.Point(18, 271);
            this.lblBrandAndModel.Name = "lblBrandAndModel";
            this.lblBrandAndModel.Size = new System.Drawing.Size(166, 25);
            this.lblBrandAndModel.TabIndex = 2;
            this.lblBrandAndModel.Text = "Brand and model:";
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(18, 324);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(133, 25);
            this.lblLicensePlate.TabIndex = 1;
            this.lblLicensePlate.Text = "License plate:";
            // 
            // lblTypeOfVehicle
            // 
            this.lblTypeOfVehicle.AutoSize = true;
            this.lblTypeOfVehicle.Location = new System.Drawing.Point(18, 43);
            this.lblTypeOfVehicle.Name = "lblTypeOfVehicle";
            this.lblTypeOfVehicle.Size = new System.Drawing.Size(150, 25);
            this.lblTypeOfVehicle.TabIndex = 0;
            this.lblTypeOfVehicle.Text = "Type of vehicle:";
            // 
            // tbpRide
            // 
            this.tbpRide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbpRide.Controls.Add(this.gbCompletedRides);
            this.tbpRide.Controls.Add(this.gbCurrentRides);
            this.tbpRide.Controls.Add(this.gbReserveARide);
            this.tbpRide.Location = new System.Drawing.Point(4, 34);
            this.tbpRide.Name = "tbpRide";
            this.tbpRide.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRide.Size = new System.Drawing.Size(1136, 581);
            this.tbpRide.TabIndex = 1;
            this.tbpRide.Text = "Ride";
            this.tbpRide.UseVisualStyleBackColor = true;
            // 
            // gbCompletedRides
            // 
            this.gbCompletedRides.Controls.Add(this.rtxbCompletedRides);
            this.gbCompletedRides.Controls.Add(this.btnCompletedRides);
            this.gbCompletedRides.Location = new System.Drawing.Point(568, 299);
            this.gbCompletedRides.Name = "gbCompletedRides";
            this.gbCompletedRides.Size = new System.Drawing.Size(544, 276);
            this.gbCompletedRides.TabIndex = 2;
            this.gbCompletedRides.TabStop = false;
            this.gbCompletedRides.Text = "Completed rides";
            // 
            // rtxbCompletedRides
            // 
            this.rtxbCompletedRides.Location = new System.Drawing.Point(18, 43);
            this.rtxbCompletedRides.Name = "rtxbCompletedRides";
            this.rtxbCompletedRides.Size = new System.Drawing.Size(507, 165);
            this.rtxbCompletedRides.TabIndex = 3;
            this.rtxbCompletedRides.Text = "";
            // 
            // btnCompletedRides
            // 
            this.btnCompletedRides.Location = new System.Drawing.Point(116, 214);
            this.btnCompletedRides.Name = "btnCompletedRides";
            this.btnCompletedRides.Size = new System.Drawing.Size(298, 43);
            this.btnCompletedRides.TabIndex = 2;
            this.btnCompletedRides.Text = "Show completed rides";
            this.btnCompletedRides.UseVisualStyleBackColor = true;
            this.btnCompletedRides.Click += new System.EventHandler(this.btnCompletedRides_Click);
            // 
            // gbCurrentRides
            // 
            this.gbCurrentRides.Controls.Add(this.rtxbCurrentRides);
            this.gbCurrentRides.Controls.Add(this.btnCurrentRides);
            this.gbCurrentRides.Location = new System.Drawing.Point(568, 19);
            this.gbCurrentRides.Name = "gbCurrentRides";
            this.gbCurrentRides.Size = new System.Drawing.Size(544, 274);
            this.gbCurrentRides.TabIndex = 1;
            this.gbCurrentRides.TabStop = false;
            this.gbCurrentRides.Text = "Current rides";
            // 
            // rtxbCurrentRides
            // 
            this.rtxbCurrentRides.Location = new System.Drawing.Point(18, 38);
            this.rtxbCurrentRides.Name = "rtxbCurrentRides";
            this.rtxbCurrentRides.Size = new System.Drawing.Size(507, 172);
            this.rtxbCurrentRides.TabIndex = 2;
            this.rtxbCurrentRides.Text = "";
            // 
            // btnCurrentRides
            // 
            this.btnCurrentRides.Location = new System.Drawing.Point(116, 216);
            this.btnCurrentRides.Name = "btnCurrentRides";
            this.btnCurrentRides.Size = new System.Drawing.Size(298, 43);
            this.btnCurrentRides.TabIndex = 1;
            this.btnCurrentRides.Text = "Show current rides";
            this.btnCurrentRides.UseVisualStyleBackColor = true;
            this.btnCurrentRides.Click += new System.EventHandler(this.btnCurrentRides_Click);
            // 
            // gbReserveARide
            // 
            this.gbReserveARide.Controls.Add(this.btnSaveRide);
            this.gbReserveARide.Controls.Add(this.btnLoadRide);
            this.gbReserveARide.Controls.Add(this.dtEndTime);
            this.gbReserveARide.Controls.Add(this.dtStartTime);
            this.gbReserveARide.Controls.Add(this.cbbAmountOfPersons);
            this.gbReserveARide.Controls.Add(this.btnStartTheRide);
            this.gbReserveARide.Controls.Add(this.txbAmountOfKm);
            this.gbReserveARide.Controls.Add(this.txbStartingPrice);
            this.gbReserveARide.Controls.Add(this.txbAmountTwo);
            this.gbReserveARide.Controls.Add(this.txbAmountOne);
            this.gbReserveARide.Controls.Add(this.cbbTypeOfTransportation);
            this.gbReserveARide.Controls.Add(this.label5);
            this.gbReserveARide.Controls.Add(this.label4);
            this.gbReserveARide.Controls.Add(this.label3);
            this.gbReserveARide.Controls.Add(this.label2);
            this.gbReserveARide.Controls.Add(this.lblAmountTwo);
            this.gbReserveARide.Controls.Add(this.lblAmountOne);
            this.gbReserveARide.Controls.Add(this.label1);
            this.gbReserveARide.Location = new System.Drawing.Point(23, 20);
            this.gbReserveARide.Name = "gbReserveARide";
            this.gbReserveARide.Size = new System.Drawing.Size(525, 556);
            this.gbReserveARide.TabIndex = 0;
            this.gbReserveARide.TabStop = false;
            this.gbReserveARide.Text = "Reserve a ride";
            // 
            // btnSaveRide
            // 
            this.btnSaveRide.Location = new System.Drawing.Point(22, 476);
            this.btnSaveRide.Name = "btnSaveRide";
            this.btnSaveRide.Size = new System.Drawing.Size(240, 45);
            this.btnSaveRide.TabIndex = 20;
            this.btnSaveRide.Text = "Save to text file";
            this.btnSaveRide.UseVisualStyleBackColor = true;
            this.btnSaveRide.Click += new System.EventHandler(this.btnSaveRide_Click);
            // 
            // btnLoadRide
            // 
            this.btnLoadRide.Location = new System.Drawing.Point(268, 476);
            this.btnLoadRide.Name = "btnLoadRide";
            this.btnLoadRide.Size = new System.Drawing.Size(239, 45);
            this.btnLoadRide.TabIndex = 19;
            this.btnLoadRide.Text = "Load from text file";
            this.btnLoadRide.UseVisualStyleBackColor = true;
            this.btnLoadRide.Click += new System.EventHandler(this.btnLoadRide_Click);
            // 
            // dtEndTime
            // 
            this.dtEndTime.Location = new System.Drawing.Point(243, 343);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(264, 30);
            this.dtEndTime.TabIndex = 17;
            this.dtEndTime.Value = new System.DateTime(2021, 3, 20, 0, 0, 0, 0);
            // 
            // dtStartTime
            // 
            this.dtStartTime.Location = new System.Drawing.Point(243, 294);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(264, 30);
            this.dtStartTime.TabIndex = 16;
            this.dtStartTime.Value = new System.DateTime(2021, 3, 20, 0, 0, 0, 0);
            // 
            // cbbAmountOfPersons
            // 
            this.cbbAmountOfPersons.FormattingEnabled = true;
            this.cbbAmountOfPersons.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbAmountOfPersons.Location = new System.Drawing.Point(291, 98);
            this.cbbAmountOfPersons.Name = "cbbAmountOfPersons";
            this.cbbAmountOfPersons.Size = new System.Drawing.Size(216, 33);
            this.cbbAmountOfPersons.TabIndex = 15;
            // 
            // btnStartTheRide
            // 
            this.btnStartTheRide.Location = new System.Drawing.Point(243, 400);
            this.btnStartTheRide.Name = "btnStartTheRide";
            this.btnStartTheRide.Size = new System.Drawing.Size(264, 45);
            this.btnStartTheRide.TabIndex = 14;
            this.btnStartTheRide.Text = "Start the ride";
            this.btnStartTheRide.UseVisualStyleBackColor = true;
            this.btnStartTheRide.Click += new System.EventHandler(this.btnStartTheRide_Click);
            // 
            // txbAmountOfKm
            // 
            this.txbAmountOfKm.Location = new System.Drawing.Point(243, 243);
            this.txbAmountOfKm.Name = "txbAmountOfKm";
            this.txbAmountOfKm.Size = new System.Drawing.Size(264, 30);
            this.txbAmountOfKm.TabIndex = 11;
            // 
            // txbStartingPrice
            // 
            this.txbStartingPrice.Location = new System.Drawing.Point(243, 199);
            this.txbStartingPrice.Name = "txbStartingPrice";
            this.txbStartingPrice.Size = new System.Drawing.Size(264, 30);
            this.txbStartingPrice.TabIndex = 10;
            // 
            // txbAmountTwo
            // 
            this.txbAmountTwo.Location = new System.Drawing.Point(291, 146);
            this.txbAmountTwo.Name = "txbAmountTwo";
            this.txbAmountTwo.Size = new System.Drawing.Size(216, 30);
            this.txbAmountTwo.TabIndex = 9;
            // 
            // txbAmountOne
            // 
            this.txbAmountOne.Location = new System.Drawing.Point(291, 98);
            this.txbAmountOne.Name = "txbAmountOne";
            this.txbAmountOne.Size = new System.Drawing.Size(216, 30);
            this.txbAmountOne.TabIndex = 8;
            // 
            // cbbTypeOfTransportation
            // 
            this.cbbTypeOfTransportation.FormattingEnabled = true;
            this.cbbTypeOfTransportation.Items.AddRange(new object[] {
            "Passengers",
            "Freighter"});
            this.cbbTypeOfTransportation.Location = new System.Drawing.Point(243, 42);
            this.cbbTypeOfTransportation.Name = "cbbTypeOfTransportation";
            this.cbbTypeOfTransportation.Size = new System.Drawing.Size(264, 33);
            this.cbbTypeOfTransportation.TabIndex = 7;
            this.cbbTypeOfTransportation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "End time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Starting time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount of km:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Starting price:";
            // 
            // lblAmountTwo
            // 
            this.lblAmountTwo.AutoSize = true;
            this.lblAmountTwo.Location = new System.Drawing.Point(17, 146);
            this.lblAmountTwo.Name = "lblAmountTwo";
            this.lblAmountTwo.Size = new System.Drawing.Size(0, 25);
            this.lblAmountTwo.TabIndex = 2;
            // 
            // lblAmountOne
            // 
            this.lblAmountOne.AutoSize = true;
            this.lblAmountOne.Location = new System.Drawing.Point(17, 95);
            this.lblAmountOne.Name = "lblAmountOne";
            this.lblAmountOne.Size = new System.Drawing.Size(0, 25);
            this.lblAmountOne.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of transportation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 643);
            this.Controls.Add(this.tbcTransportationHub);
            this.Name = "Form1";
            this.Text = "Transportation Hub";
            this.tbcTransportationHub.ResumeLayout(false);
            this.tbpVehicle.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbViewVehicles.ResumeLayout(false);
            this.gbAddVehicle.ResumeLayout(false);
            this.gbAddVehicle.PerformLayout();
            this.tbpRide.ResumeLayout(false);
            this.gbCompletedRides.ResumeLayout(false);
            this.gbCurrentRides.ResumeLayout(false);
            this.gbReserveARide.ResumeLayout(false);
            this.gbReserveARide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTransportationHub;
        private System.Windows.Forms.TabPage tbpVehicle;
        private System.Windows.Forms.TabPage tbpRide;
        private System.Windows.Forms.GroupBox gbViewVehicles;
        private System.Windows.Forms.Button btnEditVehicleSpec;
        private System.Windows.Forms.Button btnUnavailableVehicles;
        private System.Windows.Forms.Button btnAllVehicles;
        private System.Windows.Forms.Button btnAvalableVehicles;
        private System.Windows.Forms.ListBox lbxVehicles;
        private System.Windows.Forms.GroupBox gbAddVehicle;
        private System.Windows.Forms.Button btnAddvehicle;
        private System.Windows.Forms.TextBox txbBrandAndModel;
        private System.Windows.Forms.TextBox txbLicensePlate;
        private System.Windows.Forms.TextBox txbGasUsagePerKm;
        private System.Windows.Forms.ComboBox cbbTypeOfVehicle;
        private System.Windows.Forms.Label lblGasUsage;
        private System.Windows.Forms.Label lblBrandAndModel;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.Label lblTypeOfVehicle;
        private System.Windows.Forms.GroupBox gbCompletedRides;
        private System.Windows.Forms.GroupBox gbCurrentRides;
        private System.Windows.Forms.GroupBox gbReserveARide;
        private System.Windows.Forms.ComboBox cbbTypeOfTransportation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountTwo;
        private System.Windows.Forms.Label lblAmountOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAmountOfKm;
        private System.Windows.Forms.TextBox txbStartingPrice;
        private System.Windows.Forms.TextBox txbAmountOne;
        private System.Windows.Forms.Button btnStartTheRide;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblChooseVehicle;
        private System.Windows.Forms.ComboBox cbbChoseVehicle;
        private System.Windows.Forms.ComboBox cbbAmountPassengers;
        private System.Windows.Forms.Label lblAmOne;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.Label lblAmThree;
        private System.Windows.Forms.TextBox txbVolume;
        private System.Windows.Forms.Label lblAmTwo;
        private System.Windows.Forms.TextBox txbAmountTwo;
        private System.Windows.Forms.ComboBox cbbAmountOfPersons;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Button btnCompletedRides;
        private System.Windows.Forms.Button btnCurrentRides;
        private System.Windows.Forms.RichTextBox rtxbCompletedRides;
        private System.Windows.Forms.RichTextBox rtxbCurrentRides;
        private System.Windows.Forms.Button btnLoadRide;
        private System.Windows.Forms.Button btnLoadVehicle;
        private System.Windows.Forms.Button btnSaveVehicle;
        private System.Windows.Forms.Button btnSaveRide;
        private System.Windows.Forms.Button btnDeleteVehicle;
    }
}

