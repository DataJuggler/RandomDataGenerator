namespace RandomDataGenerator
{
    partial class MemberCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberCreatorForm));
            this.MemberCreatorControl = new RandomDataGenerator.MemberCreatorControl();
            this.SuspendLayout();
            // 
            // MemberCreatorControl
            // 
            this.MemberCreatorControl.BackColor = System.Drawing.Color.Black;
            this.MemberCreatorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberCreatorControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberCreatorControl.Location = new System.Drawing.Point(0, 0);
            this.MemberCreatorControl.Name = "MemberCreatorControl";
            this.MemberCreatorControl.Size = new System.Drawing.Size(748, 496);
            this.MemberCreatorControl.TabIndex = 0;
            // 
            // MemberCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 496);
            this.Controls.Add(this.MemberCreatorControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberCreatorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MemberCreatorControl MemberCreatorControl;
    }
}