﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Email.Net.Common;
using Email.Net.Common.Collections;
using Email.Net.Common.Configurations;
using Email.Net.Smtp;

namespace SendWithAuthentificationDemo
{
	public partial class Demo : Form
	{
		public Demo()
		{
			InitializeComponent();
			authentificationType.Items.AddRange(new object[] {
				EAuthenticationType.None,
				EAuthenticationType.Auto,
				EAuthenticationType.Plain,
				EAuthenticationType.CramMD5,
				EAuthenticationType.DigestMD5,
				EAuthenticationType.Login});
			authentificationType.DropDownStyle = ComboBoxStyle.DropDownList;
			authentificationType.SelectedIndex = 5;
			authentificationType.Refresh();
		}

		private void sendMessage_Click(object sender, EventArgs e)
		{
			//Create and send message using any authentification type
			//SMTP client settings
			//URL of host to connect to
			target.Host = hostBox.Text;
			//TCP port for connection
			target.Port = (ushort)portNum.Value;
			//Username to login to the SMTP server
			target.Username = loginBox.Text;
			//Password to login to the SMTP server
			target.Password = passwordBox.Text;
			//Assign authentication 
			target.AuthenticationType = (EAuthenticationType)authentificationType.SelectedItem;
			//Create address and message 
			EmailAddressCollection addressCollection = new EmailAddressCollection();
			addressCollection.Add(new EmailAddress(toBox.Text));
			//Create message
			SmtpMessage message = new SmtpMessage(
				new EmailAddress(fromBox.Text),//Source address
				addressCollection,//Address of the recipient
				subjectBox.Text,//Message subject
				messageBox.Text //Message text
				);
		SendResult result =	target.SendOne(message);//Send message	
		if (result.IsSuccessful)
		{
			MessageBox.Show("Message sent successful!");
		}
		else 
		{
			MessageBox.Show("Message sending failed!");
		}
		}
	}
}