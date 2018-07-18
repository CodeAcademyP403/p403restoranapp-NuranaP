namespace RestoranApp_1
{
    partial class MainForm
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
            this.btn_Admin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.txtx_Price = new System.Windows.Forms.TextBox();
            this.cmbx_products = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbx_categories = new System.Windows.Forms.ComboBox();
            this.txtx_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Basket = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Basket)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(803, 12);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(120, 53);
            this.btn_Admin.TabIndex = 0;
            this.btn_Admin.Text = "Login as Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            //this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_order);
            this.groupBox1.Controls.Add(this.txtx_Price);
            this.groupBox1.Controls.Add(this.cmbx_products);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbx_categories);
            this.groupBox1.Controls.Add(this.txtx_count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(100, 285);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(133, 33);
            this.btn_order.TabIndex = 10;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // txtx_Price
            // 
            this.txtx_Price.Location = new System.Drawing.Point(57, 156);
            this.txtx_Price.Name = "txtx_Price";
            this.txtx_Price.ReadOnly = true;
            this.txtx_Price.Size = new System.Drawing.Size(207, 20);
            this.txtx_Price.TabIndex = 9;
            // 
            // cmbx_products
            // 
            this.cmbx_products.FormattingEnabled = true;
            this.cmbx_products.Location = new System.Drawing.Point(57, 96);
            this.cmbx_products.Name = "cmbx_products";
            this.cmbx_products.Size = new System.Drawing.Size(207, 21);
            this.cmbx_products.TabIndex = 8;
            this.cmbx_products.SelectedIndexChanged += new System.EventHandler(this.cmbx_products_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category:";
            // 
            // cmbx_categories
            // 
            this.cmbx_categories.FormattingEnabled = true;
            this.cmbx_categories.Location = new System.Drawing.Point(57, 41);
            this.cmbx_categories.Name = "cmbx_categories";
            this.cmbx_categories.Size = new System.Drawing.Size(207, 21);
            this.cmbx_categories.TabIndex = 6;
            this.cmbx_categories.SelectedIndexChanged += new System.EventHandler(this.cmbx_categories_SelectedIndexChanged);
            // 
            // txtx_count
            // 
            this.txtx_count.Location = new System.Drawing.Point(57, 220);
            this.txtx_count.Name = "txtx_count";
            this.txtx_count.Size = new System.Drawing.Size(207, 20);
            this.txtx_count.TabIndex = 5;
            this.txtx_count.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // dgv_Basket
            // 
            this.dgv_Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Basket.Location = new System.Drawing.Point(424, 71);
            this.dgv_Basket.Name = "dgv_Basket";
            this.dgv_Basket.Size = new System.Drawing.Size(420, 199);
            this.dgv_Basket.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Price:";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(736, 294);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(15, 15);
            this.lbl_totalPrice.TabIndex = 4;
            this.lbl_totalPrice.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 471);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Basket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Admin);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtx_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.TextBox txtx_Price;
        private System.Windows.Forms.ComboBox cmbx_products;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbx_categories;
        private System.Windows.Forms.DataGridView dgv_Basket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_totalPrice;
    }
}

