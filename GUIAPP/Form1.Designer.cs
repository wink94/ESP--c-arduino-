namespace GUIAPP
{
    partial class ProcessSTOP
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxProcess = new System.Windows.Forms.TextBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.stopTime = new System.Windows.Forms.Timer(this.components);
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.arduinoCOM1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbBoxTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 245);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxProcess
            // 
            this.txtBoxProcess.Location = new System.Drawing.Point(126, 73);
            this.txtBoxProcess.Name = "txtBoxProcess";
            this.txtBoxProcess.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProcess.TabIndex = 3;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(49, 73);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(45, 13);
            this.lblProcess.TabIndex = 4;
            this.lblProcess.Text = "Process";
            // 
            // stopTime
            // 
            this.stopTime.Interval = 5000;
            this.stopTime.Tick += new System.EventHandler(this.stopTime_Tick);
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(126, 169);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTime.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(49, 124);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time(Min)";
            // 
            // arduinoCOM1
            // 
            this.arduinoCOM1.PortName = "COM11";
            // 
            // cmbBoxTime
            // 
            this.cmbBoxTime.FormattingEnabled = true;
            this.cmbBoxTime.Items.AddRange(new object[] {
            "Select Time",
            "0 hr 30 mins",
            "1 hr 00 mins",
            "1 hr 30 mins",
            "1 hr 45 mins",
            "2 hr 00 mins"});
            this.cmbBoxTime.Location = new System.Drawing.Point(126, 117);
            this.cmbBoxTime.Name = "cmbBoxTime";
            this.cmbBoxTime.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Custom Time (mins.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "OR";
            // 
            // ProcessSTOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.txtBoxProcess);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "ProcessSTOP";
            this.Text = "ProcessSTOP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoxProcess;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Timer stopTime;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.Label lblTime;
        private System.IO.Ports.SerialPort arduinoCOM1;
        private System.Windows.Forms.ComboBox cmbBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

