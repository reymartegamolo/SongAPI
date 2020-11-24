/*
 * Created by SharpDevelop.
 * User: GAMOLO
 * Date: 11/24/2020
 * Time: 3:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SongAppRest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.BindingSource bindingSourceSong;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn recordLabelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pickChartPositionDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnGetSong;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.bindingSourceSong = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.releaseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recordLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pickChartPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnSave = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGetSong = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// bindingSourceSong
			// 
			this.bindingSourceSong.DataSource = typeof(song);
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.BindingSource = this.bindingSourceSong;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.bindingNavigatorDeleteItem});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(867, 25);
			this.bindingNavigator1.TabIndex = 0;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 48);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(867, 365);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(859, 339);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "DateSheet View";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.idDataGridViewTextBoxColumn,
			this.titleDataGridViewTextBoxColumn,
			this.artistDataGridViewTextBoxColumn,
			this.genreDataGridViewTextBoxColumn,
			this.durationDataGridViewTextBoxColumn,
			this.releaseYearDataGridViewTextBoxColumn,
			this.recordLabelDataGridViewTextBoxColumn,
			this.pickChartPositionDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.bindingSourceSong;
			this.dataGridView1.Location = new System.Drawing.Point(8, 20);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(845, 294);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			// 
			// artistDataGridViewTextBoxColumn
			// 
			this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
			this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
			this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
			// 
			// genreDataGridViewTextBoxColumn
			// 
			this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
			this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
			this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
			// 
			// durationDataGridViewTextBoxColumn
			// 
			this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
			this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
			this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
			// 
			// releaseYearDataGridViewTextBoxColumn
			// 
			this.releaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear";
			this.releaseYearDataGridViewTextBoxColumn.HeaderText = "ReleaseYear";
			this.releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
			// 
			// recordLabelDataGridViewTextBoxColumn
			// 
			this.recordLabelDataGridViewTextBoxColumn.DataPropertyName = "RecordLabel";
			this.recordLabelDataGridViewTextBoxColumn.HeaderText = "RecordLabel";
			this.recordLabelDataGridViewTextBoxColumn.Name = "recordLabelDataGridViewTextBoxColumn";
			// 
			// pickChartPositionDataGridViewTextBoxColumn
			// 
			this.pickChartPositionDataGridViewTextBoxColumn.DataPropertyName = "PickChartPosition";
			this.pickChartPositionDataGridViewTextBoxColumn.HeaderText = "PickChartPosition";
			this.pickChartPositionDataGridViewTextBoxColumn.Name = "pickChartPositionDataGridViewTextBoxColumn";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnSave);
			this.tabPage2.Controls.Add(this.textBox5);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.textBox4);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.textBox3);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(859, 339);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Detail View";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Click += new System.EventHandler(this.TabPage2Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(131, 197);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(72, 29);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSong, "PickChartPosition", true));
			this.textBox5.Location = new System.Drawing.Point(131, 154);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(265, 20);
			this.textBox5.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(62, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Chart:";
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSong, "ReleaseYear", true));
			this.textBox4.Location = new System.Drawing.Point(131, 125);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(265, 20);
			this.textBox4.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(62, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Release Year:";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSong, "Artist", true));
			this.textBox3.Location = new System.Drawing.Point(131, 96);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(265, 20);
			this.textBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(62, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Artist:";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSong, "Title", true));
			this.textBox2.Location = new System.Drawing.Point(131, 67);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(265, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(62, 70);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Title:";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSong, "Id", true));
			this.textBox1.Location = new System.Drawing.Point(131, 38);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(265, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(62, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// btnGetSong
			// 
			this.btnGetSong.Location = new System.Drawing.Point(734, 28);
			this.btnGetSong.Name = "btnGetSong";
			this.btnGetSong.Size = new System.Drawing.Size(121, 36);
			this.btnGetSong.TabIndex = 2;
			this.btnGetSong.Text = "Get Songs";
			this.btnGetSong.UseVisualStyleBackColor = true;
			this.btnGetSong.Click += new System.EventHandler(this.BtnGetSongClick);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(498, 37);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(213, 20);
			this.txtSearch.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 415);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnGetSong);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.bindingNavigator1);
			this.Name = "MainForm";
			this.Text = "SongAppRest";
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
