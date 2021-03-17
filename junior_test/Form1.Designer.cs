
namespace junior_test
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
            this.data_panel_enterprises = new System.Windows.Forms.DataGridView();
            this.fill = new System.Windows.Forms.Button();
            this.data_panel_address = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_panel_enterprises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_panel_address)).BeginInit();
            this.SuspendLayout();
            // 
            // data_panel_enterprises
            // 
            this.data_panel_enterprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_panel_enterprises.Location = new System.Drawing.Point(3, 129);
            this.data_panel_enterprises.Name = "data_panel_enterprises";
            this.data_panel_enterprises.RowTemplate.Height = 25;
            this.data_panel_enterprises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_panel_enterprises.Size = new System.Drawing.Size(440, 511);
            this.data_panel_enterprises.TabIndex = 0;
            this.data_panel_enterprises.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_panel_CellDoubleClick);
            // 
            // fill
            // 
            this.fill.Location = new System.Drawing.Point(290, 51);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(153, 72);
            this.fill.TabIndex = 1;
            this.fill.Text = "Заполнить";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // data_panel_address
            // 
            this.data_panel_address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_panel_address.Location = new System.Drawing.Point(506, 129);
            this.data_panel_address.Name = "data_panel_address";
            this.data_panel_address.RowTemplate.Height = 25;
            this.data_panel_address.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_panel_address.Size = new System.Drawing.Size(658, 511);
            this.data_panel_address.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 652);
            this.Controls.Add(this.data_panel_address);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.data_panel_enterprises);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.data_panel_enterprises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_panel_address)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_panel_enterprises;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.DataGridView data_panel_address;
    }
}

