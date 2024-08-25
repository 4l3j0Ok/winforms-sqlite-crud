namespace SQLiteABM
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonDelete = new Button();
            buttonNew = new Button();
            buttonModify = new Button();
            panel2 = new Panel();
            txtEmail = new TextBox();
            label3 = new Label();
            txtJob = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.AutoSize = true;
            groupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox.Controls.Add(tableLayoutPanel1);
            groupBox.Controls.Add(panel2);
            groupBox.Dock = DockStyle.Top;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(5);
            groupBox.Size = new Size(384, 190);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Datos del contacto";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttonDelete, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonNew, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonModify, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(5, 155);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(374, 30);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSize = true;
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Location = new Point(251, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 24);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Borrar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonNew
            // 
            buttonNew.AutoSize = true;
            buttonNew.Dock = DockStyle.Fill;
            buttonNew.Location = new Point(3, 3);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(118, 24);
            buttonNew.TabIndex = 6;
            buttonNew.Text = "Nuevo";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonModify
            // 
            buttonModify.AutoSize = true;
            buttonModify.Dock = DockStyle.Fill;
            buttonModify.Location = new Point(127, 3);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(118, 24);
            buttonModify.TabIndex = 8;
            buttonModify.Text = "Modificar";
            buttonModify.UseVisualStyleBackColor = true;
            buttonModify.Click += buttonModify_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtJob);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 21);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(374, 134);
            panel2.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Location = new Point(5, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(364, 23);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(5, 81);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtJob
            // 
            txtJob.Dock = DockStyle.Top;
            txtJob.Location = new Point(5, 58);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(364, 23);
            txtJob.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(5, 43);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Empleo";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Top;
            txtName.Location = new Point(5, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(364, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 190);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(384, 171);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(dataGridView);
            Controls.Add(groupBox);
            MinimumSize = new Size(400, 260);
            Name = "Form1";
            Text = "Contactos - SQLite & WinForms edition";
            Load += LoadData;
            groupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private TextBox txtEmail;
        private TextBox txtJob;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView;
        private Button buttonDelete;
        private Button buttonNew;
        private Button buttonModify;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
