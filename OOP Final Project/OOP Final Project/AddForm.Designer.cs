
namespace OOP_Final_Project
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            System.Windows.Forms.Label taskLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label time_InLabel;
            System.Windows.Forms.Label time_OutLabel;
            this.vwBtn = new System.Windows.Forms.Button();
            this.lgOutbtn = new System.Windows.Forms.Button();
            this.hmBtn = new System.Windows.Forms.Button();
            this.myDatabaseDataSet = new OOP_Final_Project.MyDatabaseDataSet();
            this.myTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTableTableAdapter = new OOP_Final_Project.MyDatabaseDataSetTableAdapters.MyTableTableAdapter();
            this.tableAdapterManager = new OOP_Final_Project.MyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.myTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.myTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.time_InDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_OutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            taskLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            time_InLabel = new System.Windows.Forms.Label();
            time_OutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingNavigator)).BeginInit();
            this.myTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // vwBtn
            // 
            this.vwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vwBtn.Location = new System.Drawing.Point(289, 285);
            this.vwBtn.Name = "vwBtn";
            this.vwBtn.Size = new System.Drawing.Size(81, 41);
            this.vwBtn.TabIndex = 16;
            this.vwBtn.Text = "View";
            this.vwBtn.UseVisualStyleBackColor = true;
            this.vwBtn.Click += new System.EventHandler(this.vwBtn_Click);
            // 
            // lgOutbtn
            // 
            this.lgOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgOutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgOutbtn.Location = new System.Drawing.Point(405, 285);
            this.lgOutbtn.Name = "lgOutbtn";
            this.lgOutbtn.Size = new System.Drawing.Size(81, 41);
            this.lgOutbtn.TabIndex = 17;
            this.lgOutbtn.Text = "Log out";
            this.lgOutbtn.UseVisualStyleBackColor = true;
            this.lgOutbtn.Click += new System.EventHandler(this.lgOutbtn_Click);
            // 
            // hmBtn
            // 
            this.hmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmBtn.Location = new System.Drawing.Point(173, 285);
            this.hmBtn.Name = "hmBtn";
            this.hmBtn.Size = new System.Drawing.Size(81, 41);
            this.hmBtn.TabIndex = 18;
            this.hmBtn.Text = "Home";
            this.hmBtn.UseVisualStyleBackColor = true;
            this.hmBtn.Click += new System.EventHandler(this.hmBtn_Click);
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myTableBindingSource
            // 
            this.myTableBindingSource.DataMember = "MyTable";
            this.myTableBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // myTableTableAdapter
            // 
            this.myTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MyTableTableAdapter = this.myTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = OOP_Final_Project.MyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // myTableBindingNavigator
            // 
            this.myTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.myTableBindingNavigator.BindingSource = this.myTableBindingSource;
            this.myTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.myTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.myTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.myTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.myTableBindingNavigatorSaveItem});
            this.myTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.myTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.myTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.myTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.myTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.myTableBindingNavigator.Name = "myTableBindingNavigator";
            this.myTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.myTableBindingNavigator.Size = new System.Drawing.Size(578, 33);
            this.myTableBindingNavigator.TabIndex = 19;
            this.myTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // myTableBindingNavigatorSaveItem
            // 
            this.myTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.myTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("myTableBindingNavigatorSaveItem.Image")));
            this.myTableBindingNavigatorSaveItem.Name = "myTableBindingNavigatorSaveItem";
            this.myTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.myTableBindingNavigatorSaveItem.Text = "Save Data";
            this.myTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.myTableBindingNavigatorSaveItem_Click);
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.BackColor = System.Drawing.Color.Transparent;
            taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taskLabel.Location = new System.Drawing.Point(65, 98);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new System.Drawing.Size(52, 20);
            taskLabel.TabIndex = 21;
            taskLabel.Text = "Task:";
            // 
            // taskTextBox
            // 
            this.taskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myTableBindingSource, "Task", true));
            this.taskTextBox.Location = new System.Drawing.Point(173, 98);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(312, 26);
            this.taskTextBox.TabIndex = 22;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(65, 144);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 20);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myTableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(173, 144);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(312, 26);
            this.nameTextBox.TabIndex = 24;
            // 
            // time_InLabel
            // 
            time_InLabel.AutoSize = true;
            time_InLabel.BackColor = System.Drawing.Color.Transparent;
            time_InLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            time_InLabel.Location = new System.Drawing.Point(65, 190);
            time_InLabel.Name = "time_InLabel";
            time_InLabel.Size = new System.Drawing.Size(73, 20);
            time_InLabel.TabIndex = 25;
            time_InLabel.Text = "Time In:";
            // 
            // time_InDateTimePicker
            // 
            this.time_InDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.myTableBindingSource, "Time In", true));
            this.time_InDateTimePicker.Location = new System.Drawing.Point(173, 190);
            this.time_InDateTimePicker.Name = "time_InDateTimePicker";
            this.time_InDateTimePicker.Size = new System.Drawing.Size(312, 26);
            this.time_InDateTimePicker.TabIndex = 26;
            // 
            // time_OutLabel
            // 
            time_OutLabel.AutoSize = true;
            time_OutLabel.BackColor = System.Drawing.Color.Transparent;
            time_OutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            time_OutLabel.Location = new System.Drawing.Point(65, 236);
            time_OutLabel.Name = "time_OutLabel";
            time_OutLabel.Size = new System.Drawing.Size(86, 20);
            time_OutLabel.TabIndex = 27;
            time_OutLabel.Text = "Time Out:";
            // 
            // time_OutDateTimePicker
            // 
            this.time_OutDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.myTableBindingSource, "Time Out", true));
            this.time_OutDateTimePicker.Location = new System.Drawing.Point(173, 236);
            this.time_OutDateTimePicker.Name = "time_OutDateTimePicker";
            this.time_OutDateTimePicker.Size = new System.Drawing.Size(312, 26);
            this.time_OutDateTimePicker.TabIndex = 28;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 398);
            this.Controls.Add(taskLabel);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(time_InLabel);
            this.Controls.Add(this.time_InDateTimePicker);
            this.Controls.Add(time_OutLabel);
            this.Controls.Add(this.time_OutDateTimePicker);
            this.Controls.Add(this.myTableBindingNavigator);
            this.Controls.Add(this.hmBtn);
            this.Controls.Add(this.lgOutbtn);
            this.Controls.Add(this.vwBtn);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingNavigator)).EndInit();
            this.myTableBindingNavigator.ResumeLayout(false);
            this.myTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button vwBtn;
        private System.Windows.Forms.Button lgOutbtn;
        private System.Windows.Forms.Button hmBtn;
        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource myTableBindingSource;
        private MyDatabaseDataSetTableAdapters.MyTableTableAdapter myTableTableAdapter;
        private MyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator myTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton myTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker time_InDateTimePicker;
        private System.Windows.Forms.DateTimePicker time_OutDateTimePicker;
    }
}