
namespace VendingMachineSYS
{
    partial class FrmPaymentSummary
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
            this.btnBackPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackPayment
            // 
            this.btnBackPayment.Location = new System.Drawing.Point(20, 20);
            this.btnBackPayment.Name = "btnBackPayment";
            this.btnBackPayment.Size = new System.Drawing.Size(75, 25);
            this.btnBackPayment.TabIndex = 0;
            this.btnBackPayment.Text = "Back";
            this.btnBackPayment.UseVisualStyleBackColor = true;
            this.btnBackPayment.Click += new System.EventHandler(this.btnBackPayment_Click);
            // 
            // FrmPaymentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackPayment);
            this.Name = "FrmPaymentSummary";
            this.Text = "FrmPaymentSummary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackPayment;
    }
}