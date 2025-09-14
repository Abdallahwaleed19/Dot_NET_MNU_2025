using System.Drawing;
using System.Windows.Forms;

namespace Simple_Address_Book
{
    partial class Simple_Address_Book
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simple_Address_Book));
            dgvContacts = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // dgvContacts
            // 
            dgvContacts.BackgroundColor = Color.OldLace;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Location = new Point(61, 201);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.ReadOnly = true;
            dgvContacts.RowHeadersWidth = 51;
            dgvContacts.Size = new Size(420, 199);
            dgvContacts.TabIndex = 0;
            dgvContacts.SelectionChanged += dgvContacts_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(78, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add_Contact";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 255, 192);
            btnEdit.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(213, 406);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit_Contact";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(345, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete_Contact";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 27);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(174, 131);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 27);
            txtPhone.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 55);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 94);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 8;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 134);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 9;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 9);
            label4.Name = "label4";
            label4.Size = new Size(187, 35);
            label4.TabIndex = 10;
            label4.Text = "Your Information";
            // 
            // Simple_Address_Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(548, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvContacts);
            Name = "Simple_Address_Book";
            Text = "Simple Address Book";
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContacts;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}