namespace Cinemagic
{
    partial class Bookingstbl
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
            this.sale = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtseats = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtbookings = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemagicDBDataSet = new Cinemagic.CinemagicDBDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bOOKINGTableAdapter = new Cinemagic.CinemagicDBDataSetTableAdapters.BOOKINGTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.cinemagicDBDataSet1 = new Cinemagic.CinemagicDBDataSet1();
            this.cinemagicDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTicketCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsSaleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmovie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemagicDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemagicDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemagicDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(132, 331);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(200, 20);
            this.sale.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "TicketSaleDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "NumberOfSeats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Total TicketCost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Bookings";
            // 
            // txtseats
            // 
            this.txtseats.Location = new System.Drawing.Point(132, 277);
            this.txtseats.Name = "txtseats";
            this.txtseats.Size = new System.Drawing.Size(200, 20);
            this.txtseats.TabIndex = 33;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(132, 209);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(200, 20);
            this.txtcost.TabIndex = 32;
            // 
            // txtbookings
            // 
            this.txtbookings.Location = new System.Drawing.Point(132, 40);
            this.txtbookings.Name = "txtbookings";
            this.txtbookings.Size = new System.Drawing.Size(200, 20);
            this.txtbookings.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.movieIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.totalTicketCostDataGridViewTextBoxColumn,
            this.numberOfSeatsDataGridViewTextBoxColumn,
            this.ticketsSaleDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKINGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(398, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 324);
            this.dataGridView1.TabIndex = 39;
            // 
            // bOOKINGBindingSource
            // 
            this.bOOKINGBindingSource.DataMember = "BOOKING";
            this.bOOKINGBindingSource.DataSource = this.cinemagicDBDataSet;
            // 
            // cinemagicDBDataSet
            // 
            this.cinemagicDBDataSet.DataSetName = "CinemagicDBDataSet";
            this.cinemagicDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(599, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 52);
            this.button4.TabIndex = 30;
            this.button4.Text = "Connect";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 46);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bOOKINGTableAdapter
            // 
            this.bOOKINGTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(740, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 52);
            this.button5.TabIndex = 40;
            this.button5.Text = "Display Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cinemagicDBDataSet1
            // 
            this.cinemagicDBDataSet1.DataSetName = "CinemagicDBDataSet1";
            this.cinemagicDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinemagicDBDataSet1BindingSource
            // 
            this.cinemagicDBDataSet1BindingSource.DataSource = this.cinemagicDBDataSet1;
            this.cinemagicDBDataSet1BindingSource.Position = 0;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // totalTicketCostDataGridViewTextBoxColumn
            // 
            this.totalTicketCostDataGridViewTextBoxColumn.DataPropertyName = "Total_TicketCost";
            this.totalTicketCostDataGridViewTextBoxColumn.HeaderText = "Total_TicketCost";
            this.totalTicketCostDataGridViewTextBoxColumn.Name = "totalTicketCostDataGridViewTextBoxColumn";
            // 
            // numberOfSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.HeaderText = "NumberOfSeats";
            this.numberOfSeatsDataGridViewTextBoxColumn.Name = "numberOfSeatsDataGridViewTextBoxColumn";
            // 
            // ticketsSaleDateDataGridViewTextBoxColumn
            // 
            this.ticketsSaleDateDataGridViewTextBoxColumn.DataPropertyName = "Tickets_SaleDate";
            this.ticketsSaleDateDataGridViewTextBoxColumn.HeaderText = "Tickets_SaleDate";
            this.ticketsSaleDateDataGridViewTextBoxColumn.Name = "ticketsSaleDateDataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Movie_ID";
            // 
            // txtmovie
            // 
            this.txtmovie.Location = new System.Drawing.Point(132, 101);
            this.txtmovie.Name = "txtmovie";
            this.txtmovie.Size = new System.Drawing.Size(200, 20);
            this.txtmovie.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Customer_ID";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(132, 159);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(200, 20);
            this.txtcustomer.TabIndex = 43;
            // 
            // Bookingstbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 483);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmovie);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtseats);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtbookings);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Bookingstbl";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemagicDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemagicDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemagicDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker sale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtseats;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtbookings;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private CinemagicDBDataSet cinemagicDBDataSet;
        private System.Windows.Forms.BindingSource bOOKINGBindingSource;
        private CinemagicDBDataSetTableAdapters.BOOKINGTableAdapter bOOKINGTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTicketCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketsSaleDateDataGridViewTextBoxColumn;
        private CinemagicDBDataSet1 cinemagicDBDataSet1;
        private System.Windows.Forms.BindingSource cinemagicDBDataSet1BindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcustomer;
    }
}