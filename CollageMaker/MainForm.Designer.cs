namespace ITLN.CollageMaker {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.uAdd = new System.Windows.Forms.Button();
			this.uOrientation = new System.Windows.Forms.DomainUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.uSave = new System.Windows.Forms.Button();
			this.uCopy = new System.Windows.Forms.Button();
			this.uPicture = new System.Windows.Forms.PictureBox();
			this.uOpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.uList = new System.Windows.Forms.ListView();
			this.uCaptions = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.uSeparatorEnabled = new System.Windows.Forms.CheckBox();
			this.uSeparatorSize = new System.Windows.Forms.NumericUpDown();
			this.uSeparatorLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.uColorPanel = new System.Windows.Forms.Panel();
			this.uColorDialog = new System.Windows.Forms.ColorDialog();
			this.label4 = new System.Windows.Forms.Label();
			this.uAlignment = new System.Windows.Forms.DomainUpDown();
			((System.ComponentModel.ISupportInitialize)(this.uPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uSeparatorSize)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Photos:";
			// 
			// uAdd
			// 
			this.uAdd.Location = new System.Drawing.Point(62, 8);
			this.uAdd.Name = "uAdd";
			this.uAdd.Size = new System.Drawing.Size(21, 23);
			this.uAdd.TabIndex = 1;
			this.uAdd.Text = "+";
			this.uAdd.UseVisualStyleBackColor = true;
			this.uAdd.Click += new System.EventHandler(this.uAdd_Click);
			// 
			// uOrientation
			// 
			this.uOrientation.Location = new System.Drawing.Point(16, 235);
			this.uOrientation.Name = "uOrientation";
			this.uOrientation.Size = new System.Drawing.Size(118, 20);
			this.uOrientation.TabIndex = 4;
			this.uOrientation.Text = "Horizontal";
			this.uOrientation.SelectedItemChanged += new System.EventHandler(this.uiForConfigChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Orientation:";
			// 
			// uSave
			// 
			this.uSave.Location = new System.Drawing.Point(16, 540);
			this.uSave.Name = "uSave";
			this.uSave.Size = new System.Drawing.Size(118, 31);
			this.uSave.TabIndex = 14;
			this.uSave.Text = "Save";
			this.uSave.UseVisualStyleBackColor = true;
			this.uSave.Click += new System.EventHandler(this.uSave_Click);
			// 
			// uCopy
			// 
			this.uCopy.Location = new System.Drawing.Point(16, 590);
			this.uCopy.Name = "uCopy";
			this.uCopy.Size = new System.Drawing.Size(118, 31);
			this.uCopy.TabIndex = 15;
			this.uCopy.Text = "Copy to clipboard";
			this.uCopy.UseVisualStyleBackColor = true;
			this.uCopy.Click += new System.EventHandler(this.uCopy_Click);
			// 
			// uPicture
			// 
			this.uPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uPicture.Location = new System.Drawing.Point(204, 13);
			this.uPicture.Name = "uPicture";
			this.uPicture.Size = new System.Drawing.Size(597, 623);
			this.uPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.uPicture.TabIndex = 6;
			this.uPicture.TabStop = false;
			// 
			// uOpenDialog
			// 
			this.uOpenDialog.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
			this.uOpenDialog.Multiselect = true;
			this.uOpenDialog.RestoreDirectory = true;
			// 
			// uList
			// 
			this.uList.Location = new System.Drawing.Point(16, 37);
			this.uList.Name = "uList";
			this.uList.Size = new System.Drawing.Size(171, 163);
			this.uList.TabIndex = 2;
			this.uList.UseCompatibleStateImageBehavior = false;
			this.uList.View = System.Windows.Forms.View.List;
			// 
			// uCaptions
			// 
			this.uCaptions.AcceptsReturn = true;
			this.uCaptions.Location = new System.Drawing.Point(16, 411);
			this.uCaptions.Multiline = true;
			this.uCaptions.Name = "uCaptions";
			this.uCaptions.Size = new System.Drawing.Size(171, 101);
			this.uCaptions.TabIndex = 13;
			this.uCaptions.TextChanged += new System.EventHandler(this.uiForConfigChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Captions:";
			// 
			// uSeparatorEnabled
			// 
			this.uSeparatorEnabled.AutoSize = true;
			this.uSeparatorEnabled.Location = new System.Drawing.Point(16, 326);
			this.uSeparatorEnabled.Name = "uSeparatorEnabled";
			this.uSeparatorEnabled.Size = new System.Drawing.Size(75, 17);
			this.uSeparatorEnabled.TabIndex = 7;
			this.uSeparatorEnabled.Text = "Separator:";
			this.uSeparatorEnabled.UseVisualStyleBackColor = true;
			this.uSeparatorEnabled.CheckedChanged += new System.EventHandler(this.uSeparatorEnabled_CheckedChanged);
			// 
			// uSeparatorSize
			// 
			this.uSeparatorSize.Location = new System.Drawing.Point(97, 325);
			this.uSeparatorSize.Name = "uSeparatorSize";
			this.uSeparatorSize.Size = new System.Drawing.Size(37, 20);
			this.uSeparatorSize.TabIndex = 8;
			this.uSeparatorSize.ValueChanged += new System.EventHandler(this.uiForConfigChanged);
			// 
			// uSeparatorLabel
			// 
			this.uSeparatorLabel.AutoSize = true;
			this.uSeparatorLabel.Location = new System.Drawing.Point(140, 327);
			this.uSeparatorLabel.Name = "uSeparatorLabel";
			this.uSeparatorLabel.Size = new System.Drawing.Size(33, 13);
			this.uSeparatorLabel.TabIndex = 9;
			this.uSeparatorLabel.Text = "pixels";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 359);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Color:";
			// 
			// uColorPanel
			// 
			this.uColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.uColorPanel.Location = new System.Drawing.Point(97, 354);
			this.uColorPanel.Name = "uColorPanel";
			this.uColorPanel.Size = new System.Drawing.Size(52, 24);
			this.uColorPanel.TabIndex = 11;
			this.uColorPanel.Click += new System.EventHandler(this.uColorPanel_Click);
			// 
			// uColorDialog
			// 
			this.uColorDialog.AnyColor = true;
			this.uColorDialog.FullOpen = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Alignment:";
			// 
			// uAlignment
			// 
			this.uAlignment.Location = new System.Drawing.Point(16, 286);
			this.uAlignment.Name = "uAlignment";
			this.uAlignment.Size = new System.Drawing.Size(118, 20);
			this.uAlignment.TabIndex = 6;
			this.uAlignment.Text = "Horizontal";
			this.uAlignment.SelectedItemChanged += new System.EventHandler(this.uiForConfigChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(813, 648);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.uAlignment);
			this.Controls.Add(this.uColorPanel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.uSeparatorLabel);
			this.Controls.Add(this.uSeparatorSize);
			this.Controls.Add(this.uSeparatorEnabled);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.uCaptions);
			this.Controls.Add(this.uList);
			this.Controls.Add(this.uPicture);
			this.Controls.Add(this.uCopy);
			this.Controls.Add(this.uSave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.uOrientation);
			this.Controls.Add(this.uAdd);
			this.Controls.Add(this.label1);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Collage Maker";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.uPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uSeparatorSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button uAdd;
		private System.Windows.Forms.DomainUpDown uOrientation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button uSave;
		private System.Windows.Forms.Button uCopy;
		private System.Windows.Forms.PictureBox uPicture;
		private System.Windows.Forms.OpenFileDialog uOpenDialog;
		private System.Windows.Forms.ListView uList;
		private System.Windows.Forms.TextBox uCaptions;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox uSeparatorEnabled;
		private System.Windows.Forms.NumericUpDown uSeparatorSize;
		private System.Windows.Forms.Label uSeparatorLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel uColorPanel;
		private System.Windows.Forms.ColorDialog uColorDialog;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DomainUpDown uAlignment;
	}
}

