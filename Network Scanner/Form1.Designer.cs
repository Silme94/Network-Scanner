namespace Network_Scanner
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
            dataGridView1 = new DataGridView();
            ipaddr_column = new DataGridViewTextBoxColumn();
            host_column = new DataGridViewTextBoxColumn();
            status_column = new DataGridViewTextBoxColumn();
            subnettxtbox = new TextBox();
            scanbtn = new Button();
            statuslabel = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ipaddr_column, host_column, status_column });
            dataGridView1.Location = new Point(12, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(570, 376);
            dataGridView1.TabIndex = 0;
            // 
            // ipaddr_column
            // 
            ipaddr_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ipaddr_column.HeaderText = "IPAddress";
            ipaddr_column.MinimumWidth = 6;
            ipaddr_column.Name = "ipaddr_column";
            ipaddr_column.ReadOnly = true;
            ipaddr_column.Resizable = DataGridViewTriState.False;
            ipaddr_column.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // host_column
            // 
            host_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            host_column.HeaderText = "HostName";
            host_column.MinimumWidth = 6;
            host_column.Name = "host_column";
            host_column.ReadOnly = true;
            host_column.Resizable = DataGridViewTriState.False;
            host_column.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // status_column
            // 
            status_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status_column.HeaderText = "Status";
            status_column.MinimumWidth = 6;
            status_column.Name = "status_column";
            status_column.ReadOnly = true;
            status_column.Resizable = DataGridViewTriState.False;
            status_column.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // subnettxtbox
            // 
            subnettxtbox.Location = new Point(12, 421);
            subnettxtbox.Name = "subnettxtbox";
            subnettxtbox.PlaceholderText = "Subnet (192.168.0.)";
            subnettxtbox.Size = new Size(570, 27);
            subnettxtbox.TabIndex = 1;
            // 
            // scanbtn
            // 
            scanbtn.Location = new Point(12, 454);
            scanbtn.Name = "scanbtn";
            scanbtn.Size = new Size(280, 29);
            scanbtn.TabIndex = 2;
            scanbtn.Text = "SCAN";
            scanbtn.UseVisualStyleBackColor = true;
            scanbtn.Click += scanbtn_Click;
            // 
            // statuslabel
            // 
            statuslabel.AutoSize = true;
            statuslabel.Location = new Point(10, 6);
            statuslabel.Name = "statuslabel";
            statuslabel.Size = new Size(0, 20);
            statuslabel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(298, 454);
            button1.Name = "button1";
            button1.Size = new Size(284, 29);
            button1.TabIndex = 4;
            button1.Text = "STOP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 494);
            Controls.Add(button1);
            Controls.Add(statuslabel);
            Controls.Add(scanbtn);
            Controls.Add(subnettxtbox);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Network Scanner";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox subnettxtbox;
        private Button scanbtn;
        private Label statuslabel;
        private DataGridViewTextBoxColumn ipaddr_column;
        private DataGridViewTextBoxColumn host_column;
        private DataGridViewTextBoxColumn status_column;
        private Button button1;
    }
}