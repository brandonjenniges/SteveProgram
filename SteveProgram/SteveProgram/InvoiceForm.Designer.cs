namespace ButcherBlock
{
    partial class winForm
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customer_name = new System.Windows.Forms.Label();
            this.customer_name_tb = new System.Windows.Forms.TextBox();
            this.customer_phone_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_address_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreview = new System.Windows.Forms.PrintPreviewControl();
            this.form_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_menu
            // 
            this.form_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pricesToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.form_menu.Location = new System.Drawing.Point(0, 0);
            this.form_menu.Name = "form_menu";
            this.form_menu.Size = new System.Drawing.Size(1858, 40);
            this.form_menu.TabIndex = 0;
            this.form_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.reloadPricesToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 42);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(244, 42);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(244, 42);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // reloadPricesToolStripMenuItem
            // 
            this.reloadPricesToolStripMenuItem.Name = "reloadPricesToolStripMenuItem";
            this.reloadPricesToolStripMenuItem.Size = new System.Drawing.Size(244, 42);
            this.reloadPricesToolStripMenuItem.Text = "Reload Data";
            this.reloadPricesToolStripMenuItem.Click += new System.EventHandler(this.reloadPricesToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(244, 42);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pricesToolStripMenuItem
            // 
            this.pricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceSheetToolStripMenuItem});
            this.pricesToolStripMenuItem.Name = "pricesToolStripMenuItem";
            this.pricesToolStripMenuItem.Size = new System.Drawing.Size(102, 42);
            this.pricesToolStripMenuItem.Text = "Prices";
            // 
            // priceSheetToolStripMenuItem
            // 
            this.priceSheetToolStripMenuItem.Name = "priceSheetToolStripMenuItem";
            this.priceSheetToolStripMenuItem.Size = new System.Drawing.Size(233, 42);
            this.priceSheetToolStripMenuItem.Text = "Price Sheet";
            this.priceSheetToolStripMenuItem.Click += new System.EventHandler(this.priceSheetToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(92, 42);
            this.clearToolStripMenuItem.Text = "Clear";
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
            // customer_phone_tb
            // 
            this.customer_phone_tb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_phone_tb.Location = new System.Drawing.Point(169, 137);
            this.customer_phone_tb.Name = "customer_phone_tb";
            this.customer_phone_tb.Size = new System.Drawing.Size(403, 50);
            this.customer_phone_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone:";
            // 
            // customer_address_tb
            // 
            this.customer_address_tb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address_tb.Location = new System.Drawing.Point(169, 207);
            this.customer_address_tb.Name = "customer_address_tb";
            this.customer_address_tb.Size = new System.Drawing.Size(403, 50);
            this.customer_address_tb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreview
            // 
            this.printPreview.Location = new System.Drawing.Point(30, 339);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(443, 441);
            this.printPreview.TabIndex = 8;
            // 
            // winForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1151);
            this.Controls.Add(this.printPreview);
            this.Controls.Add(this.customer_address_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_phone_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_name_tb);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.form_menu);
            this.MainMenuStrip = this.form_menu;
            this.Name = "winForm";
            this.Text = "Butcher Block";
            this.form_menu.ResumeLayout(false);
            this.form_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip form_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label customer_name;
        private System.Windows.Forms.TextBox customer_name_tb;
        private System.Windows.Forms.TextBox customer_phone_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_address_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem reloadPricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewControl printPreview;
        private System.Windows.Forms.ToolStripMenuItem pricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceSheetToolStripMenuItem;
    }
}

