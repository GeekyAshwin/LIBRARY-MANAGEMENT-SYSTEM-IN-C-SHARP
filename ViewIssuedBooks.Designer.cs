namespace Library_Management_System
{
    partial class ViewIssuedBooks
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lIB_MAN_SYSDataSet4 = new Library_Management_System.LIB_MAN_SYSDataSet4();
            this.iSSUEDBOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSSUEDBOOKSTableAdapter = new Library_Management_System.LIB_MAN_SYSDataSet4TableAdapters.ISSUEDBOOKSTableAdapter();
            this.lIB_MAN_SYSDataSet5 = new Library_Management_System.LIB_MAN_SYSDataSet5();
            this.iSSUEDBOOKSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iSSUEDBOOKSTableAdapter1 = new Library_Management_System.LIB_MAN_SYSDataSet5TableAdapters.ISSUEDBOOKSTableAdapter();
            this.lIB_MAN_SYSDataSet6 = new Library_Management_System.LIB_MAN_SYSDataSet6();
            this.iSSUEDBOOKSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iSSUEDBOOKSTableAdapter2 = new Library_Management_System.LIB_MAN_SYSDataSet6TableAdapters.ISSUEDBOOKSTableAdapter();
            this.sNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEDBOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEDBOOKSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEDBOOKSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(320, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Issued Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNODataGridViewTextBoxColumn,
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.sTUDENTIDDataGridViewTextBoxColumn,
            this.sTUDENTNAMEDataGridViewTextBoxColumn,
            this.cONTACTDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.iSSUEDBOOKSBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 302);
            this.dataGridView1.TabIndex = 2;
            // 
            // lIB_MAN_SYSDataSet4
            // 
            this.lIB_MAN_SYSDataSet4.DataSetName = "LIB_MAN_SYSDataSet4";
            this.lIB_MAN_SYSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSSUEDBOOKSBindingSource
            // 
            this.iSSUEDBOOKSBindingSource.DataMember = "ISSUEDBOOKS";
            this.iSSUEDBOOKSBindingSource.DataSource = this.lIB_MAN_SYSDataSet4;
            // 
            // iSSUEDBOOKSTableAdapter
            // 
            this.iSSUEDBOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // lIB_MAN_SYSDataSet5
            // 
            this.lIB_MAN_SYSDataSet5.DataSetName = "LIB_MAN_SYSDataSet5";
            this.lIB_MAN_SYSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSSUEDBOOKSBindingSource1
            // 
            this.iSSUEDBOOKSBindingSource1.DataMember = "ISSUEDBOOKS";
            this.iSSUEDBOOKSBindingSource1.DataSource = this.lIB_MAN_SYSDataSet5;
            // 
            // iSSUEDBOOKSTableAdapter1
            // 
            this.iSSUEDBOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // lIB_MAN_SYSDataSet6
            // 
            this.lIB_MAN_SYSDataSet6.DataSetName = "LIB_MAN_SYSDataSet6";
            this.lIB_MAN_SYSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSSUEDBOOKSBindingSource2
            // 
            this.iSSUEDBOOKSBindingSource2.DataMember = "ISSUEDBOOKS";
            this.iSSUEDBOOKSBindingSource2.DataSource = this.lIB_MAN_SYSDataSet6;
            // 
            // iSSUEDBOOKSTableAdapter2
            // 
            this.iSSUEDBOOKSTableAdapter2.ClearBeforeFill = true;
            // 
            // sNODataGridViewTextBoxColumn
            // 
            this.sNODataGridViewTextBoxColumn.DataPropertyName = "SNO";
            this.sNODataGridViewTextBoxColumn.HeaderText = "SNO";
            this.sNODataGridViewTextBoxColumn.Name = "sNODataGridViewTextBoxColumn";
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTIDDataGridViewTextBoxColumn
            // 
            this.sTUDENTIDDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.HeaderText = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.Name = "sTUDENTIDDataGridViewTextBoxColumn";
            // 
            // sTUDENTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_NAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENT_NAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTNAMEDataGridViewTextBoxColumn";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Width = 130;
            // 
            // cONTACTDataGridViewTextBoxColumn
            // 
            this.cONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT";
            this.cONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT";
            this.cONTACTDataGridViewTextBoxColumn.Name = "cONTACTDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DATA/TIME OF ISSUE";
            this.dataGridViewTextBoxColumn1.HeaderText = "DATA/TIME OF ISSUE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // ViewIssuedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "ViewIssuedBooks";
            this.Text = "ViewIssuedBooks";
            this.Load += new System.EventHandler(this.ViewIssuedBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEDBOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEDBOOKSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEDBOOKSBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LIB_MAN_SYSDataSet4 lIB_MAN_SYSDataSet4;
        private System.Windows.Forms.BindingSource iSSUEDBOOKSBindingSource;
        private LIB_MAN_SYSDataSet4TableAdapters.ISSUEDBOOKSTableAdapter iSSUEDBOOKSTableAdapter;
        private LIB_MAN_SYSDataSet5 lIB_MAN_SYSDataSet5;
        private System.Windows.Forms.BindingSource iSSUEDBOOKSBindingSource1;
        private LIB_MAN_SYSDataSet5TableAdapters.ISSUEDBOOKSTableAdapter iSSUEDBOOKSTableAdapter1;
        private LIB_MAN_SYSDataSet6 lIB_MAN_SYSDataSet6;
        private System.Windows.Forms.BindingSource iSSUEDBOOKSBindingSource2;
        private LIB_MAN_SYSDataSet6TableAdapters.ISSUEDBOOKSTableAdapter iSSUEDBOOKSTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}