namespace PowerShellWinform
{
    partial class FormShowService
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
            this.labelServicename = new System.Windows.Forms.Label();
            this.labelDisplayname = new System.Windows.Forms.Label();
            this.labelServicename_value = new System.Windows.Forms.Label();
            this.labelDisplayname_value = new System.Windows.Forms.Label();
            this.labelServicePath = new System.Windows.Forms.Label();
            this.labelServicePath_value = new System.Windows.Forms.Label();
            this.labelServiceStartuptype = new System.Windows.Forms.Label();
            this.comboBoxSV_Startup_type_value = new System.Windows.Forms.ComboBox();
            this.labelService_status = new System.Windows.Forms.Label();
            this.labelService_status_value = new System.Windows.Forms.Label();
            this.buttonSV_Start = new System.Windows.Forms.Button();
            this.buttonSV_Stop = new System.Windows.Forms.Button();
            this.buttonSV_OK = new System.Windows.Forms.Button();
            this.buttonSV_Cancel = new System.Windows.Forms.Button();
            this.buttonSV_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelServicename
            // 
            this.labelServicename.AutoSize = true;
            this.labelServicename.Location = new System.Drawing.Point(12, 9);
            this.labelServicename.Name = "labelServicename";
            this.labelServicename.Size = new System.Drawing.Size(75, 13);
            this.labelServicename.TabIndex = 0;
            this.labelServicename.Text = "Service name:";
            // 
            // labelDisplayname
            // 
            this.labelDisplayname.AutoSize = true;
            this.labelDisplayname.Location = new System.Drawing.Point(12, 37);
            this.labelDisplayname.Name = "labelDisplayname";
            this.labelDisplayname.Size = new System.Drawing.Size(73, 13);
            this.labelDisplayname.TabIndex = 0;
            this.labelDisplayname.Text = "Display name:";
            // 
            // labelServicename_value
            // 
            this.labelServicename_value.AutoSize = true;
            this.labelServicename_value.Location = new System.Drawing.Point(127, 9);
            this.labelServicename_value.Name = "labelServicename_value";
            this.labelServicename_value.Size = new System.Drawing.Size(33, 13);
            this.labelServicename_value.TabIndex = 0;
            this.labelServicename_value.Text = "value";
            // 
            // labelDisplayname_value
            // 
            this.labelDisplayname_value.AutoSize = true;
            this.labelDisplayname_value.Location = new System.Drawing.Point(127, 37);
            this.labelDisplayname_value.Name = "labelDisplayname_value";
            this.labelDisplayname_value.Size = new System.Drawing.Size(33, 13);
            this.labelDisplayname_value.TabIndex = 0;
            this.labelDisplayname_value.Text = "value";
            // 
            // labelServicePath
            // 
            this.labelServicePath.AutoSize = true;
            this.labelServicePath.Location = new System.Drawing.Point(12, 65);
            this.labelServicePath.Name = "labelServicePath";
            this.labelServicePath.Size = new System.Drawing.Size(100, 13);
            this.labelServicePath.TabIndex = 0;
            this.labelServicePath.Text = "Path to Executable:";
            // 
            // labelServicePath_value
            // 
            this.labelServicePath_value.AutoSize = true;
            this.labelServicePath_value.Location = new System.Drawing.Point(127, 65);
            this.labelServicePath_value.Name = "labelServicePath_value";
            this.labelServicePath_value.Size = new System.Drawing.Size(33, 13);
            this.labelServicePath_value.TabIndex = 0;
            this.labelServicePath_value.Text = "value";
            // 
            // labelServiceStartuptype
            // 
            this.labelServiceStartuptype.AutoSize = true;
            this.labelServiceStartuptype.Location = new System.Drawing.Point(12, 97);
            this.labelServiceStartuptype.Name = "labelServiceStartuptype";
            this.labelServiceStartuptype.Size = new System.Drawing.Size(67, 13);
            this.labelServiceStartuptype.TabIndex = 0;
            this.labelServiceStartuptype.Text = "Startup type:";
            // 
            // comboBoxSV_Startup_type_value
            // 
            this.comboBoxSV_Startup_type_value.FormattingEnabled = true;
            this.comboBoxSV_Startup_type_value.Items.AddRange(new object[] {
            "Automatic (Delayed Start)",
            "Automatic",
            "Manual",
            "Disabled"});
            this.comboBoxSV_Startup_type_value.Location = new System.Drawing.Point(130, 89);
            this.comboBoxSV_Startup_type_value.Name = "comboBoxSV_Startup_type_value";
            this.comboBoxSV_Startup_type_value.Size = new System.Drawing.Size(138, 21);
            this.comboBoxSV_Startup_type_value.TabIndex = 1;
            // 
            // labelService_status
            // 
            this.labelService_status.AutoSize = true;
            this.labelService_status.Location = new System.Drawing.Point(12, 131);
            this.labelService_status.Name = "labelService_status";
            this.labelService_status.Size = new System.Drawing.Size(77, 13);
            this.labelService_status.TabIndex = 0;
            this.labelService_status.Text = "Service status:";
            // 
            // labelService_status_value
            // 
            this.labelService_status_value.AutoSize = true;
            this.labelService_status_value.Location = new System.Drawing.Point(127, 131);
            this.labelService_status_value.Name = "labelService_status_value";
            this.labelService_status_value.Size = new System.Drawing.Size(33, 13);
            this.labelService_status_value.TabIndex = 0;
            this.labelService_status_value.Text = "value";
            // 
            // buttonSV_Start
            // 
            this.buttonSV_Start.Location = new System.Drawing.Point(15, 165);
            this.buttonSV_Start.Name = "buttonSV_Start";
            this.buttonSV_Start.Size = new System.Drawing.Size(75, 23);
            this.buttonSV_Start.TabIndex = 2;
            this.buttonSV_Start.Text = "Start";
            this.buttonSV_Start.UseVisualStyleBackColor = true;
            this.buttonSV_Start.Click += new System.EventHandler(this.buttonSV_Start_Click);
            // 
            // buttonSV_Stop
            // 
            this.buttonSV_Stop.Location = new System.Drawing.Point(130, 165);
            this.buttonSV_Stop.Name = "buttonSV_Stop";
            this.buttonSV_Stop.Size = new System.Drawing.Size(75, 23);
            this.buttonSV_Stop.TabIndex = 2;
            this.buttonSV_Stop.Text = "Stop";
            this.buttonSV_Stop.UseVisualStyleBackColor = true;
            this.buttonSV_Stop.Click += new System.EventHandler(this.buttonSV_Stop_Click);
            // 
            // buttonSV_OK
            // 
            this.buttonSV_OK.Location = new System.Drawing.Point(130, 208);
            this.buttonSV_OK.Name = "buttonSV_OK";
            this.buttonSV_OK.Size = new System.Drawing.Size(75, 23);
            this.buttonSV_OK.TabIndex = 2;
            this.buttonSV_OK.Text = "OK";
            this.buttonSV_OK.UseVisualStyleBackColor = true;
            this.buttonSV_OK.Click += new System.EventHandler(this.buttonSV_OK_Click);
            // 
            // buttonSV_Cancel
            // 
            this.buttonSV_Cancel.Location = new System.Drawing.Point(244, 208);
            this.buttonSV_Cancel.Name = "buttonSV_Cancel";
            this.buttonSV_Cancel.Size = new System.Drawing.Size(75, 23);
            this.buttonSV_Cancel.TabIndex = 2;
            this.buttonSV_Cancel.Text = "Cancel";
            this.buttonSV_Cancel.UseVisualStyleBackColor = true;
            this.buttonSV_Cancel.Click += new System.EventHandler(this.buttonSV_Cancel_Click);
            // 
            // buttonSV_Apply
            // 
            this.buttonSV_Apply.Location = new System.Drawing.Point(357, 208);
            this.buttonSV_Apply.Name = "buttonSV_Apply";
            this.buttonSV_Apply.Size = new System.Drawing.Size(75, 23);
            this.buttonSV_Apply.TabIndex = 2;
            this.buttonSV_Apply.Text = "Apply";
            this.buttonSV_Apply.UseVisualStyleBackColor = true;
            this.buttonSV_Apply.Click += new System.EventHandler(this.buttonSV_Apply_Click);
            // 
            // FormShowService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 239);
            this.Controls.Add(this.buttonSV_Apply);
            this.Controls.Add(this.buttonSV_Cancel);
            this.Controls.Add(this.buttonSV_OK);
            this.Controls.Add(this.buttonSV_Stop);
            this.Controls.Add(this.buttonSV_Start);
            this.Controls.Add(this.comboBoxSV_Startup_type_value);
            this.Controls.Add(this.labelService_status_value);
            this.Controls.Add(this.labelServicePath_value);
            this.Controls.Add(this.labelDisplayname_value);
            this.Controls.Add(this.labelServicename_value);
            this.Controls.Add(this.labelService_status);
            this.Controls.Add(this.labelServiceStartuptype);
            this.Controls.Add(this.labelServicePath);
            this.Controls.Add(this.labelDisplayname);
            this.Controls.Add(this.labelServicename);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 278);
            this.MinimumSize = new System.Drawing.Size(465, 278);
            this.Name = "FormShowService";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.FormShowService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServicename;
        private System.Windows.Forms.Label labelDisplayname;
        private System.Windows.Forms.Label labelServicename_value;
        private System.Windows.Forms.Label labelDisplayname_value;
        private System.Windows.Forms.Label labelServicePath;
        private System.Windows.Forms.Label labelServicePath_value;
        private System.Windows.Forms.Label labelServiceStartuptype;
        private System.Windows.Forms.ComboBox comboBoxSV_Startup_type_value;
        private System.Windows.Forms.Label labelService_status;
        private System.Windows.Forms.Label labelService_status_value;
        private System.Windows.Forms.Button buttonSV_Start;
        private System.Windows.Forms.Button buttonSV_Stop;
        private System.Windows.Forms.Button buttonSV_OK;
        private System.Windows.Forms.Button buttonSV_Cancel;
        private System.Windows.Forms.Button buttonSV_Apply;
    }
}

