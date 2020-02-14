﻿namespace DeepLinking
{
	partial class UserDataDialog
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
			this.columnProperty = new Wisej.Web.DataGridViewColumn();
			this.columnValue = new Wisej.Web.DataGridViewColumn();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.label3 = new Wisej.Web.Label();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.textBoxName = new Wisej.Web.TextBox();
			this.textBoxLastName = new Wisej.Web.TextBox();
			this.comboBoxRole = new Wisej.Web.ComboBox();
			this.dateTimePickerActivation = new Wisej.Web.DateTimePicker();
			this.dateTimePickerExpiration = new Wisej.Web.DateTimePicker();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonOK = new Wisej.Web.Button();
			this.helpTip = new Wisej.Web.HelpTip(this.components);
			this.label6 = new Wisej.Web.Label();
			this.labelID = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// columnProperty
			// 
			this.columnProperty.HeaderText = "Property";
			this.columnProperty.Name = "columnProperty";
			this.columnProperty.Width = 200;
			// 
			// columnValue
			// 
			this.columnValue.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.columnValue.HeaderText = "Value";
			this.columnValue.Name = "columnValue";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 27);
			this.label1.TabIndex = 12;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 27);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(27, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 27);
			this.label3.TabIndex = 4;
			this.label3.Text = "Role";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(27, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 27);
			this.label4.TabIndex = 6;
			this.label4.Text = "Activation Date";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(27, 272);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 27);
			this.label5.TabIndex = 8;
			this.label5.Text = "Expiration Date";
			// 
			// textBoxName
			// 
			this.helpTip.SetHelpTip(this.textBoxName, "Enter the user\'s first name.");
			this.textBoxName.Location = new System.Drawing.Point(238, 83);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(328, 32);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.Watermark = "Enter the name";
			// 
			// textBoxLastName
			// 
			this.helpTip.SetHelpTip(this.textBoxLastName, "Enter the user\'s last name.");
			this.textBoxLastName.Location = new System.Drawing.Point(238, 131);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(328, 32);
			this.textBoxLastName.TabIndex = 3;
			this.textBoxLastName.Watermark = "Enter the last name";
			// 
			// comboBoxRole
			// 
			this.comboBoxRole.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxRole.FormattingEnabled = true;
			this.helpTip.SetHelpTip(this.comboBoxRole, "Select the user\'s role from the list.");
			this.comboBoxRole.Items.AddRange(new object[] {
            "User",
            "Editor",
            "Contributor",
            "Administrator"});
			this.comboBoxRole.Location = new System.Drawing.Point(238, 176);
			this.comboBoxRole.Name = "comboBoxRole";
			this.comboBoxRole.Size = new System.Drawing.Size(328, 34);
			this.comboBoxRole.TabIndex = 5;
			this.comboBoxRole.Watermark = "Select a role";
			// 
			// dateTimePickerActivation
			// 
			this.helpTip.SetHelpTip(this.dateTimePickerActivation, "Select the date the user\'s account was first activated.");
			this.dateTimePickerActivation.Location = new System.Drawing.Point(238, 220);
			this.dateTimePickerActivation.Name = "dateTimePickerActivation";
			this.dateTimePickerActivation.Size = new System.Drawing.Size(328, 34);
			this.dateTimePickerActivation.TabIndex = 7;
			this.dateTimePickerActivation.Value = new System.DateTime(2016, 4, 28, 13, 0, 0, 0);
			// 
			// dateTimePickerExpiration
			// 
			this.helpTip.SetHelpTip(this.dateTimePickerExpiration, "Select the date the user\'s account will automatically expire and get deactivated." +
        "");
			this.dateTimePickerExpiration.InvalidMessage = "The expiration date is invalid. It should be higher than the Activation Date.\r\n";
			this.dateTimePickerExpiration.Location = new System.Drawing.Point(238, 268);
			this.dateTimePickerExpiration.Name = "dateTimePickerExpiration";
			this.dateTimePickerExpiration.Size = new System.Drawing.Size(328, 34);
			this.dateTimePickerExpiration.TabIndex = 9;
			this.dateTimePickerExpiration.Value = new System.DateTime(2016, 4, 28, 13, 0, 0, 0);
			this.dateTimePickerExpiration.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerExpiration_Validating);
			// 
			// buttonCancel
			// 
			this.buttonCancel.AppearanceKey = "button-cancel";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(266, 352);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(130, 47);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.AppearanceKey = "button-ok";
			this.buttonOK.DialogResult = Wisej.Web.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(434, 350);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(134, 49);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "&OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(27, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 27);
			this.label6.TabIndex = 13;
			this.label6.Text = "ID";
			// 
			// labelID
			// 
			this.labelID.Location = new System.Drawing.Point(238, 40);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(22, 27);
			this.labelID.TabIndex = 14;
			this.labelID.Text = "#";
			// 
			// UserDataDialog
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(609, 433);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.dateTimePickerExpiration);
			this.Controls.Add(this.dateTimePickerActivation);
			this.Controls.Add(this.comboBoxRole);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.Margin = new Wisej.Web.Padding(9, 0, 9, 0);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserDataDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "User Data";
			this.Load += new System.EventHandler(this.UserDataDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.DataGridViewColumn columnProperty;
		private Wisej.Web.DataGridViewColumn columnValue;
		private Wisej.Web.Label label1;
		private Wisej.Web.Label label2;
		private Wisej.Web.Label label3;
		private Wisej.Web.Label label4;
		private Wisej.Web.Label label5;
		private Wisej.Web.TextBox textBoxName;
		private Wisej.Web.TextBox textBoxLastName;
		private Wisej.Web.ComboBox comboBoxRole;
		private Wisej.Web.DateTimePicker dateTimePickerActivation;
		private Wisej.Web.DateTimePicker dateTimePickerExpiration;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonOK;
		private Wisej.Web.HelpTip helpTip;
		private Wisej.Web.Label label6;
		private Wisej.Web.Label labelID;
	}
}

