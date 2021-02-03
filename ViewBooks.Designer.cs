namespace Library_Management_System
{
    partial class ViewBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lIB_MAN_SYSDataSet2 = new Library_Management_System.LIB_MAN_SYSDataSet2();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new Library_Management_System.LIB_MAN_SYSDataSet2TableAdapters.BOOKSTableAdapter();
            this.lIB_MAN_SYSDataSet3 = new Library_Management_System.LIB_MAN_SYSDataSet3();
            this.bOOKSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter1 = new Library_Management_System.LIB_MAN_SYSDataSet3TableAdapters.BOOKSTableAdapter();
            this.sNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSSUEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNODataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.pUBLISHERDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.aVAILABLEDataGridViewTextBoxColumn,
            this.iSSUEDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(82, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // lIB_MAN_SYSDataSet2
            // 
            this.lIB_MAN_SYSDataSet2.DataSetName = "LIB_MAN_SYSDataSet2";
            this.lIB_MAN_SYSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.lIB_MAN_SYSDataSet2;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // lIB_MAN_SYSDataSet3
            // 
            this.lIB_MAN_SYSDataSet3.DataSetName = "LIB_MAN_SYSDataSet3";
            this.lIB_MAN_SYSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource1
            // 
            this.bOOKSBindingSource1.DataMember = "BOOKS";
            this.bOOKSBindingSource1.DataSource = this.lIB_MAN_SYSDataSet3;
            // 
            // bOOKSTableAdapter1
            // 
            this.bOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // sNODataGridViewTextBoxColumn
            // 
            this.sNODataGridViewTextBoxColumn.DataPropertyName = "SNO";
            this.sNODataGridViewTextBoxColumn.HeaderText = "SNO";
            this.sNODataGridViewTextBoxColumn.Name = "sNODataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // pUBLISHERDataGridViewTextBoxColumn
            // 
            this.pUBLISHERDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER";
            this.pUBLISHERDataGridViewTextBoxColumn.HeaderText = "PUBLISHER";
            this.pUBLISHERDataGridViewTextBoxColumn.Name = "pUBLISHERDataGridViewTextBoxColumn";
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            // 
            // aVAILABLEDataGridViewTextBoxColumn
            // 
            this.aVAILABLEDataGridViewTextBoxColumn.DataPropertyName = "AVAILABLE";
            this.aVAILABLEDataGridViewTextBoxColumn.HeaderText = "AVAILABLE";
            this.aVAILABLEDataGridViewTextBoxColumn.Name = "aVAILABLEDataGridViewTextBoxColumn";
            // 
            // iSSUEDDataGridViewTextBoxColumn
            // 
            this.iSSUEDDataGridViewTextBoxColumn.DataPropertyName = "ISSUED";
            this.iSSUEDDataGridViewTextBoxColumn.HeaderText = "ISSUED";
            this.iSSUEDDataGridViewTextBoxColumn.Name = "iSSUEDDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(809, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBooks";
            this.Text = "ViewBooks";
            this.Load += new System.EventHandler(this.ViewBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIB_MAN_SYSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LIB_MAN_SYSDataSet2 lIB_MAN_SYSDataSet2;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private LIB_MAN_SYSDataSet2TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private LIB_MAN_SYSDataSet3 lIB_MAN_SYSDataSet3;
        private System.Windows.Forms.BindingSource bOOKSBindingSource1;
        private LIB_MAN_SYSDataSet3TableAdapters.BOOKSTableAdapter bOOKSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSSUEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}