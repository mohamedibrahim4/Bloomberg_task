
namespace testWindowsblp
{
    partial class Form1
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
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfileName = new System.Windows.Forms.TextBox();
            this.lblfilename = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTextRows = new System.Windows.Forms.Label();
            this.lblTextColumns = new System.Windows.Forms.Label();
            this.lblResultColumn = new System.Windows.Forms.Label();
            this.lblResultRows = new System.Windows.Forms.Label();
            this.rbtntextRows = new System.Windows.Forms.ComboBox();
            this.rbtntextColumns = new System.Windows.Forms.ComboBox();
            this.rbtnResultRows = new System.Windows.Forms.ComboBox();
            this.rbtnResultColumns = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(252, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "GET SPY:US";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(193, 95);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(525, 98);
            this.txtresult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "SPY:US";
            // 
            // txtfileName
            // 
            this.txtfileName.Location = new System.Drawing.Point(193, 260);
            this.txtfileName.Multiline = true;
            this.txtfileName.Name = "txtfileName";
            this.txtfileName.Size = new System.Drawing.Size(525, 34);
            this.txtfileName.TabIndex = 3;
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilename.Location = new System.Drawing.Point(12, 262);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(155, 18);
            this.lblfilename.TabIndex = 4;
            this.lblfilename.Text = "Exceel Sheet Name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(281, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(663, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTextRows
            // 
            this.lblTextRows.AutoSize = true;
            this.lblTextRows.Location = new System.Drawing.Point(23, 134);
            this.lblTextRows.Name = "lblTextRows";
            this.lblTextRows.Size = new System.Drawing.Size(34, 13);
            this.lblTextRows.TabIndex = 7;
            this.lblTextRows.Text = "Rows";
            // 
            // lblTextColumns
            // 
            this.lblTextColumns.AutoSize = true;
            this.lblTextColumns.Location = new System.Drawing.Point(96, 134);
            this.lblTextColumns.Name = "lblTextColumns";
            this.lblTextColumns.Size = new System.Drawing.Size(47, 13);
            this.lblTextColumns.TabIndex = 9;
            this.lblTextColumns.Text = "Columns";
            // 
            // lblResultColumn
            // 
            this.lblResultColumn.AutoSize = true;
            this.lblResultColumn.Location = new System.Drawing.Point(400, 205);
            this.lblResultColumn.Name = "lblResultColumn";
            this.lblResultColumn.Size = new System.Drawing.Size(47, 13);
            this.lblResultColumn.TabIndex = 13;
            this.lblResultColumn.Text = "Columns";
            // 
            // lblResultRows
            // 
            this.lblResultRows.AutoSize = true;
            this.lblResultRows.Location = new System.Drawing.Point(341, 205);
            this.lblResultRows.Name = "lblResultRows";
            this.lblResultRows.Size = new System.Drawing.Size(34, 13);
            this.lblResultRows.TabIndex = 12;
            this.lblResultRows.Text = "Rows";
            // 
            // rbtntextRows
            // 
            this.rbtntextRows.FormattingEnabled = true;
            this.rbtntextRows.Location = new System.Drawing.Point(26, 153);
            this.rbtntextRows.Name = "rbtntextRows";
            this.rbtntextRows.Size = new System.Drawing.Size(60, 21);
            this.rbtntextRows.TabIndex = 16;
            // 
            // rbtntextColumns
            // 
            this.rbtntextColumns.FormattingEnabled = true;
            this.rbtntextColumns.Location = new System.Drawing.Point(99, 153);
            this.rbtntextColumns.Name = "rbtntextColumns";
            this.rbtntextColumns.Size = new System.Drawing.Size(60, 21);
            this.rbtntextColumns.TabIndex = 17;
            // 
            // rbtnResultRows
            // 
            this.rbtnResultRows.FormattingEnabled = true;
            this.rbtnResultRows.Location = new System.Drawing.Point(332, 222);
            this.rbtnResultRows.Name = "rbtnResultRows";
            this.rbtnResultRows.Size = new System.Drawing.Size(60, 21);
            this.rbtnResultRows.TabIndex = 18;
            // 
            // rbtnResultColumns
            // 
            this.rbtnResultColumns.FormattingEnabled = true;
            this.rbtnResultColumns.Location = new System.Drawing.Point(403, 221);
            this.rbtnResultColumns.Name = "rbtnResultColumns";
            this.rbtnResultColumns.Size = new System.Drawing.Size(60, 21);
            this.rbtnResultColumns.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnResultColumns);
            this.Controls.Add(this.rbtnResultRows);
            this.Controls.Add(this.rbtntextColumns);
            this.Controls.Add(this.rbtntextRows);
            this.Controls.Add(this.lblResultColumn);
            this.Controls.Add(this.lblResultRows);
            this.Controls.Add(this.lblTextColumns);
            this.Controls.Add(this.lblTextRows);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblfilename);
            this.Controls.Add(this.txtfileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Bloomberg Data";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfileName;
        private System.Windows.Forms.Label lblfilename;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTextColumns;
        private System.Windows.Forms.Label lblTextRows;
        private System.Windows.Forms.Label lblResultColumn;
        private System.Windows.Forms.Label lblResultRows;
        private System.Windows.Forms.ComboBox rbtntextRows;
        private System.Windows.Forms.ComboBox rbtntextColumns;
        private System.Windows.Forms.ComboBox rbtnResultColumns;
        private System.Windows.Forms.ComboBox rbtnResultRows;
    }
}

