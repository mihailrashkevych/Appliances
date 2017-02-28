namespace Devices
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.devicesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.loadXmlButton = new System.Windows.Forms.Button();
            this.saveAsXtmlButton = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.voltageComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.devicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 20);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // devicesDataGridView
            // 
            this.devicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicesDataGridView.Location = new System.Drawing.Point(24, 243);
            this.devicesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.devicesDataGridView.Name = "devicesDataGridView";
            this.devicesDataGridView.ReadOnly = true;
            this.devicesDataGridView.Size = new System.Drawing.Size(707, 352);
            this.devicesDataGridView.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(24, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(24, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 35);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(242, 200);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(103, 35);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(133, 200);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 35);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(200, 603);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(170, 35);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear table";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // loadXmlButton
            // 
            this.loadXmlButton.Location = new System.Drawing.Point(376, 603);
            this.loadXmlButton.Name = "loadXmlButton";
            this.loadXmlButton.Size = new System.Drawing.Size(170, 35);
            this.loadXmlButton.TabIndex = 7;
            this.loadXmlButton.Text = "Load XML";
            this.loadXmlButton.UseVisualStyleBackColor = true;
            this.loadXmlButton.Click += new System.EventHandler(this.loadXmlButton_Click);
            // 
            // saveAsXtmlButton
            // 
            this.saveAsXtmlButton.Location = new System.Drawing.Point(24, 603);
            this.saveAsXtmlButton.Name = "saveAsXtmlButton";
            this.saveAsXtmlButton.Size = new System.Drawing.Size(170, 35);
            this.saveAsXtmlButton.TabIndex = 6;
            this.saveAsXtmlButton.Text = "Save as XML";
            this.saveAsXtmlButton.UseVisualStyleBackColor = true;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(242, 43);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(199, 26);
            this.weightTextBox.TabIndex = 10;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(238, 20);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(59, 20);
            this.weightLabel.TabIndex = 9;
            this.weightLabel.Text = "Weight";
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(24, 97);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(199, 26);
            this.powerTextBox.TabIndex = 12;
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(20, 74);
            this.powerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(53, 20);
            this.powerLabel.TabIndex = 11;
            this.powerLabel.Text = "Power";
            // 
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Location = new System.Drawing.Point(238, 74);
            this.voltageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(64, 20);
            this.voltageLabel.TabIndex = 13;
            this.voltageLabel.Text = "Voltage";
            // 
            // voltageComboBox
            // 
            this.voltageComboBox.FormattingEnabled = true;
            this.voltageComboBox.Items.AddRange(new object[] {
            "380",
            "220"});
            this.voltageComboBox.Location = new System.Drawing.Point(242, 95);
            this.voltageComboBox.Name = "voltageComboBox";
            this.voltageComboBox.Size = new System.Drawing.Size(199, 28);
            this.voltageComboBox.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 650);
            this.Controls.Add(this.voltageComboBox);
            this.Controls.Add(this.voltageLabel);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loadXmlButton);
            this.Controls.Add(this.saveAsXtmlButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.devicesDataGridView);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Device";
            ((System.ComponentModel.ISupportInitialize)(this.devicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView devicesDataGridView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button loadXmlButton;
        private System.Windows.Forms.Button saveAsXtmlButton;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.ComboBox voltageComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

