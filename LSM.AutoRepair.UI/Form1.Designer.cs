namespace LSM.AutoRepair.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lbxCustomer = new System.Windows.Forms.ListBox();
            this.btnAddCalc = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.btnAddAuto = new System.Windows.Forms.Button();
            this.lbxVehicles = new System.Windows.Forms.ListBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAutoDel = new System.Windows.Forms.Button();
            this.btnAutoUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(22, 61);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(22, 107);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(-2, 163);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(91, 15);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lbxCustomer
            // 
            this.lbxCustomer.FormattingEnabled = true;
            this.lbxCustomer.ItemHeight = 15;
            this.lbxCustomer.Location = new System.Drawing.Point(203, 53);
            this.lbxCustomer.Name = "lbxCustomer";
            this.lbxCustomer.Size = new System.Drawing.Size(263, 229);
            this.lbxCustomer.TabIndex = 3;
            this.lbxCustomer.SelectedIndexChanged += new System.EventHandler(this.lbxCustomer_SelectedIndexChanged);
            // 
            // btnAddCalc
            // 
            this.btnAddCalc.Location = new System.Drawing.Point(65, 199);
            this.btnAddCalc.Name = "btnAddCalc";
            this.btnAddCalc.Size = new System.Drawing.Size(130, 23);
            this.btnAddCalc.TabIndex = 4;
            this.btnAddCalc.Text = "Add Customer";
            this.btnAddCalc.UseVisualStyleBackColor = true;
            this.btnAddCalc.Click += new System.EventHandler(this.btnAddCalc_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(97, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(97, 155);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(565, 155);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 23);
            this.txtYear.TabIndex = 15;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(565, 99);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 23);
            this.txtModel.TabIndex = 14;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(563, 53);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 23);
            this.txtMake.TabIndex = 13;
            // 
            // btnAddAuto
            // 
            this.btnAddAuto.Location = new System.Drawing.Point(533, 199);
            this.btnAddAuto.Name = "btnAddAuto";
            this.btnAddAuto.Size = new System.Drawing.Size(130, 23);
            this.btnAddAuto.TabIndex = 12;
            this.btnAddAuto.Text = "Add Vehicle";
            this.btnAddAuto.UseVisualStyleBackColor = true;
            this.btnAddAuto.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // lbxVehicles
            // 
            this.lbxVehicles.FormattingEnabled = true;
            this.lbxVehicles.ItemHeight = 15;
            this.lbxVehicles.Location = new System.Drawing.Point(671, 53);
            this.lbxVehicles.Name = "lbxVehicles";
            this.lbxVehicles.Size = new System.Drawing.Size(263, 229);
            this.lbxVehicles.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(490, 163);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 15);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Year:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(490, 107);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(44, 15);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(490, 61);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(36, 15);
            this.lblMake.TabIndex = 8;
            this.lblMake.Text = "Make";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(65, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(65, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAutoDel
            // 
            this.btnAutoDel.Location = new System.Drawing.Point(533, 257);
            this.btnAutoDel.Name = "btnAutoDel";
            this.btnAutoDel.Size = new System.Drawing.Size(130, 23);
            this.btnAutoDel.TabIndex = 18;
            this.btnAutoDel.Text = "btnAutoDelete";
            this.btnAutoDel.UseVisualStyleBackColor = true;
            // 
            // btnAutoUp
            // 
            this.btnAutoUp.Location = new System.Drawing.Point(533, 228);
            this.btnAutoUp.Name = "btnAutoUp";
            this.btnAutoUp.Size = new System.Drawing.Size(132, 23);
            this.btnAutoUp.TabIndex = 19;
            this.btnAutoUp.Text = "Update Auto";
            this.btnAutoUp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 333);
            this.Controls.Add(this.btnAutoUp);
            this.Controls.Add(this.btnAutoDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.btnAddAuto);
            this.Controls.Add(this.lbxVehicles);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnAddCalc);
            this.Controls.Add(this.lbxCustomer);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private ListBox lbxCustomer;
        private Button btnAddCalc;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private TextBox txtYear;
        private TextBox txtModel;
        private TextBox txtMake;
        private Button btnAddAuto;
        private ListBox lbxVehicles;
        private Label lblYear;
        private Label lblModel;
        private Label lblMake;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAutoDel;
        private Button btnAutoUp;
    }
}