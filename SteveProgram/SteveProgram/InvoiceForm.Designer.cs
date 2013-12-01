namespace ButcherBlock
{
    partial class InvoiceForm
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
            this.form_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customer_name = new System.Windows.Forms.Label();
            this.customer_name_tb = new System.Windows.Forms.TextBox();
            this.customer_address_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_email_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.date_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.license_no_tb = new System.Windows.Forms.TextBox();
            this.customer_phone_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addToFormButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.form_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_menu
            // 
            this.form_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pricesToolStripMenuItem});
            this.form_menu.Location = new System.Drawing.Point(0, 0);
            this.form_menu.Name = "form_menu";
            this.form_menu.Size = new System.Drawing.Size(1858, 40);
            this.form_menu.TabIndex = 0;
            this.form_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.clearToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pricesToolStripMenuItem
            // 
            this.pricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceSheetToolStripMenuItem});
            this.pricesToolStripMenuItem.Name = "pricesToolStripMenuItem";
            this.pricesToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.pricesToolStripMenuItem.Text = "Prices";
            // 
            // priceSheetToolStripMenuItem
            // 
            this.priceSheetToolStripMenuItem.Name = "priceSheetToolStripMenuItem";
            this.priceSheetToolStripMenuItem.Size = new System.Drawing.Size(209, 36);
            this.priceSheetToolStripMenuItem.Text = "Price Sheet";
            this.priceSheetToolStripMenuItem.Click += new System.EventHandler(this.priceSheetToolStripMenuItem_Click);
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.Location = new System.Drawing.Point(12, 61);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(112, 45);
            this.customer_name.TabIndex = 1;
            this.customer_name.Text = "Name:";
            // 
            // customer_name_tb
            // 
            this.customer_name_tb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_tb.Location = new System.Drawing.Point(169, 61);
            this.customer_name_tb.Name = "customer_name_tb";
            this.customer_name_tb.Size = new System.Drawing.Size(403, 50);
            this.customer_name_tb.TabIndex = 2;
            // 
            // customer_address_tb
            // 
            this.customer_address_tb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address_tb.Location = new System.Drawing.Point(169, 137);
            this.customer_address_tb.Name = "customer_address_tb";
            this.customer_address_tb.Size = new System.Drawing.Size(403, 50);
            this.customer_address_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address:";
            // 
            // customer_email_tb
            // 
            this.customer_email_tb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_email_tb.Location = new System.Drawing.Point(169, 207);
            this.customer_email_tb.Name = "customer_email_tb";
            this.customer_email_tb.Size = new System.Drawing.Size(403, 50);
            this.customer_email_tb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // date_tb
            // 
            this.date_tb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_tb.Location = new System.Drawing.Point(882, 61);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(403, 50);
            this.date_tb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(672, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "License No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone:";
            // 
            // license_no_tb
            // 
            this.license_no_tb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.license_no_tb.Location = new System.Drawing.Point(882, 137);
            this.license_no_tb.Name = "license_no_tb";
            this.license_no_tb.Size = new System.Drawing.Size(403, 50);
            this.license_no_tb.TabIndex = 13;
            // 
            // customer_phone_tb
            // 
            this.customer_phone_tb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_phone_tb.Location = new System.Drawing.Point(882, 212);
            this.customer_phone_tb.Name = "customer_phone_tb";
            this.customer_phone_tb.Size = new System.Drawing.Size(403, 50);
            this.customer_phone_tb.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 443);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1788, 101);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(769, 53);
            this.comboBox1.TabIndex = 17;
            // 
            // addToFormButton
            // 
            this.addToFormButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToFormButton.Location = new System.Drawing.Point(882, 325);
            this.addToFormButton.Name = "addToFormButton";
            this.addToFormButton.Size = new System.Drawing.Size(197, 67);
            this.addToFormButton.TabIndex = 18;
            this.addToFormButton.Text = "Add";
            this.addToFormButton.UseVisualStyleBackColor = true;
            this.addToFormButton.Click += new System.EventHandler(this.addToFormButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(20, 400);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 19;
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(152, 36);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 994);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.addToFormButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.customer_phone_tb);
            this.Controls.Add(this.license_no_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.customer_email_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_address_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_name_tb);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.form_menu);
            this.MainMenuStrip = this.form_menu;
            this.Name = "InvoiceForm";
            this.Text = "Butcher Block";
            this.form_menu.ResumeLayout(false);
            this.form_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip form_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label customer_name;
        private System.Windows.Forms.TextBox customer_name_tb;
        private System.Windows.Forms.TextBox customer_address_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_email_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem pricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceSheetToolStripMenuItem;
        private System.Windows.Forms.TextBox date_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox license_no_tb;
        private System.Windows.Forms.TextBox customer_phone_tb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addToFormButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
    }
}

