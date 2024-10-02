namespace ИТ_Практ._2._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aeroDataSet = new ИТ_Практ._2._1.aeroDataSet();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripTableAdapter = new ИТ_Практ._2._1.aeroDataSetTableAdapters.TripTableAdapter();
            this.tripnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.towntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.company = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripnoDataGridViewTextBoxColumn,
            this.iDcompDataGridViewTextBoxColumn,
            this.planeDataGridViewTextBoxColumn,
            this.townfromDataGridViewTextBoxColumn,
            this.towntoDataGridViewTextBoxColumn,
            this.timeoutDataGridViewTextBoxColumn,
            this.timeinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tripBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1444, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // aeroDataSet
            // 
            this.aeroDataSet.DataSetName = "aeroDataSet";
            this.aeroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.aeroDataSet;
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // tripnoDataGridViewTextBoxColumn
            // 
            this.tripnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tripnoDataGridViewTextBoxColumn.DataPropertyName = "trip_no";
            this.tripnoDataGridViewTextBoxColumn.HeaderText = "trip_no";
            this.tripnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tripnoDataGridViewTextBoxColumn.Name = "tripnoDataGridViewTextBoxColumn";
            this.tripnoDataGridViewTextBoxColumn.Width = 110;
            // 
            // iDcompDataGridViewTextBoxColumn
            // 
            this.iDcompDataGridViewTextBoxColumn.DataPropertyName = "ID_comp";
            this.iDcompDataGridViewTextBoxColumn.HeaderText = "ID_comp";
            this.iDcompDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDcompDataGridViewTextBoxColumn.Name = "iDcompDataGridViewTextBoxColumn";
            this.iDcompDataGridViewTextBoxColumn.Width = 125;
            // 
            // planeDataGridViewTextBoxColumn
            // 
            this.planeDataGridViewTextBoxColumn.DataPropertyName = "plane";
            this.planeDataGridViewTextBoxColumn.HeaderText = "plane";
            this.planeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planeDataGridViewTextBoxColumn.Name = "planeDataGridViewTextBoxColumn";
            this.planeDataGridViewTextBoxColumn.Width = 125;
            // 
            // townfromDataGridViewTextBoxColumn
            // 
            this.townfromDataGridViewTextBoxColumn.DataPropertyName = "town_from";
            this.townfromDataGridViewTextBoxColumn.HeaderText = "town_from";
            this.townfromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.townfromDataGridViewTextBoxColumn.Name = "townfromDataGridViewTextBoxColumn";
            this.townfromDataGridViewTextBoxColumn.Width = 125;
            // 
            // towntoDataGridViewTextBoxColumn
            // 
            this.towntoDataGridViewTextBoxColumn.DataPropertyName = "town_to";
            this.towntoDataGridViewTextBoxColumn.HeaderText = "town_to";
            this.towntoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.towntoDataGridViewTextBoxColumn.Name = "towntoDataGridViewTextBoxColumn";
            this.towntoDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeoutDataGridViewTextBoxColumn
            // 
            this.timeoutDataGridViewTextBoxColumn.DataPropertyName = "time_out";
            this.timeoutDataGridViewTextBoxColumn.HeaderText = "time_out";
            this.timeoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeoutDataGridViewTextBoxColumn.Name = "timeoutDataGridViewTextBoxColumn";
            this.timeoutDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeinDataGridViewTextBoxColumn
            // 
            this.timeinDataGridViewTextBoxColumn.DataPropertyName = "time_in";
            this.timeinDataGridViewTextBoxColumn.HeaderText = "time_in";
            this.timeinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeinDataGridViewTextBoxColumn.Name = "timeinDataGridViewTextBoxColumn";
            this.timeinDataGridViewTextBoxColumn.Width = 125;
            // 
            // remove
            // 
            this.remove.FlatAppearance.BorderSize = 0;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove.Location = new System.Drawing.Point(428, 641);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(202, 75);
            this.remove.TabIndex = 1;
            this.remove.Text = "Удалить изменения";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(220, 641);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(202, 75);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // company
            // 
            this.company.FlatAppearance.BorderSize = 0;
            this.company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.company.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.company.Location = new System.Drawing.Point(12, 641);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(202, 75);
            this.company.TabIndex = 3;
            this.company.Text = "Авиакомпании";
            this.company.UseVisualStyleBackColor = true;
            this.company.Click += new System.EventHandler(this.company_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(220, 584);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(410, 36);
            this.name.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 745);
            this.Controls.Add(this.name);
            this.Controls.Add(this.company);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private aeroDataSet aeroDataSet;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private aeroDataSetTableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn towntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button company;
        private System.Windows.Forms.TextBox name;
    }
}

