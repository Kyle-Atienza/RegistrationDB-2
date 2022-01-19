
using System.Windows.Forms;

namespace RegistrationDB_2
{
    partial class Form2
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
            this.dgvRegistrants = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobbiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrants2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registrantsDataSet = new RegistrationDB_2.RegistrantsDataSet();
            this.registrants2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrants2TableAdapter = new RegistrationDB_2.RegistrantsDataSetTableAdapters.Registrants2TableAdapter();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrants2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrants2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistrants
            // 
            this.dgvRegistrants.AllowUserToAddRows = false;
            this.dgvRegistrants.AllowUserToDeleteRows = false;
            this.dgvRegistrants.AutoGenerateColumns = false;
            this.dgvRegistrants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.barangayDataGridViewTextBoxColumn,
            this.municipalityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.hobbiesDataGridViewTextBoxColumn});
            this.dgvRegistrants.DataSource = this.registrants2BindingSource1;
            this.dgvRegistrants.Location = new System.Drawing.Point(36, 44);
            this.dgvRegistrants.Name = "dgvRegistrants";
            this.dgvRegistrants.ReadOnly = true;
            this.dgvRegistrants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistrants.Size = new System.Drawing.Size(609, 201);
            this.dgvRegistrants.TabIndex = 1;
            this.dgvRegistrants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrants_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "middleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "middleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "birthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "birthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barangayDataGridViewTextBoxColumn
            // 
            this.barangayDataGridViewTextBoxColumn.DataPropertyName = "barangay";
            this.barangayDataGridViewTextBoxColumn.HeaderText = "barangay";
            this.barangayDataGridViewTextBoxColumn.Name = "barangayDataGridViewTextBoxColumn";
            this.barangayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // municipalityDataGridViewTextBoxColumn
            // 
            this.municipalityDataGridViewTextBoxColumn.DataPropertyName = "municipality";
            this.municipalityDataGridViewTextBoxColumn.HeaderText = "municipality";
            this.municipalityDataGridViewTextBoxColumn.Name = "municipalityDataGridViewTextBoxColumn";
            this.municipalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hobbiesDataGridViewTextBoxColumn
            // 
            this.hobbiesDataGridViewTextBoxColumn.DataPropertyName = "hobbies";
            this.hobbiesDataGridViewTextBoxColumn.HeaderText = "hobbies";
            this.hobbiesDataGridViewTextBoxColumn.Name = "hobbiesDataGridViewTextBoxColumn";
            this.hobbiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrants2BindingSource1
            // 
            this.registrants2BindingSource1.DataMember = "Registrants2";
            this.registrants2BindingSource1.DataSource = this.registrantsDataSet;
            // 
            // registrantsDataSet
            // 
            this.registrantsDataSet.DataSetName = "RegistrantsDataSet";
            this.registrantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrants2BindingSource
            // 
            this.registrants2BindingSource.DataMember = "Registrants2";
            this.registrants2BindingSource.DataSource = this.registrantsDataSet;
            // 
            // registrants2TableAdapter
            // 
            this.registrants2TableAdapter.ClearBeforeFill = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(36, 269);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 33);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 33);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 344);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvRegistrants);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrants2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrants2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRegistrants;
        private RegistrantsDataSet registrantsDataSet;
        private System.Windows.Forms.BindingSource registrants2BindingSource;
        private RegistrantsDataSetTableAdapters.Registrants2TableAdapter registrants2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobbiesDataGridViewTextBoxColumn;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCancel;
        private BindingSource registrants2BindingSource1;
    }
}