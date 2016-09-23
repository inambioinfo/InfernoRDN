namespace Wizard.UI
{
    public class InternalWizardPage : Wizard.UI.WizardPage
    {
        protected Wizard.UI.WizardBanner Banner;
        private readonly System.ComponentModel.IContainer components = null;

        protected InternalWizardPage()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Banner = new Wizard.UI.WizardBanner();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.SystemColors.Window;
            this.Banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(432, 64);
            this.Banner.Subtitle = "Subtitle";
            this.Banner.TabIndex = 0;
            this.Banner.Title = "Title";
            // 
            // InternalWizardPage
            // 
            this.Controls.Add(this.Banner);
            this.Name = "InternalWizardPage";
            this.Size = new System.Drawing.Size(432, 150);
            this.ResumeLayout(false);
        }

        #endregion
    }
}