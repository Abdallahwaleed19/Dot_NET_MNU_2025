using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simple_Address_Book
{
    public partial class Simple_Address_Book : Form
    {
        private List<Contact> contacts;

        public Simple_Address_Book()
        {
            InitializeComponent();
            contacts = new List<Contact>();

            // Add some sample data to start with
            contacts.Add(new Contact { Name = "Abdallah Waleed", Email = "abdallah@example.com", Phone = "01012345678" });
            contacts.Add(new Contact { Name = "Mohamed Ali", Email = "mohamed@example.com", Phone = "01298765432" });

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = contacts;
            dgvContacts.Columns["Name"].HeaderText = "Name";
            dgvContacts.Columns["Email"].HeaderText = "Email";
            dgvContacts.Columns["Phone"].HeaderText = "Phone";
        }

        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contact newContact = new Contact
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };

            contacts.Add(newContact);
            RefreshDataGridView();
            ClearTextBoxes();
        }

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                Contact selectedContact = (Contact)dgvContacts.SelectedRows[0].DataBoundItem;
                txtName.Text = selectedContact.Name;
                txtEmail.Text = selectedContact.Email;
                txtPhone.Text = selectedContact.Phone;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Contact selectedContact = (Contact)dgvContacts.SelectedRows[0].DataBoundItem;
            selectedContact.Name = txtName.Text;
            selectedContact.Email = txtEmail.Text;
            selectedContact.Phone = txtPhone.Text;

            RefreshDataGridView();
            MessageBox.Show("Contact updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Contact selectedContact = (Contact)dgvContacts.SelectedRows[0].DataBoundItem;
                contacts.Remove(selectedContact);
                RefreshDataGridView();
                ClearTextBoxes();
            }
        }
    }
}