
namespace multiple_choice
{
    partial class QuestionType
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
            this.cBoxDiff = new System.Windows.Forms.ComboBox();
            this.cBoxQType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cBoxDiff
            // 
            this.cBoxDiff.FormattingEnabled = true;
            this.cBoxDiff.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cBoxDiff.Location = new System.Drawing.Point(154, 227);
            this.cBoxDiff.Name = "cBoxDiff";
            this.cBoxDiff.Size = new System.Drawing.Size(121, 23);
            this.cBoxDiff.TabIndex = 0;
            // 
            // cBoxQType
            // 
            this.cBoxQType.FormattingEnabled = true;
            this.cBoxQType.Items.AddRange(new object[] {
            "Comp Sci"});
            this.cBoxQType.Location = new System.Drawing.Point(522, 227);
            this.cBoxQType.Name = "cBoxQType";
            this.cBoxQType.Size = new System.Drawing.Size(121, 23);
            this.cBoxQType.TabIndex = 1;
            // 
            // QuestionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBoxQType);
            this.Controls.Add(this.cBoxDiff);
            this.Name = "QuestionType";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxDiff;
        private System.Windows.Forms.ComboBox cBoxQType;
    }
}